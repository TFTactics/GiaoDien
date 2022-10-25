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
        string err;
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
            int check = role.bROLE(txtUser.Text.Trim(), txtPass.Text.Trim(), ceADMIN.Checked, ceMANAGER.Checked, ref err);

            if (check == -1)
                MessageBox.Show("Chỉ được chọn 1 trong 2 quyền!");
            else if (check == 1)
            {
                this.Hide();
                homePage hp = new homePage();
                hp.ShowDialog();
            }
            else if (check == 2)
            {
                this.Hide();
                homePage hp = new homePage();
                hp.ShowDialog();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}