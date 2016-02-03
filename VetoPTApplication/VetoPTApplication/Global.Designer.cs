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
            this.afficherAnimauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherRappelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterRappelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneEspèceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionsDuStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.suiviPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherDossiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherTraitementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rédigerOrdonnanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gestionAnimauxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherAnimauxToolStripMenuItem,
            this.afficherRappelToolStripMenuItem,
            this.ajouterAnimalToolStripMenuItem,
            this.ajouterRappelToolStripMenuItem,
            this.ajouterUneRaceToolStripMenuItem,
            this.ajouterUneEspèceToolStripMenuItem});
            this.gestionAnimauxToolStripMenuItem.Name = "gestionAnimauxToolStripMenuItem";
            this.gestionAnimauxToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionAnimauxToolStripMenuItem.Text = "Gestion des animaux";
            this.gestionAnimauxToolStripMenuItem.Click += new System.EventHandler(this.gestionAnimauxToolStripMenuItem_Click);
            // 
            // afficherAnimauxToolStripMenuItem
            // 
            this.afficherAnimauxToolStripMenuItem.Name = "afficherAnimauxToolStripMenuItem";
            this.afficherAnimauxToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.afficherAnimauxToolStripMenuItem.Text = "Afficher animaux";
            // 
            // afficherRappelToolStripMenuItem
            // 
            this.afficherRappelToolStripMenuItem.Name = "afficherRappelToolStripMenuItem";
            this.afficherRappelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.afficherRappelToolStripMenuItem.Text = "Afficher rappel";
            // 
            // ajouterAnimalToolStripMenuItem
            // 
            this.ajouterAnimalToolStripMenuItem.Name = "ajouterAnimalToolStripMenuItem";
            this.ajouterAnimalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterAnimalToolStripMenuItem.Text = "Ajouter animal";
            // 
            // ajouterRappelToolStripMenuItem
            // 
            this.ajouterRappelToolStripMenuItem.Name = "ajouterRappelToolStripMenuItem";
            this.ajouterRappelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterRappelToolStripMenuItem.Text = "Ajouter rappel";
            // 
            // ajouterUneRaceToolStripMenuItem
            // 
            this.ajouterUneRaceToolStripMenuItem.Name = "ajouterUneRaceToolStripMenuItem";
            this.ajouterUneRaceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterUneRaceToolStripMenuItem.Text = "Ajouter une race";
            // 
            // ajouterUneEspèceToolStripMenuItem
            // 
            this.ajouterUneEspèceToolStripMenuItem.Name = "ajouterUneEspèceToolStripMenuItem";
            this.ajouterUneEspèceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterUneEspèceToolStripMenuItem.Text = "Ajouter une espèce";
            // 
            // gestionSoinsToolStripMenuItem
            // 
            this.gestionSoinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suiviPatientToolStripMenuItem,
            this.afficherDossiersToolStripMenuItem,
            this.nouveauDossierToolStripMenuItem,
            this.afficherTraitementsToolStripMenuItem,
            this.rédigerOrdonnanceToolStripMenuItem,
            this.imprimerToolStripMenuItem});
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
            // suiviPatientToolStripMenuItem
            // 
            this.suiviPatientToolStripMenuItem.Name = "suiviPatientToolStripMenuItem";
            this.suiviPatientToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.suiviPatientToolStripMenuItem.Text = "Suivi patient";
            this.suiviPatientToolStripMenuItem.Click += new System.EventHandler(this.suiviPatientToolStripMenuItem_Click);
            // 
            // afficherDossiersToolStripMenuItem
            // 
            this.afficherDossiersToolStripMenuItem.Name = "afficherDossiersToolStripMenuItem";
            this.afficherDossiersToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.afficherDossiersToolStripMenuItem.Text = "Afficher dossiers";
            this.afficherDossiersToolStripMenuItem.Click += new System.EventHandler(this.afficherDossiersToolStripMenuItem_Click);
            // 
            // afficherTraitementsToolStripMenuItem
            // 
            this.afficherTraitementsToolStripMenuItem.Name = "afficherTraitementsToolStripMenuItem";
            this.afficherTraitementsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.afficherTraitementsToolStripMenuItem.Text = "Afficher traitements";
            this.afficherTraitementsToolStripMenuItem.Click += new System.EventHandler(this.afficherTraitementsToolStripMenuItem_Click);
            // 
            // rédigerOrdonnanceToolStripMenuItem
            // 
            this.rédigerOrdonnanceToolStripMenuItem.Name = "rédigerOrdonnanceToolStripMenuItem";
            this.rédigerOrdonnanceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.rédigerOrdonnanceToolStripMenuItem.Text = "Rédiger ordonnance";
            this.rédigerOrdonnanceToolStripMenuItem.Click += new System.EventHandler(this.rédigerOrdonnanceToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem afficherAnimauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherRappelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterRappelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneEspèceToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem suiviPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherDossiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherTraitementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rédigerOrdonnanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
    }
}