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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajKorisnika dodajKorisnika = new frmDodajKorisnika();
            dodajKorisnika.ShowDialog();
        }

        private void popisKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPopisKorisnika popisKorisnika = new frmPopisKorisnika();
            popisKorisnika.ShowDialog();
        }

        private void promijeniOsobnePodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPromijeniOsobnePodatke osobniPodaci = new frmPromijeniOsobnePodatke();
            osobniPodaci.ShowDialog();
        }
    }
}
 