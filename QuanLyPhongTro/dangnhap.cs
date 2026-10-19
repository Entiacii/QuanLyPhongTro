using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro
{
    public partial class Form1 : Form
    {
        // Lưu quyền người dùng sau khi đăng nhập
        public static string VaiTroDangNhap = "";

        public Form1()
        {
            InitializeComponent();

            // Mặc định ẩn mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;
        }

        // Sự kiện Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Hiện / ẩn mật khẩu
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        // Nút đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (tenDangNhap == "" || matKhau == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tài khoản và mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT VaiTro
                                   FROM NguoiDung
                                   WHERE TenDangNhap = @TenDangNhap
                                   AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        object ketQua = cmd.ExecuteScalar();

                        if (ketQua != null)
                        {
                            VaiTroDangNhap = ketQua.ToString();

                            MessageBox.Show(
                                "Đăng nhập thành công!\nQuyền: " + VaiTroDangNhap,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Mở form quản lý, không cần truyền tham số
                            QuanLyPhong frm = new QuanLyPhong();
                            frm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Sai tên đăng nhập hoặc mật khẩu!",
                                "Đăng nhập thất bại",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            txtMatKhau.Clear();
                            txtMatKhau.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi kết nối SQL Server:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Chuyển sang form đăng ký
        private void lnkDangKy_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            dangky frm = new dangky();
            frm.Show();

            this.Hide();
        }
        private void lblDangKy_Click(object sender, EventArgs e)
        {
            dangky frm = new dangky();
            frm.Show();
            this.Hide();
        }
    }
}
