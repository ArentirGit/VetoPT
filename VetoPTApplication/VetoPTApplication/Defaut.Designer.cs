namespace VetoPTApplication
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAnimauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherDossiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherTraitementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterTraitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rédigerOrdonnanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gestionDesSoinsToolStripMenuItem,
            this.gestionStockToolStripMenuItem,
            this.venteToolStripMenuItem,
            this.gestionSalariésToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(125, 342);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionUtilisateursToolStripMenuItem
            // 
            this.gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            this.gestionUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(112, 19);
            this.gestionUtilisateursToolStripMenuItem.Text = "Gestion utilisateurs";
            // 
            // gestionClientsToolStripMenuItem
            // 
            this.gestionClientsToolStripMenuItem.Name = "gestionClientsToolStripMenuItem";
            this.gestionClientsToolStripMenuItem.Size = new System.Drawing.Size(112, 19);
            this.gestionClientsToolStripMenuItem.Text = "Gestion clients";
            // 
            // gestionAnimauxToolStripMenuItem
            // 
            this.gestionAnimauxToolStripMenuItem.Name = "gestionAnimauxToolStripMenuItem";
            this.gestionAnimauxToolStripMenuItem.Size = new System.Drawing.Size(112, 19);
            this.gestionAnimauxToolStripMenuItem.Text = "Gestion animaux";
            // 
            // gestionDesSoinsToolStripMenuItem
            // 
            this.gestionDesSoinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suiviPatientToolStripMenuItem,
            this.afficherDossiersToolStripMenuItem,
            this.nouveauDossierToolStripMenuItem,
            this.afficherTraitementsToolStripMenuItem,
            this.ajouterTraitementToolStripMenuItem,
            this.rédigerOrdonnanceToolStripMenuItem,
            this.imprimerToolStripMenuItem});
            this.gestionDesSoinsToolStripMenuItem.Name = "gestionDesSoinsToolStripMenuItem";
            this.gestionDesSoinsToolStripMenuItem.Size = new System.Drawing.Size(112, 19);
            this.gestionDesSoinsToolStripMenuItem.Text = "Gestion soins";
            // 
            // suiviPatientToolStripMenuItem
            // 
            this.suiviPatientToolStripMenuItem.Name = "suiviPatientToolStripMenuItem";
            this.suiviPatientToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.suiviPatientToolStripMenuItem.Text = "Suivi patient";
            // 
            // afficherDossiersToolStripMenuItem
            // 
            this.afficherDossiersToolStripMenuItem.Name = "afficherDossiersToolStripMenuItem";
            this.afficherDossiersToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.afficherDossiersToolStripMenuItem.Text = "Afficher dossiers";
            // 
            // nouveauDossierToolStripMenuItem
            // 
            this.nouveauDossierToolStripMenuItem.Name = "nouveauDossierToolStripMenuItem";
            this.nouveauDossierToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.nouveauDossierToolStripMenuItem.Text = "Nouveau dossier";
            // 
            // afficherTraitementsToolStripMenuItem
            // 
            this.afficherTraitementsToolStripMenuItem.Name = "afficherTraitementsToolStripMenuItem";
            this.afficherTraitementsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.afficherTraitementsToolStripMenuItem.Text = "Afficher traitements";
            // 
            // ajouterTraitementToolStripMenuItem
            // 
            this.ajouterTraitementToolStripMenuItem.Name = "ajouterTraitementToolStripMenuItem";
            this.ajouterTraitementToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ajouterTraitementToolStripMenuItem.Text = "Ajouter traitement";
            // 
            // rédigerOrdonnanceToolStripMenuItem
            // 
            this.rédigerOrdonnanceToolStripMenuItem.Name = "rédigerOrdonnanceToolStripMenuItem";
            this.rédigerOrdonnanceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.rédigerOrdonnanceToolStripMenuItem.Text = "Rédiger ordonnance";
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // gestionStockToolStripMenuItem
            // 
            this.gestionStockToolStripMenuItem.Name = "gestionStockToolStripMenuItem";
            this.gestionStockToolStripMenuItem.Size = new System.Drawing.Size(112, 19);
            this.gestionStockToolStripMenuItem.Text = "Gestion stock";
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(112, 19);
            this.venteToolStripMenuItem.Text = "Vente";
            // 
            // gestionSalariésToolStripMenuItem
            // 
            this.gestionSalariésToolStripMenuItem.Name = "gestionSalariésToolStripMenuItem";
            this.gestionSalariésToolStripMenuItem.Size = new System.Drawing.Size(112, 19);
            this.gestionSalariésToolStripMenuItem.Text = "Gestion salariés";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 342);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ToolStripMenuItem gestionDesSoinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauDossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSalariésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiviPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherDossiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherTraitementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterTraitementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rédigerOrdonnanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;



    }
}

