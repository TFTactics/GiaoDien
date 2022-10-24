using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using GiaoDien.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.FE
{
    public partial class homePage : DevExpress.XtraEditors.XtraForm
    {
        //Khoi Tao UserControl
        UCDashBoard dash = new UCDashBoard();
        UCEmployees employee = new UCEmployees();
        UCProduct product = new UCProduct();
        UCSales sales = new UCSales();
        EditEmployee ep = new EditEmployee();
        public homePage()
        {
            InitializeComponent();
            LoadUC();
        }

        //Load UserControl
        public void LoadUC()
        {
            pnlMain.Controls.Add(dash);
            pnlMain.Controls.Add(employee);
            pnlMain.Controls.Add(sales);
            pnlMain.Controls.Add(product);
            pnlMain.Controls.Add(ep);
            dash.Dock = DockStyle.Fill;
            employee.Dock = DockStyle.Fill;
            sales.Dock = DockStyle.Fill;
            product.Dock = DockStyle.Fill;
            ep.Dock = DockStyle.Fill;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dash.BringToFront();
        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            employee.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            product.BringToFront();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            sales.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}