﻿using System;

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
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.lb_DoiMatKhauNhanVien = new System.Windows.Forms.Label();
            this.btn_DoiMatKhauNhanVien = new System.Windows.Forms.Button();
            this.btn_QuayLaiBanHang = new System.Windows.Forms.Button();
            this.lb_DangXuatHoaDonBanHang = new System.Windows.Forms.Label();
            this.btn_DangXuatHoaDonBanHang = new System.Windows.Forms.Button();
            this.btn_KHHoaDonBanHang = new System.Windows.Forms.Button();
            this.grb_SanPham = new System.Windows.Forms.GroupBox();
            this.cbb_TimKiem_Theo = new System.Windows.Forms.ComboBox();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.cbo_MaNV = new System.Windows.Forms.ComboBox();
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
            this.grb_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.grb_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDonBanHang)).BeginInit();
            this.grb_HoaDonBanHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Header
            // 
            this.grb_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_Header.Controls.Add(this.pic_Logo);
            this.grb_Header.Controls.Add(this.lb_DoiMatKhauNhanVien);
            this.grb_Header.Controls.Add(this.btn_DoiMatKhauNhanVien);
            this.grb_Header.Controls.Add(this.btn_QuayLaiBanHang);
            this.grb_Header.Controls.Add(this.lb_DangXuatHoaDonBanHang);
            this.grb_Header.Controls.Add(this.btn_DangXuatHoaDonBanHang);
            this.grb_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_Header.Location = new System.Drawing.Point(3, 24);
            this.grb_Header.Name = "grb_Header";
            this.grb_Header.Size = new System.Drawing.Size(1270, 153);
            this.grb_Header.TabIndex = 15;
            this.grb_Header.TabStop = false;
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.DimGray;
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
            this.lb_DoiMatKhauNhanVien.Location = new System.Drawing.Point(1034, 108);
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
            this.btn_DoiMatKhauNhanVien.Location = new System.Drawing.Point(1053, 32);
            this.btn_DoiMatKhauNhanVien.Name = "btn_DoiMatKhauNhanVien";
            this.btn_DoiMatKhauNhanVien.Size = new System.Drawing.Size(59, 61);
            this.btn_DoiMatKhauNhanVien.TabIndex = 62;
            this.btn_DoiMatKhauNhanVien.UseVisualStyleBackColor = false;
            this.btn_DoiMatKhauNhanVien.Click += new System.EventHandler(this.btn_DoiMatKhauNhanVien_Click);
            // 
            // btn_QuayLaiBanHang
            // 
            this.btn_QuayLaiBanHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_QuayLaiBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuayLaiBanHang.Image")));
            this.btn_QuayLaiBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLaiBanHang.Location = new System.Drawing.Point(174, 27);
            this.btn_QuayLaiBanHang.Name = "btn_QuayLaiBanHang";
            this.btn_QuayLaiBanHang.Size = new System.Drawing.Size(150, 45);
            this.btn_QuayLaiBanHang.TabIndex = 4;
            this.btn_QuayLaiBanHang.Text = "Quay lại";
            this.btn_QuayLaiBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QuayLaiBanHang.UseVisualStyleBackColor = false;
            this.btn_QuayLaiBanHang.Click += new System.EventHandler(this.lb_QuayLaiBanHang_Click);
            // 
            // lb_DangXuatHoaDonBanHang
            // 
            this.lb_DangXuatHoaDonBanHang.AutoSize = true;
            this.lb_DangXuatHoaDonBanHang.Location = new System.Drawing.Point(1162, 107);
            this.lb_DangXuatHoaDonBanHang.Name = "lb_DangXuatHoaDonBanHang";
            this.lb_DangXuatHoaDonBanHang.Size = new System.Drawing.Size(92, 22);
            this.lb_DangXuatHoaDonBanHang.TabIndex = 3;
            this.lb_DangXuatHoaDonBanHang.Text = "Đăng xuất";
            // 
            // btn_DangXuatHoaDonBanHang
            // 
            this.btn_DangXuatHoaDonBanHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_DangXuatHoaDonBanHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuatHoaDonBanHang.BackgroundImage")));
            this.btn_DangXuatHoaDonBanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DangXuatHoaDonBanHang.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_DangXuatHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuatHoaDonBanHang.Location = new System.Drawing.Point(1181, 43);
            this.btn_DangXuatHoaDonBanHang.Name = "btn_DangXuatHoaDonBanHang";
            this.btn_DangXuatHoaDonBanHang.Size = new System.Drawing.Size(50, 61);
            this.btn_DangXuatHoaDonBanHang.TabIndex = 2;
            this.btn_DangXuatHoaDonBanHang.UseVisualStyleBackColor = false;
            this.btn_DangXuatHoaDonBanHang.Click += new System.EventHandler(this.btn_DangXuatHoaDonBanHang_Click);
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
            this.grb_SanPham.Controls.Add(this.cbb_TimKiem_Theo);
            this.grb_SanPham.Controls.Add(this.dtp_Ngay);
            this.grb_SanPham.Controls.Add(this.txt_MaKH);
            this.grb_SanPham.Controls.Add(this.btn_TaoHoaDon);
            this.grb_SanPham.Controls.Add(this.cbo_MaNV);
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
            // cbb_TimKiem_Theo
            // 
            this.cbb_TimKiem_Theo.FormattingEnabled = true;
            this.cbb_TimKiem_Theo.Items.AddRange(new object[] {
            "MaHD",
            "MaNV",
            "MaKH",
            "Ngày"});
            this.cbb_TimKiem_Theo.Location = new System.Drawing.Point(721, 30);
            this.cbb_TimKiem_Theo.Name = "cbb_TimKiem_Theo";
            this.cbb_TimKiem_Theo.Size = new System.Drawing.Size(144, 28);
            this.cbb_TimKiem_Theo.TabIndex = 61;
            this.cbb_TimKiem_Theo.SelectedIndexChanged += new System.EventHandler(this.Cbb_TimKiem_Theo_SelectedIndexChanged_1);
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Location = new System.Drawing.Point(886, 31);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(239, 27);
            this.dtp_Ngay.TabIndex = 60;
            this.dtp_Ngay.Visible = false;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(13, 281);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(311, 27);
            this.txt_MaKH.TabIndex = 45;
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_TaoHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoHoaDon.Image")));
            this.btn_TaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(13, 342);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(311, 45);
            this.btn_TaoHoaDon.TabIndex = 44;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = false;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo_MaNV
            // 
            this.cbo_MaNV.FormattingEnabled = true;
            this.cbo_MaNV.Location = new System.Drawing.Point(13, 211);
            this.cbo_MaNV.Name = "cbo_MaNV";
            this.cbo_MaNV.Size = new System.Drawing.Size(311, 28);
            this.cbo_MaNV.TabIndex = 43;
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
            this.dtp_NgayLapHoaDonBanHang.Location = new System.Drawing.Point(13, 153);
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
            this.btn_LamMoi.Location = new System.Drawing.Point(923, 499);
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
            this.lb_MaNVHoaDonBanHang.Location = new System.Drawing.Point(9, 188);
            this.lb_MaNVHoaDonBanHang.Name = "lb_MaNVHoaDonBanHang";
            this.lb_MaNVHoaDonBanHang.Size = new System.Drawing.Size(60, 20);
            this.lb_MaNVHoaDonBanHang.TabIndex = 28;
            this.lb_MaNVHoaDonBanHang.Text = "Mã NV";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(13, 87);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.ReadOnly = true;
            this.txt_MaHoaDon.Size = new System.Drawing.Size(311, 27);
            this.txt_MaHoaDon.TabIndex = 27;
            // 
            // lb_MaHoaDonHoaDonBanHang
            // 
            this.lb_MaHoaDonHoaDonBanHang.AutoSize = true;
            this.lb_MaHoaDonHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaHoaDonHoaDonBanHang.Location = new System.Drawing.Point(13, 56);
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
            this.lb_NgayLapHoaDonBanHang.Location = new System.Drawing.Point(9, 117);
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
            this.txt_TimKiemHoaDonBanHang.Size = new System.Drawing.Size(321, 32);
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
            this.btn_XemDanhSachHoaDon.Location = new System.Drawing.Point(17, 421);
            this.btn_XemDanhSachHoaDon.Name = "btn_XemDanhSachHoaDon";
            this.btn_XemDanhSachHoaDon.Size = new System.Drawing.Size(154, 59);
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
            this.btn_XuatThongTinHoaDonBanHang.Location = new System.Drawing.Point(1102, 499);
            this.btn_XuatThongTinHoaDonBanHang.Name = "btn_XuatThongTinHoaDonBanHang";
            this.btn_XuatThongTinHoaDonBanHang.Size = new System.Drawing.Size(141, 51);
            this.btn_XuatThongTinHoaDonBanHang.TabIndex = 18;
            this.btn_XuatThongTinHoaDonBanHang.Text = "Xuất thông tin";
            this.btn_XuatThongTinHoaDonBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XuatThongTinHoaDonBanHang.UseVisualStyleBackColor = false;
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKH.Location = new System.Drawing.Point(9, 258);
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
            // frm_HoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 746);
            this.Controls.Add(this.grb_HoaDonBanHang);
            this.Name = "frm_HoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonBanHang";
            this.Load += new System.EventHandler(this.HoaDonBanHang_Load);
            this.grb_Header.ResumeLayout(false);
            this.grb_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.grb_SanPham.ResumeLayout(false);
            this.grb_SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDonBanHang)).EndInit();
            this.grb_HoaDonBanHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox grb_Header;
        private System.Windows.Forms.Button btn_QuayLaiBanHang;
        private System.Windows.Forms.Label lb_DangXuatHoaDonBanHang;
        private System.Windows.Forms.Button btn_DangXuatHoaDonBanHang;
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
        private System.Windows.Forms.ComboBox cbo_MaNV;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.ComboBox cbb_TimKiem_Theo;
        private System.Windows.Forms.Label lb_DoiMatKhauNhanVien;
        private System.Windows.Forms.Button btn_DoiMatKhauNhanVien;
        private System.Windows.Forms.PictureBox pic_Logo;
    }
}