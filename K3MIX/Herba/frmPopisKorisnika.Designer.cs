namespace Herba
{
    partial class frmPopisKorisnika
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.txtStruk = new System.Windows.Forms.TextBox();
            this.txtMetabolicka = new System.Windows.Forms.TextBox();
            this.txtUdioMasti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpMjere = new System.Windows.Forms.GroupBox();
            this.btnPotvrdiMjere = new System.Windows.Forms.Button();
            this.btnPopisMjera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpMjere.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtTezina
            // 
            this.txtTezina.Location = new System.Drawing.Point(47, 32);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(100, 20);
            this.txtTezina.TabIndex = 3;
            // 
            // txtStruk
            // 
            this.txtStruk.Location = new System.Drawing.Point(47, 157);
            this.txtStruk.Name = "txtStruk";
            this.txtStruk.Size = new System.Drawing.Size(100, 20);
            this.txtStruk.TabIndex = 4;
            // 
            // txtMetabolicka
            // 
            this.txtMetabolicka.Location = new System.Drawing.Point(47, 116);
            this.txtMetabolicka.Name = "txtMetabolicka";
            this.txtMetabolicka.Size = new System.Drawing.Size(100, 20);
            this.txtMetabolicka.TabIndex = 5;
            // 
            // txtUdioMasti
            // 
            this.txtUdioMasti.Location = new System.Drawing.Point(47, 74);
            this.txtUdioMasti.Name = "txtUdioMasti";
            this.txtUdioMasti.Size = new System.Drawing.Size(100, 20);
            this.txtUdioMasti.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Težina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Udio masti";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Metablolička dob";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Struk";
            // 
            // grpMjere
            // 
            this.grpMjere.Controls.Add(this.btnPotvrdiMjere);
            this.grpMjere.Controls.Add(this.txtTezina);
            this.grpMjere.Controls.Add(this.label4);
            this.grpMjere.Controls.Add(this.txtStruk);
            this.grpMjere.Controls.Add(this.label3);
            this.grpMjere.Controls.Add(this.txtMetabolicka);
            this.grpMjere.Controls.Add(this.label2);
            this.grpMjere.Controls.Add(this.txtUdioMasti);
            this.grpMjere.Controls.Add(this.label1);
            this.grpMjere.Location = new System.Drawing.Point(44, 23);
            this.grpMjere.Name = "grpMjere";
            this.grpMjere.Size = new System.Drawing.Size(208, 232);
            this.grpMjere.TabIndex = 11;
            this.grpMjere.TabStop = false;
            this.grpMjere.Text = "Mjere korisnika";
            // 
            // btnPotvrdiMjere
            // 
            this.btnPotvrdiMjere.Location = new System.Drawing.Point(58, 194);
            this.btnPotvrdiMjere.Name = "btnPotvrdiMjere";
            this.btnPotvrdiMjere.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdiMjere.TabIndex = 11;
            this.btnPotvrdiMjere.Text = "Potvrdi";
            this.btnPotvrdiMjere.UseVisualStyleBackColor = true;
            this.btnPotvrdiMjere.Click += new System.EventHandler(this.btnPotvrdiMjere_Click);
            // 
            // btnPopisMjera
            // 
            this.btnPopisMjera.Location = new System.Drawing.Point(44, 290);
            this.btnPopisMjera.Name = "btnPopisMjera";
            this.btnPopisMjera.Size = new System.Drawing.Size(94, 23);
            this.btnPopisMjera.TabIndex = 12;
            this.btnPopisMjera.Text = "Popis svih mjera";
            this.btnPopisMjera.UseVisualStyleBackColor = true;
            this.btnPopisMjera.Click += new System.EventHandler(this.btnPopisMjera_Click);
            // 
            // frmPopisKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 448);
            this.Controls.Add(this.btnPopisMjera);
            this.Controls.Add(this.grpMjere);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPopisKorisnika";
            this.Text = "frmPopisKorisnika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpMjere.ResumeLayout(false);
            this.grpMjere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.TextBox txtStruk;
        private System.Windows.Forms.TextBox txtMetabolicka;
        private System.Windows.Forms.TextBox txtUdioMasti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpMjere;
        private System.Windows.Forms.Button btnPotvrdiMjere;
        private System.Windows.Forms.Button btnPopisMjera;
    }
}