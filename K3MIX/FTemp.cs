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
    public partial class FTemp : Form, IForm
    {
        public FTemp()
        {
            InitializeComponent();
        }

        CLogic Logic;

        #region Interface implementation

        void IForm.DisplayForm()
        {
            this.ShowDialog();
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
        }

        void IForm.ContinueDialog()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.None;
        }

        #endregion Interface implementation
    }
}
