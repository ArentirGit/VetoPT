using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class ModifyClient
    {
        private Panel modifyClientPanel;
        private int clientId;

        Label title;

        ComboBox client;
        TextBox city;
        TextBox adress;
        TextBox mail;

        Button confirmButton;
        Button cancelButton;

        List<string> clients;
        int? code;

        DataBase.DataBaseManagement db;

        public ModifyClient(Panel modifyClientPanel, int? code)
        {
            this.modifyClientPanel = modifyClientPanel;
            this.code = code;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            modifyClientPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Modifier un client";
            modifyClientPanel.Controls.Add(title);
            // client 
            client = new ComboBox();
            client.Size = new Size(100, 30);
            client.Location = new Point(230, 100);
            client.Text = "Nom Client";
            client.SelectedIndexChanged += new EventHandler(client_SelectedIndexChanged);
            modifyClientPanel.Controls.Add(client);     
            // city
            city = new TextBox();
            city.Size = new Size(100, 30);
            city.Location = new Point(230, 160);
            city.Text = "Ville";
            modifyClientPanel.Controls.Add(city);
            // adresse
            adress = new TextBox();
            adress.Size = new Size(100, 30);
            adress.Location = new Point(230, 190);
            adress.Text = "Adresse";
            modifyClientPanel.Controls.Add(adress);
            // mail
            mail = new TextBox();
            mail.Size = new Size(100, 30);
            mail.Location = new Point(230, 220);
            mail.Text = "Mail";
            modifyClientPanel.Controls.Add(mail);                      
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            modifyClientPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            modifyClientPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);

            completeClient();
        }

        private void completeClient()
        {
            if(code == null)
            {
                clients = db.DisplayClients();
                foreach (string s in clients)
                {
                    client.Items.Add(s.Split(':')[1] + " " + s.Split(':')[2]);
                }
            }
            else
            {
                client.Items.Add(db.detailsClient(code.Value));
            }
        }
        private void client_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(clients[client.SelectedIndex]);
            adress.Text = clients[client.SelectedIndex].Split(':')[4];
            mail.Text = clients[client.SelectedIndex].Split(':')[5];
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            db.modifyClient(Int32.Parse(clients[client.SelectedIndex].Split(':')[0]),city.Text,adress.Text,mail.Text);
            clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            client.Text = "Nom Client";
            city.Text = "Ville";
            adress.Text = "Adresse";
            mail.Text = "Mail";
        }
    }
}
