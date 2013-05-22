using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K3MIX
{
    public partial class FMenu : Form
    {
        CLogic Logic;

        public FMenu()
        {
            InitializeComponent();
        }

        #region Interface implementation

        void IForm.DisplayForm()
        {
            this.Show();
        }

        bool IForm.SetLogic(CLogic Logic)
        {
            if (Logic == null)
                return false;
            this.Logic = Logic;
            return true;
        }

        void IForm.FinishDialog()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        void IForm.ContinueDialog()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.None;
        }

        #endregion Interface implementation

        private void btnShowClients_Click(object sender, EventArgs e)
        {
            CGlobals.Form.FinishDialog();
            CGlobals.SetUp(State.Show, ref CGlobals.Form);
        }

        private void btnPriceList_Click(object sender, EventArgs e)
        {
            CGlobals.Form.FinishDialog();
            CGlobals.SetUp(State.PriceList, ref CGlobals.Form);
        }

        private void btnTrackClients_Click(object sender, EventArgs e)
        {
            CGlobals.Form.FinishDialog();
            CGlobals.SetUp(State.Track, ref CGlobals.Form);
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            CGlobals.Form.FinishDialog();
            CGlobals.SetUp(State.Input, ref CGlobals.Form); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
