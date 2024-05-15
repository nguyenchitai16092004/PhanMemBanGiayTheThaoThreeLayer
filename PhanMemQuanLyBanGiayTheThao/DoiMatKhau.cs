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

    public partial class frm_DoiMatKhau : Form
    {
        public int MaTK;
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        public void DoiMatKhau()
        {
            // Lấy giá trị từ các ô nhập liệu
            string MatKhauMoi = txt_NhapLaiMatKhau.Text;
            string NhapLaimatKhauMoi = txt_NhapLaiMatKhau.Text;
            string TenDangNhapCu = txt_TenDangNhapCu.Text;
            string MatKhauCu = txt_MatKhauCu.Text;

            // Kiểm tra xác nhận mật khẩu mới
            if (NhapLaimatKhauMoi != MatKhauMoi)
            {
                MessageBox.Show("Xác nhận mật khẩu nhập lại chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khai báo chuỗi kết nối
            string scon = "Data Source=SECRET-0327\\SQL_SEVER_01Initial Catalog=SHOPBANGIAY;Integrated Security=True";

            // Kết nối tới cơ sở dữ liệu
            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                // Tạo chuỗi truy vấn kiểm tra tên đăng nhập và mật khẩu cũ
                string checkSQL = "SELECT COUNT(*) FROM TAIKHOAN WHERE MaTK = @MaTK AND TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

                try
                {
                    myConnection.Open();

                    // Tạo đối tượng SqlCommand để kiểm tra tài khoản cũ
                    using (SqlCommand checkCmd = new SqlCommand(checkSQL, myConnection))
                    {
                        checkCmd.Parameters.AddWithValue("@MaTK", MaTK);
                        checkCmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhapCu);
                        checkCmd.Parameters.AddWithValue("@MatKhau", MatKhauCu);

                        // Kiểm tra kết quả truy vấn
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Nếu đúng, thực hiện cập nhật mật khẩu
                    string sSQL = "UPDATE TAIKHOAN SET MatKhau = @MatKhau WHERE MaTK = @MaTK";

                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@MatKhau", MatKhauMoi);
                        cmd.Parameters.AddWithValue("@MaTK", MaTK);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công! Đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm_DangNhap dn = new frm_DangNhap();
                            dn.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }

        private void chk_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienMatKhau.Checked == true)
            {
                txt_MatKhauCu.PasswordChar = '\0';
                txt_MatKhauMoi.PasswordChar = '\0';
                txt_NhapLaiMatKhau.PasswordChar = '\0';

            }
            else
            {
                txt_MatKhauCu.PasswordChar = '*';
                txt_MatKhauMoi.PasswordChar = '*';
                txt_NhapLaiMatKhau.PasswordChar = '*';
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            frm_Menu ql = new frm_Menu();
            ql.Show();
            ql.MaTK = MaTK;
            this.Close();
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
