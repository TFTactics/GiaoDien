using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using GiaoDien.BE.DB_Layer;

namespace GiaoDien.BE.BS_Layer
{
    class BLEmployee
    {
        DBMain db = null;
        public BLEmployee()
        {
            db = new DBMain();
        }

        public DataSet LoadEmployee(ref string err)
        {
            return db.GoiThuTucOrHam("dbo.p_LoadNhanVien", CommandType.StoredProcedure, ref err);
        }
    }
}
