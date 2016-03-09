using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class DetailsClient
    {
        private Panel detailsClientPanel;
        DataBase.DataBaseManagement db;

        Label title;
        int code;

        Label name;
        Label firstName;
        Label city;
        Label adress;
        Label mail;

        Button backButton;
        Button modifyButton;
        Button displayAppointmentButton;

        string client;

        public DetailsClient(Panel detailsClientPanel, int code)
        {
            this.detailsClientPanel = detailsClientPanel;
            this.code = code;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            client = db.detailsClient(code);
            // suppression de tout les objets du panel
            detailsClientPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Détails client";
            detailsClientPanel.Controls.Add(title);
            // nom 
            name = new Label();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, 100);
            name.Text = client.Split(':')[1];
            detailsClientPanel.Controls.Add(name);
            // prénom 
            firstName = new Label();
            firstName.Size = new Size(100, 30);
            firstName.Location = new Point(230, 130);
            firstName.Text = client.Split(':')[2];
            detailsClientPanel.Controls.Add(firstName);
            // city
            city = new Label();
            city.Size = new Size(100, 30);
            city.Location = new Point(230, 160);
            city.Text = client.Split(':')[3];
            detailsClientPanel.Controls.Add(city);
            // adresse
            adress = new Label();
            adress.Size = new Size(200, 30);
            adress.Location = new Point(230, 190);
            adress.Text = client.Split(':')[4];
            detailsClientPanel.Controls.Add(adress);
            // mail
            mail = new Label();
            mail.Size = new Size(200, 30);
            mail.Location = new Point(230, 220);
            mail.Text = client.Split(':')[5];
            detailsClientPanel.Controls.Add(mail);
            // bouton retour
            backButton = new Button();
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(150, 310);
            backButton.Text = "Retour";
            detailsClientPanel.Controls.Add(backButton);
            backButton.Click += new EventHandler(back_Click);
            // bouton modifier
            modifyButton = new Button();
            modifyButton.Size = new Size(100, 30);
            modifyButton.Location = new Point(275, 310);
            modifyButton.Text = "Modifier";
            detailsClientPanel.Controls.Add(modifyButton);
            modifyButton.Click += new EventHandler(modify_Click);
            // bouton afficher rendez-vous
            displayAppointmentButton = new Button();
            displayAppointmentButton.Size = new Size(100, 30);
            displayAppointmentButton.Location = new Point(400, 310);
            displayAppointmentButton.Text = "Afficher rendez-vous";
            detailsClientPanel.Controls.Add(displayAppointmentButton);
            displayAppointmentButton.Click += new EventHandler(displayAppointment_Click);

        }

        private void displayAppointment_Click(object sender, EventArgs e)
        {
            new DisplayAppointments(detailsClientPanel, code);
        }

        private void back_Click(object sender, EventArgs e)
        {
            new DisplayClient(detailsClientPanel);
        }

        private void modify_Click(object sender, EventArgs e)
        {
            new ModifyClient(detailsClientPanel,code);
        }

    }
}
