using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herba
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (upiti.ProvjeriLogin(txtUsername.Text, txtPassword.Text))
            {
                frmMain mainfrm = new frmMain();
                this.Hide();
                mainfrm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Krivi podaci za login");
            }


        }
    }
}
