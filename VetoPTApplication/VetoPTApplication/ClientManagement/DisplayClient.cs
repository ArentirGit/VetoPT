﻿using System;
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
        Label clientsList;

        DataBase.DataBaseManagement db;

        public DisplayClient(Panel displayClientsPanel)
        {
            this.displayClientsPanel = displayClientsPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
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
            // liste des clients
            clientsList = new Label();
            clientsList.Location = new Point(60, 80);
            clientsList.Size = new Size(75, 1000);
            completeClientsList();
            displayClientsPanel.Controls.Add(clientsList);
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
            AddClient ca = new AddClient(this.displayClientsPanel);
        }

        private void completeClientsList()
        {
            int y = 75;     // ordonnee boutons pour chaque client
            foreach (string s in db.DisplayClients())
            {
                Label name = new Label();
                name.Location = new Point(60, y);
                name.Size = new Size(100, 28);
                name.Text += s.Split(':')[1];
                displayClientsPanel.Controls.Add(name);
                Label firstName = new Label();
                firstName.Location = new Point(170, y);
                firstName.Size = new Size(100, 28);
                firstName.Text += s.Split(':')[2];
                displayClientsPanel.Controls.Add(firstName);
                int client_id = Int32.Parse(s.Split(':')[0]);
                // bouton modifier client
                Button modifyClientButton = new Button();
                modifyClientButton.Location = new Point(275, y);
                modifyClientButton.Text = "Modifier client";
                modifyClientButton.Size = new Size(75, 20);
                modifyClientButton.Click += (sender, eventArgs) => modifyClient_Click(sender, eventArgs, client_id);
                displayClientsPanel.Controls.Add(modifyClientButton);
                // bouton supprimer client
                Button deleteClientButton = new Button();
                deleteClientButton.Location = new Point(360, y);
                deleteClientButton.Text = "Supprimer client";
                deleteClientButton.Size = new Size(75, 20);
                deleteClientButton.Click += (sender, eventArgs) => deleteClient_Click(sender, eventArgs, client_id);
                displayClientsPanel.Controls.Add(deleteClientButton);
                // bouton afficher rdv client
                Button displayAppointmentButton = new Button();
                displayAppointmentButton.Location = new Point(435, y);
                displayAppointmentButton.Text = "Afficher rendez-vous";
                displayAppointmentButton.Size = new Size(75, 20);
                displayAppointmentButton.Click += (sender, eventArgs) => displayAppointment_Click(sender, eventArgs, client_id);
                displayClientsPanel.Controls.Add(displayAppointmentButton);
                // bouton details client
                Button detailsClientButton = new Button();
                detailsClientButton.Location = new Point(510, y);
                detailsClientButton.Text = "Détails client";
                detailsClientButton.Size = new Size(75, 20);
                detailsClientButton.Click += (sender, eventArgs) => detailsClient_Click(sender, eventArgs, client_id);
                displayClientsPanel.Controls.Add(detailsClientButton);
                y += 27;
            }
        }

        private void detailsClient_Click(object sender, EventArgs e, int code)
        {
            new DetailsClient(displayClientsPanel,code);
        }

        private void displayAppointment_Click(object sender, EventArgs e, int code)
        {
            new DisplayAppointments(displayClientsPanel,code);
        }

        private void deleteClient_Click(object sender, EventArgs e, int code)
        {
            db.deleteClient(code);
            Init();
        }

        private void modifyClient_Click(object sender, EventArgs e, int code)
        {
            new ModifyClient(displayClientsPanel, code);
        }
    }
    
}
