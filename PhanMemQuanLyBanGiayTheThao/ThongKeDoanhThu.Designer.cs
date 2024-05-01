namespace PhanMemQuanLyBanGiayTheThao
{
    partial class frm_ThongKeDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongKeDoanhThu));
            this.grb_HeaderThongKe = new System.Windows.Forms.GroupBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.lb_SanPham = new System.Windows.Forms.Label();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_QuayLaiThongKe = new System.Windows.Forms.Button();
            this.grb_ThongKeThongKe = new System.Windows.Forms.GroupBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.cbb_DoanhThu = new System.Windows.Forms.ComboBox();
            this.lb_TongSoLuongHoaDon = new System.Windows.Forms.Label();
            this.lb_TongDoanhThuThongKe = new System.Windows.Forms.Label();
            this.txt_SLHoaDon = new System.Windows.Forms.TextBox();
            this.txt_TongDoanhThuThongKe = new System.Windows.Forms.TextBox();
            this.dgv_ThongKeHoaDon = new System.Windows.Forms.DataGridView();
            this.txt_TimKiemThongKe = new System.Windows.Forms.TextBox();
            this.btn_SearchThongKe = new System.Windows.Forms.Button();
            this.cbb_TimKiem_Theo = new System.Windows.Forms.ComboBox();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.grb_BoLoc = new System.Windows.Forms.GroupBox();
            this.grb_HeaderThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.grb_ThongKeThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeHoaDon)).BeginInit();
            this.grb_BoLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_HeaderThongKe
            // 
            this.grb_HeaderThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_HeaderThongKe.Controls.Add(this.pic_Logo);
            this.grb_HeaderThongKe.Controls.Add(this.lb_SanPham);
            this.grb_HeaderThongKe.Controls.Add(this.btn_SanPham);
            this.grb_HeaderThongKe.Controls.Add(this.btn_QuayLaiThongKe);
            this.grb_HeaderThongKe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grb_HeaderThongKe.Location = new System.Drawing.Point(11, 1);
            this.grb_HeaderThongKe.Name = "grb_HeaderThongKe";
            this.grb_HeaderThongKe.Size = new System.Drawing.Size(1263, 142);
            this.grb_HeaderThongKe.TabIndex = 55;
            this.grb_HeaderThongKe.TabStop = false;
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.White;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(1, 5);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(143, 137);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 65;
            this.pic_Logo.TabStop = false;
            // 
            // lb_SanPham
            // 
            this.lb_SanPham.AutoSize = true;
            this.lb_SanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SanPham.ForeColor = System.Drawing.Color.Black;
            this.lb_SanPham.Location = new System.Drawing.Point(1022, 104);
            this.lb_SanPham.Name = "lb_SanPham";
            this.lb_SanPham.Size = new System.Drawing.Size(137, 19);
            this.lb_SanPham.TabIndex = 41;
            this.lb_SanPham.Text = "Thống kê sản phẩm";
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SanPham.BackgroundImage")));
            this.btn_SanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SanPham.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.Location = new System.Drawing.Point(1045, 21);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(80, 80);
            this.btn_SanPham.TabIndex = 40;
            this.btn_SanPham.UseVisualStyleBackColor = false;
            this.btn_SanPham.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_QuayLaiThongKe
            // 
            this.btn_QuayLaiThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuayLaiThongKe.Image")));
            this.btn_QuayLaiThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLaiThongKe.Location = new System.Drawing.Point(180, 21);
            this.btn_QuayLaiThongKe.Name = "btn_QuayLaiThongKe";
            this.btn_QuayLaiThongKe.Size = new System.Drawing.Size(109, 40);
            this.btn_QuayLaiThongKe.TabIndex = 34;
            this.btn_QuayLaiThongKe.Text = "Quay lại";
            this.btn_QuayLaiThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QuayLaiThongKe.UseVisualStyleBackColor = true;
            this.btn_QuayLaiThongKe.Click += new System.EventHandler(this.btn_QuayLaiThongKe_Click);
            // 
            // grb_ThongKeThongKe
            // 
            this.grb_ThongKeThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_ThongKeThongKe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grb_ThongKeThongKe.Controls.Add(this.btn_LamMoi);
            this.grb_ThongKeThongKe.Controls.Add(this.cbb_DoanhThu);
            this.grb_ThongKeThongKe.Controls.Add(this.lb_TongSoLuongHoaDon);
            this.grb_ThongKeThongKe.Controls.Add(this.lb_TongDoanhThuThongKe);
            this.grb_ThongKeThongKe.Controls.Add(this.txt_SLHoaDon);
            this.grb_ThongKeThongKe.Controls.Add(this.txt_TongDoanhThuThongKe);
            this.grb_ThongKeThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongKeThongKe.Location = new System.Drawing.Point(11, 507);
            this.grb_ThongKeThongKe.Name = "grb_ThongKeThongKe";
            this.grb_ThongKeThongKe.Size = new System.Drawing.Size(1264, 189);
            this.grb_ThongKeThongKe.TabIndex = 54;
            this.grb_ThongKeThongKe.TabStop = false;
            this.grb_ThongKeThongKe.Text = "Thống kê";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_LamMoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.Image")));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(1111, 21);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(146, 50);
            this.btn_LamMoi.TabIndex = 57;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // cbb_DoanhThu
            // 
            this.cbb_DoanhThu.FormattingEnabled = true;
            this.cbb_DoanhThu.Items.AddRange(new object[] {
            "Tháng ",
            "Quý",
            "Năm"});
            this.cbb_DoanhThu.Location = new System.Drawing.Point(28, 32);
            this.cbb_DoanhThu.Name = "cbb_DoanhThu";
            this.cbb_DoanhThu.Size = new System.Drawing.Size(192, 28);
            this.cbb_DoanhThu.TabIndex = 62;
            this.cbb_DoanhThu.SelectedIndexChanged += new System.EventHandler(this.Cbb_DoanhThu_SelectedIndexChanged);
            // 
            // lb_TongSoLuongHoaDon
            // 
            this.lb_TongSoLuongHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_TongSoLuongHoaDon.AutoSize = true;
            this.lb_TongSoLuongHoaDon.Location = new System.Drawing.Point(24, 82);
            this.lb_TongSoLuongHoaDon.Name = "lb_TongSoLuongHoaDon";
            this.lb_TongSoLuongHoaDon.Size = new System.Drawing.Size(188, 20);
            this.lb_TongSoLuongHoaDon.TabIndex = 31;
            this.lb_TongSoLuongHoaDon.Text = "Tổng số lượng hóa đơn :\r\n";
            // 
            // lb_TongDoanhThuThongKe
            // 
            this.lb_TongDoanhThuThongKe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_TongDoanhThuThongKe.AutoSize = true;
            this.lb_TongDoanhThuThongKe.Location = new System.Drawing.Point(69, 125);
            this.lb_TongDoanhThuThongKe.Name = "lb_TongDoanhThuThongKe";
            this.lb_TongDoanhThuThongKe.Size = new System.Drawing.Size(134, 20);
            this.lb_TongDoanhThuThongKe.TabIndex = 31;
            this.lb_TongDoanhThuThongKe.Text = "Tổng doanh thu :";
            // 
            // txt_SLHoaDon
            // 
            this.txt_SLHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_SLHoaDon.Location = new System.Drawing.Point(218, 79);
            this.txt_SLHoaDon.Name = "txt_SLHoaDon";
            this.txt_SLHoaDon.Size = new System.Drawing.Size(312, 27);
            this.txt_SLHoaDon.TabIndex = 30;
            // 
            // txt_TongDoanhThuThongKe
            // 
            this.txt_TongDoanhThuThongKe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_TongDoanhThuThongKe.Location = new System.Drawing.Point(218, 122);
            this.txt_TongDoanhThuThongKe.Name = "txt_TongDoanhThuThongKe";
            this.txt_TongDoanhThuThongKe.Size = new System.Drawing.Size(312, 27);
            this.txt_TongDoanhThuThongKe.TabIndex = 30;
            // 
            // dgv_ThongKeHoaDon
            // 
            this.dgv_ThongKeHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeHoaDon.Location = new System.Drawing.Point(11, 269);
            this.dgv_ThongKeHoaDon.Name = "dgv_ThongKeHoaDon";
            this.dgv_ThongKeHoaDon.RowHeadersWidth = 51;
            this.dgv_ThongKeHoaDon.RowTemplate.Height = 24;
            this.dgv_ThongKeHoaDon.Size = new System.Drawing.Size(1263, 232);
            this.dgv_ThongKeHoaDon.TabIndex = 57;
            // 
            // txt_TimKiemThongKe
            // 
            this.txt_TimKiemThongKe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_TimKiemThongKe.Location = new System.Drawing.Point(97, 42);
            this.txt_TimKiemThongKe.Name = "txt_TimKiemThongKe";
            this.txt_TimKiemThongKe.Size = new System.Drawing.Size(309, 27);
            this.txt_TimKiemThongKe.TabIndex = 50;
            // 
            // btn_SearchThongKe
            // 
            this.btn_SearchThongKe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchThongKe.Image")));
            this.btn_SearchThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchThongKe.Location = new System.Drawing.Point(271, 69);
            this.btn_SearchThongKe.Name = "btn_SearchThongKe";
            this.btn_SearchThongKe.Size = new System.Drawing.Size(135, 39);
            this.btn_SearchThongKe.TabIndex = 52;
            this.btn_SearchThongKe.Text = "Search";
            this.btn_SearchThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchThongKe.UseVisualStyleBackColor = false;
            this.btn_SearchThongKe.Click += new System.EventHandler(this.btn_SearchThongKe_Click);
            // 
            // cbb_TimKiem_Theo
            // 
            this.cbb_TimKiem_Theo.FormattingEnabled = true;
            this.cbb_TimKiem_Theo.Items.AddRange(new object[] {
            "MaHD",
            "MaNV",
            "MaKH",
            "Ngày"});
            this.cbb_TimKiem_Theo.Location = new System.Drawing.Point(412, 40);
            this.cbb_TimKiem_Theo.Name = "cbb_TimKiem_Theo";
            this.cbb_TimKiem_Theo.Size = new System.Drawing.Size(239, 28);
            this.cbb_TimKiem_Theo.TabIndex = 58;
            this.cbb_TimKiem_Theo.SelectedIndexChanged += new System.EventHandler(this.Cbb_TimKiem_Theo_SelectedIndexChanged);
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Location = new System.Drawing.Point(657, 42);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(239, 27);
            this.dtp_Ngay.TabIndex = 59;
            this.dtp_Ngay.Visible = false;
            // 
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Location = new System.Drawing.Point(14, 45);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lb_TimKiem.TabIndex = 61;
            this.lb_TimKiem.Text = "Tìm kiếm";
            // 
            // grb_BoLoc
            // 
            this.grb_BoLoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grb_BoLoc.Controls.Add(this.lb_TimKiem);
            this.grb_BoLoc.Controls.Add(this.dtp_Ngay);
            this.grb_BoLoc.Controls.Add(this.cbb_TimKiem_Theo);
            this.grb_BoLoc.Controls.Add(this.btn_SearchThongKe);
            this.grb_BoLoc.Controls.Add(this.txt_TimKiemThongKe);
            this.grb_BoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_BoLoc.Location = new System.Drawing.Point(11, 149);
            this.grb_BoLoc.Name = "grb_BoLoc";
            this.grb_BoLoc.Size = new System.Drawing.Size(1264, 114);
            this.grb_BoLoc.TabIndex = 61;
            this.grb_BoLoc.TabStop = false;
            this.grb_BoLoc.Text = "Thống kê hóa đơn";
            // 
            // frm_ThongKeDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1294, 736);
            this.Controls.Add(this.grb_BoLoc);
            this.Controls.Add(this.dgv_ThongKeHoaDon);
            this.Controls.Add(this.grb_HeaderThongKe);
            this.Controls.Add(this.grb_ThongKeThongKe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ThongKeDoanhThu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.grb_HeaderThongKe.ResumeLayout(false);
            this.grb_HeaderThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.grb_ThongKeThongKe.ResumeLayout(false);
            this.grb_ThongKeThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeHoaDon)).EndInit();
            this.grb_BoLoc.ResumeLayout(false);
            this.grb_BoLoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_HeaderThongKe;
        private System.Windows.Forms.GroupBox grb_ThongKeThongKe;
        private System.Windows.Forms.Label lb_TongDoanhThuThongKe;
        private System.Windows.Forms.TextBox txt_TongDoanhThuThongKe;
        private System.Windows.Forms.Button btn_QuayLaiThongKe;
        private System.Windows.Forms.DataGridView dgv_ThongKeHoaDon;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Label lb_SanPham;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.TextBox txt_TimKiemThongKe;
        private System.Windows.Forms.Button btn_SearchThongKe;
        private System.Windows.Forms.ComboBox cbb_TimKiem_Theo;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.GroupBox grb_BoLoc;
        private System.Windows.Forms.ComboBox cbb_DoanhThu;
        private System.Windows.Forms.Label lb_TongSoLuongHoaDon;
        private System.Windows.Forms.TextBox txt_SLHoaDon;
        private System.Windows.Forms.PictureBox pic_Logo;
    }
}