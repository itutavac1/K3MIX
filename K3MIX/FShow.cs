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
    public partial class FShow : Form
    {
        CLogic Logic;

        public FShow()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CGlobals.Form.FinishDialog();
            CGlobals.SetUp(State.Menu, ref CGlobals.Form);
        }
    }
}
