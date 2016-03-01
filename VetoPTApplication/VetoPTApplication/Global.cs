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
            new AnimalManagement.HomePage(this.panel1);
        }

        private void afficherAnimauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnimalManagement.DisplayAnimals(this.panel1);
        }

        private void afficherRappelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnimalManagement.DisplayReminders(this.panel1);
        }

        private void ajouterAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnimalManagement.AddAnimal(this.panel1);
        }

        private void ajouterRappelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnimalManagement.AddReminder(this.panel1);
        }

        private void ajouterUneRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnimalManagement.AddBreed(this.panel1);
        }

        private void ajouterUneEspèceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnimalManagement.AddSpecy(this.panel1);
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
            UserManagement.AddUser au = new UserManagement.AddUser(this.panel1);
        }

        //ClientManagement
        private void gestionClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.HomePage cm = new ClientManagement.HomePage(this.panel1);
        }

        private void afficherClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.DisplayClient dc = new ClientManagement.DisplayClient(this.panel1);
        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.AddClient ac = new ClientManagement.AddClient(this.panel1);
        }

        private void modifierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.ModifyClient mc = new ClientManagement.ModifyClient(this.panel1);
        }

        private void supprimerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.DeleteClient dc = new ClientManagement.DeleteClient(this.panel1);
        }

        private void ajouterRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.AddAppointment aa = new ClientManagement.AddAppointment(this.panel1); 
        }

        private void annulerRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.CancelAppointment ca = new ClientManagement.CancelAppointment(this.panel1); 
        }

        private void afficherRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.DisplayAppointments da = new ClientManagement.DisplayAppointments(this.panel1); 
        }

        private void modifierRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement.ModifyAppointment ma = new ClientManagement.ModifyAppointment(this.panel1); 
        }

        //StockManagement
        private void afficherStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagement.DisplayProducts dp = new StockManagement.DisplayProducts(this.panel1);
        }

        private void gestionsDuStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagement.HomePage hp = new StockManagement.HomePage(this.panel1);
        }

        private void supprimerProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagement.DeleteProduct dp = new StockManagement.DeleteProduct(this.panel1);
        }

        private void modifierPrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagement.ModifyPrice mp = new StockManagement.ModifyPrice(this.panel1);
        }

        private void ajouterProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagement.AddProduct ap = new StockManagement.AddProduct(this.panel1);
        }

        //Selling
        private void vendreProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Selling.SellProduct sp = new Selling.SellProduct(this.panel1);
        }

        private void afficherFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Selling.DisplayInvoice di = new Selling.DisplayInvoice(this.panel1);
        }

        private void créerFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selling.CreateInvoice ci = new Selling.CreateInvoice(this.panel1);
        }

        private void imprimerFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Selling.PrintInvoice pi = new Selling.PrintInvoice(this.panel1);
        }

        private void venteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selling.HomePage hp = new Selling.HomePage(this.panel1);
        }


    }
}
