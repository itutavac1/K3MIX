namespace K3MIX
{
    partial class FMenu : IForm
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
            this.Show();
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
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnTrackClients = new System.Windows.Forms.Button();
            this.btnShowClients = new System.Windows.Forms.Button();
            this.btnPriceList = new System.Windows.Forms.Button();
            this.btnShowPriceList = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(66, 70);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(132, 23);
            this.btnNewClient.TabIndex = 0;
            this.btnNewClient.Text = "Unos novog klijenta";
            this.btnNewClient.UseVisualStyleBackColor = true;
            // 
            // btnTrackClients
            // 
            this.btnTrackClients.Location = new System.Drawing.Point(66, 120);
            this.btnTrackClients.Name = "btnTrackClients";
            this.btnTrackClients.Size = new System.Drawing.Size(132, 23);
            this.btnTrackClients.TabIndex = 1;
            this.btnTrackClients.Text = "Praćenje klijenata";
            this.btnTrackClients.UseVisualStyleBackColor = true;
            // 
            // btnShowClients
            // 
            this.btnShowClients.Location = new System.Drawing.Point(66, 161);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(132, 23);
            this.btnShowClients.TabIndex = 2;
            this.btnShowClients.Text = "Ispis klijenata";
            this.btnShowClients.UseVisualStyleBackColor = true;
            // 
            // btnPriceList
            // 
            this.btnPriceList.Location = new System.Drawing.Point(66, 208);
            this.btnPriceList.Name = "btnPriceList";
            this.btnPriceList.Size = new System.Drawing.Size(132, 23);
            this.btnPriceList.TabIndex = 3;
            this.btnPriceList.Text = "Cjenik proizvoda";
            this.btnPriceList.UseVisualStyleBackColor = true;
            // 
            // btnShowPriceList
            // 
            this.btnShowPriceList.Location = new System.Drawing.Point(66, 259);
            this.btnShowPriceList.Name = "btnShowPriceList";
            this.btnShowPriceList.Size = new System.Drawing.Size(132, 23);
            this.btnShowPriceList.TabIndex = 4;
            this.btnShowPriceList.Text = "Ispis cjenika";
            this.btnShowPriceList.UseVisualStyleBackColor = true;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(66, 309);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(132, 23);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Odjava";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(210, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Herbalife distribucija";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnShowPriceList);
            this.Controls.Add(this.btnPriceList);
            this.Controls.Add(this.btnShowClients);
            this.Controls.Add(this.btnTrackClients);
            this.Controls.Add(this.btnNewClient);
            this.Name = "FMenu";
            this.Text = "Izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnTrackClients;
        private System.Windows.Forms.Button btnShowClients;
        private System.Windows.Forms.Button btnPriceList;
        private System.Windows.Forms.Button btnShowPriceList;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label label1;
    }
}