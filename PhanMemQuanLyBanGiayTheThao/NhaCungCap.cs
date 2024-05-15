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
    public partial class frm_NhaCungCap : Form
    {
        public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }
        public int MaTK;

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            XemDanhSachNhaCungCap();
            txt_TimKiem.Clear();
            cbo_Search.Text = "Tìm kiếm theo :";
        }

        private void ddv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void XemDanhSachNhaCungCap()
        {
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT * FROM NHACUNGCAP;";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);

                myConnection.Close();
                dgv_NhaCungCap.DataSource = dsSanPham.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi. Chi tiet: " + ex.Message);
            }
        }


        private void dgv_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_NhaCungCap.CurrentRow.Index;
            txt_MaNhaCungCap.Text = dgv_NhaCungCap.Rows[i].Cells[0].Value.ToString();
            txt_TenNhaCungCap.Text = dgv_NhaCungCap.Rows[i].Cells[1].Value.ToString();
            txt_DiaChi.Text = dgv_NhaCungCap.Rows[i].Cells[2].Value.ToString();
            txt_SDT.Text = dgv_NhaCungCap.Rows[i].Cells[3].Value.ToString();
            if ((bool)dgv_NhaCungCap.Rows[i].Cells[4].Value == false)
            {
                chk_HoatDong.Checked = false;
            }
            else
            {
                chk_HoatDong.Checked = true;
            }
        }
        public void ThemNhaCungCap()
        {
            string sSQL = "INSERT INTO NHACUNGCAP (TenNCC, DiaChi, SDT, TrangThai) VALUES (@TenNCC, @DiaChi, @SDT, @TrangThai)";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TenNCC", txt_TenNhaCungCap.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                        cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", chk_HoatDong.Checked);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btn_Thembtn_NhaCungCapNhaCungCap_Click(object sender, EventArgs e)
        {
            ThemNhaCungCap();
            XemDanhSachNhaCungCap();
        }
        public void SuaNhaCungCap()
        {
            string MaNhaCungCap = txt_MaNhaCungCap.Text;
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                string sSQL = "UPDATE NHACUNGCAP SET TenNCC = @TenNCC, DiaChi = @DiaChi, SDT = @SDT, TrangThai = @TrangThai WHERE MaNCC = @MaNCC";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        // Thêm các tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@TenNCC", txt_TenNhaCungCap.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                        cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", chk_HoatDong.Checked);
                        cmd.Parameters.AddWithValue("@MaNCC", txt_MaNhaCungCap.Text);

                        // Thực thi truy vấn cập nhật
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bạn đã cập nhật nhà cung cấp thành công nhà cung cấp có mã là : " + MaNhaCungCap, "THÔNG BÁO");
                        }
                        else
                        {
                            MessageBox.Show("Không có nhà cung cấp nào được cập nhật.", "THÔNG BÁO");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
                }
            }

        }
        private void btn_Suabtn_NhaCungCapNhaCungCap_Click(object sender, EventArgs e)
        {
            SuaNhaCungCap();
            XemDanhSachNhaCungCap();
        }
        public void XoaNhaCungCap()
        {
            string MaNhaCungCap = txt_MaNhaCungCap.Text;
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                string sSQL = "DELETE FROM NHACUNGCAP WHERE MaNCC = @MaNCC";

                try
                {
                    myConnection.Open();
                    // Khởi tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@MaNCC", MaNhaCungCap);

                        // Thực thi truy vấn xóa
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa nhà cung cấp có mã là: " + MaNhaCungCap, "THÔNG BÁO");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!!. Chi tiết: " + ex.Message);
                }
            }
        }

        private void btn_Xoabtn_NhaCungCapNhaCungCap_Click(object sender, EventArgs e)
        {
            XoaNhaCungCap();
            XemDanhSachNhaCungCap();
            txt_DiaChi.Clear();
            txt_MaNhaCungCap.Clear();
            txt_SDT.Clear();
            txt_TenNhaCungCap.Clear();
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
                    string sSQL = "SELECT * FROM NHACUNGCAP WHERE " + TimKiemTheo + " = @TimKiemThongKe";
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TimKiemThongKe", TimKiemThongKe);

                        SqlDataAdapter daTK = new SqlDataAdapter(cmd);
                        DataSet dsTK = new DataSet();
                        daTK.Fill(dsTK);

                        dgv_NhaCungCap.DataSource = dsTK.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
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

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            XemDanhSachNhaCungCap();
            txt_TimKiem.Clear();
            cbo_Search.SelectedIndex = 0;
            txt_DiaChi.Clear();
            txt_MaNhaCungCap.Clear();
            txt_SDT.Clear();
            txt_TenNhaCungCap.Clear();

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
    }
}
