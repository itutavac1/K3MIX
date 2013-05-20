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
    public partial class Form1 : Form
    {
        bool started = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (started)
                return;
            this.Hide();
            CGlobals.SetUp(State.Login, ref CGlobals.Form);
            started = true;
        }
    }
}
