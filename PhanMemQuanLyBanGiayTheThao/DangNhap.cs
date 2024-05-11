using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhanMemQuanLyBanGiayTheThao
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhapBLL dangNhapBLL = new DangNhapBLL();
            string username = txt_TenDangNhap.Text;
            string password = txt_MatKhau.Text;

            bool isAuthenticated = dangNhapBLL.KiemTraDangNhap(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Đăng nhập thành công!");
                MessageBox.Show("Xin chào " + username);
                DangNhapBLL PhanQuyenBLL = new DangNhapBLL();
                int MaTK = PhanQuyenBLL.PhanQuyen(username, password);
                frm_Menu home = new frm_Menu();
                home.MaTK = int.Parse(MaTK.ToString());
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập không thành công, hãy kiểm tra lại tên đăng nhập và mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = !txt_MatKhau.UseSystemPasswordChar;
            if (txt_MatKhau.UseSystemPasswordChar)
            {
                btn_eyeclose.Visible = false;
                btn_eyeopen.Visible = true;
            }
            else
            {
                btn_eyeclose.Visible = true;
                btn_eyeopen.Visible = false;
            }
        }

    }

}
