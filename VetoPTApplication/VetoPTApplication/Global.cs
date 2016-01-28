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
    }
}
