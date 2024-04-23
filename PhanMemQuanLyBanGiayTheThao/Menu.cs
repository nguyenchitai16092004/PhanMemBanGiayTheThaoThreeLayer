﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyBanGiayTheThao
{
    public partial class frm_Menu : Form
    {
        string Quyen;
        int MaTaiKhoan ;
        public string QuyenHang(int MaTK)
        {
            string quyen = null;
            string connectionString = "Data Source=SECRET-0327\\SQL_SEVER_01;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
            string query = "SELECT ThuocLoai FROM TAIKHOAN WHERE MaTK = @MaTK";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaTK", MaTK);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                quyen = reader["ThuocLoai"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log hoặc báo cáo lỗi
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return quyen;
        }

        //----------------------------------------------------------------------------------------------
        public frm_Menu()
        {
            InitializeComponent();
        }
        public int MaTK;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_TaiKhoanMenu_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {
                frm_TaiKhoan homeForm = new frm_TaiKhoan();
                homeForm.MaTK = MaTK;
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyên truy cập !!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btn_HoaDonBanHangMenu_Click(object sender, EventArgs e)
        {
            frm_HoaDonBanHang homeForm = new frm_HoaDonBanHang();
            homeForm.MaTK = MaTK;
            homeForm.Show();
            this.Hide();
        }

        private void btn_KhachHangMenu_Click(object sender, EventArgs e)
        {
            frm_KhachHang homeForm = new frm_KhachHang();
            homeForm.MaTK = MaTK;
            homeForm.Show();
            this.Hide();
        }

        private void btn_NhaCungCapMenu_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {
                frm_NhaCungCap homeForm = new frm_NhaCungCap();
                homeForm.MaTK = MaTK;
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyên truy cập !!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void btn_SanPhamMenu_Click(object sender, EventArgs e)
        {

            if (Quyen == "Admin")
            {
                frm_SanPham homeForm = new frm_SanPham();
                homeForm.MaTK = MaTK;
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyên truy cập !!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btn_ThongKeMenu_Click(object sender, EventArgs e)
        {
            frm_ThongKeDoanhThu homeForm = new frm_ThongKeDoanhThu();
            homeForm.MaTK = MaTK;
            homeForm.Show();
            this.Hide();
        }

        private void btn_NhanVienMenu_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {
                frm_NhanVien homeForm = new frm_NhanVien();
                homeForm.MaTK = MaTK;
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyên truy cập !!!", "Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
        }

        private void btn_DangXuatMenu_Click(object sender, EventArgs e)
        {
            frm_DangNhap homeForm = new frm_DangNhap();
            homeForm.Show();
            this.Hide();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            MaTaiKhoan = MaTK;
            MessageBox.Show(MaTaiKhoan.ToString());
            Quyen = QuyenHang(MaTaiKhoan);
            
        }

        private void btn_ThoatMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
