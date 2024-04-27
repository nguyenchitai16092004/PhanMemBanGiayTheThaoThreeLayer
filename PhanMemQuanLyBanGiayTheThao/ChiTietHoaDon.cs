using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyBanGiayTheThao
{
    public partial class frm_ChiTietHoaDon : Form
    {
        public string scon = "Data Source=SECRET-0327\\SQL_SEVER_01;Initial Catalog=SHOPBANGIAY;Integrated Security=True";

        public void XemChiTietHoaDon(int MaHD)
        {
            // Khai báo chuỗi kết nối CSDL
            string sSQL = "SELECT CHITIETHOADON.MaHD, SANPHAM.MaSP, SANPHAM.TenSP, SANPHAM.GiaBan, SANPHAM.KhuyenMai, CHITIETHOADON.SoLuong, CHITIETHOADON.ThanhTien, SANPHAM.Anh FROM SANPHAM INNER JOIN CHITIETHOADON ON SANPHAM.MaSP = CHITIETHOADON.MaSP WHERE CHITIETHOADON.MaHD = @MaHD";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);

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

        //

        public void HienThiMaSanPham()
        {

            //Doi tuong ket noi CSDL
            SqlConnection myConnection = new SqlConnection(scon);
            string sSql;
            sSql = "SELECT MaSP, TenSP, GiaBan FROM SANPHAM";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sSql, myConnection);
                //DataSet: du lieu tren bo nho RAM
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();

                //cbo_MaSP
                cbo_MaSP.DataSource = ds.Tables[0];
                cbo_MaSP.DisplayMember = "MaSP";
                cbo_MaSP.ValueMember = "TenSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI. Chi tiet: " + ex.Message);
            }
        }

        //

        public void XuatThongTinSP()
        {
            String MaSP = cbo_MaSP.Text;
            string sSQL = "SELECT TenSP, GiaBan, KhuyenMai " +
                          "FROM SANPHAM " +
                          "WHERE MaSP = @MaSP";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", MaSP);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_TenSP.Text = reader["TenSP"].ToString();
                                txt_DonGia.Text = reader["GiaBan"].ToString();
                                txt_KhuyenMai.Text = reader["KhuyenMai"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //
            }
        }

        //

        public void TongHD()
        {
            string MaSP = cbo_MaSP.Text;
            string sSQL = "SELECT SUM(ThanhTien) as 'Tổng tiền' " +
                          "FROM CHITIETHOADON INNER JOIN HOADON on CHITIETHOADON.MaHD = HOADON.MaHD " +
                          "WHERE HOADON.MaHD = @MaHD " +
                          "GROUP BY CHITIETHOADON.MaHD";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_TongTien.Text = reader["Tổng tiền"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        //

        public void ThemChiTietHoaDon(int MaHD)
        {
            int SoLuong = int.Parse(nud_SoLuong.Value.ToString());
            int DonGia = int.Parse(txt_DonGia.Text);
            int ThanhTien = SoLuong * DonGia;
            txt_ThanhTien.Text = ThanhTien.ToString();
            string sSQL = "INSERT INTO CHITIETHOADON (MaHD,MaSP,SoLuong,ThanhTien) VALUES (@MaHD,@MaSP,@SoLuong,@ThanhTien)";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);
                        cmd.Parameters.AddWithValue("@MaSP", cbo_MaSP.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", nud_SoLuong.Value);
                        cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        //

        public void XoaSP(int MaHD)
        {
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                myConnection.Open();
                string sSQL = "DELETE CHITIETHOADON WHERE MaHD = @MaHD and MaSP = @MaSP";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);
                        cmd.Parameters.AddWithValue("@MaSP", int.Parse(cbo_MaSP.Text));
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Xóa sản Phẩm thành công!", "Thông báo");
                        else
                            MessageBox.Show("Ko có sản phẩm để xóa !", "Thông báo");

                    }
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
                }
            }
        }

        //
        public void SuaSP(int MaHD)
        {
            // Khai báo chuỗi kết nối CSDL
            string sSQL = "UPDATE CHITIETHOADON SET SoLuong = @SoLuong WHERE MaHD = @MaHD AND MaSP = @MaSP";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);
                        cmd.Parameters.AddWithValue("@MaSP", cbo_MaSP.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", nud_SoLuong.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cập nhật thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        //
        public void HoanThienHoaDon(int MaHD)
        {
            // Khai báo chuỗi kết nối CSDL
            string sSQL = "UPDATE HOADON SET TienKhachDua = @TienKhachDua , TienGuiLai = @TienGuiLai , TongHD = @TongHD WHERE MaHD = @MaHD";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);
                        cmd.Parameters.AddWithValue("@TienKhachDua", txt_TienKhachDua.Text);
                        cmd.Parameters.AddWithValue("@TienGuiLai", txt_TienGuiKhach.Text);
                        cmd.Parameters.AddWithValue("@TongHD", txt_TongTien.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        public frm_ChiTietHoaDon()
        {
            InitializeComponent();
        }

        public int MaHD;
        public int MaTK;
        public int TienKhachDua;
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            txt_TienKhachDua.Text = TienKhachDua.ToString();
            XemChiTietHoaDon(MaHD);
            HienThiMaSanPham();
            TongHD();
            DataGridViewImageColumn avatar_column = (DataGridViewImageColumn)dgv_HoaDonBanHang.Columns[7];
            avatar_column.Width = 60;
            avatar_column.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void cbo_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            XuatThongTinSP();

        }

        private void nud_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            int Gia = int.Parse(txt_DonGia.Text);
            int Soluong = (int)nud_SoLuong.Value;
            int ThanhTien = Soluong * Gia;
            txt_ThanhTien.Text = ThanhTien.ToString();
            TongHD();
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {


            ThemChiTietHoaDon(MaHD);
            XemChiTietHoaDon(MaHD);
            TongHD();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            double tienKhachDua = double.Parse(txt_TienKhachDua.Text);
            double TongTien = Double.Parse(txt_TongTien.Text);
            double tienGuiKhach = tienKhachDua - TongTien;

            txt_TienGuiKhach.Text = tienGuiKhach.ToString();

            HoanThienHoaDon(MaHD);
            frm_HoaDonBanHang hoaDonBanHang = new frm_HoaDonBanHang();
            hoaDonBanHang.ShowDialog();
            this.Close();
        }

        private void btn_SuaHoaDonBanHang_Click(object sender, EventArgs e)
        {
            SuaSP(MaHD);
            XemChiTietHoaDon(MaHD);
        }

        private void dgv_HoaDonBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgv_HoaDonBanHang.Rows[rowIndex];
            if (selectedRow != null)
            {
                int i = dgv_HoaDonBanHang.CurrentRow.Index;
                cbo_MaSP.Text = dgv_HoaDonBanHang.Rows[i].Cells[1].Value.ToString();
                txt_TenSP.Text = dgv_HoaDonBanHang.Rows[i].Cells[2].Value.ToString();
                txt_DonGia.Text = dgv_HoaDonBanHang.Rows[i].Cells[3].Value.ToString();
                txt_KhuyenMai.Text = dgv_HoaDonBanHang.Rows[i].Cells[4].Value.ToString();
                nud_SoLuong.Value = Convert.ToInt32(dgv_HoaDonBanHang.Rows[i].Cells[5].Value);
                txt_ThanhTien.Text = dgv_HoaDonBanHang.Rows[i].Cells[6].Value.ToString();
                // Kiểm tra nếu cột "Anh" có dữ liệu
                if (selectedRow.Cells[7].Value != DBNull.Value)
                {
                    // Lấy dữ liệu dạng byte[] từ cột "Anh"
                    byte[] imageData = (byte[])selectedRow.Cells[7].Value;
                    // Chuyển đổi dữ liệu byte[] thành hình ảnh
                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pic_ImageSP.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Nếu không có hình ảnh, đặt hình ảnh mặc định hoặc xóa hình cũ
                        pic_ImageSP.Image = null;
                    }
                }
            }
        }


            private void btn_XoaHoaDonBanHang_Click(object sender, EventArgs e)
        {
            XoaSP(MaHD);
            XemChiTietHoaDon(MaHD);
        }

        private void dgv_HoaDonBanHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_HoaDonBanHang.Rows[e.RowIndex].Height = 80;

        }

        private void btn_QuayLaiBanHang_Click(object sender, EventArgs e)
        {
            frm_HoaDonBanHang ql = new frm_HoaDonBanHang();
            ql.MaTK = MaTK;
            ql.Show();
            this.Hide();
        }

        private void txt_KhuyenMai_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
