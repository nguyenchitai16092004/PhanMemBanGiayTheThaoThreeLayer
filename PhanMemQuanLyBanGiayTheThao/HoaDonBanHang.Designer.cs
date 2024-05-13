using System;

namespace PhanMemQuanLyBanGiayTheThao
{
    partial class frm_HoaDonBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDonBanHang));
            this.grb_Header = new System.Windows.Forms.GroupBox();
            this.grb_Menu = new System.Windows.Forms.GroupBox();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.lb_DoiMatKhauNhanVien = new System.Windows.Forms.Label();
            this.btn_DoiMatKhauNhanVien = new System.Windows.Forms.Button();
            this.btn_KHHoaDonBanHang = new System.Windows.Forms.Button();
            this.grb_SanPham = new System.Windows.Forms.GroupBox();
            this.cbo_TenNhanVien = new System.Windows.Forms.ComboBox();
            this.cbo_TimKiem_Theo = new System.Windows.Forms.ComboBox();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.cbo_TenNV = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_HoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.dtp_NgayLapHoaDonBanHang = new System.Windows.Forms.DateTimePicker();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.lb_MaNVHoaDonBanHang = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.lb_MaHoaDonHoaDonBanHang = new System.Windows.Forms.Label();
            this.btn_SuaHoaDonBanHang = new System.Windows.Forms.Button();
            this.lb_NgayLapHoaDonBanHang = new System.Windows.Forms.Label();
            this.lb_TimKiemHoaDonBanHang = new System.Windows.Forms.Label();
            this.txt_TimKiemHoaDonBanHang = new System.Windows.Forms.TextBox();
            this.btn_XoaHoaDonBanHang = new System.Windows.Forms.Button();
            this.btn_XemDanhSachHoaDon = new System.Windows.Forms.Button();
            this.btn_XuatThongTinHoaDonBanHang = new System.Windows.Forms.Button();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.grb_HoaDonBanHang = new System.Windows.Forms.GroupBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_Header.SuspendLayout();
            this.grb_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.grb_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDonBanHang)).BeginInit();
            this.grb_HoaDonBanHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Header
            // 
            this.grb_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_Header.Controls.Add(this.grb_Menu);
            this.grb_Header.Controls.Add(this.pic_Logo);
            this.grb_Header.Controls.Add(this.lb_DoiMatKhauNhanVien);
            this.grb_Header.Controls.Add(this.btn_DoiMatKhauNhanVien);
            this.grb_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_Header.Location = new System.Drawing.Point(3, 24);
            this.grb_Header.Name = "grb_Header";
            this.grb_Header.Size = new System.Drawing.Size(1270, 153);
            this.grb_Header.TabIndex = 15;
            this.grb_Header.TabStop = false;
            // 
            // grb_Menu
            // 
            this.grb_Menu.BackColor = System.Drawing.Color.Transparent;
            this.grb_Menu.Controls.Add(this.btn_dangxuat);
            this.grb_Menu.Controls.Add(this.btn_exit);
            this.grb_Menu.Controls.Add(this.btn_quaylai);
            this.grb_Menu.ForeColor = System.Drawing.Color.Black;
            this.grb_Menu.Location = new System.Drawing.Point(1115, 10);
            this.grb_Menu.Name = "grb_Menu";
            this.grb_Menu.Size = new System.Drawing.Size(158, 80);
            this.grb_Menu.TabIndex = 65;
            this.grb_Menu.TabStop = false;
            this.grb_Menu.Enter += new System.EventHandler(this.grb_Menu_Enter);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.Image")));
            this.btn_dangxuat.Location = new System.Drawing.Point(62, 20);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(37, 41);
            this.btn_dangxuat.TabIndex = 63;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(109, 21);
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
            this.pic_Logo.Location = new System.Drawing.Point(6, 10);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(143, 137);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 64;
            this.pic_Logo.TabStop = false;
            // 
            // lb_DoiMatKhauNhanVien
            // 
            this.lb_DoiMatKhauNhanVien.AutoSize = true;
            this.lb_DoiMatKhauNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DoiMatKhauNhanVien.Location = new System.Drawing.Point(205, 95);
            this.lb_DoiMatKhauNhanVien.Name = "lb_DoiMatKhauNhanVien";
            this.lb_DoiMatKhauNhanVien.Size = new System.Drawing.Size(115, 22);
            this.lb_DoiMatKhauNhanVien.TabIndex = 63;
            this.lb_DoiMatKhauNhanVien.Text = "Đổi mật khẩu";
            // 
            // btn_DoiMatKhauNhanVien
            // 
            this.btn_DoiMatKhauNhanVien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_DoiMatKhauNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhauNhanVien.BackgroundImage")));
            this.btn_DoiMatKhauNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DoiMatKhauNhanVien.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_DoiMatKhauNhanVien.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_DoiMatKhauNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhauNhanVien.Location = new System.Drawing.Point(224, 31);
            this.btn_DoiMatKhauNhanVien.Name = "btn_DoiMatKhauNhanVien";
            this.btn_DoiMatKhauNhanVien.Size = new System.Drawing.Size(61, 61);
            this.btn_DoiMatKhauNhanVien.TabIndex = 62;
            this.btn_DoiMatKhauNhanVien.UseVisualStyleBackColor = false;
            this.btn_DoiMatKhauNhanVien.Click += new System.EventHandler(this.btn_DoiMatKhauNhanVien_Click);
            // 
            // btn_KHHoaDonBanHang
            // 
            this.btn_KHHoaDonBanHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_KHHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KHHoaDonBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_KHHoaDonBanHang.Image")));
            this.btn_KHHoaDonBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KHHoaDonBanHang.Location = new System.Drawing.Point(1097, 64);
            this.btn_KHHoaDonBanHang.Name = "btn_KHHoaDonBanHang";
            this.btn_KHHoaDonBanHang.Size = new System.Drawing.Size(146, 48);
            this.btn_KHHoaDonBanHang.TabIndex = 38;
            this.btn_KHHoaDonBanHang.Text = "Khách hàng";
            this.btn_KHHoaDonBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_KHHoaDonBanHang.UseVisualStyleBackColor = false;
            this.btn_KHHoaDonBanHang.Click += new System.EventHandler(this.btn_KHHoaDonBanHang_Click);
            // 
            // grb_SanPham
            // 
            this.grb_SanPham.Controls.Add(this.txt_MaNV);
            this.grb_SanPham.Controls.Add(this.label1);
            this.grb_SanPham.Controls.Add(this.cbo_TenNhanVien);
            this.grb_SanPham.Controls.Add(this.cbo_TimKiem_Theo);
            this.grb_SanPham.Controls.Add(this.dtp_Ngay);
            this.grb_SanPham.Controls.Add(this.txt_MaKH);
            this.grb_SanPham.Controls.Add(this.btn_TaoHoaDon);
            this.grb_SanPham.Controls.Add(this.cbo_TenNV);
            this.grb_SanPham.Controls.Add(this.btn_Search);
            this.grb_SanPham.Controls.Add(this.btn_KHHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.dgv_HoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.dtp_NgayLapHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.btn_LamMoi);
            this.grb_SanPham.Controls.Add(this.lb_MaNVHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.txt_MaHoaDon);
            this.grb_SanPham.Controls.Add(this.lb_MaHoaDonHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.btn_SuaHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.lb_NgayLapHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.lb_TimKiemHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.txt_TimKiemHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.btn_XoaHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.btn_XemDanhSachHoaDon);
            this.grb_SanPham.Controls.Add(this.btn_XuatThongTinHoaDonBanHang);
            this.grb_SanPham.Controls.Add(this.lb_MaKH);
            this.grb_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_SanPham.Location = new System.Drawing.Point(3, 177);
            this.grb_SanPham.Name = "grb_SanPham";
            this.grb_SanPham.Size = new System.Drawing.Size(1270, 566);
            this.grb_SanPham.TabIndex = 16;
            this.grb_SanPham.TabStop = false;
            this.grb_SanPham.Text = "Sản phẩm";
            // 
            // cbo_TenNhanVien
            // 
            this.cbo_TenNhanVien.FormattingEnabled = true;
            this.cbo_TenNhanVien.Location = new System.Drawing.Point(377, 27);
            this.cbo_TenNhanVien.Name = "cbo_TenNhanVien";
            this.cbo_TenNhanVien.Size = new System.Drawing.Size(321, 28);
            this.cbo_TenNhanVien.TabIndex = 62;
            this.cbo_TenNhanVien.Visible = false;
            // 
            // cbo_TimKiem_Theo
            // 
            this.cbo_TimKiem_Theo.FormattingEnabled = true;
            this.cbo_TimKiem_Theo.Items.AddRange(new object[] {
            "MaHD",
            "Tên Nhân viên",
            "MaKH",
            "Ngày"});
            this.cbo_TimKiem_Theo.Location = new System.Drawing.Point(721, 30);
            this.cbo_TimKiem_Theo.Name = "cbo_TimKiem_Theo";
            this.cbo_TimKiem_Theo.Size = new System.Drawing.Size(144, 28);
            this.cbo_TimKiem_Theo.TabIndex = 61;
            this.cbo_TimKiem_Theo.SelectedIndexChanged += new System.EventHandler(this.Cbb_TimKiem_Theo_SelectedIndexChanged_1);
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Location = new System.Drawing.Point(377, 28);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(321, 27);
            this.dtp_Ngay.TabIndex = 60;
            this.dtp_Ngay.Visible = false;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(17, 359);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(311, 27);
            this.txt_MaKH.TabIndex = 45;
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_TaoHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoHoaDon.Image")));
            this.btn_TaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(17, 397);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(311, 45);
            this.btn_TaoHoaDon.TabIndex = 44;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = false;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // cbo_TenNV
            // 
            this.cbo_TenNV.FormattingEnabled = true;
            this.cbo_TenNV.Location = new System.Drawing.Point(17, 289);
            this.cbo_TenNV.Name = "cbo_TenNV";
            this.cbo_TenNV.Size = new System.Drawing.Size(311, 28);
            this.cbo_TenNV.TabIndex = 43;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(377, 64);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(131, 51);
            this.btn_Search.TabIndex = 40;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_HoaDonBanHang
            // 
            this.dgv_HoaDonBanHang.AllowUserToAddRows = false;
            this.dgv_HoaDonBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_HoaDonBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDonBanHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_HoaDonBanHang.CausesValidation = false;
            this.dgv_HoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDonBanHang.Location = new System.Drawing.Point(364, 121);
            this.dgv_HoaDonBanHang.Name = "dgv_HoaDonBanHang";
            this.dgv_HoaDonBanHang.RowHeadersWidth = 51;
            this.dgv_HoaDonBanHang.RowTemplate.Height = 24;
            this.dgv_HoaDonBanHang.Size = new System.Drawing.Size(880, 359);
            this.dgv_HoaDonBanHang.TabIndex = 39;
            this.dgv_HoaDonBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDonBanHang_CellClick);
            // 
            // dtp_NgayLapHoaDonBanHang
            // 
            this.dtp_NgayLapHoaDonBanHang.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLapHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLapHoaDonBanHang.Location = new System.Drawing.Point(17, 156);
            this.dtp_NgayLapHoaDonBanHang.Name = "dtp_NgayLapHoaDonBanHang";
            this.dtp_NgayLapHoaDonBanHang.Size = new System.Drawing.Size(311, 22);
            this.dtp_NgayLapHoaDonBanHang.TabIndex = 30;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.Image")));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(871, 500);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(146, 50);
            this.btn_LamMoi.TabIndex = 22;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // lb_MaNVHoaDonBanHang
            // 
            this.lb_MaNVHoaDonBanHang.AutoSize = true;
            this.lb_MaNVHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNVHoaDonBanHang.Location = new System.Drawing.Point(17, 258);
            this.lb_MaNVHoaDonBanHang.Name = "lb_MaNVHoaDonBanHang";
            this.lb_MaNVHoaDonBanHang.Size = new System.Drawing.Size(113, 20);
            this.lb_MaNVHoaDonBanHang.TabIndex = 28;
            this.lb_MaNVHoaDonBanHang.Text = "Tên nhân viên";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(17, 87);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.ReadOnly = true;
            this.txt_MaHoaDon.Size = new System.Drawing.Size(311, 27);
            this.txt_MaHoaDon.TabIndex = 27;
            // 
            // lb_MaHoaDonHoaDonBanHang
            // 
            this.lb_MaHoaDonHoaDonBanHang.AutoSize = true;
            this.lb_MaHoaDonHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaHoaDonHoaDonBanHang.Location = new System.Drawing.Point(17, 56);
            this.lb_MaHoaDonHoaDonBanHang.Name = "lb_MaHoaDonHoaDonBanHang";
            this.lb_MaHoaDonHoaDonBanHang.Size = new System.Drawing.Size(96, 20);
            this.lb_MaHoaDonHoaDonBanHang.TabIndex = 26;
            this.lb_MaHoaDonHoaDonBanHang.Text = "Mã hóa đơn";
            // 
            // btn_SuaHoaDonBanHang
            // 
            this.btn_SuaHoaDonBanHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SuaHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaHoaDonBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaHoaDonBanHang.Image")));
            this.btn_SuaHoaDonBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaHoaDonBanHang.Location = new System.Drawing.Point(363, 498);
            this.btn_SuaHoaDonBanHang.Name = "btn_SuaHoaDonBanHang";
            this.btn_SuaHoaDonBanHang.Size = new System.Drawing.Size(96, 51);
            this.btn_SuaHoaDonBanHang.TabIndex = 25;
            this.btn_SuaHoaDonBanHang.Text = "Sửa";
            this.btn_SuaHoaDonBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SuaHoaDonBanHang.UseVisualStyleBackColor = false;
            this.btn_SuaHoaDonBanHang.Click += new System.EventHandler(this.btn_SuaHoaDonBanHang_Click);
            // 
            // lb_NgayLapHoaDonBanHang
            // 
            this.lb_NgayLapHoaDonBanHang.AutoSize = true;
            this.lb_NgayLapHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayLapHoaDonBanHang.Location = new System.Drawing.Point(17, 125);
            this.lb_NgayLapHoaDonBanHang.Name = "lb_NgayLapHoaDonBanHang";
            this.lb_NgayLapHoaDonBanHang.Size = new System.Drawing.Size(74, 20);
            this.lb_NgayLapHoaDonBanHang.TabIndex = 23;
            this.lb_NgayLapHoaDonBanHang.Text = "Ngày lập";
            // 
            // lb_TimKiemHoaDonBanHang
            // 
            this.lb_TimKiemHoaDonBanHang.AutoSize = true;
            this.lb_TimKiemHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiemHoaDonBanHang.Location = new System.Drawing.Point(387, 3);
            this.lb_TimKiemHoaDonBanHang.Name = "lb_TimKiemHoaDonBanHang";
            this.lb_TimKiemHoaDonBanHang.Size = new System.Drawing.Size(77, 20);
            this.lb_TimKiemHoaDonBanHang.TabIndex = 20;
            this.lb_TimKiemHoaDonBanHang.Text = "Tìm kiếm";
            // 
            // txt_TimKiemHoaDonBanHang
            // 
            this.txt_TimKiemHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiemHoaDonBanHang.Location = new System.Drawing.Point(377, 26);
            this.txt_TimKiemHoaDonBanHang.Multiline = true;
            this.txt_TimKiemHoaDonBanHang.Name = "txt_TimKiemHoaDonBanHang";
            this.txt_TimKiemHoaDonBanHang.Size = new System.Drawing.Size(321, 27);
            this.txt_TimKiemHoaDonBanHang.TabIndex = 21;
            // 
            // btn_XoaHoaDonBanHang
            // 
            this.btn_XoaHoaDonBanHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XoaHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHoaDonBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaHoaDonBanHang.Image")));
            this.btn_XoaHoaDonBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaHoaDonBanHang.Location = new System.Drawing.Point(488, 499);
            this.btn_XoaHoaDonBanHang.Name = "btn_XoaHoaDonBanHang";
            this.btn_XoaHoaDonBanHang.Size = new System.Drawing.Size(107, 51);
            this.btn_XoaHoaDonBanHang.TabIndex = 17;
            this.btn_XoaHoaDonBanHang.Text = "Xóa ";
            this.btn_XoaHoaDonBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaHoaDonBanHang.UseVisualStyleBackColor = false;
            this.btn_XoaHoaDonBanHang.Click += new System.EventHandler(this.btn_XoaHoaDonBanHang_Click);
            // 
            // btn_XemDanhSachHoaDon
            // 
            this.btn_XemDanhSachHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XemDanhSachHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDanhSachHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemDanhSachHoaDon.Image")));
            this.btn_XemDanhSachHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemDanhSachHoaDon.Location = new System.Drawing.Point(21, 484);
            this.btn_XemDanhSachHoaDon.Name = "btn_XemDanhSachHoaDon";
            this.btn_XemDanhSachHoaDon.Size = new System.Drawing.Size(175, 59);
            this.btn_XemDanhSachHoaDon.TabIndex = 18;
            this.btn_XemDanhSachHoaDon.Text = "Xem chi tiết HD";
            this.btn_XemDanhSachHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XemDanhSachHoaDon.UseVisualStyleBackColor = false;
            this.btn_XemDanhSachHoaDon.Click += new System.EventHandler(this.btn_XemDanhSachHoaDon_Click);
            // 
            // btn_XuatThongTinHoaDonBanHang
            // 
            this.btn_XuatThongTinHoaDonBanHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XuatThongTinHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatThongTinHoaDonBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatThongTinHoaDonBanHang.Image")));
            this.btn_XuatThongTinHoaDonBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatThongTinHoaDonBanHang.Location = new System.Drawing.Point(1083, 499);
            this.btn_XuatThongTinHoaDonBanHang.Name = "btn_XuatThongTinHoaDonBanHang";
            this.btn_XuatThongTinHoaDonBanHang.Size = new System.Drawing.Size(160, 51);
            this.btn_XuatThongTinHoaDonBanHang.TabIndex = 18;
            this.btn_XuatThongTinHoaDonBanHang.Text = "Xuất thông tin";
            this.btn_XuatThongTinHoaDonBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XuatThongTinHoaDonBanHang.UseVisualStyleBackColor = false;
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKH.Location = new System.Drawing.Point(17, 328);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(61, 20);
            this.lb_MaKH.TabIndex = 2;
            this.lb_MaKH.Text = "Mã KH";
            // 
            // grb_HoaDonBanHang
            // 
            this.grb_HoaDonBanHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grb_HoaDonBanHang.Controls.Add(this.grb_SanPham);
            this.grb_HoaDonBanHang.Controls.Add(this.grb_Header);
            this.grb_HoaDonBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_HoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_HoaDonBanHang.Location = new System.Drawing.Point(0, 0);
            this.grb_HoaDonBanHang.Name = "grb_HoaDonBanHang";
            this.grb_HoaDonBanHang.Size = new System.Drawing.Size(1276, 746);
            this.grb_HoaDonBanHang.TabIndex = 19;
            this.grb_HoaDonBanHang.TabStop = false;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(17, 220);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(311, 27);
            this.txt_MaNV.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã nhân viên";
            // 
            // frm_HoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 746);
            this.ControlBox = false;
            this.Controls.Add(this.grb_HoaDonBanHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonBanHang";
            this.Load += new System.EventHandler(this.HoaDonBanHang_Load);
            this.grb_Header.ResumeLayout(false);
            this.grb_Header.PerformLayout();
            this.grb_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.grb_SanPham.ResumeLayout(false);
            this.grb_SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDonBanHang)).EndInit();
            this.grb_HoaDonBanHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox grb_Header;
        private System.Windows.Forms.GroupBox grb_SanPham;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapHoaDonBanHang;
        private System.Windows.Forms.Label lb_MaNVHoaDonBanHang;
        private System.Windows.Forms.TextBox txt_MaHoaDon;
        private System.Windows.Forms.Label lb_MaHoaDonHoaDonBanHang;
        private System.Windows.Forms.Button btn_SuaHoaDonBanHang;
        private System.Windows.Forms.Label lb_NgayLapHoaDonBanHang;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Label lb_TimKiemHoaDonBanHang;
        private System.Windows.Forms.TextBox txt_TimKiemHoaDonBanHang;
        private System.Windows.Forms.Button btn_XoaHoaDonBanHang;
        private System.Windows.Forms.Button btn_XemDanhSachHoaDon;
        private System.Windows.Forms.Button btn_XuatThongTinHoaDonBanHang;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.GroupBox grb_HoaDonBanHang;
        private System.Windows.Forms.Button btn_KHHoaDonBanHang;
        private System.Windows.Forms.DataGridView dgv_HoaDonBanHang;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.ComboBox cbo_TimKiem_Theo;
        private System.Windows.Forms.Button btn_DoiMatKhauNhanVien;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.ComboBox cbo_TenNV;
        private System.Windows.Forms.GroupBox grb_Menu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label lb_DoiMatKhauNhanVien;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.ComboBox cbo_TenNhanVien;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label1;
    }
}