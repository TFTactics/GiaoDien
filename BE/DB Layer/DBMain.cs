using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

// Tầng dữ liệu
namespace GiaoDien.BE.DB_Layer
{
    class DBMain
    {
        // Chuỗi kết nối
        string connStr = @"Data Source=THANG\SQLEXPRESS; Initial Catalog=QuanLyCaPhe; Integrated Security=True";

        // Đối tượng kết nối
        SqlConnection conn = null;
        SqlCommand comm = null;

        // Đối tượng đưa dữ liệu vào DataTable
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(connStr);
            comm = new SqlCommand();
        }

        public DataSet GoiThuTucOrHam(string strPro, CommandType ct, ref string err, params SqlParameter[] param)
        {
            // Kiểm tra đối tượng kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.Connection = conn;
            comm.CommandText = strPro;
            comm.CommandType = ct;

            comm.Parameters.Clear();

            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);

            da = new SqlDataAdapter(comm);

            // Khởi tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Đổ dữ liệu lấy được vào DataSet
            da.Fill(ds);
            return ds;
        }

    }
}
