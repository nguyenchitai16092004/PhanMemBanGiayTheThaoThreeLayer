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
        public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";

        private bool isThemTaoChiTietHoaDonClicked = false;
        private bool isHoanTatClicked = false;


        public bool KiemTraSoLuongSanPham()
        {
            int soluongmuahang = (int)nud_SoLuong.Value;
            SqlConnection myConnection = new SqlConnection(scon);
            try
            {
                myConnection.Open();

                // Lấy số lượng hiện tại của sản phẩm từ CSDL
                string sSQL = "SELECT SoLuong FROM SANPHAM WHERE MaSP = @MaSP";
                SqlCommand command = new SqlCommand(sSQL, myConnection);
                command.Parameters.AddWithValue("@MaSP", int.Parse(cbo_MaSP.Text));
                int soluongdb = (int)command.ExecuteScalar();

                // Tính số lượng còn lại sau khi mua
                int soluongtravedb = soluongdb - soluongmuahang;

                if (soluongtravedb < 0)
                {
                    MessageBox.Show("Hiện số lượng không đủ để bán, hãy thử giảm số lượng mua hoặc quay lại lần sau nhé!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    return false; // Trả về false nếu số lượng không đủ
                }
                else
                {
                    // Cập nhật số lượng sản phẩm
                    string updateSQL = "UPDATE SANPHAM SET SoLuong = @SoLuongTraVedb WHERE MaSP = @MaSP";
                    SqlCommand updateCommand = new SqlCommand(updateSQL, myConnection);
                    updateCommand.Parameters.AddWithValue("@SoLuongTraVedb", soluongtravedb);
                    updateCommand.Parameters.AddWithValue("@MaSP", int.Parse(cbo_MaSP.Text));
                    updateCommand.ExecuteNonQuery();

                    return true; // Trả về true nếu cập nhật thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
                return false; // Trả về false nếu có lỗi
            }
            finally
            {
                myConnection.Close(); // Đảm bảo kết nối được đóng lại
            }
        }

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
            string sSQL = "SELECT TenSP, GiaBan, KhuyenMai, Anh " +
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
                                if (reader["Anh"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["Anh"];

                                    if (imageData.Length > 0)
                                    {
                                        using (MemoryStream ms = new MemoryStream(imageData))
                                        {
                                            pic_ImageSP.Image = Image.FromStream(ms);
                                        }
                                    }
                                    else
                                    {
                                        pic_ImageSP.Image = null;
                                    }
                                }
                                else
                                {
                                    pic_ImageSP.Image = null;
                                }
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
            int KhuyenMai = int.Parse(txt_KhuyenMai.Text);
            double ThanhTien = (SoLuong * DonGia) * ((100.0 - KhuyenMai) / 100.0);
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
            int KhuyenMai = int.Parse(txt_KhuyenMai.Text);
            int Gia = int.Parse(txt_DonGia.Text);
            int Soluong = (int)nud_SoLuong.Value;
            double ThanhTien = (Soluong * Gia) * ((100.0 - KhuyenMai) / 100);
            txt_ThanhTien.Text = ThanhTien.ToString();

            TongHD();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            isHoanTatClicked = true;
            // Kiểm tra xem giá trị nhập vào có rỗng hoặc trống không
            string tienKhachDuaText = txt_TienKhachDua.Text.Trim();
            if (string.IsNullOrEmpty(tienKhachDuaText))
            {
                MessageBox.Show("Hãy nhập số tiền mà khách đã đưa cho bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double tienKhachDua;
            try
            {
                // Chuyển đổi giá trị sang kiểu số
                tienKhachDua = double.Parse(tienKhachDuaText);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ. Hãy nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tienKhachDua <= 0)
            {
                MessageBox.Show("Số tiền của khách đưa không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double TongTien;
            try
            {
                TongTien = double.Parse(txt_TongTien.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tổng tiền không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double tienGuiKhach = tienKhachDua - TongTien;
            if (tienGuiKhach < 0)
            {
                MessageBox.Show("Số tiền đưa không đủ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_TienGuiKhach.Text = tienGuiKhach.ToString();
                HoanThienHoaDon(MaHD);
                frm_HoaDonBanHang hoaDonBanHang = new frm_HoaDonBanHang();
                hoaDonBanHang.MaTK = MaTK;
                hoaDonBanHang.Show();
                this.Hide();
            }

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

        private void frm_ChiTietHoaDon_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_ThemTaoChiTietHoaDon_Click_1(object sender, EventArgs e)
        {
            isThemTaoChiTietHoaDonClicked = true;
            int KhuyenMai = int.Parse(txt_KhuyenMai.Text);
            int SoLuong = (int)nud_SoLuong.Value;

            if (SoLuong == 0)
            {
                MessageBox.Show("Hãy chọn số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi hàm nếu không có số lượng
            }

            if (KhuyenMai > 0)
            {
                MessageBox.Show("Sản phẩm hiện đang được khuyên mãi: " + KhuyenMai + "%", "Bạn có biết?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Kiểm tra số lượng sản phẩm trước khi thực hiện các thao tác khác
            bool soLuongDu = KiemTraSoLuongSanPham();
            if (soLuongDu)
            {
                // Chỉ thực hiện nếu số lượng đủ
                ThemChiTietHoaDon(MaHD);
                XemChiTietHoaDon(MaHD);
                TongHD();
            }
        }

        private void pic_ImageSP_Click(object sender, EventArgs e)
        {

        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            if (!isThemTaoChiTietHoaDonClicked || !isHoanTatClicked)
            {
                MessageBox.Show("Hóa đơn chưa được hoàn thành, hãy hoàn thành hóa đơn trước khi trở về trang trước!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nud_SoLuong.Value < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số lượng lớn hơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool tmp = ChekcOut();
            if (tmp == true)
            {
                frm_HoaDonBanHang ql = new frm_HoaDonBanHang();
                ql.MaTK = MaTK;
                ql.Show();
                this.Close();
            }
        }


        private void grb_Menu_Enter(object sender, EventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            if (!isThemTaoChiTietHoaDonClicked || !isHoanTatClicked)
            {
                MessageBox.Show("Hóa đơn chưa được hoàn thành, hãy hoàn thành hóa đơn trước khi đăng xuất!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nud_SoLuong.Value < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số lượng lớn hơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool tmp = ChekcOut();
            if (tmp == true)
            {
                frm_DangNhap dn = new frm_DangNhap();
                dn.Show();
                this.Close();
            }
           
        }

        public bool ChekcOut()
        {
            // Kiểm tra xem giá trị nhập vào có rỗng hoặc trống không
            string tienKhachDuaText = txt_TienKhachDua.Text.Trim();
            if (string.IsNullOrEmpty(tienKhachDuaText))
            {
                MessageBox.Show("Hãy nhập số tiền mà khách đã đưa cho bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            double tienKhachDua;
            try
            {
                // Chuyển đổi giá trị sang kiểu số
                tienKhachDua = double.Parse(tienKhachDuaText);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ. Hãy nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tienKhachDua <= 0)
            {
                MessageBox.Show("Số tiền của khách đưa không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double TongTien;
            try
            {
                TongTien = double.Parse(txt_TongTien.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tổng tiền không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
