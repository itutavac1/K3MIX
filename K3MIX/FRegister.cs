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
    public partial class FRegister : Form, IForm
    {
        CLogic Logic;

        public FRegister()
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CGlobals.Form.FinishDialog();
            CGlobals.SetUp(State.Login, ref CGlobals.Form);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
