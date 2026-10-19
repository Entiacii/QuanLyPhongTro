namespace QuanLyPhongTro
{
    partial class QuanLyPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnMenu = new Panel();
            btnDangXuat = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            lblLogo = new Label();
            pnlTimKiem = new Panel();
            label12 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnTimKiem = new Button();
            cboLocTrangThai = new ComboBox();
            cboLocLoaiPhong = new ComboBox();
            txtTimKiem = new TextBox();
            dgvPhong = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colMaPhong = new DataGridViewTextBoxColumn();
            colTenPhong = new DataGridViewTextBoxColumn();
            colLoaiPhong = new DataGridViewTextBoxColumn();
            colGiaThue = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colSua = new DataGridViewButtonColumn();
            colXoa = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            cboTrangThai = new ComboBox();
            cboLoaiPhong = new ComboBox();
            txtMoTa = new TextBox();
            txtGiaThue = new TextBox();
            txtTenPhong = new TextBox();
            txtMaPhong = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pnMenu.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.FromArgb(18, 59, 120);
            pnMenu.Controls.Add(btnDangXuat);
            pnMenu.Controls.Add(button2);
            pnMenu.Controls.Add(button1);
            pnMenu.Controls.Add(label2);
            pnMenu.Controls.Add(label1);
            pnMenu.Controls.Add(lblLogo);
            pnMenu.Location = new Point(0, 3);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(220, 756);
            pnMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(15, 694);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(190, 45);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "↪  Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(18, 59, 120);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(15, 195);
            button2.Name = "button2";
            button2.Size = new Size(190, 45);
            button2.TabIndex = 4;
            button2.Text = "▣  Quản lý phòng";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(15, 140);
            button1.Name = "button1";
            button1.Size = new Size(190, 45);
            button1.TabIndex = 3;
            button1.Text = "⌂  Trang chủ";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 2;
            label2.Text = "________________________";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 108);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(12, 50);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(203, 25);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "QUẢN LÝ PHÒNG TRỌ";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(label12);
            pnlTimKiem.Controls.Add(label4);
            pnlTimKiem.Controls.Add(label3);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(cboLocTrangThai);
            pnlTimKiem.Controls.Add(cboLocLoaiPhong);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Location = new Point(240, 75);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(800, 60);
            pnlTimKiem.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 2);
            label12.Name = "label12";
            label12.Size = new Size(176, 20);
            label12.TabIndex = 8;
            label12.Text = "Mã phòng, tên phòng,...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(565, 5);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(389, 4);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Loại phòng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(22, 116, 209);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(685, 24);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 33);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "⌕ Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.BackColor = Color.White;
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Items.AddRange(new object[] { "Trống", "Đang thuê", "Bảo trì" });
            cboLocTrangThai.Location = new Point(525, 25);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(154, 31);
            cboLocTrangThai.TabIndex = 4;
            // 
            // cboLocLoaiPhong
            // 
            cboLocLoaiPhong.BackColor = Color.White;
            cboLocLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoaiPhong.ForeColor = Color.FromArgb(52, 64, 84);
            cboLocLoaiPhong.FormattingEnabled = true;
            cboLocLoaiPhong.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi" });
            cboLocLoaiPhong.Location = new Point(340, 25);
            cboLocLoaiPhong.Name = "cboLocLoaiPhong";
            cboLocLoaiPhong.Size = new Size(179, 31);
            cboLocLoaiPhong.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.FromArgb(52, 64, 84);
            txtTimKiem.Location = new Point(19, 25);
            txtTimKiem.MaxLength = 100;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(305, 30);
            txtTimKiem.TabIndex = 2;
            // 
            // dgvPhong
            // 
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToDeleteRows = false;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(234, 244, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(23, 74, 135);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPhong.ColumnHeadersHeight = 35;
            dgvPhong.Columns.AddRange(new DataGridViewColumn[] { colSTT, colMaPhong, colTenPhong, colLoaiPhong, colGiaThue, colTrangThai, colSua, colXoa });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(52, 64, 84);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(215, 234, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(23, 74, 135);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPhong.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPhong.EnableHeadersVisualStyles = false;
            dgvPhong.GridColor = Color.FromArgb(216, 232, 248);
            dgvPhong.Location = new Point(240, 160);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(800, 490);
            dgvPhong.TabIndex = 2;
            // 
            // colSTT
            // 
            colSTT.FillWeight = 35.3948822F;
            colSTT.HeaderText = "STT";
            colSTT.MinimumWidth = 6;
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            // 
            // colMaPhong
            // 
            colMaPhong.FillWeight = 66.3654F;
            colMaPhong.HeaderText = "Mã phòng";
            colMaPhong.MinimumWidth = 6;
            colMaPhong.Name = "colMaPhong";
            colMaPhong.ReadOnly = true;
            // 
            // colTenPhong
            // 
            colTenPhong.FillWeight = 88.4872055F;
            colTenPhong.HeaderText = "Tên phòng";
            colTenPhong.MinimumWidth = 6;
            colTenPhong.Name = "colTenPhong";
            colTenPhong.ReadOnly = true;
            // 
            // colLoaiPhong
            // 
            colLoaiPhong.FillWeight = 84.06285F;
            colLoaiPhong.HeaderText = "Loại phòng";
            colLoaiPhong.MinimumWidth = 6;
            colLoaiPhong.Name = "colLoaiPhong";
            colLoaiPhong.ReadOnly = true;
            // 
            // colGiaThue
            // 
            colGiaThue.FillWeight = 88.4872055F;
            colGiaThue.HeaderText = "Giá thuê";
            colGiaThue.MinimumWidth = 6;
            colGiaThue.Name = "colGiaThue";
            colGiaThue.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.FillWeight = 84.06285F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // colSua
            // 
            colSua.FillWeight = 169.6524F;
            colSua.HeaderText = "";
            colSua.MinimumWidth = 40;
            colSua.Name = "colSua";
            colSua.ReadOnly = true;
            colSua.Text = "Sửa";
            colSua.UseColumnTextForButtonValue = true;
            // 
            // colXoa
            // 
            colXoa.FillWeight = 88.4872055F;
            colXoa.HeaderText = "";
            colXoa.MinimumWidth = 6;
            colXoa.Name = "colXoa";
            colXoa.ReadOnly = true;
            colXoa.Text = "Xóa";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(cboTrangThai);
            panel1.Controls.Add(cboLoaiPhong);
            panel1.Controls.Add(txtMoTa);
            panel1.Controls.Add(txtGiaThue);
            panel1.Controls.Add(txtTenPhong);
            panel1.Controls.Add(txtMaPhong);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(1055, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 576);
            panel1.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(380, 520);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(95, 42);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(302, 518);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(72, 45);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(218, 518);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(78, 45);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(124, 516);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(88, 46);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(31, 518);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(87, 42);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Trống", "Đang thuê", "Bảo trì" });
            cboTrangThai.Location = new Point(26, 346);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(462, 31);
            cboTrangThai.TabIndex = 12;
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi" });
            cboLoaiPhong.Location = new Point(26, 215);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(462, 31);
            cboLoaiPhong.TabIndex = 11;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(26, 430);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(462, 62);
            txtMoTa.TabIndex = 10;
            // 
            // txtGiaThue
            // 
            txtGiaThue.Location = new Point(26, 275);
            txtGiaThue.Name = "txtGiaThue";
            txtGiaThue.Size = new Size(462, 30);
            txtGiaThue.TabIndex = 9;
            txtGiaThue.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(26, 147);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(462, 30);
            txtTenPhong.TabIndex = 8;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(26, 88);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.ReadOnly = true;
            txtMaPhong.Size = new Size(462, 30);
            txtMaPhong.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(35, 63, 99);
            label11.Location = new Point(26, 391);
            label11.Name = "label11";
            label11.Size = new Size(57, 23);
            label11.TabIndex = 6;
            label11.Text = "Mô tả";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(35, 63, 99);
            label10.Location = new Point(26, 320);
            label10.Name = "label10";
            label10.Size = new Size(92, 23);
            label10.TabIndex = 5;
            label10.Text = "Trạng thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(35, 63, 99);
            label9.Location = new Point(26, 249);
            label9.Name = "label9";
            label9.Size = new Size(77, 23);
            label9.TabIndex = 4;
            label9.Text = "Giá thuê";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(35, 63, 99);
            label8.Location = new Point(24, 189);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 3;
            label8.Text = "Loại phòng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(35, 63, 99);
            label7.Location = new Point(24, 121);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 2;
            label7.Text = "Tên phòng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(35, 63, 99);
            label6.Location = new Point(26, 62);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 1;
            label6.Text = "Mã phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(35, 63, 99);
            label5.Location = new Point(15, 6);
            label5.Name = "label5";
            label5.Size = new Size(170, 28);
            label5.TabIndex = 0;
            label5.Text = "Thông tin phòng";
            // 
            // QuanLyPhong
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1555, 751);
            Controls.Add(panel1);
            Controls.Add(dgvPhong);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnMenu);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1235, 798);
            Name = "QuanLyPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyPhongTro";
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Label lblLogo;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button btnDangXuat;
        private Button button2;
        private Panel pnlTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cboLocLoaiPhong;
        private ComboBox cboLocTrangThai;
        private Label label4;
        private Label label3;
        private Button btnTimKiem;
        private DataGridView dgvPhong;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colMaPhong;
        private DataGridViewTextBoxColumn colTenPhong;
        private DataGridViewTextBoxColumn colLoaiPhong;
        private DataGridViewTextBoxColumn colGiaThue;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewButtonColumn colSua;
        private DataGridViewButtonColumn colXoa;
        private Panel panel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnThem;
        private ComboBox cboTrangThai;
        private ComboBox cboLoaiPhong;
        private TextBox txtMoTa;
        private TextBox txtGiaThue;
        private TextBox txtTenPhong;
        private TextBox txtMaPhong;
        private Label label12;
    }
}