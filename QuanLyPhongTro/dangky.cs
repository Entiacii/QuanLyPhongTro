using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro
{
    public partial class dangky : Form
    {
        private bool dangChuyenForm = false;

        public dangky()
        {
            InitializeComponent();

            txtMatKhau.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;

            // Gắn các sự kiện
            btnDangKy.Click += XuLyDangKy;
            btnQuayLai.Click += XuLyQuayLai;
            this.FormClosing += XuLyDongForm;
        }

        private void XuLyDangKy(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string nhapLai = txtNhapLaiMatKhau.Text;

            // Kiểm tra từng trường còn thiếu
            if (hoTen == "")
            {
                MessageBox.Show("Bạn chưa nhập họ và tên!");
                txtHoTen.Focus();
                return;
            }

            if (sdt == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!");
                txtSoDienThoai.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                sdt, @"^0[0-9]{9}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0!");
                txtSoDienThoai.Focus();
                return;
            }

            if (tenDN == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
                txtTenDangNhap.Focus();
                return;
            }

            if (matKhau == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }

            if (nhapLai == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu!");
                txtNhapLaiMatKhau.Focus();
                return;
            }

            if (matKhau != nhapLai)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                txtNhapLaiMatKhau.Clear();
                txtNhapLaiMatKhau.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // Kiểm tra tên đăng nhập đã tồn tại
                    string sqlKiemTra =
                        "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @TenDN";

                    using (SqlCommand cmd = new SqlCommand(sqlKiemTra, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDN", tenDN);

                        int soLuong = Convert.ToInt32(cmd.ExecuteScalar());

                        if (soLuong > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại!");
                            txtTenDangNhap.Focus();
                            return;
                        }
                    }

                    // Thêm tài khoản mới với quyền KhachHang
                    string sqlThem = @"
                        INSERT INTO NguoiDung
                        (TenDangNhap, MatKhau, HoTen, SoDienThoai, VaiTro)
                        VALUES
                        (@TenDN, @MatKhau, @HoTen, @SDT, @VaiTro)";

                    using (SqlCommand cmd = new SqlCommand(sqlThem, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDN", tenDN);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@VaiTro", "KhachHang");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Đăng ký tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                QuayLaiDangNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đăng ký thất bại!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Quay lại đăng nhập
        private void XuLyQuayLai(object sender, EventArgs e)
        {
            QuayLaiDangNhap();
        }

        private void QuayLaiDangNhap()
        {
            dangChuyenForm = true;

            // Tìm form đăng nhập đang bị ẩn
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    f.Show();
                    this.Close();
                    return;
                }
            }

            // Nếu chưa có form đăng nhập thì tạo mới
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        // Xác nhận khi nhấn X
        private void XuLyDongForm(object sender, FormClosingEventArgs e)
        {
            if (dangChuyenForm)
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
                Application.Exit();
            }
        }
    }
}