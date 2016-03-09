using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class DisplayAppointments
    {
        private Panel DisplayAppointmentsPanel;

        Label title;

        ComboBox client;
        ComboBox animal;
        MonthCalendar calendar;
        TextBox reason;

        Button confirmButton;
        Button cancelButton;

        List<string> clients;
        string clientData;
        int? code;

        DataBase.DataBaseManagement db;
         public DisplayAppointments(Panel DisplayAppointmentsPanel, int? code)
        {
            this.DisplayAppointmentsPanel = DisplayAppointmentsPanel;
            this.code = code;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            DisplayAppointmentsPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Afficher rendez-vous";
            DisplayAppointmentsPanel.Controls.Add(title);
            // client
            client = new ComboBox();
            client.Size = new Size(150, 30);
            client.Location = new Point(205, 100);
            client.Text = "Nom";
            client.SelectedIndexChanged += new EventHandler(name_SelectedIndexChanged);
            DisplayAppointmentsPanel.Controls.Add(client);
            // animal
            animal = new ComboBox();
            animal.Size = new Size(150, 30);
            animal.Location = new Point(205, 130);
            animal.Text = "Animal";
            animal.SelectedIndexChanged += new EventHandler(animal_SelectedIndexChanged);
            DisplayAppointmentsPanel.Controls.Add(animal);
            // Date
            calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            DisplayAppointmentsPanel.Controls.Add(calendar);
            // raison
            reason = new TextBox();
            reason.Size = new Size(150, 30);
            reason.Location = new Point(205, 350);
            reason.Text = "Objet du rendez-vous";
            DisplayAppointmentsPanel.Controls.Add(reason);
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 400);
            confirmButton.Text = "Confirmer";
            DisplayAppointmentsPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 400);
            cancelButton.Text = "Annuler";
            DisplayAppointmentsPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);
        }

        private void animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Animal");
            //adress.Text = clients[client.SelectedIndex].Split(':')[4];
            //mail.Text = clients[client.SelectedIndex].Split(':')[5];
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Nom");
            //adress.Text = clients[client.SelectedIndex].Split(':')[4];
            //mail.Text = clients[client.SelectedIndex].Split(':')[5];
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmer");
        }

        private void clear()
        {
            client.Text = "Nom";
            animal.Text = "Animal";
            reason.Text = "Objet du rendez-vous";
        }

        private void completeClient()
        {
            if (code == null)
            {
                clients = db.DisplayClients();
                foreach (string s in clients)
                {
                    client.Items.Add(s.Split(':')[1] + " " + s.Split(':')[2]);
                }
            }
            else
            {
                clientData = db.detailsClient(code.Value);
                client.Items.Add(clientData.Split(':')[1] + " " + clientData.Split(':')[2]);
                client.Text = clientData.Split(':')[1] + " " + clientData.Split(':')[2];
            }
        }
    }
}
