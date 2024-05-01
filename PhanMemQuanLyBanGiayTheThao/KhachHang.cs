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
    public partial class frm_KhachHang : Form
    {
       public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        public int MaTK;
        public void XemDanhSachKhachHang()
        {
            //khai báo chuoi ket noi CSDL
            
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT * FROM KHACHHANG;";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);

                myConnection.Close();
                dgv_KhachHang.DataSource = dsSanPham.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi. Chi tiet: " + ex.Message);
            }
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            XemDanhSachKhachHang();
            txt_TimKiemKhachHang.Clear();
            cbo_Search.Text = "Tìm kiếm theo :";

        }
        private void btn_QuayLaiKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu ql = new frm_Menu();
            ql.MaTK = MaTK;
            ql.Show();
        }
        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_KhachHang.CurrentRow.Index;
            txt_MaKhachHangKhachHang.Text = dgv_KhachHang.Rows[i].Cells[1].Value.ToString();
            txt_MaTaiKhoanKhachHang.Text = dgv_KhachHang.Rows[i].Cells[0].Value.ToString();
            txt_TenKhachHang.Text = dgv_KhachHang.Rows[i].Cells[2].Value.ToString();
            txt_EmailKhachHang.Text = dgv_KhachHang.Rows[i].Cells[3].Value.ToString();
            txt_DiaChiKhachHang.Text = dgv_KhachHang.Rows[i].Cells[4].Value.ToString();
            txt_SDTKhachHang.Text = dgv_KhachHang.Rows[i].Cells[6].Value.ToString();
            cbo_QuyenHang.Text = dgv_KhachHang.Rows[i].Cells[7].Value.ToString();
            if ((bool)dgv_KhachHang.Rows[i].Cells[5].Value == true)
            {
                cbo_GioiTinh.Text = "Nam";
            }
            else
            {
                cbo_GioiTinh.Text = "Nữ";

            }
        }
        public void ThemKhachHang()
        {
            //khai báo chuoi ket noi CSDL
            string sSQL = "INSERT INTO KHACHHANG (TenKH, Email, DiaChi, GioiTinh, SDT,QuyenHang) VALUES (@TenKH, @Email, @DiaChi, @GioiTinh,@SDT, @QuyenHang)";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TenKH", txt_TenKhachHang.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_EmailKhachHang.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChiKhachHang.Text);
                        cmd.Parameters.AddWithValue("@SDT", txt_SDTKhachHang.Text);
                        cmd.Parameters.AddWithValue("@QuyenHang", cbo_QuyenHang.Text);




                        // Ánh xạ giữa giá trị của combobox và giá trị bit trong cơ sở dữ liệu
                        if (cbo_GioiTinh.Text == "Nam")
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", true);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", false);
                        }

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            ThemKhachHang();
            XemDanhSachKhachHang();
        }
        public void SuaKhachHang()
        {
            string MaKhachHang = txt_MaKhachHangKhachHang.Text;
            // Khởi tạo kết nối
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                // Chuỗi truy vấn cập nhật TenKH, Email, DiaChi, GioiTinh, SDT,QuyenHang
                string sSQL = "UPDATE KHACHHANG SET TenKH = @TenKH, Email = @Email, DiaChi = @DiaChi, GioiTinh = @GioiTinh, SDT = @SDT, QuyenHang = @QuyenHang WHERE MaKH = @MaKH";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        // Thêm các tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@TenKH", txt_TenKhachHang.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_EmailKhachHang.Text);
                        if (cbo_GioiTinh.Text == "Nam")
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", true);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", false);
                        }
                        cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChiKhachHang.Text);
                        cmd.Parameters.AddWithValue("@SDT", txt_SDTKhachHang.Text);
                        cmd.Parameters.AddWithValue("@QuyenHang", cbo_QuyenHang.Text);
                        cmd.Parameters.AddWithValue("@MaKH", txt_MaKhachHangKhachHang.Text);



                        // Thực thi truy vấn cập nhật
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bạn đã cập nhật khách hàng thành công khách hàng có mã là : " + MaKhachHang, "THÔNG BÁO");
                        }
                        else
                        {
                            MessageBox.Show("Không có khách hàng nào được cập nhật.", "THÔNG BÁO");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
                }
            }

        }

        private void btn_SuaKhachHang_Click(object sender, EventArgs e)
        {
            SuaKhachHang();
            XemDanhSachKhachHang();
        }
        public void XoaKhachHang()
        {
            string MaKhachHang = txt_MaKhachHangKhachHang.Text;

            // Khởi tạo kết nối
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                // Chuỗi truy vấn xóa
                string sSQL = "DELETE FROM KHACHHANG WHERE MaKH = @MaKH";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@MaKH", MaKhachHang);

                        // Thực thi truy vấn xóa
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa khách hàng có mã là: " + MaKhachHang, "THÔNG BÁO");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!!. Chi tiết: " + ex.Message);
                }
            }
        }

        private void btn_XoaKhachHang_Click(object sender, EventArgs e)
        {
            XoaKhachHang();
            XemDanhSachKhachHang();
        }
        public void TimKiem()
        {
            string TimKiemTheo = "", TimKiemThongKe = "";

            TimKiemTheo = cbo_Search.Text;
            TimKiemThongKe = txt_TimKiemKhachHang.Text;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    string sSQL = "SELECT * FROM KHACHHANG WHERE " + TimKiemTheo + " = @TimKiemThongKe";
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TimKiemThongKe", TimKiemThongKe);

                        SqlDataAdapter daKH = new SqlDataAdapter(cmd);
                        DataSet dsKH = new DataSet();
                        daKH.Fill(dsKH);

                        dgv_KhachHang.DataSource = dsKH.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btn_SearchKhachHang_Click(object sender, EventArgs e)
        {
            if (cbo_Search.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_TimKiemKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa điền vào ô tìm kiếm hoặc bạn chọn chức năng tìm kiếm chưa phù hợp.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                TimKiem();
            }

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            XemDanhSachKhachHang();
            txt_TimKiemKhachHang.Clear();
            cbo_Search.Text = "Tìm kiếm theo :";
            txt_DiaChiKhachHang.Clear();
            txt_MaKhachHangKhachHang.Clear();
            txt_MaTaiKhoanKhachHang.Clear();
            txt_TenKhachHang.Clear();
            txt_EmailKhachHang.Clear();
            txt_SDTKhachHang.Clear();
            cbo_GioiTinh.SelectedIndex = -1;
            cbo_QuyenHang.SelectedIndex = -1;
        }

        private void txt_SDTKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn ký tự không hợp lệ
                e.Handled = true;

                // Hiển thị thông báo
                MessageBox.Show("Chỉ được nhập số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
