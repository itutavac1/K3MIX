namespace Herba
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promijeniOsobnePodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.postavkeToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popisKorisnikaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("korisniciToolStripMenuItem.Image")));
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // popisKorisnikaToolStripMenuItem
            // 
            this.popisKorisnikaToolStripMenuItem.Name = "popisKorisnikaToolStripMenuItem";
            this.popisKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.popisKorisnikaToolStripMenuItem.Text = "Popis korisnika";
            this.popisKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.popisKorisnikaToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popisProizvodaToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proizvodiToolStripMenuItem.Image")));
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(134, 34);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // popisProizvodaToolStripMenuItem
            // 
            this.popisProizvodaToolStripMenuItem.Name = "popisProizvodaToolStripMenuItem";
            this.popisProizvodaToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.popisProizvodaToolStripMenuItem.Text = "Popis proizvoda";
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promijeniOsobnePodatkeToolStripMenuItem});
            this.postavkeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("postavkeToolStripMenuItem.Image")));
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.postavkeToolStripMenuItem.Text = "Postavke";
            // 
            // promijeniOsobnePodatkeToolStripMenuItem
            // 
            this.promijeniOsobnePodatkeToolStripMenuItem.Name = "promijeniOsobnePodatkeToolStripMenuItem";
            this.promijeniOsobnePodatkeToolStripMenuItem.Size = new System.Drawing.Size(346, 34);
            this.promijeniOsobnePodatkeToolStripMenuItem.Text = "Promijeni osobne podatke";
            this.promijeniOsobnePodatkeToolStripMenuItem.Click += new System.EventHandler(this.promijeniOsobnePodatkeToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izlazToolStripMenuItem.Image")));
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1095, 564);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promijeniOsobnePodatkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}