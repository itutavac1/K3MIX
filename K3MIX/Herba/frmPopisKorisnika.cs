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
    public partial class frmPopisKorisnika : Form
    {
        private string id;
        public frmPopisKorisnika()
        {
            InitializeComponent();
            NpgsqlDataReader dr= upiti.DohvatiSveKorisnike();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dataGridView1.DataSource = dt;
        }

        

        private void btnPotvrdiMjere_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                int redak = dataGridView1.CurrentCell.RowIndex;
                upiti.DodajMjere(dataGridView1.Rows[redak].Cells[0].Value.ToString(), txtTezina.Text, txtUdioMasti.Text, txtMetabolicka.Text, txtStruk.Text);
                MessageBox.Show("Uspjesno dodane mjere!");
            }
            else
            {
                upiti.AzurirajMjere(id, txtTezina.Text, txtUdioMasti.Text, txtMetabolicka.Text, txtStruk.Text);
                MessageBox.Show("Uspjesno azurirane promijene!");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Dohvati_mjere();
        }

        private void Dohvati_mjere()
        {
            txtMetabolicka.Text = "";
            txtStruk.Text = "";
            txtTezina.Text = "";
            txtUdioMasti.Text = "";
            grpMjere.Text = "Mjere korisnika -> Ne postoje za ovaj mjesec!";

            try
            {
                btnPotvrdiMjere.Enabled = true;

                int redak = dataGridView1.CurrentCell.RowIndex;
                NpgsqlDataReader dr = upiti.DohvatiMjereKorisnika(dataGridView1.Rows[redak].Cells[0].Value.ToString());
                bool postoji = false;

                while (dr.Read())
                {
                    grpMjere.Text = "Mjere korisnika -> Postoje za ovaj mjesec!";
                    id = dr[0].ToString();
                    txtTezina.Text = dr[2].ToString();
                    txtStruk.Text = dr[5].ToString();
                    txtMetabolicka.Text = dr[4].ToString();
                    txtUdioMasti.Text = dr[3].ToString();
                    postoji = true;
                }
                dr.Close();
                dr.Dispose();
                if (!postoji)
                    id = null;
            }
            catch
            {

                btnPotvrdiMjere.Enabled = false;
            }
        }

        private void btnPopisMjera_Click(object sender, EventArgs e)
        {
            frmPopisMjera popismjera = new frmPopisMjera(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            popismjera.ShowDialog();
            Dohvati_mjere();
        }

 
    }
}
