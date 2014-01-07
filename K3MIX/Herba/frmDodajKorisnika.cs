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
    public partial class frmDodajKorisnika : Form
    {
        public frmDodajKorisnika()
        {
            InitializeComponent();
            this.CenterToParent();
        }


        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            upiti.DodajKorisnika(txtIme.Text, txtPrezime.Text, txtEmail.Text, txtTelefon.Text, txtUsername.Text, txtPassword.Text);
            MessageBox.Show("Uspjesno je dodan novi korisnik!");
            this.Close();
        }
    }
}
