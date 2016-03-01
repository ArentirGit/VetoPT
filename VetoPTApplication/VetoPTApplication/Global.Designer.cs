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
            this.afficherUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterRendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierRendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerRendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherRendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAnimauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherAnimauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherRappelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterRappelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneEspèceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherDossiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherTraitementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterTraitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rédigerOrdonnanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionsDuStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierPrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vendreProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gestionUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherUtilisateursToolStripMenuItem,
            this.ajouterUtilisateurToolStripMenuItem});
            this.gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            this.gestionUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            this.gestionUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionUtilisateursToolStripMenuItem_Click);
            // 
            // afficherUtilisateursToolStripMenuItem
            // 
            this.afficherUtilisateursToolStripMenuItem.Name = "afficherUtilisateursToolStripMenuItem";
            this.afficherUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.afficherUtilisateursToolStripMenuItem.Text = "Afficher Utilisateurs";
            this.afficherUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.afficherUtilisateursToolStripMenuItem_Click);
            // 
            // ajouterUtilisateurToolStripMenuItem
            // 
            this.ajouterUtilisateurToolStripMenuItem.Name = "ajouterUtilisateurToolStripMenuItem";
            this.ajouterUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ajouterUtilisateurToolStripMenuItem.Text = "Ajouter Utilisateur";
            this.ajouterUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUtilisateurToolStripMenuItem_Click);
            // 
            // gestionClientsToolStripMenuItem
            // 
            this.gestionClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherClientsToolStripMenuItem,
            this.ajouterClientToolStripMenuItem,
            this.modifierClientToolStripMenuItem,
            this.supprimerClientToolStripMenuItem,
            this.ajouterRendezvousToolStripMenuItem,
            this.modifierRendezvousToolStripMenuItem,
            this.annulerRendezvousToolStripMenuItem,
            this.afficherRendezvousToolStripMenuItem});
            this.gestionClientsToolStripMenuItem.Name = "gestionClientsToolStripMenuItem";
            this.gestionClientsToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionClientsToolStripMenuItem.Text = "Gestion des clients";
            this.gestionClientsToolStripMenuItem.Click += new System.EventHandler(this.gestionClientsToolStripMenuItem_Click);
            // 
            // afficherClientsToolStripMenuItem
            // 
            this.afficherClientsToolStripMenuItem.Name = "afficherClientsToolStripMenuItem";
            this.afficherClientsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.afficherClientsToolStripMenuItem.Text = "Afficher clients";
            this.afficherClientsToolStripMenuItem.Click += new System.EventHandler(this.afficherClientsToolStripMenuItem_Click);
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter client";
            this.ajouterClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterClientToolStripMenuItem_Click);
            // 
            // modifierClientToolStripMenuItem
            // 
            this.modifierClientToolStripMenuItem.Name = "modifierClientToolStripMenuItem";
            this.modifierClientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modifierClientToolStripMenuItem.Text = "Modifier client";
            this.modifierClientToolStripMenuItem.Click += new System.EventHandler(this.modifierClientToolStripMenuItem_Click);
            // 
            // supprimerClientToolStripMenuItem
            // 
            this.supprimerClientToolStripMenuItem.Name = "supprimerClientToolStripMenuItem";
            this.supprimerClientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.supprimerClientToolStripMenuItem.Text = "Supprimer client";
            this.supprimerClientToolStripMenuItem.Click += new System.EventHandler(this.supprimerClientToolStripMenuItem_Click);
            // 
            // ajouterRendezvousToolStripMenuItem
            // 
            this.ajouterRendezvousToolStripMenuItem.Name = "ajouterRendezvousToolStripMenuItem";
            this.ajouterRendezvousToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterRendezvousToolStripMenuItem.Text = "Ajouter rendez-vous";
            this.ajouterRendezvousToolStripMenuItem.Click += new System.EventHandler(this.ajouterRendezvousToolStripMenuItem_Click);
            // 
            // modifierRendezvousToolStripMenuItem
            // 
            this.modifierRendezvousToolStripMenuItem.Name = "modifierRendezvousToolStripMenuItem";
            this.modifierRendezvousToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modifierRendezvousToolStripMenuItem.Text = "Modifier rendez-vous";
            this.modifierRendezvousToolStripMenuItem.Click += new System.EventHandler(this.modifierRendezvousToolStripMenuItem_Click);
            // 
            // annulerRendezvousToolStripMenuItem
            // 
            this.annulerRendezvousToolStripMenuItem.Name = "annulerRendezvousToolStripMenuItem";
            this.annulerRendezvousToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.annulerRendezvousToolStripMenuItem.Text = "Annuler rendez-vous";
            this.annulerRendezvousToolStripMenuItem.Click += new System.EventHandler(this.annulerRendezvousToolStripMenuItem_Click);
            // 
            // afficherRendezvousToolStripMenuItem
            // 
            this.afficherRendezvousToolStripMenuItem.Name = "afficherRendezvousToolStripMenuItem";
            this.afficherRendezvousToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.afficherRendezvousToolStripMenuItem.Text = "Afficher rendez-vous";
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
            this.afficherAnimauxToolStripMenuItem.Click += new System.EventHandler(this.afficherAnimauxToolStripMenuItem_Click);
            // 
            // afficherRappelToolStripMenuItem
            // 
            this.afficherRappelToolStripMenuItem.Name = "afficherRappelToolStripMenuItem";
            this.afficherRappelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.afficherRappelToolStripMenuItem.Text = "Afficher rappel";
            this.afficherRappelToolStripMenuItem.Click += new System.EventHandler(this.afficherRappelToolStripMenuItem_Click);
            // 
            // ajouterAnimalToolStripMenuItem
            // 
            this.ajouterAnimalToolStripMenuItem.Name = "ajouterAnimalToolStripMenuItem";
            this.ajouterAnimalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterAnimalToolStripMenuItem.Text = "Ajouter animal";
            this.ajouterAnimalToolStripMenuItem.Click += new System.EventHandler(this.ajouterAnimalToolStripMenuItem_Click);
            // 
            // ajouterRappelToolStripMenuItem
            // 
            this.ajouterRappelToolStripMenuItem.Name = "ajouterRappelToolStripMenuItem";
            this.ajouterRappelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterRappelToolStripMenuItem.Text = "Ajouter rappel";
            this.ajouterRappelToolStripMenuItem.Click += new System.EventHandler(this.ajouterRappelToolStripMenuItem_Click);
            // 
            // ajouterUneRaceToolStripMenuItem
            // 
            this.ajouterUneRaceToolStripMenuItem.Name = "ajouterUneRaceToolStripMenuItem";
            this.ajouterUneRaceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterUneRaceToolStripMenuItem.Text = "Ajouter une race";
            this.ajouterUneRaceToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneRaceToolStripMenuItem_Click);
            // 
            // ajouterUneEspèceToolStripMenuItem
            // 
            this.ajouterUneEspèceToolStripMenuItem.Name = "ajouterUneEspèceToolStripMenuItem";
            this.ajouterUneEspèceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterUneEspèceToolStripMenuItem.Text = "Ajouter une espèce";
            this.ajouterUneEspèceToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneEspèceToolStripMenuItem_Click);
            // 
            // gestionSoinsToolStripMenuItem
            // 
            this.gestionSoinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suiviPatientToolStripMenuItem,
            this.afficherDossiersToolStripMenuItem,
            this.nouveauDossierToolStripMenuItem,
            this.afficherTraitementsToolStripMenuItem,
            this.ajouterTraitementToolStripMenuItem,
            this.rédigerOrdonnanceToolStripMenuItem,
            this.imprimerToolStripMenuItem});
            this.gestionSoinsToolStripMenuItem.Name = "gestionSoinsToolStripMenuItem";
            this.gestionSoinsToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionSoinsToolStripMenuItem.Text = "Gestion des soins";
            this.gestionSoinsToolStripMenuItem.Click += new System.EventHandler(this.gestionSoinsToolStripMenuItem_Click);
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
            // nouveauDossierToolStripMenuItem
            // 
            this.nouveauDossierToolStripMenuItem.Name = "nouveauDossierToolStripMenuItem";
            this.nouveauDossierToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.nouveauDossierToolStripMenuItem.Text = "Nouveau dossier";
            this.nouveauDossierToolStripMenuItem.Click += new System.EventHandler(this.nouveauDossierToolStripMenuItem_Click);
            // 
            // afficherTraitementsToolStripMenuItem
            // 
            this.afficherTraitementsToolStripMenuItem.Name = "afficherTraitementsToolStripMenuItem";
            this.afficherTraitementsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.afficherTraitementsToolStripMenuItem.Text = "Afficher traitements";
            this.afficherTraitementsToolStripMenuItem.Click += new System.EventHandler(this.afficherTraitementsToolStripMenuItem_Click);
            // 
            // ajouterTraitementToolStripMenuItem
            // 
            this.ajouterTraitementToolStripMenuItem.Name = "ajouterTraitementToolStripMenuItem";
            this.ajouterTraitementToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ajouterTraitementToolStripMenuItem.Text = "Ajouter traitement";
            this.ajouterTraitementToolStripMenuItem.Click += new System.EventHandler(this.ajouterTraitementToolStripMenuItem_Click);
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
            // gestionsDuStockToolStripMenuItem
            // 
            this.gestionsDuStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherStocksToolStripMenuItem,
            this.ajouterProduitToolStripMenuItem,
            this.supprimerProduitToolStripMenuItem,
            this.modifierPrixToolStripMenuItem});
            this.gestionsDuStockToolStripMenuItem.Name = "gestionsDuStockToolStripMenuItem";
            this.gestionsDuStockToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.gestionsDuStockToolStripMenuItem.Text = "Gestions du stock";
            this.gestionsDuStockToolStripMenuItem.Click += new System.EventHandler(this.gestionsDuStockToolStripMenuItem_Click);
            // 
            // afficherStocksToolStripMenuItem
            // 
            this.afficherStocksToolStripMenuItem.Name = "afficherStocksToolStripMenuItem";
            this.afficherStocksToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.afficherStocksToolStripMenuItem.Text = "Afficher stock";
            this.afficherStocksToolStripMenuItem.Click += new System.EventHandler(this.afficherStocksToolStripMenuItem_Click);
            // 
            // ajouterProduitToolStripMenuItem
            // 
            this.ajouterProduitToolStripMenuItem.Name = "ajouterProduitToolStripMenuItem";
            this.ajouterProduitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ajouterProduitToolStripMenuItem.Text = "Ajouter produit";
            this.ajouterProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterProduitToolStripMenuItem_Click);
            // 
            // supprimerProduitToolStripMenuItem
            // 
            this.supprimerProduitToolStripMenuItem.Name = "supprimerProduitToolStripMenuItem";
            this.supprimerProduitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.supprimerProduitToolStripMenuItem.Text = "Supprimer produit";
            this.supprimerProduitToolStripMenuItem.Click += new System.EventHandler(this.supprimerProduitToolStripMenuItem_Click);
            // 
            // modifierPrixToolStripMenuItem
            // 
            this.modifierPrixToolStripMenuItem.Name = "modifierPrixToolStripMenuItem";
            this.modifierPrixToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.modifierPrixToolStripMenuItem.Text = "Modifier prix";
            this.modifierPrixToolStripMenuItem.Click += new System.EventHandler(this.modifierPrixToolStripMenuItem_Click);
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendreProduitToolStripMenuItem,
            this.afficherFactureToolStripMenuItem,
            this.créerFactureToolStripMenuItem,
            this.imprimerFactureToolStripMenuItem});
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.venteToolStripMenuItem.Text = "Vente";
            this.venteToolStripMenuItem.Click += new System.EventHandler(this.venteToolStripMenuItem_Click);
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
            // vendreProduitToolStripMenuItem
            // 
            this.vendreProduitToolStripMenuItem.Name = "vendreProduitToolStripMenuItem";
            this.vendreProduitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.vendreProduitToolStripMenuItem.Text = "Vendre produit";
            this.vendreProduitToolStripMenuItem.Click += new System.EventHandler(this.vendreProduitToolStripMenuItem_Click);
            // 
            // afficherFactureToolStripMenuItem
            // 
            this.afficherFactureToolStripMenuItem.Name = "afficherFactureToolStripMenuItem";
            this.afficherFactureToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.afficherFactureToolStripMenuItem.Text = "Afficher facture";
            this.afficherFactureToolStripMenuItem.Click += new System.EventHandler(this.afficherFactureToolStripMenuItem_Click);
            // 
            // créerFactureToolStripMenuItem
            // 
            this.créerFactureToolStripMenuItem.Name = "créerFactureToolStripMenuItem";
            this.créerFactureToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.créerFactureToolStripMenuItem.Text = "Créer facture";
            this.créerFactureToolStripMenuItem.Click += new System.EventHandler(this.créerFactureToolStripMenuItem_Click);
            // 
            // imprimerFactureToolStripMenuItem
            // 
            this.imprimerFactureToolStripMenuItem.Name = "imprimerFactureToolStripMenuItem";
            this.imprimerFactureToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.imprimerFactureToolStripMenuItem.Text = "Imprimer facture";
            this.imprimerFactureToolStripMenuItem.Click += new System.EventHandler(this.imprimerFactureToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem afficherUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiviPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherDossiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherTraitementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterTraitementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rédigerOrdonnanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterRendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierRendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerRendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherRendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierPrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendreProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerFactureToolStripMenuItem;
    }
}