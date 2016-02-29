using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    
    class DisplayClient
    {
        private Panel displayClientsPanel;
        Label title;

        Button displayAppointmentsButton;
        Button addClientButton;
        TextBox search;
        public DisplayClient(Panel displayClientsPanel)
        {
            this.displayClientsPanel = displayClientsPanel;
            Init();
        }

        public void Init()
        {
         // suppression de tout les objets du panel
            displayClientsPanel.Controls.Clear();
            // titre
            title= new Label();
            title.Size = new Size(500, 30);
            title.Size = new Size(90, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "Clients";
            displayClientsPanel.Controls.Add(title);
            // bouton afficher rendez-vous
            displayAppointmentsButton = new Button();
            displayAppointmentsButton.Location = new Point(0, 0);
            displayAppointmentsButton.Text = "Afficher rendez-vous";
            displayAppointmentsButton.Size = new Size(150, 30);
            displayClientsPanel.Controls.Add(displayAppointmentsButton);
            displayAppointmentsButton.Click += new EventHandler(displayAppointments_Click);
            // bouton ajouter client
            addClientButton = new Button();
            addClientButton.Location = new Point(260, 10);
            addClientButton.Text = "Ajouter client";
            addClientButton.Size = new Size(150, 30);
            displayClientsPanel.Controls.Add(addClientButton);
            addClientButton.Click += new EventHandler(addClient_Click);
            // barre de recherche
            search = new TextBox();
            search.Location = new Point(450, 0);
            search.Text = "Rechercher";
            search.Size = new Size(150, 30);
            displayClientsPanel.Controls.Add(search);
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            ClientManagement.AddClient ca = new ClientManagement.AddClient(this.displayClientsPanel);
        }

        private void displayAppointments_Click(object sender, EventArgs e)
        {
            ClientManagement.DisplayAppointments ca = new ClientManagement.DisplayAppointments(this.displayClientsPanel);
        }
    }
    
}
