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
    public partial class frm_TaiKhoan : Form
    {
        public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        public frm_TaiKhoan()
        {
            InitializeComponent();
        }
        public int MaTK;
        public void XemDanhSachTaiKhoan()
        {
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT* FROM TAIKHOAN;";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);

                myConnection.Close();
                dgv_TaiKhoan.DataSource = dsSanPham.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi. Chi tiet: " + ex.Message);
            }
        }

        private void btn_QuayLaiTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu ql = new frm_Menu();
            ql.MaTK = MaTK;
            ql.Show();
        }
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            XemDanhSachTaiKhoan();
            txt_TimKiem.Clear();
            cbo_Search.SelectedIndex = 0;


        }
        public void ThemTK()
        {
            //khai báo chuoi ket noi CSDL
            string sSQL = "INSERT INTO TAIKHOAN (TenDangNhap, MatKhau, TrangThai, ThuocLoai) VALUES (@TenDangNhap, @MatKhau, @TrangThai, @ThuocLoai)";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", txt_TenTaiKhoanTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txt_MatKhauTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", chk_HoatDongTaiKhoan.Checked);
                        cmd.Parameters.AddWithValue("@ThuocLoai", cbo_LoaiTaiKhoan.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }

        }
        public void SuaTK()
        {
            int TrangThai;
            string MaTK = txt_MataiKhoanTaiKhoan.Text;
            if (chk_HoatDongTaiKhoan.Checked == false)
            {
                TrangThai = 0;
            }
            else
            {
                TrangThai = 1;
            }
            // Khởi tạo kết nối
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                // Chuỗi truy vấn cập nhật
                string sSQL = "UPDATE TAIKHOAN SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, TrangThai = @TrangThai, ThuocLoai = @ThuocLoai WHERE MaTK = @MaTK";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        // Thêm các tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@TenDangNhap", txt_TenTaiKhoanTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txt_MatKhauTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", chk_HoatDongTaiKhoan.Checked);
                        cmd.Parameters.AddWithValue("@ThuocLoai", cbo_LoaiTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@MaTK", txt_MataiKhoanTaiKhoan.Text);

                        // Thực thi truy vấn cập nhật
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bạn đã cập nhật tài khoản thành công tài khoản có mã là : " + MaTK, "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không có tài khoản nào được cập nhật.", "Thông báo");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
                }
            }

        }


        public void XoaTK()
        {
            string MaTaiKhoan = txt_MataiKhoanTaiKhoan.Text;
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                string sSQL = "DELETE FROM TAIKHOAN WHERE MaTK = @MaTK";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@MaTK", MaTaiKhoan);

                        // Thực thi truy vấn xóa
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa tài khoản có mã là: " + MaTaiKhoan, "Thông báo");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // mã lỗi khóa ngoại
                    {
                        MessageBox.Show("Hãy xóa nhân viên này trong bảng Nhân Viên trước khi xóa tài khoản này bạn nhé!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!!!. Chi tiết: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!!. Chi tiết: " + ex.Message);
                }
            }
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            XemDanhSachTaiKhoan();
            txt_TimKiem.Clear();
            cbo_Search.SelectedIndex = 0;
            txt_MataiKhoanTaiKhoan.Clear();
            txt_TenTaiKhoanTaiKhoan.Clear();
            txt_MatKhauTaiKhoan.Clear();
            cbo_LoaiTaiKhoan.SelectedIndex = -1;
            chk_HoatDongTaiKhoan.Checked = false;

        }

        private void btn_ThemTaiKhoan_Click_1(object sender, EventArgs e)
        {
            ThemTK();
            XemDanhSachTaiKhoan();
        }

        private void btn_XoaTaiKhoan_Click_1(object sender, EventArgs e)
        {
            XoaTK();
            XemDanhSachTaiKhoan();
            txt_MataiKhoanTaiKhoan.Clear();
            txt_TenTaiKhoanTaiKhoan.Clear();
            txt_MatKhauTaiKhoan.Clear();
            cbo_LoaiTaiKhoan.SelectedIndex = -1;
            chk_HoatDongTaiKhoan.Checked = false;
        }

        private void btn_SuaTaiKhoan_Click_1(object sender, EventArgs e)
        {
            SuaTK();
            XemDanhSachTaiKhoan();
        }

        private void dgv_TaiKhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_TaiKhoan.CurrentRow.Index;
            txt_MataiKhoanTaiKhoan.Text = dgv_TaiKhoan.Rows[i].Cells[0].Value.ToString();
            txt_TenTaiKhoanTaiKhoan.Text = dgv_TaiKhoan.Rows[i].Cells[1].Value.ToString();
            txt_MatKhauTaiKhoan.Text = dgv_TaiKhoan.Rows[i].Cells[2].Value.ToString();
            cbo_LoaiTaiKhoan.Text = dgv_TaiKhoan.Rows[i].Cells[4].Value.ToString();
            if ((bool)dgv_TaiKhoan.Rows[i].Cells[3].Value == false)
            {
                chk_HoatDongTaiKhoan.Checked = false;
            }
            else
            {
                chk_HoatDongTaiKhoan.Checked = true;
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
                    string sSQL = "SELECT * FROM TAIKHOAN WHERE " + TimKiemTheo + " = @TimKiemThongKe";
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TimKiemThongKe", TimKiemThongKe);

                        SqlDataAdapter daTK = new SqlDataAdapter(cmd);
                        DataSet dsTK = new DataSet();
                        daTK.Fill(dsTK);

                        dgv_TaiKhoan.DataSource = dsTK.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btn_SearchTaiKhoan_Click_1(object sender, EventArgs e)
        {
            if(cbo_Search.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_TimKiem.Text))
            {
                MessageBox.Show("Bạn chưa điền vào ô tìm kiếm hoặc bạn chọn chức năng tìm kiếm chưa phù hợp.", "Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            else
            {
                TimKiem();
            }
        }

        private void frm_TaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_XuatThongTinTaiKhoan_Click(object sender, EventArgs e)
        {

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

        private void grb_HeaderTaiKhoan_Enter(object sender, EventArgs e)
        {

        }
    }
}
