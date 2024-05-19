namespace PhanMemQuanLyBanGiayTheThao
{
    partial class frm_TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaiKhoan));
            this.btn_SearchTaiKhoan = new System.Windows.Forms.Button();
            this.lb_TimKiemTaiKhoan = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lb_LoaiTaiKhoanTaiKhoan = new System.Windows.Forms.Label();
            this.txt_MatKhauTaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_MataiKhoanTaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_TenTaiKhoanTaiKhoan = new System.Windows.Forms.TextBox();
            this.lb_MaTaiKhoanTaiKhoan = new System.Windows.Forms.Label();
            this.lb_MatKhauTaiKhoan = new System.Windows.Forms.Label();
            this.lb_TenTaiKhoanTaiKhoan = new System.Windows.Forms.Label();
            this.btn_SuaTaiKhoan = new System.Windows.Forms.Button();
            this.grb_QLTaiKhoanTaiKhoan = new System.Windows.Forms.GroupBox();
            this.cbo_LoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.lb_TrangThaiTaiKhoan = new System.Windows.Forms.Label();
            this.chk_HoatDongTaiKhoan = new System.Windows.Forms.CheckBox();
            this.btn_ThemTaiKhoan = new System.Windows.Forms.Button();
            this.btn_XoaTaiKhoan = new System.Windows.Forms.Button();
            this.grb_HeaderTaiKhoan = new System.Windows.Forms.GroupBox();
            this.grb_Menu = new System.Windows.Forms.GroupBox();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.cbo_Search = new System.Windows.Forms.ComboBox();
            this.grb_QLTaiKhoanTaiKhoan.SuspendLayout();
            this.grb_HeaderTaiKhoan.SuspendLayout();
            this.grb_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SearchTaiKhoan
            // 
            this.btn_SearchTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchTaiKhoan.Image")));
            this.btn_SearchTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchTaiKhoan.Location = new System.Drawing.Point(1128, 171);
            this.btn_SearchTaiKhoan.Name = "btn_SearchTaiKhoan";
            this.btn_SearchTaiKhoan.Size = new System.Drawing.Size(126, 44);
            this.btn_SearchTaiKhoan.TabIndex = 46;
            this.btn_SearchTaiKhoan.Text = "Search";
            this.btn_SearchTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_SearchTaiKhoan.Click += new System.EventHandler(this.btn_SearchTaiKhoan_Click_1);
            // 
            // lb_TimKiemTaiKhoan
            // 
            this.lb_TimKiemTaiKhoan.AutoSize = true;
            this.lb_TimKiemTaiKhoan.Location = new System.Drawing.Point(626, 182);
            this.lb_TimKiemTaiKhoan.Name = "lb_TimKiemTaiKhoan";
            this.lb_TimKiemTaiKhoan.Size = new System.Drawing.Size(62, 16);
            this.lb_TimKiemTaiKhoan.TabIndex = 45;
            this.lb_TimKiemTaiKhoan.Text = "Tìm kiếm";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_TimKiem.Location = new System.Drawing.Point(709, 171);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(256, 33);
            this.txt_TimKiem.TabIndex = 44;
            // 
            // lb_LoaiTaiKhoanTaiKhoan
            // 
            this.lb_LoaiTaiKhoanTaiKhoan.AutoSize = true;
            this.lb_LoaiTaiKhoanTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiTaiKhoanTaiKhoan.Location = new System.Drawing.Point(22, 258);
            this.lb_LoaiTaiKhoanTaiKhoan.Name = "lb_LoaiTaiKhoanTaiKhoan";
            this.lb_LoaiTaiKhoanTaiKhoan.Size = new System.Drawing.Size(113, 20);
            this.lb_LoaiTaiKhoanTaiKhoan.TabIndex = 32;
            this.lb_LoaiTaiKhoanTaiKhoan.Text = "Loại tài khoản";
            // 
            // txt_MatKhauTaiKhoan
            // 
            this.txt_MatKhauTaiKhoan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_MatKhauTaiKhoan.Location = new System.Drawing.Point(22, 215);
            this.txt_MatKhauTaiKhoan.Name = "txt_MatKhauTaiKhoan";
            this.txt_MatKhauTaiKhoan.PasswordChar = '*';
            this.txt_MatKhauTaiKhoan.Size = new System.Drawing.Size(321, 27);
            this.txt_MatKhauTaiKhoan.TabIndex = 27;
            // 
            // txt_MataiKhoanTaiKhoan
            // 
            this.txt_MataiKhoanTaiKhoan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_MataiKhoanTaiKhoan.Location = new System.Drawing.Point(22, 99);
            this.txt_MataiKhoanTaiKhoan.Multiline = true;
            this.txt_MataiKhoanTaiKhoan.Name = "txt_MataiKhoanTaiKhoan";
            this.txt_MataiKhoanTaiKhoan.ReadOnly = true;
            this.txt_MataiKhoanTaiKhoan.Size = new System.Drawing.Size(321, 24);
            this.txt_MataiKhoanTaiKhoan.TabIndex = 29;
            // 
            // txt_TenTaiKhoanTaiKhoan
            // 
            this.txt_TenTaiKhoanTaiKhoan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_TenTaiKhoanTaiKhoan.Location = new System.Drawing.Point(22, 153);
            this.txt_TenTaiKhoanTaiKhoan.Name = "txt_TenTaiKhoanTaiKhoan";
            this.txt_TenTaiKhoanTaiKhoan.Size = new System.Drawing.Size(321, 27);
            this.txt_TenTaiKhoanTaiKhoan.TabIndex = 28;
            // 
            // lb_MaTaiKhoanTaiKhoan
            // 
            this.lb_MaTaiKhoanTaiKhoan.AutoSize = true;
            this.lb_MaTaiKhoanTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaTaiKhoanTaiKhoan.Location = new System.Drawing.Point(22, 64);
            this.lb_MaTaiKhoanTaiKhoan.Name = "lb_MaTaiKhoanTaiKhoan";
            this.lb_MaTaiKhoanTaiKhoan.Size = new System.Drawing.Size(104, 20);
            this.lb_MaTaiKhoanTaiKhoan.TabIndex = 25;
            this.lb_MaTaiKhoanTaiKhoan.Text = "Mã tài khoản";
            // 
            // lb_MatKhauTaiKhoan
            // 
            this.lb_MatKhauTaiKhoan.AutoSize = true;
            this.lb_MatKhauTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhauTaiKhoan.Location = new System.Drawing.Point(22, 188);
            this.lb_MatKhauTaiKhoan.Name = "lb_MatKhauTaiKhoan";
            this.lb_MatKhauTaiKhoan.Size = new System.Drawing.Size(77, 20);
            this.lb_MatKhauTaiKhoan.TabIndex = 26;
            this.lb_MatKhauTaiKhoan.Text = "Mật khẩu";
            // 
            // lb_TenTaiKhoanTaiKhoan
            // 
            this.lb_TenTaiKhoanTaiKhoan.AutoSize = true;
            this.lb_TenTaiKhoanTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTaiKhoanTaiKhoan.Location = new System.Drawing.Point(22, 126);
            this.lb_TenTaiKhoanTaiKhoan.Name = "lb_TenTaiKhoanTaiKhoan";
            this.lb_TenTaiKhoanTaiKhoan.Size = new System.Drawing.Size(109, 20);
            this.lb_TenTaiKhoanTaiKhoan.TabIndex = 24;
            this.lb_TenTaiKhoanTaiKhoan.Text = "Tên tài khoản";
            // 
            // btn_SuaTaiKhoan
            // 
            this.btn_SuaTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SuaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaTaiKhoan.Image")));
            this.btn_SuaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaTaiKhoan.Location = new System.Drawing.Point(150, 545);
            this.btn_SuaTaiKhoan.Name = "btn_SuaTaiKhoan";
            this.btn_SuaTaiKhoan.Size = new System.Drawing.Size(98, 51);
            this.btn_SuaTaiKhoan.TabIndex = 50;
            this.btn_SuaTaiKhoan.Text = "Sửa";
            this.btn_SuaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SuaTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_SuaTaiKhoan.Click += new System.EventHandler(this.btn_SuaTaiKhoan_Click_1);
            // 
            // grb_QLTaiKhoanTaiKhoan
            // 
            this.grb_QLTaiKhoanTaiKhoan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.cbo_LoaiTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.lb_TrangThaiTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.chk_HoatDongTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.lb_LoaiTaiKhoanTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.txt_MatKhauTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.txt_MataiKhoanTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.txt_TenTaiKhoanTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.lb_MaTaiKhoanTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.lb_MatKhauTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Controls.Add(this.lb_TenTaiKhoanTaiKhoan);
            this.grb_QLTaiKhoanTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_QLTaiKhoanTaiKhoan.Location = new System.Drawing.Point(12, 157);
            this.grb_QLTaiKhoanTaiKhoan.Name = "grb_QLTaiKhoanTaiKhoan";
            this.grb_QLTaiKhoanTaiKhoan.Size = new System.Drawing.Size(399, 382);
            this.grb_QLTaiKhoanTaiKhoan.TabIndex = 49;
            this.grb_QLTaiKhoanTaiKhoan.TabStop = false;
            this.grb_QLTaiKhoanTaiKhoan.Text = "Tài khoản";
            // 
            // cbo_LoaiTaiKhoan
            // 
            this.cbo_LoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiTaiKhoan.FormattingEnabled = true;
            this.cbo_LoaiTaiKhoan.Items.AddRange(new object[] {
            "Nhân viên",
            "Khách hàng",
            "Quản lý"});
            this.cbo_LoaiTaiKhoan.Location = new System.Drawing.Point(22, 281);
            this.cbo_LoaiTaiKhoan.Name = "cbo_LoaiTaiKhoan";
            this.cbo_LoaiTaiKhoan.Size = new System.Drawing.Size(317, 28);
            this.cbo_LoaiTaiKhoan.TabIndex = 42;
            // 
            // lb_TrangThaiTaiKhoan
            // 
            this.lb_TrangThaiTaiKhoan.AutoSize = true;
            this.lb_TrangThaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangThaiTaiKhoan.Location = new System.Drawing.Point(22, 317);
            this.lb_TrangThaiTaiKhoan.Name = "lb_TrangThaiTaiKhoan";
            this.lb_TrangThaiTaiKhoan.Size = new System.Drawing.Size(89, 20);
            this.lb_TrangThaiTaiKhoan.TabIndex = 39;
            this.lb_TrangThaiTaiKhoan.Text = "Trạng thái:";
            // 
            // chk_HoatDongTaiKhoan
            // 
            this.chk_HoatDongTaiKhoan.AutoSize = true;
            this.chk_HoatDongTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HoatDongTaiKhoan.Location = new System.Drawing.Point(122, 317);
            this.chk_HoatDongTaiKhoan.Name = "chk_HoatDongTaiKhoan";
            this.chk_HoatDongTaiKhoan.Size = new System.Drawing.Size(108, 24);
            this.chk_HoatDongTaiKhoan.TabIndex = 38;
            this.chk_HoatDongTaiKhoan.Text = "Hoạt động";
            this.chk_HoatDongTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btn_ThemTaiKhoan
            // 
            this.btn_ThemTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThemTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemTaiKhoan.Image")));
            this.btn_ThemTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemTaiKhoan.Location = new System.Drawing.Point(12, 545);
            this.btn_ThemTaiKhoan.Name = "btn_ThemTaiKhoan";
            this.btn_ThemTaiKhoan.Size = new System.Drawing.Size(102, 51);
            this.btn_ThemTaiKhoan.TabIndex = 40;
            this.btn_ThemTaiKhoan.Text = "Thêm";
            this.btn_ThemTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_ThemTaiKhoan.Click += new System.EventHandler(this.btn_ThemTaiKhoan_Click_1);
            // 
            // btn_XoaTaiKhoan
            // 
            this.btn_XoaTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XoaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaTaiKhoan.Image")));
            this.btn_XoaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaTaiKhoan.Location = new System.Drawing.Point(288, 545);
            this.btn_XoaTaiKhoan.Name = "btn_XoaTaiKhoan";
            this.btn_XoaTaiKhoan.Size = new System.Drawing.Size(109, 51);
            this.btn_XoaTaiKhoan.TabIndex = 51;
            this.btn_XoaTaiKhoan.Text = "Xóa";
            this.btn_XoaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_XoaTaiKhoan.Click += new System.EventHandler(this.btn_XoaTaiKhoan_Click_1);
            // 
            // grb_HeaderTaiKhoan
            // 
            this.grb_HeaderTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_HeaderTaiKhoan.Controls.Add(this.grb_Menu);
            this.grb_HeaderTaiKhoan.Controls.Add(this.pic_Logo);
            this.grb_HeaderTaiKhoan.Location = new System.Drawing.Point(12, 5);
            this.grb_HeaderTaiKhoan.Name = "grb_HeaderTaiKhoan";
            this.grb_HeaderTaiKhoan.Size = new System.Drawing.Size(1371, 146);
            this.grb_HeaderTaiKhoan.TabIndex = 52;
            this.grb_HeaderTaiKhoan.TabStop = false;
            this.grb_HeaderTaiKhoan.Enter += new System.EventHandler(this.grb_HeaderTaiKhoan_Enter);
            // 
            // grb_Menu
            // 
            this.grb_Menu.BackColor = System.Drawing.Color.Transparent;
            this.grb_Menu.Controls.Add(this.btn_dangxuat);
            this.grb_Menu.Controls.Add(this.btn_exit);
            this.grb_Menu.Controls.Add(this.btn_quaylai);
            this.grb_Menu.ForeColor = System.Drawing.Color.Black;
            this.grb_Menu.Location = new System.Drawing.Point(1209, 0);
            this.grb_Menu.Name = "grb_Menu";
            this.grb_Menu.Size = new System.Drawing.Size(162, 80);
            this.grb_Menu.TabIndex = 66;
            this.grb_Menu.TabStop = false;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.Image")));
            this.btn_dangxuat.Location = new System.Drawing.Point(67, 20);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(37, 41);
            this.btn_dangxuat.TabIndex = 68;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(119, 21);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(37, 41);
            this.btn_exit.TabIndex = 58;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Image")));
            this.btn_quaylai.Location = new System.Drawing.Point(15, 21);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(37, 41);
            this.btn_quaylai.TabIndex = 59;
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.White;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(6, 9);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(143, 137);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 65;
            this.pic_Logo.TabStop = false;
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.AllowUserToAddRows = false;
            this.dgv_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(431, 221);
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            this.dgv_TaiKhoan.RowHeadersWidth = 51;
            this.dgv_TaiKhoan.RowTemplate.Height = 24;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(952, 479);
            this.dgv_TaiKhoan.TabIndex = 53;
            this.dgv_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TaiKhoan_CellClick_1);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.Image")));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(1237, 706);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(146, 50);
            this.btn_LamMoi.TabIndex = 54;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // cbo_Search
            // 
            this.cbo_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Search.FormattingEnabled = true;
            this.cbo_Search.Items.AddRange(new object[] {
            "MaTK",
            "TenDangNhap"});
            this.cbo_Search.Location = new System.Drawing.Point(985, 171);
            this.cbo_Search.Name = "cbo_Search";
            this.cbo_Search.Size = new System.Drawing.Size(121, 24);
            this.cbo_Search.TabIndex = 55;
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1395, 768);
            this.ControlBox = false;
            this.Controls.Add(this.cbo_Search);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_ThemTaiKhoan);
            this.Controls.Add(this.dgv_TaiKhoan);
            this.Controls.Add(this.grb_HeaderTaiKhoan);
            this.Controls.Add(this.btn_SearchTaiKhoan);
            this.Controls.Add(this.lb_TimKiemTaiKhoan);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_SuaTaiKhoan);
            this.Controls.Add(this.grb_QLTaiKhoanTaiKhoan);
            this.Controls.Add(this.btn_XoaTaiKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.grb_QLTaiKhoanTaiKhoan.ResumeLayout(false);
            this.grb_QLTaiKhoanTaiKhoan.PerformLayout();
            this.grb_HeaderTaiKhoan.ResumeLayout(false);
            this.grb_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SearchTaiKhoan;
        private System.Windows.Forms.Label lb_TimKiemTaiKhoan;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lb_LoaiTaiKhoanTaiKhoan;
        private System.Windows.Forms.TextBox txt_MatKhauTaiKhoan;
        private System.Windows.Forms.TextBox txt_MataiKhoanTaiKhoan;
        private System.Windows.Forms.TextBox txt_TenTaiKhoanTaiKhoan;
        private System.Windows.Forms.Label lb_MaTaiKhoanTaiKhoan;
        private System.Windows.Forms.Label lb_MatKhauTaiKhoan;
        private System.Windows.Forms.Label lb_TenTaiKhoanTaiKhoan;
        private System.Windows.Forms.Button btn_SuaTaiKhoan;
        private System.Windows.Forms.GroupBox grb_QLTaiKhoanTaiKhoan;
        private System.Windows.Forms.Label lb_TrangThaiTaiKhoan;
        private System.Windows.Forms.CheckBox chk_HoatDongTaiKhoan;
        private System.Windows.Forms.Button btn_XoaTaiKhoan;
        private System.Windows.Forms.GroupBox grb_HeaderTaiKhoan;
        private System.Windows.Forms.Button btn_ThemTaiKhoan;
        private System.Windows.Forms.ComboBox cbo_LoaiTaiKhoan;
        private System.Windows.Forms.DataGridView dgv_TaiKhoan;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.ComboBox cbo_Search;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.GroupBox grb_Menu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_dangxuat;
    }
}