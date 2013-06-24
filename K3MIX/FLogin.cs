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
    public partial class FLogin : Form, IForm
    {
        CLogic Logic;

        public FLogin()
        {
            InitializeComponent();
        }

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

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            Logic.SignUp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CGlobals.Form.FinishDialog();
            CGlobals.SetUp(State.Register, ref CGlobals.Form);
        }
    }
}
