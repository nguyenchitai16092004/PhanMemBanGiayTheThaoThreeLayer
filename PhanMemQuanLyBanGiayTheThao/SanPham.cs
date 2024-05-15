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
    public partial class frm_SanPham : Form
    {
        public string scon = "Data Source=LAPTOP-C5AR9CK3;Initial Catalog=SHOPBANGIAY;Integrated Security=True";
        private bool isChangeImage = false;
        public frm_SanPham()
        {
            InitializeComponent();
        }
        public int MaTK;
        public void XemDanhSachSanPham()
        {
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "SELECT * FROM SANPHAM; ";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);

                myConnection.Close();
                dgv_SanPham.DataSource = dsSanPham.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!. Chi tiết: " + ex.Message);
            }
        }

        public void XoaSanPham()
        {
            string MaSP = txt_MaSanPham.Text;
            SqlConnection myConnection = new SqlConnection(scon);
            string sSQL = "DELETE FROM SANPHAM WHERE MaSP like '" + MaSP.ToString() + "'";
            try
            {
                myConnection.Open();

                SqlDataAdapter daSanPham = new SqlDataAdapter(sSQL, myConnection);
                DataSet dsSanPham = new DataSet();
                daSanPham.Fill(dsSanPham);
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!. Chi tiết: " + ex.Message);
            }
        }

        public void SuaSP()
        {
            int TrangThai;
            string MaSP = txt_MaSanPham.Text;

            if (chk_TrangThai.Checked == false)
            {
                TrangThai = 0;
            }
            else
            {
                TrangThai = 1;
            }

            using (SqlConnection myConnection = new SqlConnection(scon))
            {
                string sSQL = "UPDATE SANPHAM SET TenSP = @TenSP, GiaBan = @Gia, MaNCC = @MaNCC, SoLuong = @SoLuong, TrangThai = @TrangThai, KhuyenMai = @KhuyenMai, GiaNhap = @GiaNhap WHERE MaSP = @MaSP";

                try
                {
                    myConnection.Open();

                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TenSP", txt_TenSanPhamSanPham.Text);
                        cmd.Parameters.AddWithValue("@Gia", nud_DonGiaSanPham.Text);
                        cmd.Parameters.AddWithValue("@MaNCC", cbo_MaNCC.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", nud_SoLuongSanPham.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                        cmd.Parameters.AddWithValue("@KhuyenMai", txt_KhuyenMai.Text);
                        cmd.Parameters.AddWithValue("@GiaNhap", nud_GiaNhap.Value);
                        cmd.Parameters.AddWithValue("@MaSP", MaSP);

                        // Chỉ cập nhật ảnh nếu có ảnh mới
                        if (this.isChangeImage)
                        {
                            MemoryStream ms = new MemoryStream();
                            try
                            {
                                pic_ImageSP.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                            catch (Exception imgEx)
                            {
                                MessageBox.Show("Vui lòng cập nhật lại ảnh của sản phẩm trước khi xác nhận Sửa. Chi tiết lỗi: " + imgEx.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            byte[] imgByte = ms.ToArray(); // Chuyển đổi sang byte array
                            cmd.Parameters.AddWithValue("@Anh", imgByte);

                            cmd.CommandText = "UPDATE SANPHAM SET TenSP = @TenSP, GiaBan = @Gia, MaNCC = @MaNCC, SoLuong = @SoLuong, TrangThai = @TrangThai, KhuyenMai = @KhuyenMai, Anh = @Anh, GiaNhap = @GiaNhap WHERE MaSP = @MaSP";
                        }

                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi truy vấn
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bạn đã thay đổi thành công sản phẩm có mã sản phẩm là: " + MaSP, "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không có sản phẩm nào được cập nhật.", "Thông báo");
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        public void ThemSP()
        {
            string maSanPham = txt_MaSanPham.Text;
            string sSQLKiemTra = "SELECT COUNT(*) FROM SANPHAM WHERE MaSP = @MaSP";
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    myConnection.Open();
                    using (SqlCommand cmdKiemTra = new SqlCommand(sSQLKiemTra, myConnection))
                    {
                        cmdKiemTra.Parameters.AddWithValue("@MaSP", maSanPham);
                        int count = (int)cmdKiemTra.ExecuteScalar();
                        if (count > 0)// nếu ktra không trùng mã sản phẩm thì tiếp tục thực hiện thêm sản phẩm
                        {
                            MessageBox.Show("Mã sản phẩm đã tồn tại. Hãy chọn nút 'Làm mới' trước thêm sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // thoát khỏi hàm
                        }
                    }

                    //kiểm tra ảnh sản phẩm
                    if (pic_ImageSP.Image == null)
                    {
                        MessageBox.Show("Bạn hãy thêm ảnh của sản phẩm trước khi thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string sSQL = "INSERT INTO SANPHAM (TenSP, GiaBan, MaNCC, SoLuong, TrangThai, KhuyenMai, GiaNhap, Anh) VALUES (@TenSP, @GiaBan, @MaNCC, @SoLuong, @TrangThai, @KhuyenMai, @GiaNhap, @Anh)";
                    using (SqlCommand cmdThemSP = new SqlCommand(sSQL, myConnection))
                    {
                        cmdThemSP.Parameters.AddWithValue("@TenSP", txt_TenSanPhamSanPham.Text);
                        cmdThemSP.Parameters.AddWithValue("@GiaBan", nud_DonGiaSanPham.Text);
                        cmdThemSP.Parameters.AddWithValue("@MaNCC", cbo_MaNCC.Text);
                        cmdThemSP.Parameters.AddWithValue("@SoLuong", nud_SoLuongSanPham.Text);
                        cmdThemSP.Parameters.AddWithValue("@TrangThai", 1);
                        cmdThemSP.Parameters.AddWithValue("@KhuyenMai", txt_KhuyenMai.Text);
                        cmdThemSP.Parameters.AddWithValue("@GiaNhap", nud_GiaNhap.Text);

                        // Chuyển ảnh sang dạng byte array và thêm vào parameter
                        MemoryStream ms = new MemoryStream();
                        pic_ImageSP.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imgByte = ms.GetBuffer();
                        cmdThemSP.Parameters.AddWithValue("@Anh", imgByte);

                        cmdThemSP.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btn_XoaSanPham_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                XoaSanPham();
                XemDanhSachSanPham();
            }
            chk_TrangThai.Checked = false;
            cbo_MaNCC.SelectedIndex = -1;
            txt_MaSanPham.Clear();
            txt_TenSanPhamSanPham.Clear();
            txt_KhuyenMai.Clear();
            nud_DonGiaSanPham.Value = 0;
            nud_GiaNhap.Value = 0;
            nud_SoLuongSanPham.Value = 0;

            if (pic_ImageSP.Image != null)
            {
                pic_ImageSP.Image.Dispose(); // Giải phóng các byte của hình ảnh( làm trống)
            }
            pic_ImageSP.Image = null;

        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.isChangeImage = false;
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgv_SanPham.Rows.Count)
            {
                DataGridViewRow selectedRow = dgv_SanPham.Rows[rowIndex];
                if (selectedRow != null)
                {
                    txt_MaSanPham.Text = selectedRow.Cells[0].Value.ToString();
                    txt_TenSanPhamSanPham.Text = selectedRow.Cells[1].Value.ToString();
                    nud_DonGiaSanPham.Value = Convert.ToDecimal(selectedRow.Cells[2].Value);
                    cbo_MaNCC.Text = selectedRow.Cells[3].Value.ToString();
                    nud_SoLuongSanPham.Value = Convert.ToDecimal(selectedRow.Cells[4].Value);
                    txt_KhuyenMai.Text = selectedRow.Cells[6].Value.ToString();
                    nud_GiaNhap.Value = Convert.ToDecimal(selectedRow.Cells[7].Value);

                    // Kiểm tra nếu cột "Anh" có dữ liệu
                    if (selectedRow.Cells[8].Value != DBNull.Value)
                    {
                        byte[] imageData = (byte[])selectedRow.Cells[8].Value;// lấy dữ liệu từ cột Ảnh
                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pic_ImageSP.Image = Image.FromStream(ms); // chuyển ảnh sang kiểu Image và hiện ảnh
                            }
                        }
                        else
                        {
                            // Nếu không có hình ảnh, đặt hình ảnh mặc định hoặc xóa hình cũ
                            pic_ImageSP.Image = null;
                        }
                    }
                    else
                    {
                        // Nếu cột "Anh" không có dữ liệu, đặt hình ảnh mặc định hoặc xóa hình cũ
                        pic_ImageSP.Image = null;
                    }

                    if ((bool)selectedRow.Cells[5].Value == false)
                    {
                        chk_TrangThai.Checked = false;
                    }
                    else
                    {
                        chk_TrangThai.Checked = true;
                    }
                }

            }
        }

        private void btn_SuaSanPham_Click(object sender, EventArgs e)
        {
            SuaSP();
            XemDanhSachSanPham();
        }
        private void btn_SearchSanPham_Click(object sender, EventArgs e)
        {
            if (cbo_Search.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_TimKiemSanPham.Text))
            {
                MessageBox.Show("Bạn chưa điền vào ô tìm kiếm hoặc bạn chọn chức năng tìm kiếm chưa phù hợp.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                TimKiem();
            }

        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            ThemSP();
            XemDanhSachSanPham();
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            XemDanhSachSanPham();
            cbo_Search.SelectedIndex = 0;
            DataGridViewImageColumn avatar_column = (DataGridViewImageColumn)dgv_SanPham.Columns[8];
            avatar_column.Width = 60;
            avatar_column.ImageLayout = DataGridViewImageCellLayout.Zoom;
            txt_TimKiemSanPham.Clear();
            cbo_MaNCC.SelectedIndex = -1;
            HienThiMaNhaCungCap();
        }
        public void TimKiem()
        {
            string TimKiemTheo = cbo_Search.Text,
                    TimKiemThongKe = txt_TimKiemSanPham.Text;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    string sSQL;
                    if (TimKiemTheo == "MaSP")
                    {
                        sSQL = "SELECT * FORM SANPHAM WHERE MaSP = @TimKiem";
                    }
                    else
                    {
                        sSQL = "SELECT * FROM SANPHAM WHERE TenSP like '%' + @TimKiem + '%'";
                    }
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(sSQL, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@TimKiem", TimKiemThongKe.ToString());

                        SqlDataAdapter daSanPham = new SqlDataAdapter(cmd);
                        DataSet dsSanPham = new DataSet();
                        daSanPham.Fill(dsSanPham);
                        dgv_SanPham.DataSource = dsSanPham.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void pic_ImageSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_image = new OpenFileDialog();
            open_image.Filter = "Image|*.jpg; *.jpeg; *.png";
            if (open_image.ShowDialog() == DialogResult.OK)
            {
                pic_ImageSP.Image = Image.FromFile(open_image.FileName);
            }

            this.isChangeImage = true;
        }

        private void dgv_SanPham_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_SanPham.Rows[e.RowIndex].Height = 80;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            XemDanhSachSanPham();
            txt_TimKiemSanPham.Clear();
            cbo_Search.SelectedIndex = 0;
            chk_TrangThai.Checked = false;
            cbo_MaNCC.SelectedIndex = -1;
            txt_MaSanPham.Clear();
            txt_TenSanPhamSanPham.Clear();
            txt_KhuyenMai.Clear();
            nud_DonGiaSanPham.Value = 0;
            nud_GiaNhap.Value = 0;
            nud_SoLuongSanPham.Value = 0;
            cbo_MaNCC.SelectedIndex = 0;

            if (pic_ImageSP.Image != null)
            {
                pic_ImageSP.Image.Dispose(); // Giải phóng các byte của hình ảnh( làm trống)
            }
            pic_ImageSP.Image = null;
        }

        public void HienThiMaNhaCungCap()
        {
            //Doi tuong ket noi CSDL
            SqlConnection myConnection = new SqlConnection(scon);
            string sSql;
            sSql = "SELECT MaNCC, TenNCC FROM NHACUNGCAP";
            try
            {
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sSql, myConnection);
                //DataSet: du lieu tren bo nho RAM
                DataSet ds = new DataSet();
                da.Fill(ds);
                myConnection.Close();
                cbo_MaNCC.DataSource = ds.Tables[0];
                cbo_MaNCC.DisplayMember = "MaNCC";
                cbo_MaNCC.ValueMember = "TenNCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI. Chi tiet: " + ex.Message);
            }
        }

        private void grb_HeaderSanPham_Enter(object sender, EventArgs e)
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

    }
}

