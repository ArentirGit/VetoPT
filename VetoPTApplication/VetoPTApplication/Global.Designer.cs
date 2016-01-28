namespace VetoPTApplication
{
    partial class Global
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAnimauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionsDuStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUtilisateursToolStripMenuItem,
            this.gestionClientsToolStripMenuItem,
            this.gestionAnimauxToolStripMenuItem,
            this.gestionSoinsToolStripMenuItem,
            this.gestionsDuStockToolStripMenuItem,
            this.venteToolStripMenuItem,
            this.gestionSalariésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(146, 462);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionUtilisateursToolStripMenuItem
            // 
            this.gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            this.gestionUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            // 
            // gestionClientsToolStripMenuItem
            // 
            this.gestionClientsToolStripMenuItem.Name = "gestionClientsToolStripMenuItem";
            this.gestionClientsToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionClientsToolStripMenuItem.Text = "Gestion des clients";
            // 
            // gestionAnimauxToolStripMenuItem
            // 
            this.gestionAnimauxToolStripMenuItem.Name = "gestionAnimauxToolStripMenuItem";
            this.gestionAnimauxToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionAnimauxToolStripMenuItem.Text = "Gestion des animaux";
            // 
            // gestionSoinsToolStripMenuItem
            // 
            this.gestionSoinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauDossierToolStripMenuItem});
            this.gestionSoinsToolStripMenuItem.Name = "gestionSoinsToolStripMenuItem";
            this.gestionSoinsToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionSoinsToolStripMenuItem.Text = "Gestion des soins";
            // 
            // nouveauDossierToolStripMenuItem
            // 
            this.nouveauDossierToolStripMenuItem.Name = "nouveauDossierToolStripMenuItem";
            this.nouveauDossierToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nouveauDossierToolStripMenuItem.Text = "Nouveau dossier";
            this.nouveauDossierToolStripMenuItem.Click += new System.EventHandler(this.nouveauDossierToolStripMenuItem_Click);
            // 
            // gestionsDuStockToolStripMenuItem
            // 
            this.gestionsDuStockToolStripMenuItem.Name = "gestionsDuStockToolStripMenuItem";
            this.gestionsDuStockToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionsDuStockToolStripMenuItem.Text = "Gestions du stock";
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.venteToolStripMenuItem.Text = "Vente";
            // 
            // gestionSalariésToolStripMenuItem
            // 
            this.gestionSalariésToolStripMenuItem.Name = "gestionSalariésToolStripMenuItem";
            this.gestionSalariésToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionSalariésToolStripMenuItem.Text = "Gestion salariés";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 462);
            this.panel1.TabIndex = 2;
            // 
            // Global
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Global";
            this.Text = "Veto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAnimauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSoinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionsDuStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSalariésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauDossierToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}