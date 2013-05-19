namespace K3MIX
{
    partial class FTrack : IForm
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

        #region User created code

        CLogic Logic;

        #region Interface implementation

        void IForm.DisplayForm()
        {
            this.ShowDialog();
        }

        bool IForm.SetLogic(CLogic tempLogic)
        {
            if (tempLogic == null)
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Name = "FTrack";
            this.Text = "Track";
            this.ResumeLayout(false);

        }

        #endregion
    }
}