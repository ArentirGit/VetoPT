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

        Label client;
        ComboBox animal;
        MonthCalendar calendar;
        Label reason;

        Button backButton;

        List<string> animals;
        int code;

        DataBase.DataBaseManagement db;
         public DisplayAppointments(Panel DisplayAppointmentsPanel, int code)
        {
            this.DisplayAppointmentsPanel = DisplayAppointmentsPanel;
            this.code = code;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            animals = db.getAnimalsClient(code);

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
            client = new Label();
            client.Size = new Size(150, 30);
            client.Location = new Point(205, 100);
            client.Text = "Nom";
            DisplayAppointmentsPanel.Controls.Add(client);
            // animal
            animal = new ComboBox();
            animal.Size = new Size(150, 30);
            animal.Location = new Point(205, 130);
            animal.Text = "Animal";
            //animal.SelectedIndexChanged += new EventHandler(animal_SelectedIndexChanged);
            DisplayAppointmentsPanel.Controls.Add(animal);
            // Date
            calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            DisplayAppointmentsPanel.Controls.Add(calendar);
            // raison
            reason = new Label();
            reason.Size = new Size(150, 30);
            reason.Location = new Point(205, 350);
            reason.Text = "Objet du rendez-vous";
            DisplayAppointmentsPanel.Controls.Add(reason);
            // bouton retour
            backButton = new Button();
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(205, 380);
            backButton.Text = "Retour";
            DisplayAppointmentsPanel.Controls.Add(backButton);
            backButton.Click += new EventHandler(back_Click);
        }
        /*
        private void completeClient()
        {
            clients = db.DisplayClients();
            foreach (string s in clients)
            {
                client.Items.Add(s.Split(':')[1] + " " + s.Split(':')[2]);
            }

        }
        private void client_SelectedIndexChanged(object sender, EventArgs e)
        {
            adress.Text = clients[client.SelectedIndex].Split(':')[4];
            mail.Text = clients[client.SelectedIndex].Split(':')[5];
        }

        private void animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        */

        private void back_Click(object sender, EventArgs e)
        {
            new DisplayClient(DisplayAppointmentsPanel);
        }
    }
}
