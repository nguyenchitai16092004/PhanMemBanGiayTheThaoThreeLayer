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
using System.Windows.Media;

namespace PhanMemQuanLyBanGiayTheThao
{
    public partial class frm_ThongKeDoanhThu : Form
    {
        public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        public frm_ThongKeDoanhThu()
        {
            InitializeComponent();
        }
        public int MaTK;
        private void ThongKe_Load(object sender, EventArgs e)
        {
            XemThongKe();
            cbb_TimKiem_Theo.Text = "Tìm kiếm theo :";
            cbb_DoanhThu.Text = "Tháng";
            TongDoanhThu();
        }
        public void XemThongKe()
        {
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT * FROM HOADON";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);

                myConnection.Close();
                dgv_ThongKeHoaDon.DataSource = dsSanPham.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi. Chi tiet: " + ex.Message);
            }
        }

        public void TimKiem()
        {
            string TimKiemTheo = "", TimKiemThongKe = "";
            if (cbb_TimKiem_Theo.Text == "Ngày")
            {
                TimKiemTheo = "NgayLap";
                TimKiemThongKe = dtp_Ngay.Value.ToString("yyyy/MM/dd");
            }
            else
            {
                TimKiemTheo = cbb_TimKiem_Theo.Text;
                TimKiemThongKe = txt_TimKiemThongKe.Text;
            }
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    string sSQL = "SELECT * FROM HOADON WHERE " + TimKiemTheo + " = @TimKiemThongKe";
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TimKiemThongKe", TimKiemThongKe);

                        SqlDataAdapter daSanPham = new SqlDataAdapter(cmd);
                        DataSet dsSanPham = new DataSet();
                        daSanPham.Fill(dsSanPham);

                        dgv_ThongKeHoaDon.DataSource = dsSanPham.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        public void TongDoanhThu()
        {
            int Nam = DateTime.Now.Year,
                ThongKeTheo = DateTime.Now.Month;
            string sSQL = "";

            if (cbb_DoanhThu.Text == "Tháng")
            {
                sSQL = "SELECT SUM(TongHD) AS TongHoaDon, COUNT(*) AS SoLuongHoaDon FROM HOADON WHERE YEAR(NgayLap) = @Nam AND MONTH(NgayLap) = @ThongKeTheo;";
            }
            else if (cbb_DoanhThu.Text == "Quỹ")
            {
                sSQL = "SELECT SUM(TongHD) AS TongHoaDon, COUNT(*) AS SoLuongHoaDon FROM HOADON WHERE NgayLap >= DATE_SUB(CURRENT_DATE(), INTERVAL 3 MONTH) AND NgayLap <= CURRENT_DATE();";
            }
            else
            {
                sSQL = "SELECT SUM(TongHD) AS TongHoaDon, COUNT(*) AS SoLuongHoaDon FROM HOADON WHERE YEAR(NgayLap) = @Nam;";
            }

            SqlConnection myConnection = new SqlConnection(scon);
            try
            {
                myConnection.Open();
                using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Nam", Nam.ToString());
                    cmd.Parameters.AddWithValue("@ThongKeTheo", ThongKeTheo.ToString());

                    SqlDataAdapter daSanPham = new SqlDataAdapter(cmd);
                    DataSet dsSanPham = new DataSet();
                    daSanPham.Fill(dsSanPham);

                    if (dsSanPham.Tables.Count > 0 && dsSanPham.Tables[0].Rows.Count > 0)
                    {
                        string tongDoanhThu = dsSanPham.Tables[0].Rows[0]["TongHoaDon"].ToString();
                        int soLuongHoaDon = Convert.ToInt32(dsSanPham.Tables[0].Rows[0]["SoLuongHoaDon"]);
                        txt_TongDoanhThuThongKe.Text = tongDoanhThu;
                        txt_SLHoaDon.Text = soLuongHoaDon.ToString();
                    }
                    else
                    {
                        txt_TongDoanhThuThongKe.Text = "Không có dữ liệu";
                        txt_SLHoaDon.Text = "0";
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi. Chi tiet: " + ex.Message);
            }
        }

        private void btn_QuayLaiThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu ql = new frm_Menu();
            ql.MaTK = MaTK;
            ql.Show();
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            XemThongKe();
            txt_TimKiemThongKe.Clear();
            cbb_TimKiem_Theo.Text = "Tìm kiếm theo :";
            dtp_Ngay.Visible = false;
        }
        private void btn_SearchThongKe_Click(object sender, EventArgs e)
        {
            if (cbb_TimKiem_Theo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_TimKiemThongKe.Text) && cbb_TimKiem_Theo.Text != "Ngày")
            {
                MessageBox.Show("Bạn chưa điền vào ô tìm kiếm hoặc bạn chọn chức năng tìm kiếm chưa phù hợp.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                TimKiem();
            }
        }
        private void Cbb_TimKiem_Theo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimKiem_Theo.Text == "Ngày")
            {
                dtp_Ngay.Visible = true;
            }
            else
            {
                dtp_Ngay.Visible=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ThongKeSanPham TKSP = new frm_ThongKeSanPham();
            TKSP.Show();
            this.Hide();
        }
        private void Cbb_DoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            TongDoanhThu();
        }

        private void btn_DangXuatTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_DangNhap dn = new frm_DangNhap();
            dn.Show();
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

        private void grb_HeaderThongKe_Enter(object sender, EventArgs e)
        {

        }

        private void txt_TimKiemThongKe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
