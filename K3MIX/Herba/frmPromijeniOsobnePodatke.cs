using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Herba
{
    public partial class frmPromijeniOsobnePodatke : Form
    {
        public frmPromijeniOsobnePodatke()
        {
            InitializeComponent();
            this.CenterToParent();
            NpgsqlDataReader dr = upiti.DohvatiOsobnePodatke();
            while (dr.Read())
            {

                txtIme.Text = dr[1].ToString();
                txtPrezime.Text = dr[2].ToString();
                txtEmail.Text = dr[3].ToString();
                txtTelefon.Text = dr[4].ToString();
                txtUsername.Text = dr[6].ToString();
                txtPassword.Text = dr[7].ToString();


            }
            dr.Close();
            dr.Dispose();
        }

        private void frmPromijeniOsobnePodatke_Load(object sender, EventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            upiti.AzurirajOsobnePodatke(txtIme.Text, txtPrezime.Text, txtEmail.Text, txtTelefon.Text, txtUsername.Text, txtPassword.Text);
            MessageBox.Show("Podatci uspjesno azurirani!");
            this.Close();
        }
    }
}
