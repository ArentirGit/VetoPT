using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class HomePage
    {
        private Panel clientManagementPanel;

        public HomePage(Panel clientManagementPanel)
        {
            this.clientManagementPanel = clientManagementPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            clientManagementPanel.Controls.Clear();
            // MENU //
            // titre
            
            Label title = new Label();
            title.Size = new Size(300, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Gestion des clients";
            clientManagementPanel.Controls.Add(title);
            
            // bouton afficher clients
            Button displayClientsButton = new Button();
            displayClientsButton.Location = new Point(205, 100);
            displayClientsButton.Text = "Afficher clients";
            displayClientsButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(displayClientsButton);
            displayClientsButton.Click += new EventHandler(displayClients_Click);
            // bouton ajouter client
            Button addClientButton = new Button();
            addClientButton.Location = new Point(205, 150);
            addClientButton.Text = "Ajouter un client";
            addClientButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(addClientButton);
            addClientButton.Click += new EventHandler(addClient_Click);
            // bouton modifier client
            Button modifyClientButton = new Button();
            modifyClientButton.Location = new Point(205, 200);
            modifyClientButton.Text = "Modifier un client";
            modifyClientButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(modifyClientButton);
            modifyClientButton.Click += new EventHandler(modifyClient_Click);
            // bouton supprimer client
            Button deleteClientButton = new Button();
            deleteClientButton.Location = new Point(205, 250);
            deleteClientButton.Text = "Supprimer un client";
            deleteClientButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(deleteClientButton);
            deleteClientButton.Click += new EventHandler(deleteClient_Click);
            // bouton ajouter rendez-vous
            Button addAppointmentButton = new Button();
            addAppointmentButton.Location = new Point(205, 300);
            addAppointmentButton.Text = "Ajouter un rendez-vous ";
            addAppointmentButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(addAppointmentButton);
            addAppointmentButton.Click += new EventHandler(addAppointment_Click);
            // bouton modifier rendez-vous
            Button modifyAppointmentButton = new Button();
            modifyAppointmentButton.Location = new Point(205, 350);
            modifyAppointmentButton.Text = "Modifier un rendez-vous";
            modifyAppointmentButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(modifyAppointmentButton);
            modifyAppointmentButton.Click += new EventHandler(modifyAppointment_Click);
            // bouton annuler rendez-vous
            Button deleteAppointmentButton = new Button();
            deleteAppointmentButton.Location = new Point(205, 400);
            deleteAppointmentButton.Text = "Annuler un rendez-vous";
            deleteAppointmentButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(deleteAppointmentButton);
            deleteAppointmentButton.Click += new EventHandler(deleteAppointment_Click);
            
        }

        private void deleteAppointment_Click(object sender, EventArgs e)
        {
            ClientManagement.CancelAppointment ca = new ClientManagement.CancelAppointment(this.clientManagementPanel);
        }

        private void modifyAppointment_Click(object sender, EventArgs e)
        {
            ClientManagement.ModifyAppointment ma = new ClientManagement.ModifyAppointment(this.clientManagementPanel);
        }

        private void addAppointment_Click(object sender, EventArgs e)
        {
            ClientManagement.AddAppointment aa = new ClientManagement.AddAppointment(this.clientManagementPanel); 
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            ClientManagement.DeleteClient dc = new ClientManagement.DeleteClient(this.clientManagementPanel);
        }

        private void modifyClient_Click(object sender, EventArgs e)
        {
            ClientManagement.ModifyClient mc = new ClientManagement.ModifyClient(this.clientManagementPanel,null);
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            ClientManagement.AddClient ac = new ClientManagement.AddClient(this.clientManagementPanel);
        }

        private void displayClients_Click(object sender, EventArgs e)
        {
            ClientManagement.DisplayClient dc = new ClientManagement.DisplayClient(this.clientManagementPanel);
        }

    }
}
