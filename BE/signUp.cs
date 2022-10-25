using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using GiaoDien.BE.BS_Layer;

namespace GiaoDien.BE
{
    internal class signUp
    {
        string quyen;
        public int bROLE(string TaiKhoan, string MatKhau, bool Admin, bool Staff, ref string err)
        {
            if (Admin == true && Staff == true || Admin == false && Staff == false)
                return -1;
            else if (Admin == true)
                quyen = "Quản lý";
            else if (Staff == true)
                quyen = "Nhân viên";
            BLSignIn blLogin = new BLSignIn();
            DataSet ds = blLogin.DangNhap(TaiKhoan, MatKhau, quyen, ref err);
            DataTable dt = ds.Tables[0];
            int ketqua = Int32.Parse(dt.Rows[0][0].ToString());
            return ketqua;
        }
    }
}
