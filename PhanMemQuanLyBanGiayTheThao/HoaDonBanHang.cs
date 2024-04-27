using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyBanGiayTheThao
{
    public partial class frm_HoaDonBanHang : Form
    {
        public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        int TienKhachDua;
        public int MaTK;
        public frm_HoaDonBanHang()
        {
            InitializeComponent();
        }
        public void XemHoaDon()
        {
            //khai báo chuoi ket noi CSDL
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT * FROM HOADON";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);

                myConnection.Close();
                dgv_HoaDonBanHang.DataSource = dsSanPham.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi. Chi tiet: " + ex.Message);
            }
        }

        //

        public void ThemHoaDon()
        {
            // Khai báo chuỗi kết nối CSDL
            string sSQL = "INSERT INTO HOADON (MaNV, MaKH, NgayLap, TienKhachDua, TienGuiLai, TongHD) VALUES (@MaNV, @MaKH, @NgayLap, @TienKhachDua, @TienGuiLai, @TongHD)";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);
                        cmd.Parameters.AddWithValue("@MaNV", cbo_MaNV.Text);
                        cmd.Parameters.AddWithValue("@NgayLap", dtp_NgayLapHoaDonBanHang.Value.ToString("yyyy/MM/dd"));
                        cmd.Parameters.AddWithValue("@TienKhachDua", DBNull.Value);
                        cmd.Parameters.AddWithValue("@TienGuiLai", DBNull.Value);
                        cmd.Parameters.AddWithValue("@TongHD", DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }


        //

        public void SuaHoaDon()
        {
            // Khởi tạo kết nối
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                // Chuỗi truy vấn cập nhật
                string sSQL = "UPDATE HOADON SET MaNV = @MaNV, MaKH = @MaKH ,NgayLap = @NgayLap WHERE MaHD = @MaHD";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", int.Parse(txt_MaHoaDon.Text));
                        cmd.Parameters.AddWithValue("@MaNV", int.Parse(cbo_MaNV.Text));
                        cmd.Parameters.AddWithValue("@MaKH", int.Parse(txt_MaKH.Text));
                        cmd.Parameters.AddWithValue("@NgayLap", DateTime.Parse(dtp_NgayLapHoaDonBanHang.Text));
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            frm_ChiTietHoaDon chiTietHoaDon = new frm_ChiTietHoaDon();
                            this.Hide();
                            chiTietHoaDon.MaHD = int.Parse(txt_MaHoaDon.Text);
                            chiTietHoaDon.TienKhachDua = TienKhachDua;
                            chiTietHoaDon.MaTK = MaTK;
                            chiTietHoaDon.Show();
                        }
                        else
                        {
                            MessageBox.Show("Không có sản phẩm nào được cập nhật.", "Thông báo");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn chưa chọn hóa đơn ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        //

        public void XoaHoaDon()
        {
            string maHoaDon = txt_MaHoaDon.Text;
            // Mở kết nối
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                myConnection.Open();

                // Bắt đầu một giao dịch để đảm bảo tính nhất quán giữa các thao tác
                SqlTransaction transaction = myConnection.BeginTransaction();

                try
                {
                    // Xóa chi tiết hóa đơn trong bảng CHITIETHOADON
                    string sSQLChiTietHoaDon = "DELETE FROM CHITIETHOADON WHERE MaHD = @MaHD";
                    SqlCommand cmdChiTietHoaDon = new SqlCommand(sSQLChiTietHoaDon, myConnection, transaction);
                    cmdChiTietHoaDon.Parameters.AddWithValue("@MaHD", maHoaDon);
                    cmdChiTietHoaDon.ExecuteNonQuery();         

                    // Xóa hóa đơn trong bảng HOADON
                    string sSQLHoaDon = "DELETE FROM HOADON WHERE MaHD = @MaHD";
                    SqlCommand cmdHoaDon = new SqlCommand(sSQLHoaDon, myConnection, transaction);
                    cmdHoaDon.Parameters.AddWithValue("@MaHD", maHoaDon);
                    cmdHoaDon.ExecuteNonQuery();


                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
                }
            }
        }

        //

        public void HienThiMaNhanVien()
        {
            //Doi tuong ket noi CSDL
            SqlConnection myConnection = new SqlConnection(scon);
            string sSql;
            sSql = "SELECT MaNV, TenNV FROM NHANVIEN";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sSql, myConnection);
                //DataSet: du lieu tren bo nho RAM
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                cbo_MaNV.DataSource = ds.Tables[0];
                cbo_MaNV.DisplayMember = "MaNV";
                cbo_MaNV.ValueMember = "TenNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI. Chi tiet: " + ex.Message);
            }
        }

        //

        public int LayMaHDLonNhat()
        {
            int maxMaHD = 0; // Khởi tạo giá trị mặc định cho trường hợp không có dữ liệu
            string sSQL = "SELECT MAX(MaHD) AS MaxMaHD FROM HOADON";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            maxMaHD = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }

            return maxMaHD;
        }
        public int LayMaHD()
        {
            int MaHD = 0;
            string sSQL = "SELECT MAX(MaHD) AS MaxMaHD FROM HOADON";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        object result = cmd.ExecuteScalar();
                        MaHD = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }

            return MaHD;
        }

        //-------------------------------------------------------------------------------------------------------------------
        private void btn_KHHoaDonBanHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang kh = new frm_KhachHang();
            kh.Show();
            this.Hide();
        }

        private void lb_QuayLaiBanHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu ql = new frm_Menu();
            ql.MaTK = MaTK;
            ql.Show();
        }

        private void btn_DangXuatHoaDonBanHang_Click(object sender, EventArgs e)
        {

            frm_Menu mn = new frm_Menu();
            mn.Show();
            this.Hide();
        }

        private void dgv_HoaDonBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_HoaDonBanHang.CurrentRow.Index;
            txt_MaHoaDon.Text = dgv_HoaDonBanHang.Rows[i].Cells[0].Value.ToString();
            cbo_MaNV.Text = dgv_HoaDonBanHang.Rows[i].Cells[1].Value.ToString();
            txt_MaKH.Text = dgv_HoaDonBanHang.Rows[i].Cells[2].Value.ToString();
            dtp_NgayLapHoaDonBanHang.Value = DateTime.Parse(dgv_HoaDonBanHang.Rows[i].Cells[3].Value.ToString());
            TienKhachDua = int.Parse(dgv_HoaDonBanHang.Rows[i].Cells[4].Value.ToString());
        }

        private void btn_XoaHoaDonBanHang_Click(object sender, EventArgs e)
        {
            if (txt_MaHoaDon.Text != "")
            {
                XoaHoaDon();
                XemHoaDon();
                txt_MaHoaDon.Clear();
                txt_MaKH.Clear();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào !!!");
            }
        }

        private void btn_SuaHoaDonBanHang_Click(object sender, EventArgs e)
        {
            SuaHoaDon();
        }
        
        private void btn_TinhTienHoaDonBanHang_Click(object sender, EventArgs e)
        {
            //int soluong = int.Parse(txt_SoLuong.Text);
            //int dongia = int.Parse(cbo_DonGia.Text);
            //int tienkhachdua = int.Parse(txt_TienKhachDuaHoaDonBanHang.Text);
            //if (tienkhachdua == 0)
            //{
            //    MessageBox.Show("Bạn chưa nhập tiền khách đưa!!", "THÔNG BÁO");
            //}
            //else
            //{
            //    int khuyenmai = 0;
            //    string khuyenmaiText = txt_KhuyenMai.Text.Trim();
            //    if (khuyenmaiText == "CTKMKT")
            //    {
            //        khuyenmai = 1;
            //    }

            //    int tmp;

            //    if (khuyenmai == 1)
            //    {
            //        tmp = (int)(soluong * dongia * 0.9); // giảm 10% là giá trị sản phẩm còn 90%
            //    }
            //    else
            //    {
            //        tmp = soluong * dongia;
            //    }

            //    int tonghoadon = tmp;
            //    if (tienkhachdua < tonghoadon)
            //    {
            //        MessageBox.Show("Tiền khách đưa phải lớn hơn hoặc bằng Tổng hóa đơn", "THÔNG BÁO");
            //    }
            //    else
            //    {
            //        int tienguilai = tienkhachdua - tonghoadon;
            //        txt_TongHoaDonHoaDonBanHang.Text = tonghoadon.ToString();
            //        txt_TienGuiKhachHoaDonBanHang.Text = tienguilai.ToString();
            //    }
            //}
        }
        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            XemHoaDon();
            HienThiMaNhanVien();
            cbb_TimKiem_Theo.Text = "Tìm kiếm theo :";
            dtp_Ngay.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ChiTietHoaDon chiTietHoaDon = new frm_ChiTietHoaDon();
            ThemHoaDon();
            this.Hide();
            chiTietHoaDon.Show();
            chiTietHoaDon.MaHD = LayMaHD();            
        }
        private void btn_XemDanhSachHoaDon_Click(object sender, EventArgs e)
        {

            frm_ChiTietHoaDon chiTietHoaDon = new frm_ChiTietHoaDon();
            chiTietHoaDon.MaHD = int.Parse(txt_MaHoaDon.Text);
            this.Hide();
            chiTietHoaDon.Show();
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
                TimKiemThongKe = txt_TimKiemHoaDonBanHang.Text;
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

                        dgv_HoaDonBanHang.DataSource = dsSanPham.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            XemHoaDon();
            HienThiMaNhanVien();
            txt_TimKiemHoaDonBanHang.Clear();
            cbb_TimKiem_Theo.Text = "Tìm kiếm theo :";
            dtp_Ngay.Visible = false;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbb_TimKiem_Theo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_TimKiemHoaDonBanHang.Text))
            {
                MessageBox.Show("Bạn chưa điền vào ô tìm kiếm hoặc bạn chọn chức năng tìm kiếm chưa phù hợp.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                TimKiem();
            }

        }
        private void Cbb_TimKiem_Theo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbb_TimKiem_Theo.Text == "Ngày")
            {
                dtp_Ngay.Visible = true;
            }
            else
            {
                dtp_Ngay.Visible = false;
            }
        }

        private void btn_DoiMatKhauNhanVien_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau dmk = new frm_DoiMatKhau();
            dmk.Show();
            dmk.MaTK = MaTK;
            this.Hide();
        }
    }
}
