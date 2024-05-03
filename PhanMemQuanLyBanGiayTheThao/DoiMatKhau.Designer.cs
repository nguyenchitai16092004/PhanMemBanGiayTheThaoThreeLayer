namespace PhanMemQuanLyBanGiayTheThao
{
    partial class frm_DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoiMatKhau));
            this.lb_MatKhauMoi = new System.Windows.Forms.Label();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.grb_Body = new System.Windows.Forms.GroupBox();
            this.txt_NhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.lb_TenDangNhapCu = new System.Windows.Forms.Label();
            this.lb_MatKhauCu = new System.Windows.Forms.Label();
            this.lb_NhapLaiMatKhau = new System.Windows.Forms.Label();
            this.txt_TenDangNhapCu = new System.Windows.Forms.TextBox();
            this.txt_MatKhauCu = new System.Windows.Forms.TextBox();
            this.btn_DoiMatKhau = new System.Windows.Forms.Button();
            this.grb_Header = new System.Windows.Forms.GroupBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.btn_QuayLaiNhaCungCap = new System.Windows.Forms.Button();
            this.chk_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.grb_Body.SuspendLayout();
            this.grb_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MatKhauMoi
            // 
            this.lb_MatKhauMoi.AutoSize = true;
            this.lb_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhauMoi.Location = new System.Drawing.Point(68, 178);
            this.lb_MatKhauMoi.Name = "lb_MatKhauMoi";
            this.lb_MatKhauMoi.Size = new System.Drawing.Size(158, 20);
            this.lb_MatKhauMoi.TabIndex = 0;
            this.lb_MatKhauMoi.Text = "Nhập mật khẩu mới:";
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(291, 175);
            this.txt_MatKhauMoi.Multiline = true;
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.PasswordChar = '*';
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(192, 38);
            this.txt_MatKhauMoi.TabIndex = 1;
            // 
            // grb_Body
            // 
            this.grb_Body.Controls.Add(this.chk_HienMatKhau);
            this.grb_Body.Controls.Add(this.txt_NhapLaiMatKhau);
            this.grb_Body.Controls.Add(this.txt_MatKhauMoi);
            this.grb_Body.Controls.Add(this.lb_TenDangNhapCu);
            this.grb_Body.Controls.Add(this.lb_MatKhauCu);
            this.grb_Body.Controls.Add(this.lb_NhapLaiMatKhau);
            this.grb_Body.Controls.Add(this.txt_TenDangNhapCu);
            this.grb_Body.Controls.Add(this.txt_MatKhauCu);
            this.grb_Body.Controls.Add(this.lb_MatKhauMoi);
            this.grb_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Body.Location = new System.Drawing.Point(4, 170);
            this.grb_Body.Name = "grb_Body";
            this.grb_Body.Size = new System.Drawing.Size(607, 330);
            this.grb_Body.TabIndex = 2;
            this.grb_Body.TabStop = false;
            this.grb_Body.Text = "Đổi mật khẩu";
            // 
            // txt_NhapLaiMatKhau
            // 
            this.txt_NhapLaiMatKhau.Location = new System.Drawing.Point(291, 243);
            this.txt_NhapLaiMatKhau.Multiline = true;
            this.txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            this.txt_NhapLaiMatKhau.PasswordChar = '*';
            this.txt_NhapLaiMatKhau.Size = new System.Drawing.Size(192, 38);
            this.txt_NhapLaiMatKhau.TabIndex = 1;
            // 
            // lb_TenDangNhapCu
            // 
            this.lb_TenDangNhapCu.AutoSize = true;
            this.lb_TenDangNhapCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDangNhapCu.Location = new System.Drawing.Point(66, 57);
            this.lb_TenDangNhapCu.Name = "lb_TenDangNhapCu";
            this.lb_TenDangNhapCu.Size = new System.Drawing.Size(185, 20);
            this.lb_TenDangNhapCu.TabIndex = 0;
            this.lb_TenDangNhapCu.Text = "Nhập lại tên đăng nhập:";
            // 
            // lb_MatKhauCu
            // 
            this.lb_MatKhauCu.AutoSize = true;
            this.lb_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhauCu.Location = new System.Drawing.Point(66, 115);
            this.lb_MatKhauCu.Name = "lb_MatKhauCu";
            this.lb_MatKhauCu.Size = new System.Drawing.Size(171, 20);
            this.lb_MatKhauCu.TabIndex = 0;
            this.lb_MatKhauCu.Text = "Nhập lại mật khẩu cũ:";
            // 
            // lb_NhapLaiMatKhau
            // 
            this.lb_NhapLaiMatKhau.AutoSize = true;
            this.lb_NhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhapLaiMatKhau.Location = new System.Drawing.Point(68, 243);
            this.lb_NhapLaiMatKhau.Name = "lb_NhapLaiMatKhau";
            this.lb_NhapLaiMatKhau.Size = new System.Drawing.Size(148, 20);
            this.lb_NhapLaiMatKhau.TabIndex = 0;
            this.lb_NhapLaiMatKhau.Text = "Nhập lại mật khẩu:";
            // 
            // txt_TenDangNhapCu
            // 
            this.txt_TenDangNhapCu.Location = new System.Drawing.Point(291, 57);
            this.txt_TenDangNhapCu.Multiline = true;
            this.txt_TenDangNhapCu.Name = "txt_TenDangNhapCu";
            this.txt_TenDangNhapCu.Size = new System.Drawing.Size(192, 38);
            this.txt_TenDangNhapCu.TabIndex = 1;
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.Location = new System.Drawing.Point(291, 115);
            this.txt_MatKhauCu.Multiline = true;
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.PasswordChar = '*';
            this.txt_MatKhauCu.Size = new System.Drawing.Size(192, 38);
            this.txt_MatKhauCu.TabIndex = 1;
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(171, 517);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(204, 60);
            this.btn_DoiMatKhau.TabIndex = 3;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.UseVisualStyleBackColor = false;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // grb_Header
            // 
            this.grb_Header.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_Header.Controls.Add(this.pic_Logo);
            this.grb_Header.Controls.Add(this.btn_QuayLaiNhaCungCap);
            this.grb_Header.Location = new System.Drawing.Point(4, 4);
            this.grb_Header.Name = "grb_Header";
            this.grb_Header.Size = new System.Drawing.Size(607, 160);
            this.grb_Header.TabIndex = 4;
            this.grb_Header.TabStop = false;
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(8, 8);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(143, 137);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 22;
            this.pic_Logo.TabStop = false;
            // 
            // btn_QuayLaiNhaCungCap
            // 
            this.btn_QuayLaiNhaCungCap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_QuayLaiNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLaiNhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuayLaiNhaCungCap.Image")));
            this.btn_QuayLaiNhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLaiNhaCungCap.Location = new System.Drawing.Point(183, 21);
            this.btn_QuayLaiNhaCungCap.Name = "btn_QuayLaiNhaCungCap";
            this.btn_QuayLaiNhaCungCap.Size = new System.Drawing.Size(145, 49);
            this.btn_QuayLaiNhaCungCap.TabIndex = 21;
            this.btn_QuayLaiNhaCungCap.Text = "Quay lại";
            this.btn_QuayLaiNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QuayLaiNhaCungCap.UseVisualStyleBackColor = false;
            this.btn_QuayLaiNhaCungCap.Click += new System.EventHandler(this.btn_QuayLaiNhaCungCap_Click);
            // 
            // chk_HienMatKhau
            // 
            this.chk_HienMatKhau.AutoSize = true;
            this.chk_HienMatKhau.Location = new System.Drawing.Point(70, 304);
            this.chk_HienMatKhau.Name = "chk_HienMatKhau";
            this.chk_HienMatKhau.Size = new System.Drawing.Size(139, 24);
            this.chk_HienMatKhau.TabIndex = 2;
            this.chk_HienMatKhau.Text = "Hiện mật khẩu";
            this.chk_HienMatKhau.UseVisualStyleBackColor = true;
            this.chk_HienMatKhau.CheckedChanged += new System.EventHandler(this.chk_HienMatKhau_CheckedChanged);
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 589);
            this.Controls.Add(this.grb_Header);
            this.Controls.Add(this.btn_DoiMatKhau);
            this.Controls.Add(this.grb_Body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DoiMatKhau_FormClosing);
            this.grb_Body.ResumeLayout(false);
            this.grb_Body.PerformLayout();
            this.grb_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_MatKhauMoi;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.GroupBox grb_Body;
        private System.Windows.Forms.Button btn_DoiMatKhau;
        private System.Windows.Forms.GroupBox grb_Header;
        private System.Windows.Forms.TextBox txt_NhapLaiMatKhau;
        private System.Windows.Forms.Label lb_NhapLaiMatKhau;
        private System.Windows.Forms.Button btn_QuayLaiNhaCungCap;
        private System.Windows.Forms.Label lb_TenDangNhapCu;
        private System.Windows.Forms.Label lb_MatKhauCu;
        private System.Windows.Forms.TextBox txt_TenDangNhapCu;
        private System.Windows.Forms.TextBox txt_MatKhauCu;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.CheckBox chk_HienMatKhau;
    }
}