using FontAwesome.Sharp;
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
        public string scon = "Data Source=SECRET-0327\\SQL_SEVER_01;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        int TienKhachDua;
        public int MaTK;
        public frm_HoaDonBanHang()
        {
            InitializeComponent();
        }
        public void XemHoaDon()
        {
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT NHANVIEN.MaNV , NHANVIEN.TenNV AS 'Nhân viên lập hóa đơn', HOADON.MaHD, HOADON.MaKH, HOADON.NgayLap, HOADON.TienKhachDua, HOADON.TienGuiLai, HOADON.TongHD " +
                       "FROM HOADON INNER JOIN NHANVIEN ON NHANVIEN.MaNV = HOADON.MaNV;";
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
            dgv_HoaDonBanHang.ClearSelection();
        }

        //

        public void ThemHoaDon()
        {
            // Khai báo chuỗi kết nối CSDL
            dtp_NgayLapHoaDonBanHang.Value = DateTime.Now;
            string sSQL = "INSERT INTO HOADON (MaNV, MaKH, NgayLap, TienKhachDua, TienGuiLai, TongHD) VALUES (@MaNV, @MaKH, @NgayLap, @TienKhachDua, @TienGuiLai, @TongHD)";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);
                        cmd.Parameters.AddWithValue("@MaNV", cbo_TenNV.SelectedValue.ToString());
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
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                string sSQL = "UPDATE HOADON SET MaNV = @MaNV, MaKH = @MaKH ,NgayLap = @NgayLap WHERE MaHD = @MaHD";

                try
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", int.Parse(txt_MaHoaDon.Text));
                        cmd.Parameters.AddWithValue("@MaNV", int.Parse(txt_MaNV.Text));
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
                    MessageBox.Show("Bạn chưa chọn hóa đơn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //

        public void XoaHoaDon()
        {
            string maHoaDon = txt_MaHoaDon.Text;
            bool success = true;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();

                    // Xóa chi tiết hóa đơn
                    string sSQLChiTietHoaDon = "DELETE FROM CHITIETHOADON WHERE MaHD = @MaHD";
                    using (SqlCommand cmdChiTietHoaDon = new SqlCommand(sSQLChiTietHoaDon, myConnection))
                    {
                        cmdChiTietHoaDon.Parameters.AddWithValue("@MaHD", maHoaDon);
                        int rowsAffected = cmdChiTietHoaDon.ExecuteNonQuery();

                        // Kiểm tra nếu không có hàng nào bị xóa
                        if (rowsAffected == 0)
                        {
                            success = false;
                            MessageBox.Show("Không tìm thấy hóa đơn để xóa.", "Thông báo");
                        }
                    }

                    if (success)
                    {
                        // Xóa hóa đơn
                        string sSQLHoaDon = "DELETE FROM HOADON WHERE MaHD = @MaHD";
                        using (SqlCommand cmdHoaDon = new SqlCommand(sSQLHoaDon, myConnection))
                        {
                            cmdHoaDon.Parameters.AddWithValue("@MaHD", maHoaDon);
                            cmdHoaDon.ExecuteNonQuery();

                            MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                success = false;
                MessageBox.Show("Lỗi khi xóa hóa đơn. Chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HienThiMaNhanVien(int MaTK)
        {
            SqlConnection myConnection = new SqlConnection(scon);
            string sSql;
            sSql = "SELECT MaNV, TenNV FROM NHANVIEN WHERE MaTK = @MaTK";
            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(sSql, myConnection);
                cmd.Parameters.AddWithValue("@MaTK", MaTK);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet: du lieu tren bo nho RAM
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                cbo_TenNV.DataSource = ds.Tables[0];
                cbo_TenNV.DisplayMember = "TenNV";
                cbo_TenNV.ValueMember = "MaNV";
                txt_MaNV.Text = ds.Tables[0].Rows[0]["MaNV"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI. Chi tiet: " + ex.Message);
            }
        }

        //

        public void HienThiTenNhanVien()
        {
            SqlConnection myConnection = new SqlConnection(scon);
            string sSql;
            sSql = "SELECT MaNV, TenNV FROM NHANVIEN";
            try
            {
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(sSql, myConnection);
                cmd.Parameters.AddWithValue("@MaTK", MaTK);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet: du lieu tren bo nho RAM
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                cbo_TenNhanVien.DataSource = ds.Tables[0];
                cbo_TenNhanVien.DisplayMember = "TenNV";
                cbo_TenNhanVien.ValueMember = "MaNV";
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
            
        }

        private void btn_DangXuatHoaDonBanHang_Click(object sender, EventArgs e)
        {
            frm_DangNhap mn = new frm_DangNhap();
            mn.Show();
            this.Hide();
        }

        private void dgv_HoaDonBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_HoaDonBanHang.CurrentRow.Index;
            txt_MaNV.Text = dgv_HoaDonBanHang.Rows[i].Cells[0].Value.ToString();
            txt_MaHoaDon.Text = dgv_HoaDonBanHang.Rows[i].Cells[2].Value.ToString();
            cbo_TenNV.Text = dgv_HoaDonBanHang.Rows[i].Cells[1].Value.ToString();
            txt_MaKH.Text = dgv_HoaDonBanHang.Rows[i].Cells[3].Value.ToString();
            dtp_NgayLapHoaDonBanHang.Value = DateTime.Parse(dgv_HoaDonBanHang.Rows[i].Cells[4].Value.ToString());

        }


        private void btn_XoaHoaDonBanHang_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDonBanHang.SelectedCells.Count>0)
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
        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            XemHoaDon();
            HienThiMaNhanVien(MaTK);
            HienThiTenNhanVien();
            cbo_TimKiem_Theo.Text = "Tìm kiếm theo :";
            dtp_Ngay.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ChiTietHoaDon chiTietHoaDon = new frm_ChiTietHoaDon();
            chiTietHoaDon.MaTK = MaTK;
            ThemHoaDon();
            this.Hide();
            chiTietHoaDon.Show();
            chiTietHoaDon.MaHD = LayMaHD();
        }
        private void btn_XemDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDonBanHang.SelectedCells.Count > 0)
            {
                frm_ChiTietHoaDon chiTietHoaDon = new frm_ChiTietHoaDon();
                chiTietHoaDon.MaTK = MaTK;
                chiTietHoaDon.MaHD = int.Parse(txt_MaHoaDon.Text);
                this.Hide();
                chiTietHoaDon.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn bạn cần xem");
            }

        }
        public void TimKiem()
        {
            string TimKiemTheo = "", TimKiemThongKe = "";
            if (cbo_TimKiem_Theo.Text == "Ngày")
            {
                TimKiemTheo = "NgayLap";
                TimKiemThongKe = dtp_Ngay.Value.ToString("yyyy/MM/dd");
            }
            else if(cbo_TimKiem_Theo.Text == "Tên Nhân viên")
            {
                TimKiemTheo = "MaNV";
                TimKiemThongKe = cbo_TenNhanVien.SelectedValue.ToString();
            }
            else
            {
                TimKiemTheo = cbo_TimKiem_Theo.Text;
                TimKiemThongKe = txt_TimKiemHoaDonBanHang.Text;
            }
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    string sSQL = "SELECT NHANVIEN.MaNV, NHANVIEN.TenNV AS 'Nhân viên lập hóa đơn', HOADON.MaHD, HOADON.MaKH, HOADON.NgayLap, HOADON.TienKhachDua, HOADON.TienGuiLai, HOADON.TongHD " +
                                  "FROM HOADON INNER JOIN NHANVIEN ON NHANVIEN.MaNV = HOADON.MaNV " +
                                  "WHERE HOADON." + TimKiemTheo + " = @TimKiemThongKe";

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
            txt_MaHoaDon.Clear();
            txt_MaNV.Clear();
            txt_TimKiemHoaDonBanHang.Clear();
            cbo_TimKiem_Theo.Text = "Tìm kiếm theo :";
            dtp_Ngay.Visible = false;
            cbo_TenNhanVien.SelectedIndex = -1;
            txt_MaKH.Clear();
            dtp_NgayLapHoaDonBanHang.Value = DateTime.Now;
            HienThiMaNhanVien(MaTK);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbo_TimKiem_Theo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_TimKiemHoaDonBanHang.Text) && cbo_TimKiem_Theo.Text != "Ngày" && cbo_TimKiem_Theo.Text != "Tên Nhân viên")
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
            if (cbo_TimKiem_Theo.Text == "Ngày")
            {
                dtp_Ngay.Visible = true;
                cbo_TenNhanVien.Visible = false;
            }
            else if(cbo_TimKiem_Theo.Text == "Tên Nhân viên")
            {
                cbo_TenNhanVien.Visible = true;
                dtp_Ngay.Visible = false;
            }
            else
            {
                cbo_TenNhanVien.Visible = false;
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
        private void frm_HoaDonBanHang_FormClosing_1(object sender, FormClosingEventArgs e)
        {

            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
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

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            frm_ChiTietHoaDon chiTietHoaDon = new frm_ChiTietHoaDon();
            chiTietHoaDon.MaTK = MaTK;
            ThemHoaDon();
            this.Hide();
            chiTietHoaDon.Show();
            chiTietHoaDon.MaHD = LayMaHD();
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            frm_DangNhap dn = new frm_DangNhap();
            dn.Show();
            this.Close();
        }
    }
}


