﻿using System;
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

namespace PhanMemQuanLyBanGiayTheThao
{
    public partial class frm_DangNhap : Form
    {
        int count = 0;
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
                home.MaTK= int.Parse(MaTK.ToString());
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập không thành công, hãy kiểm tra lại tên đăng nhập và mật khẩu !","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

                if ((count % 2) == 0)
                {
                    txt_MatKhau.PasswordChar = '\0';
                    btn_eyeopen.Visible = true;
                    btn_eyeclose.Visible = false;
                }
                else
                {
                    txt_MatKhau.PasswordChar = '*';
                    btn_eyeclose.Visible = true;
                    btn_eyeopen.Visible = false;
                }
                count += 1;
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

}
