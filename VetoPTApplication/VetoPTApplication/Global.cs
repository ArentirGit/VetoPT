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

        private void gestionUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.UserHomePage um = new UserManagement.UserHomePage(this.panel1);
        }

        private void afficherUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.DisplayUsers du = new UserManagement.DisplayUsers(this.panel1);
        }

    }
}
