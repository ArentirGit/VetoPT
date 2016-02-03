using System;
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

        private void nouveauDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.NewFolder f = new CareManagement.NewFolder(this.panel1);
        }

        private void gestionAnimauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimalManagement.HomePage am = new AnimalManagement.HomePage(this.panel1);
        }

        private void suiviPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.MonitoringPatient p = new CareManagement.MonitoringPatient(this.panel1);
        }

        private void afficherDossiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.DisplayFolder p = new CareManagement.DisplayFolder(this.panel1);
        }

        private void afficherTraitementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.DisplayTreatment p = new CareManagement.DisplayTreatment(this.panel1);
        }

        private void rédigerOrdonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.WriteOrdinance p = new CareManagement.WriteOrdinance(this.panel1);
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CareManagement.Print p = new CareManagement.Print(this.panel1);
        }
    }
}
