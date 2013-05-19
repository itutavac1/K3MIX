namespace K3MIX
{
    partial class FTemp : IForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "FormTemp";
        }

        #endregion

        #region User created code

        CLogic Logic;

        #region Interface implementation

        void IForm.DisplayForm()
        {
            this.ShowDialog();
        }

        bool IForm.SetLogic(CLogic tempLogic)
        {
            if (Logic == null)
                return false;
            Logic = tempLogic;
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




        #endregion User created code

    }
}