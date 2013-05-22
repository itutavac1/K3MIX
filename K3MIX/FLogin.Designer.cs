namespace K3MIX
{
    partial class FLogin : IForm
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
            this.btnSupervizor = new System.Windows.Forms.Button();
            this.btnVisiSavjetnik = new System.Windows.Forms.Button();
            this.btnDistributer = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSupervizor
            // 
            this.btnSupervizor.Location = new System.Drawing.Point(108, 137);
            this.btnSupervizor.Name = "btnSupervizor";
            this.btnSupervizor.Size = new System.Drawing.Size(75, 23);
            this.btnSupervizor.TabIndex = 0;
            this.btnSupervizor.Text = "Supervizor";
            this.btnSupervizor.UseVisualStyleBackColor = true;
            // 
            // btnVisiSavjetnik
            // 
            this.btnVisiSavjetnik.Location = new System.Drawing.Point(235, 137);
            this.btnVisiSavjetnik.Name = "btnVisiSavjetnik";
            this.btnVisiSavjetnik.Size = new System.Drawing.Size(93, 23);
            this.btnVisiSavjetnik.TabIndex = 1;
            this.btnVisiSavjetnik.Text = "Viši savjetnik";
            this.btnVisiSavjetnik.UseVisualStyleBackColor = true;
            // 
            // btnDistributer
            // 
            this.btnDistributer.Location = new System.Drawing.Point(391, 137);
            this.btnDistributer.Name = "btnDistributer";
            this.btnDistributer.Size = new System.Drawing.Size(75, 23);
            this.btnDistributer.TabIndex = 2;
            this.btnDistributer.Text = "Distributer";
            this.btnDistributer.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(216, 219);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(216, 266);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(128, 20);
            this.txtPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pin";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(235, 70);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(108, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Izgasi aplikaciju";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDistributer);
            this.Controls.Add(this.btnVisiSavjetnik);
            this.Controls.Add(this.btnSupervizor);
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupervizor;
        private System.Windows.Forms.Button btnVisiSavjetnik;
        private System.Windows.Forms.Button btnDistributer;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}