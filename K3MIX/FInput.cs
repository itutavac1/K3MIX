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
    public partial class FInput : Form, IForm
    {
        CLogic Logic;

        public FInput()
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CGlobals.Form.FinishDialog();
            CGlobals.SetUp(State.Menu, ref CGlobals.Form);
        }
    }
}
