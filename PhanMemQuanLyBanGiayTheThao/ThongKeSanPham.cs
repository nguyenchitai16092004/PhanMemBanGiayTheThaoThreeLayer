using System;
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
    public partial class frm_ThongKeSanPham : Form
    {
        public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        public frm_ThongKeSanPham()
        {
            InitializeComponent();
        }
        public int MaTK;
        public void XemThongKe()
        {
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT  CHITIETHOADON.MaSP , SANPHAM.TenSP , COUNT(CHITIETHOADON.SoLuong) as 'Số Lượng sản phẩm bán được' ,SANPHAM.SoLuong as 'Số lượng còn lại' FROM SANPHAM INNER JOIN CHITIETHOADON ON SANPHAM.MaSP = CHITIETHOADON.MaSP GROUP BY CHITIETHOADON.MaSP,SANPHAM.TenSP, SANPHAM.SoLuong";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);

                myConnection.Close();
                dgv_ThongKeSanPhamBanRa.DataSource = dsSanPham.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi. Chi tiet: " + ex.Message);
            }
        }

        public void TimKiem()
        {
            string TimKiemTheo = cbo_TimKiem_Theo.Text,
                    TimKiemThongKe = txt_TimKiemThongKe.Text;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    string sSQL;
                    if (TimKiemTheo == "MaSP")
                    {
                        sSQL = "SELECT CHITIETHOADON.MaSP, SANPHAM.TenSP, COUNT(CHITIETHOADON.SoLuong) as 'Số Lượng sản phẩm bán được', SANPHAM.SoLuong as 'Số lượng còn lại' FROM SANPHAM INNER JOIN CHITIETHOADON ON SANPHAM.MaSP = CHITIETHOADON.MaSP WHERE CHITIETHOADON.MaSP = @TimKiem GROUP BY CHITIETHOADON.MaSP, SANPHAM.TenSP, SANPHAM.SoLuong";
                    }
                    else
                    {
                        sSQL = "SELECT CHITIETHOADON.MaSP, SANPHAM.TenSP, COUNT(CHITIETHOADON.SoLuong) as 'Số Lượng sản phẩm bán được', SANPHAM.SoLuong as 'Số lượng còn lại' FROM SANPHAM INNER JOIN CHITIETHOADON ON SANPHAM.MaSP = CHITIETHOADON.MaSP WHERE SANPHAM.TenSP like '%' + @TimKiem + '%' GROUP BY CHITIETHOADON.MaSP, SANPHAM.TenSP, SANPHAM.SoLuong";
                    }
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TimKiem", TimKiemThongKe.ToString());

                        SqlDataAdapter daSanPham = new SqlDataAdapter(cmd);
                        DataSet dsSanPham = new DataSet();
                        daSanPham.Fill(dsSanPham);
                        dgv_ThongKeSanPhamBanRa.DataSource = dsSanPham.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void ThongKeSanPham_Load(object sender, EventArgs e)
        {
            cbo_TimKiem_Theo.Text = "Tìm kiếm theo :";
            XemThongKe();
        }
        private void btn_SearchThongKe_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            frm_ThongKeDoanhThu tkdt = new frm_ThongKeDoanhThu();
            tkdt.Show();
            this.Hide();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu ql = new frm_Menu();
            ql.MaTK = MaTK;
            ql.Show();
            this.Close();
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

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            frm_DangNhap dn = new frm_DangNhap();
            dn.Show();
            this.Close();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            XemThongKe();
            txt_TimKiemThongKe.Clear();
            cbo_TimKiem_Theo.Text = "Tìm kiếm theo :";
        }
    }
}
