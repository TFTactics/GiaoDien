using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GiaoDien.BE;
namespace GiaoDien.FE
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            signUp role = new signUp();
            if (role.bROLE(ceADMIN.Checked, ceMANAGER.Checked))
            {
                this.Hide();
                homePage hp = new homePage();
                hp.ShowDialog();
            }
        }
    }
}