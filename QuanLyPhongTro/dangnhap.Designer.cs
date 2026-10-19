namespace QuanLyPhongTro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblTieuDe2 = new Label();
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            chkHienMatKhau = new CheckBox();
            btnDangKy = new Button();
            lbl1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = SystemColors.ButtonFace;
            lblTieuDe.Location = new Point(61, 116);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(351, 42);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ PHÒNG TRỌ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTieuDe2
            // 
            lblTieuDe2.AutoSize = true;
            lblTieuDe2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe2.ForeColor = SystemColors.ButtonFace;
            lblTieuDe2.Location = new Point(130, 158);
            lblTieuDe2.Name = "lblTieuDe2";
            lblTieuDe2.Size = new Size(206, 28);
            lblTieuDe2.TabIndex = 1;
            lblTieuDe2.Text = "Đăng nhập hệ thống";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.BackColor = Color.Transparent;
            lblTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaiKhoan.ForeColor = Color.FromArgb(52, 64, 84);
            lblTaiKhoan.Location = new Point(45, 116);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(420, 25);
            lblTaiKhoan.TabIndex = 2;
            lblTaiKhoan.Text = "Tên đăng nhập";
            lblTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMatKhau
            // 
            lblMatKhau.BackColor = Color.Transparent;
            lblMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.ForeColor = Color.FromArgb(52, 64, 84);
            lblMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            lblMatKhau.Location = new Point(47, 205);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(420, 25);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.ForeColor = Color.FromArgb(52, 64, 84);
            txtTenDangNhap.Location = new Point(47, 156);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(420, 31);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.FromArgb(52, 64, 84);
            txtMatKhau.Location = new Point(47, 244);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(420, 31);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(36, 100, 180);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 79, 145);
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 120, 212);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(47, 321);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(420, 45);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTieuDe);
            panel1.Controls.Add(lblTieuDe2);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 579);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 186);
            label2.Name = "label2";
            label2.Size = new Size(395, 23);
            label2.TabIndex = 3;
            label2.Text = "_______________________________________________________";
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(61, 232);
            label1.Name = "label1";
            label1.Size = new Size(323, 46);
            label1.TabIndex = 2;
            label1.Text = "Không gian quản lý phòng trọ đơn giản, \r\nthuận tiện";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(chkHienMatKhau);
            panel2.Controls.Add(btnDangKy);
            panel2.Controls.Add(lbl1);
            panel2.Controls.Add(lblMatKhau);
            panel2.Controls.Add(btnDangNhap);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(lblTaiKhoan);
            panel2.Controls.Add(txtTenDangNhap);
            panel2.ForeColor = Color.FromArgb(52, 64, 84);
            panel2.Location = new Point(446, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(503, 579);
            panel2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(52, 64, 84);
            label4.Location = new Point(47, 56);
            label4.Name = "label4";
            label4.Size = new Size(182, 23);
            label4.TabIndex = 8;
            label4.Text = "Đăng nhập để tiếp tục";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(52, 64, 84);
            label3.Location = new Point(45, 21);
            label3.Name = "label3";
            label3.Size = new Size(287, 35);
            label3.TabIndex = 7;
            label3.Text = "CHÀO MỪNG TRỞ LẠI!";
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.BackColor = Color.Transparent;
            chkHienMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHienMatKhau.ForeColor = Color.FromArgb(52, 64, 84);
            chkHienMatKhau.Location = new Point(47, 281);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(127, 24);
            chkHienMatKhau.TabIndex = 6;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = false;
            chkHienMatKhau.Click += chkHienMatKhau_CheckedChanged;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.White;
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.FromArgb(36, 99, 180);
            btnDangKy.Location = new Point(257, 377);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(81, 31);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += lblDangKy_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(107, 380);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(157, 23);
            lbl1.TabIndex = 4;
            lbl1.Text = "Chưa có tài khoản?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 578);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private Label lblTieuDe2;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnDangKy;
        private Label lbl1;
        private CheckBox chkHienMatKhau;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
