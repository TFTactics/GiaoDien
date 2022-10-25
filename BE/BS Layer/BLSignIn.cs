using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using GiaoDien.BE.DB_Layer;

namespace GiaoDien.BE.BS_Layer
{
    class BLSignIn
    {
        DBMain db = null;
        public BLSignIn()
        {
            db = new DBMain();
        }

        public DataSet DangNhap(string TaiKhoan, string MatKhau, string Quyen, ref string err)
        {
            return db.GoiThuTucOrHam("select dbo.f_DangNhap(@taikhoan, @matkhau, @quyen)", CommandType.Text, ref err,
                new SqlParameter("@taikhoan", TaiKhoan),
                new SqlParameter("@matkhau", MatKhau),
                new SqlParameter("@quyen", Quyen));
        }
    }
}
