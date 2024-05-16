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
    public partial class frm_NhanVien : Form
    {
        public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        public int MaTK;

        public void XemDanhSachNhanVien()
        {
            //khai báo chuoi ket noi CSDL
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT* FROM NHANVIEN;";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);

                myConnection.Close();
                dgv_NhanVien.DataSource = dsSanPham.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi. Chi tiet: " + ex.Message);
            }
            dgv_NhanVien.ClearSelection();
        }
        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_NhanVien.CurrentRow.Index;
           cbo_MaTK.Text = dgv_NhanVien.Rows[i].Cells[0].Value.ToString();
            txt_MaNhanVienNhanVien.Text = dgv_NhanVien.Rows[i].Cells[1].Value.ToString();
            txt_HoTenNhanVienNhanVien.Text = dgv_NhanVien.Rows[i].Cells[2].Value.ToString();
            txt_SDT.Text = dgv_NhanVien.Rows[i].Cells[5].Value.ToString();
            txt_DiaChiNhanVien.Text = dgv_NhanVien.Rows[i].Cells[3].Value.ToString();
            txt_Luong.Text = dgv_NhanVien.Rows[i].Cells[6].Value.ToString();
            if ((bool)dgv_NhanVien.Rows[i].Cells[4].Value == true)
            {
                cbo_GioiTinh.Text = "Nam";
            }
            else
            {
                cbo_GioiTinh.Text = "Nữ";
               
            }
        }
        public void ThemNhanVien()
        {
            string sSQL = "INSERT INTO NHANVIEN (MaTK,TenNV, DiaChi, GioiTinh, SDT, Luong) VALUES (@MaTK, @TenNV, @DiaChi, @GioiTinh, @SDT, @Luong)";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MaTK", cbo_MaTK.Text);
                        cmd.Parameters.AddWithValue("@TenNV", txt_HoTenNhanVienNhanVien.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChiNhanVien.Text);

                        // Ánh xạ giữa giá trị của combobox và giá trị bit trong cơ sở dữ liệu
                        if (cbo_GioiTinh.Text == "Nam")
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", true);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", false);
                        }

                        cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                        cmd.Parameters.AddWithValue("@Luong", txt_Luong.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            ThemNhanVien();
            XemDanhSachNhanVien();
        }
        public void SuaNhanVien()
        {
            string MaNV = txt_MaNhanVienNhanVien.Text;
            // Khởi tạo kết nối
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                // Chuỗi truy vấn cập nhật
                string sSQL = "UPDATE NHANVIEN SET MaTK = @MaTK, TenNV = @TenNV, DiaChi = @DiaChi, GioiTinh = @GioiTinh, SDT = @SDT, Luong = @Luong WHERE MaNV = @MaNV";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        // Thêm các tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@maTK", cbo_MaTK.Text);
                        cmd.Parameters.AddWithValue("@TenNV", txt_HoTenNhanVienNhanVien.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChiNhanVien.Text);
                        if (cbo_GioiTinh.Text == "Nam")
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", true);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", false);
                        }
                        cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                        cmd.Parameters.AddWithValue("@Luong", txt_Luong.Text);
                        cmd.Parameters.AddWithValue("@MaNV", txt_MaNhanVienNhanVien.Text);

                        // Thực thi truy vấn cập nhật
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bạn đã cập nhật nhân viên thành công nhân viên có mã là : " + MaNV, "THÔNG BÁO");
                        }
                        else
                        {
                            MessageBox.Show("Không có nhân viên nào được cập nhật.", "THÔNG BÁO");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
                }
            }

        }

        private void btn_SuaNhanVien_Click(object sender, EventArgs e)
        {
            SuaNhanVien();
            XemDanhSachNhanVien();
        }
        public void XoaNhanVien()
        {
            string MaNhanVien = txt_MaNhanVienNhanVien.Text;
            // Khởi tạo kết nối
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                // Chuỗi truy vấn xóa
                string sSQL = "DELETE FROM NHANVIEN WHERE MaNV = @MaNV";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@MaNV", MaNhanVien);

                        // Thực thi truy vấn xóa
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa nhân viên có mã là: " + MaNhanVien, "THÔNG BÁO");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!!. Chi tiết: " + ex.Message);
                }
            }
        }

        private void btn_XoaNhanVien_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
            XemDanhSachNhanVien();
            cbo_Search.SelectedIndex = 0; ;
            cbo_MaTK.SelectedIndex = -1;
            txt_MaNhanVienNhanVien.Clear();
            txt_HoTenNhanVienNhanVien.Clear();
            txt_SDT.Clear();
            cbo_GioiTinh.SelectedIndex = -1;
            txt_DiaChiNhanVien.Clear();
            txt_Luong.Clear();

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            XemDanhSachNhanVien();
            HienThiMaTaiKhoan();
            cbo_Search.SelectedIndex = 0;

        }

        private void btn_TimKiemThongTinNhanVien_Click(object sender, EventArgs e)
        {
            if (cbo_Search.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_TimKiem.Text))
            {
                MessageBox.Show("Bạn chưa điền vào ô tìm kiếm hoặc bạn chọn chức năng tìm kiếm chưa phù hợp.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                TimKiem();
            }

        }
        public void TimKiem()
        {
            string TimKiemTheo = "", TimKiemThongKe = "";

            TimKiemTheo = cbo_Search.Text;
            TimKiemThongKe = txt_TimKiem.Text;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    string sSQL = "SELECT * FROM NHANVIEN WHERE " + TimKiemTheo + " = @TimKiemThongKe";
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TimKiemThongKe", TimKiemThongKe);

                        SqlDataAdapter daNV = new SqlDataAdapter(cmd);
                        DataSet dsNV = new DataSet();
                        daNV.Fill(dsNV);

                        dgv_NhanVien.DataSource = dsNV.Tables[0];
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
            XemDanhSachNhanVien();
            txt_TimKiem.Clear();
            cbo_Search.SelectedIndex = 0; ;
            cbo_MaTK.SelectedIndex = -1;
            txt_MaNhanVienNhanVien.Clear();
            txt_HoTenNhanVienNhanVien.Clear();
            txt_SDT.Clear();
            cbo_GioiTinh.SelectedIndex = -1;
            txt_DiaChiNhanVien.Clear();
            txt_Luong.Clear();

        }
        public void HienThiMaTaiKhoan()
        {
            //Doi tuong ket noi CSDL
            SqlConnection myConnection = new SqlConnection(scon);
            string sSql;
            sSql = "  SELECT MaTK, TenDangNhap FROM TAIKHOAN Where ThuocLoai like N'Nhân viên'";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sSql, myConnection);
                //DataSet: du lieu tren bo nho RAM
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                cbo_MaTK.DataSource = ds.Tables[0];
                cbo_MaTK.DisplayMember = "MaTK";
                cbo_MaTK.ValueMember = "TenDangNhap";
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI. Chi tiet: " + ex.Message);
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn ký tự không hợp lệ
                e.Handled = true;

                // Hiển thị thông báo
                MessageBox.Show("Chỉ được nhập số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn ký tự không hợp lệ
                e.Handled = true;

                // Hiển thị thông báo
                MessageBox.Show("Chỉ được nhập số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Luong_TextChanged(object sender, EventArgs e)
        {

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

        private void cbo_MaTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_MaTK_Click(object sender, EventArgs e)
        {

        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
