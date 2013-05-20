﻿using System;
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
    public partial class FLogin : Form
    {
        CLogic Logic;

        public FLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            Logic.SignUp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
