namespace PhanMemQuanLyBanGiayTheThao
{
    partial class frm_ThongKeSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongKeSanPham));
            this.grb_ThongKeSanPham = new System.Windows.Forms.GroupBox();
            this.dgv_ThongKeSanPhamBanRa = new System.Windows.Forms.DataGridView();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.cbo_TimKiem_Theo = new System.Windows.Forms.ComboBox();
            this.btn_SearchThongKe = new System.Windows.Forms.Button();
            this.txt_TimKiemThongKe = new System.Windows.Forms.TextBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.lb_HoaDon = new System.Windows.Forms.Label();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.grb_Menu = new System.Windows.Forms.GroupBox();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.grb_HeaderThongKe = new System.Windows.Forms.GroupBox();
            this.grb_ThongKeSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeSanPhamBanRa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.grb_Menu.SuspendLayout();
            this.grb_HeaderThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ThongKeSanPham
            // 
            this.grb_ThongKeSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_ThongKeSanPham.Controls.Add(this.dgv_ThongKeSanPhamBanRa);
            this.grb_ThongKeSanPham.Controls.Add(this.lb_TimKiem);
            this.grb_ThongKeSanPham.Controls.Add(this.cbo_TimKiem_Theo);
            this.grb_ThongKeSanPham.Controls.Add(this.btn_SearchThongKe);
            this.grb_ThongKeSanPham.Controls.Add(this.txt_TimKiemThongKe);
            this.grb_ThongKeSanPham.Controls.Add(this.btn_LamMoi);
            this.grb_ThongKeSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongKeSanPham.Location = new System.Drawing.Point(0, 148);
            this.grb_ThongKeSanPham.Name = "grb_ThongKeSanPham";
            this.grb_ThongKeSanPham.Size = new System.Drawing.Size(1330, 413);
            this.grb_ThongKeSanPham.TabIndex = 58;
            this.grb_ThongKeSanPham.TabStop = false;
            this.grb_ThongKeSanPham.Text = "Thống kê sản phẩm";
            // 
            // dgv_ThongKeSanPhamBanRa
            // 
            this.dgv_ThongKeSanPhamBanRa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeSanPhamBanRa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeSanPhamBanRa.Location = new System.Drawing.Point(12, 108);
            this.dgv_ThongKeSanPhamBanRa.Name = "dgv_ThongKeSanPhamBanRa";
            this.dgv_ThongKeSanPhamBanRa.RowHeadersWidth = 51;
            this.dgv_ThongKeSanPhamBanRa.RowTemplate.Height = 24;
            this.dgv_ThongKeSanPhamBanRa.Size = new System.Drawing.Size(1303, 232);
            this.dgv_ThongKeSanPhamBanRa.TabIndex = 67;
            // 
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Location = new System.Drawing.Point(12, 57);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lb_TimKiem.TabIndex = 66;
            this.lb_TimKiem.Text = "Tìm kiếm";
            // 
            // cbo_TimKiem_Theo
            // 
            this.cbo_TimKiem_Theo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TimKiem_Theo.FormattingEnabled = true;
            this.cbo_TimKiem_Theo.Items.AddRange(new object[] {
            "MaSP",
            "Tên sản phẩm "});
            this.cbo_TimKiem_Theo.Location = new System.Drawing.Point(432, 57);
            this.cbo_TimKiem_Theo.Name = "cbo_TimKiem_Theo";
            this.cbo_TimKiem_Theo.Size = new System.Drawing.Size(239, 28);
            this.cbo_TimKiem_Theo.TabIndex = 64;
            // 
            // btn_SearchThongKe
            // 
            this.btn_SearchThongKe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchThongKe.Image")));
            this.btn_SearchThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchThongKe.Location = new System.Drawing.Point(686, 46);
            this.btn_SearchThongKe.Name = "btn_SearchThongKe";
            this.btn_SearchThongKe.Size = new System.Drawing.Size(152, 48);
            this.btn_SearchThongKe.TabIndex = 63;
            this.btn_SearchThongKe.Text = "Search";
            this.btn_SearchThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchThongKe.UseVisualStyleBackColor = false;
            this.btn_SearchThongKe.Click += new System.EventHandler(this.btn_SearchThongKe_Click);
            // 
            // txt_TimKiemThongKe
            // 
            this.txt_TimKiemThongKe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_TimKiemThongKe.Location = new System.Drawing.Point(103, 54);
            this.txt_TimKiemThongKe.Multiline = true;
            this.txt_TimKiemThongKe.Name = "txt_TimKiemThongKe";
            this.txt_TimKiemThongKe.Size = new System.Drawing.Size(309, 33);
            this.txt_TimKiemThongKe.TabIndex = 62;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.Image")));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(1168, 346);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(146, 50);
            this.btn_LamMoi.TabIndex = 59;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_HoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.BackgroundImage")));
            this.btn_HoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HoaDon.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.Location = new System.Drawing.Point(242, 31);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(80, 80);
            this.btn_HoaDon.TabIndex = 38;
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // lb_HoaDon
            // 
            this.lb_HoaDon.AutoSize = true;
            this.lb_HoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoaDon.Location = new System.Drawing.Point(210, 114);
            this.lb_HoaDon.Name = "lb_HoaDon";
            this.lb_HoaDon.Size = new System.Drawing.Size(140, 19);
            this.lb_HoaDon.TabIndex = 39;
            this.lb_HoaDon.Text = "Thống kê doanh thu";
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.White;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(11, 11);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(143, 137);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 65;
            this.pic_Logo.TabStop = false;
            // 
            // grb_Menu
            // 
            this.grb_Menu.BackColor = System.Drawing.Color.Transparent;
            this.grb_Menu.Controls.Add(this.btn_dangxuat);
            this.grb_Menu.Controls.Add(this.btn_exit);
            this.grb_Menu.Controls.Add(this.btn_quaylai);
            this.grb_Menu.ForeColor = System.Drawing.Color.Black;
            this.grb_Menu.Location = new System.Drawing.Point(1173, 11);
            this.grb_Menu.Name = "grb_Menu";
            this.grb_Menu.Size = new System.Drawing.Size(153, 80);
            this.grb_Menu.TabIndex = 68;
            this.grb_Menu.TabStop = false;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.Image")));
            this.btn_dangxuat.Location = new System.Drawing.Point(59, 20);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(37, 41);
            this.btn_dangxuat.TabIndex = 70;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(103, 21);
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
            // grb_HeaderThongKe
            // 
            this.grb_HeaderThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_HeaderThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_HeaderThongKe.Controls.Add(this.grb_Menu);
            this.grb_HeaderThongKe.Controls.Add(this.pic_Logo);
            this.grb_HeaderThongKe.Controls.Add(this.lb_HoaDon);
            this.grb_HeaderThongKe.Controls.Add(this.btn_HoaDon);
            this.grb_HeaderThongKe.Location = new System.Drawing.Point(1, 1);
            this.grb_HeaderThongKe.Name = "grb_HeaderThongKe";
            this.grb_HeaderThongKe.Size = new System.Drawing.Size(1326, 150);
            this.grb_HeaderThongKe.TabIndex = 56;
            this.grb_HeaderThongKe.TabStop = false;
            // 
            // frm_ThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1327, 567);
            this.ControlBox = false;
            this.Controls.Add(this.grb_ThongKeSanPham);
            this.Controls.Add(this.grb_HeaderThongKe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ThongKeSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sản phẩm";
            this.Load += new System.EventHandler(this.ThongKeSanPham_Load);
            this.grb_ThongKeSanPham.ResumeLayout(false);
            this.grb_ThongKeSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeSanPhamBanRa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.grb_Menu.ResumeLayout(false);
            this.grb_HeaderThongKe.ResumeLayout(false);
            this.grb_HeaderThongKe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_ThongKeSanPham;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.ComboBox cbo_TimKiem_Theo;
        private System.Windows.Forms.Button btn_SearchThongKe;
        private System.Windows.Forms.TextBox txt_TimKiemThongKe;
        private System.Windows.Forms.DataGridView dgv_ThongKeSanPhamBanRa;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Label lb_HoaDon;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.GroupBox grb_Menu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.GroupBox grb_HeaderThongKe;
        private System.Windows.Forms.Button btn_dangxuat;
    }
}