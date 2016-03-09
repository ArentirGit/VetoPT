using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class DeleteClient
    {
        private Panel deleteClientPanel;
        DataBase.DataBaseManagement db;

        Label title;

        ComboBox client;
        Label adress;
        Label mail;

        Button confirmButton;
        Button cancelButton;

        List<string> clients;
        public DeleteClient(Panel deleteClientPanel)
        {
            this.deleteClientPanel = deleteClientPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            deleteClientPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Supprimer un client";
            deleteClientPanel.Controls.Add(title);
            // client 
            client = new ComboBox();
            client.Size = new Size(100, 30);
            client.Location = new Point(230, 100);
            client.Text = "Nom Client";
            client.SelectedIndexChanged += new EventHandler(client_SelectedIndexChanged);
            deleteClientPanel.Controls.Add(client);
            // adresse
            adress = new Label();
            adress.Size = new Size(200, 30);
            adress.Location = new Point(180, 160);
            adress.Text = "Adresse";
            deleteClientPanel.Controls.Add(adress);
            // mail
            mail = new Label();
            mail.Size = new Size(200, 30);
            mail.Location = new Point(180, 190);
            mail.Text = "Mail";
            deleteClientPanel.Controls.Add(mail);                      
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            deleteClientPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            deleteClientPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);

            completeClient();
        }
        private void completeClient()
        {
            clients = db.DisplayClients();
            foreach(string s in clients)
            {
                client.Items.Add(s.Split(':')[1] + " " + s.Split(':')[2]);
            }

        }
        private void client_SelectedIndexChanged(object sender, EventArgs e)
        {
            adress.Text = clients[client.SelectedIndex].Split(':')[4];
            mail.Text = clients[client.SelectedIndex].Split(':')[5];
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            db.deleteClient(Int32.Parse(clients[client.SelectedIndex].Split(':')[0]));
            clear();
            clients.Clear();
            client.Items.Clear();
            completeClient();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            client.Text = "Nom Client";
            adress.Text = "Adresse";
            mail.Text = "Mail";
        }
    }
}
