
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro
{
    public partial class QuanLyPhong : Form
    {
        private int maPhongDangChon = 0;
        private string cheDo = "";
        private bool dangThoat = false;

        private bool LaAdmin
        {
            get
            {
                return Form1.VaiTroDangNhap == "Admin";
            }
        }

        public QuanLyPhong()
        {
            InitializeComponent();

            // Gắn sự kiện
            this.Load += KhoiTaoQuanLyPhong;
            this.FormClosing += XuLyDongForm;

            btnThem.Click += XuLyThem;
            btnLuu.Click += XuLyLuu;
            btnSua.Click += XuLySua;
            btnXoa.Click += XuLyXoa;
            btnLamMoi.Click += XuLyLamMoi;
            btnTimKiem.Click += XuLyTimKiem;

            dgvPhong.CellClick += XuLyChonPhong;
        }

        private void KhoiTaoQuanLyPhong(object sender, EventArgs e)
        {
            cboLoaiPhong.Items.Clear();
            cboLoaiPhong.Items.AddRange(
                new object[] { "Phòng đơn", "Phòng đôi" });

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(
                new object[] { "Trống", "Đang thuê", "Bảo trì" });

            cboLocLoaiPhong.Items.Clear();
            cboLocLoaiPhong.Items.AddRange(
                new object[] { "Tất cả", "Phòng đơn", "Phòng đôi" });

            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.AddRange(
                new object[] { "Tất cả", "Trống", "Đang thuê", "Bảo trì" });

            cboLocLoaiPhong.SelectedIndex = 0;
            cboLocTrangThai.SelectedIndex = 0;

            cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            txtMaPhong.ReadOnly = true;
            dgvPhong.ReadOnly = true;
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.MultiSelect = false;

            // Tạo các cột để hiển thị dữ liệu
            TaoCotBang();

            LamMoiThongTin();
            TaiDanhSachPhong();
        }

        // Tạo các cột DataGridView
        private void TaoCotBang()
        {
            dgvPhong.Columns.Clear();
            dgvPhong.AutoGenerateColumns = false;

            dgvPhong.Columns.Add("colSTT", "STT");
            dgvPhong.Columns.Add("colMaPhong", "Mã phòng");
            dgvPhong.Columns.Add("colTenPhong", "Tên phòng");
            dgvPhong.Columns.Add("colLoaiPhong", "Loại phòng");
            dgvPhong.Columns.Add("colGiaThue", "Giá thuê");
            dgvPhong.Columns.Add("colTrangThai", "Trạng thái");

            if (LaAdmin)
            {
                DataGridViewButtonColumn colSua =
                    new DataGridViewButtonColumn();

                colSua.Name = "colSua";
                colSua.HeaderText = "Sửa";
                colSua.Text = "Sửa";
                colSua.UseColumnTextForButtonValue = true;
                dgvPhong.Columns.Add(colSua);

                DataGridViewButtonColumn colXoa =
                    new DataGridViewButtonColumn();

                colXoa.Name = "colXoa";
                colXoa.HeaderText = "Xóa";
                colXoa.Text = "Xóa";
                colXoa.UseColumnTextForButtonValue = true;
                dgvPhong.Columns.Add(colXoa);
            }

            dgvPhong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Tải danh sách phòng từ SQL
        private void TaiDanhSachPhong()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT MaPhong, TenPhong, LoaiPhong,
                               GiaThue, TrangThai, MoTa
                        FROM Phong
                        ORDER BY MaPhong";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dgvPhong.Rows.Clear();

                        int stt = 1;

                        while (reader.Read())
                        {
                            int ma = Convert.ToInt32(reader["MaPhong"]);
                            string ten = reader["TenPhong"].ToString();
                            string loai = reader["LoaiPhong"].ToString();
                            decimal gia = Convert.ToDecimal(reader["GiaThue"]);
                            string trangThai = reader["TrangThai"].ToString();

                            int index = dgvPhong.Rows.Add();

                            DataGridViewRow row = dgvPhong.Rows[index];

                            row.Cells["colSTT"].Value = stt++;
                            row.Cells["colMaPhong"].Value = "P" + ma.ToString("D2");
                            row.Cells["colTenPhong"].Value = ten;
                            row.Cells["colLoaiPhong"].Value = loai;
                            row.Cells["colGiaThue"].Value = gia.ToString("N0");
                            row.Cells["colTrangThai"].Value = trangThai;

                            // Lưu mã SQL và mô tả trong Tag
                            row.Tag = new ThongTinPhong
                            {
                                MaPhong = ma,
                                TenPhong = ten,
                                LoaiPhong = loai,
                                GiaThue = gia,
                                TrangThai = trangThai,
                                MoTa = reader["MoTa"] == DBNull.Value
                                    ? "" : reader["MoTa"].ToString()
                            };
                        }
                    }
                }

                dgvPhong.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách phòng:\n" + ex.Message);
            }
        }

        // Lưu thông tin của từng dòng
        private class ThongTinPhong
        {
            public int MaPhong { get; set; }
            public string TenPhong { get; set; }
            public string LoaiPhong { get; set; }
            public decimal GiaThue { get; set; }
            public string TrangThai { get; set; }
            public string MoTa { get; set; }
        }

        // Chọn phòng trong bảng
        private void XuLyChonPhong(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
            ThongTinPhong phong = row.Tag as ThongTinPhong;

            if (phong == null)
                return;

            maPhongDangChon = phong.MaPhong;

            txtMaPhong.Text = "P" + phong.MaPhong.ToString("D2");
            txtTenPhong.Text = phong.TenPhong;
            cboLoaiPhong.Text = phong.LoaiPhong;
            txtGiaThue.Text = phong.GiaThue.ToString("0");
            cboTrangThai.Text = phong.TrangThai;
            txtMoTa.Text = phong.MoTa;

            cheDo = "";
            CapNhatTrangThaiNhap();

            string tenCot = dgvPhong.Columns[e.ColumnIndex].Name;

            if (LaAdmin && tenCot == "colSua")
                BatDauSua();

            if (LaAdmin && tenCot == "colXoa")
                XoaPhong();
        }

        // Bật hoặc khóa các ô nhập
        private void CapNhatTrangThaiNhap()
        {
            bool duocNhap = LaAdmin &&
                (cheDo == "Them" || cheDo == "Sua");

            txtTenPhong.ReadOnly = !duocNhap;
            txtGiaThue.ReadOnly = !duocNhap;
            txtMoTa.ReadOnly = !duocNhap;
            cboLoaiPhong.Enabled = duocNhap;
            cboTrangThai.Enabled = duocNhap;

            btnThem.Visible = LaAdmin;
            btnLuu.Visible = LaAdmin;
            btnSua.Visible = LaAdmin;
            btnXoa.Visible = LaAdmin;

            btnLuu.Enabled = duocNhap;
            btnSua.Enabled = LaAdmin && maPhongDangChon > 0;
            btnXoa.Enabled = LaAdmin && maPhongDangChon > 0;
        }

        // Xóa thông tin đang hiển thị
        private void LamMoiThongTin()
        {
            maPhongDangChon = 0;
            cheDo = "";

            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtGiaThue.Clear();
            txtMoTa.Clear();

            cboLoaiPhong.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            CapNhatTrangThaiNhap();
        }

        // Nút Thêm
        private void XuLyThem(object sender, EventArgs e)
        {
            if (!LaAdmin)
                return;

            LamMoiThongTin();
            cheDo = "Them";
            CapNhatTrangThaiNhap();

            txtMaPhong.Text = "(Tự động)";
            txtTenPhong.Focus();
        }

        // Nút Sửa
        private void XuLySua(object sender, EventArgs e)
        {
            BatDauSua();
        }

        private void BatDauSua()
        {
            if (!LaAdmin)
                return;

            if (maPhongDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            cheDo = "Sua";
            CapNhatTrangThaiNhap();
            txtTenPhong.Focus();
        }

        // Nút Lưu
        private void XuLyLuu(object sender, EventArgs e)
        {
            if (!LaAdmin)
                return;

            if (cheDo != "Them" && cheDo != "Sua")
            {
                MessageBox.Show("Hãy chọn Thêm hoặc Sửa trước khi lưu!");
                return;
            }

            string ten = txtTenPhong.Text.Trim();
            string loai = cboLoaiPhong.Text;
            string trangThai = cboTrangThai.Text;
            string moTa = txtMoTa.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên phòng!");
                txtTenPhong.Focus();
                return;
            }

            if (cboLoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại phòng!");
                return;
            }

            decimal gia;
            if (!decimal.TryParse(txtGiaThue.Text.Trim(), out gia) || gia < 0)
            {
                MessageBox.Show("Giá thuê phải là số không âm!");
                txtGiaThue.Focus();
                return;
            }

            if (cboTrangThai.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái phòng!");
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql;

                    if (cheDo == "Them")
                    {
                        sql = @"
                            INSERT INTO Phong
                            (TenPhong, LoaiPhong, GiaThue, TrangThai, MoTa)
                            VALUES
                            (@Ten, @Loai, @Gia, @TrangThai, @MoTa)";
                    }
                    else
                    {
                        sql = @"
                            UPDATE Phong
                            SET TenPhong = @Ten,
                                LoaiPhong = @Loai,
                                GiaThue = @Gia,
                                TrangThai = @TrangThai,
                                MoTa = @MoTa
                            WHERE MaPhong = @MaPhong";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ten", ten);
                        cmd.Parameters.AddWithValue("@Loai", loai);
                        cmd.Parameters.AddWithValue("@Gia", gia);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                        cmd.Parameters.AddWithValue("@MoTa", moTa);

                        if (cheDo == "Sua")
                            cmd.Parameters.AddWithValue("@MaPhong", maPhongDangChon);

                        int soDong = cmd.ExecuteNonQuery();

                        if (soDong == 0)
                        {
                            MessageBox.Show("Không tìm thấy phòng để cập nhật!");
                            return;
                        }
                    }
                }

                MessageBox.Show(
                    cheDo == "Them"
                        ? "Thêm phòng thành công!"
                        : "Cập nhật phòng thành công!");

                LamMoiThongTin();
                TaiDanhSachPhong();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    MessageBox.Show("Tên phòng đã tồn tại!");
                else
                    MessageBox.Show("Lỗi lưu phòng:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message);
            }
        }

        // Nút Xóa
        private void XuLyXoa(object sender, EventArgs e)
        {
            XoaPhong();
        }

        private void XoaPhong()
        {
            if (!LaAdmin)
                return;

            if (maPhongDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phòng " +
                txtMaPhong.Text + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM Phong WHERE MaPhong = @MaPhong";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", maPhongDangChon);

                        int soDong = cmd.ExecuteNonQuery();

                        if (soDong == 0)
                        {
                            MessageBox.Show("Phòng này không còn tồn tại!");
                            TaiDanhSachPhong();
                            return;
                        }
                    }
                }

                MessageBox.Show("Xóa phòng thành công!");
                LamMoiThongTin();
                TaiDanhSachPhong();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Không thể xóa phòng. Phòng có thể đang được sử dụng " +
                    "ở bảng hợp đồng hoặc hóa đơn.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa phòng:\n" + ex.Message);
            }
        }

        // Nút Tìm kiếm
        private void XuLyTimKiem(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            string loai = cboLocLoaiPhong.Text;
            string trangThai = cboLocTrangThai.Text;

            foreach (DataGridViewRow row in dgvPhong.Rows)
            {
                ThongTinPhong phong = row.Tag as ThongTinPhong;

                if (phong == null)
                    continue;

                string maHienThi = "P" + phong.MaPhong.ToString("D2");

                bool khopTuKhoa =
                    tuKhoa == "" ||
                    maHienThi.ToLower().Contains(tuKhoa) ||
                    phong.TenPhong.ToLower().Contains(tuKhoa);

                bool khopLoai =
                    loai == "Tất cả" || loai == "" ||
                    phong.LoaiPhong == loai;

                bool khopTrangThai =
                    trangThai == "Tất cả" || trangThai == "" ||
                    phong.TrangThai == trangThai;

                row.Visible = khopTuKhoa && khopLoai && khopTrangThai;
            }

            dgvPhong.ClearSelection();
            LamMoiThongTin();
        }

        // Nút Làm mới
        private void XuLyLamMoi(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocLoaiPhong.SelectedIndex = 0;
            cboLocTrangThai.SelectedIndex = 0;

            LamMoiThongTin();
            TaiDanhSachPhong();
        }

        // Xác nhận khi nhấn X
        private void XuLyDongForm(object sender, FormClosingEventArgs e)
        {
            if (dangThoat)
                return;

            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                dangThoat = true;
                Application.Exit();
            }
        }
        // Nút Đăng xuất
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn muốn đăng xuất tài khoản hiện tại?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                // Xóa quyền đăng nhập hiện tại
                Form1.VaiTroDangNhap = "";

                // Tìm form đăng nhập đang bị ẩn
                Form formDangNhap = null;

                foreach (Form f in Application.OpenForms)
                {
                    if (f is Form1)
                    {
                        formDangNhap = f;
                        break;
                    }
                }

                // Mở lại form đăng nhập
                if (formDangNhap != null)
                {
                    formDangNhap.Show();
                }
                else
                {
                    Form1 frm = new Form1();
                    frm.Show();
                }

                // Ẩn form quản lý phòng
                this.Hide();
            }
        }
    }
}
