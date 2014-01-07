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
    public partial class frmPopisMjera : Form
    {
        private string id;
        public frmPopisMjera(string id)
        {
            InitializeComponent();
            this.CenterToParent();
            this.id = id;
            DohvatiMjere();
        }

        private void DohvatiMjere()
        {
            NpgsqlDataReader dr = upiti.DohvatiSveMjereKorisnika(id);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dataGridView1.DataSource = dt;
           
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
           DialogResult d = MessageBox.Show("Jeste li sigurni da želite obrisati odabrane mjere za korisnika?","Brisanje mjera",MessageBoxButtons.YesNo);
           if (d == DialogResult.Yes)
           {
               try
               {
                   upiti.BrisiMjeru(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                   MessageBox.Show("Uspjesno obrisana mjera!");
                   DohvatiMjere();
               }

               catch
               {
                   MessageBox.Show("Nije uspješno obrisana mjera!");
               }
           }
           else
           { 
           
           }
        }
    }
}
