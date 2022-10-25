using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using GiaoDien.FE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using GiaoDien.BE.BS_Layer;

namespace GiaoDien.UC
{
    public partial class UCEmployees : DevExpress.XtraEditors.XtraUserControl
    {
        Employee ep = new Employee();
        string err;
        public UCEmployees()
        {
            InitializeComponent();
            gridControl.DataSource = GetDataSource();
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
            if (e.Button.Properties.Caption == "New" || e.Button.Properties.Caption == "Edit") ep.ShowDialog();
        }
        public BindingList<Customer> GetDataSource()
        {
            BLEmployee bLEmployee = new BLEmployee();
            DataSet ds = new DataSet();
            DataTable dtEmployee = new DataTable();

            ds = bLEmployee.LoadEmployee(ref err);
            dtEmployee = ds.Tables[0];

            BindingList<Customer> result = new BindingList<Customer>();

            string[] TempArr = new string[20];
            int n = 0;

            for (int i = 0; i < dtEmployee.Rows.Count; i++)
            {
                for (int j = 0; j < dtEmployee.Columns.Count; j++)
                {
                    object o = dtEmployee.Rows[i].ItemArray[j];
                    //if you want to get the string
                    TempArr[n] = (string)(o = dtEmployee.Rows[i].ItemArray[j].ToString());
                    n++;
                }
                result.Add(new Customer()
                {
                    MaNV = TempArr[0],
                    HoTen = TempArr[1],
                    DiaChi = TempArr[2],
                    SDT = TempArr[3],
                    NgayVaoLam = TempArr[4],
                    SoNgayLam = TempArr[5],
                    GioiTinh = TempArr[6],
                    NgaySinh = TempArr[7],
                    ChucVu = TempArr[8]
                });
                n = 0;
            }
            return result;
        }

        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public string MaNV { get; set; }
            [Required]
            public string HoTen { get; set; }
            public string DiaChi { get; set; }
            public string SDT { get; set; }
            public string NgayVaoLam { get; set; }
            public string SoNgayLam { get; set; }
            public string GioiTinh { get; set; }
            public string NgaySinh { get; set; }
            public string ChucVu { get; set; }
        }
    }
}
