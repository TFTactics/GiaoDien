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
    public partial class Employee : Form
    {
        EditEmployee ep = new EditEmployee();
        public Employee()
        {
            InitializeComponent();
            pnlMain.Controls.Add(ep);
            ep.Dock = DockStyle.Fill;
        }
    }
}
