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
            // bouton ajouter client
            Button addClientButton = new Button();
            addClientButton.Location = new Point(205, 150);
            addClientButton.Text = "Ajouter un client";
            addClientButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(addClientButton);
            // bouton modifier client
            Button modifyClientButton = new Button();
            modifyClientButton.Location = new Point(205, 200);
            modifyClientButton.Text = "Modifier un client";
            modifyClientButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(modifyClientButton);
            // bouton supprimer client
            Button deleteClientButton = new Button();
            deleteClientButton.Location = new Point(205, 250);
            deleteClientButton.Text = "Supprimer un client";
            deleteClientButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(deleteClientButton);
            // bouton ajouter rendez-vous
            Button addAppointmentButton = new Button();
            addAppointmentButton.Location = new Point(205, 300);
            addAppointmentButton.Text = "Ajouter un rendez-vous ";
            addAppointmentButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(addAppointmentButton);
            // bouton modifier rendez-vous
            Button modifyAppointmentButton = new Button();
            modifyAppointmentButton.Location = new Point(205, 350);
            modifyAppointmentButton.Text = "Modifier un rendez-vous";
            modifyAppointmentButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(modifyAppointmentButton);
            // bouton annuler rendez-vous
            Button deleteAppointmentButton = new Button();
            deleteAppointmentButton.Location = new Point(205, 400);
            deleteAppointmentButton.Text = "Annuler un rendez-vous";
            deleteAppointmentButton.Size = new Size(200, 30);
            clientManagementPanel.Controls.Add(deleteAppointmentButton);
            
        }

    }
}
