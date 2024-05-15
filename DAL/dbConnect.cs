using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class dbConnect
    {
        private readonly SqlConnection conn;

        public dbConnect()
        {
            // Thay đổi chuỗi kết nối của bạn tại đây
            conn = new SqlConnection("Data Source=SECRET-0327\\SQL_SEVER_01;Initial Catalog=SHOPBANGIAY;Integrated Security=True");
        }

        // Lấy dữ liệu từ câu lệnh SQL (SELECT)
        public DataTable GetDataTable(string strSQL)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(strSQL, conn))
            {
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
