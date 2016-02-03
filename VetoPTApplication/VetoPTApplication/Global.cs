﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication
{
    public partial class Global : Form
    {
        public Global()
        {
            InitializeComponent();
        }

        //CareManagement
        private void gestionSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.HomeCareManagement h = new CareManagement.HomeCareManagement(this.panel1);
        }

        private void suiviPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.MonitoringPatient m = new CareManagement.MonitoringPatient(this.panel1);
        }

        private void afficherDossiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.DisplayFolder df = new CareManagement.DisplayFolder(this.panel1);
        }

        private void nouveauDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.NewFolder nf = new CareManagement.NewFolder(this.panel1);
        }

        private void afficherTraitementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.DisplayTreatment dt = new CareManagement.DisplayTreatment(this.panel1);
        }

        private void ajouterTraitementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.AddTreatment at = new CareManagement.AddTreatment(this.panel1);
        }

        private void rédigerOrdonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.WriteOrdinance wo = new CareManagement.WriteOrdinance(this.panel1);
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.Print p = new CareManagement.Print(this.panel1);
        }

        //AnimalManagement
        private void gestionAnimauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimalManagement.HomePage am = new AnimalManagement.HomePage(this.panel1);
        }

        //UserManagement
        private void gestionUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.UserHomePage um = new UserManagement.UserHomePage(this.panel1);
        }

        private void afficherUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.DisplayUsers du = new UserManagement.DisplayUsers(this.panel1);
        }

        private void ajouterUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
