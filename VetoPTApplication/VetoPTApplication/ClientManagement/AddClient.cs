using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class AddClient
    {
        private Panel addClientPanel;
        DataBase.DataBaseManagement db;

        Label title;

        TextBox name;
        TextBox firstName;
        TextBox city;
        TextBox adress;
        TextBox mail;

        Button confirmButton;
        Button cancelButton;

        public AddClient(Panel addAnimalPanel)
        {
            this.addClientPanel = addAnimalPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            addClientPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter un client";
            addClientPanel.Controls.Add(title);
            // nom 
            name = new TextBox();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, 100);
            name.Text = "Nom";
            addClientPanel.Controls.Add(name);
            // prénom 
            firstName = new TextBox();
            firstName.Size = new Size(100, 30);
            firstName.Location = new Point(230, 130);
            firstName.Text = "Prénom";
            addClientPanel.Controls.Add(firstName);
            // city
            city = new TextBox();
            city.Size = new Size(100, 30);
            city.Location = new Point(230, 160);
            city.Text = "Ville";
            addClientPanel.Controls.Add(city);
            // adresse
            adress = new TextBox();
            adress.Size = new Size(100, 30);
            adress.Location = new Point(230, 190);
            adress.Text = "Adresse";
            addClientPanel.Controls.Add(adress);
            // mail
            mail = new TextBox();
            mail.Size = new Size(100, 30);
            mail.Location = new Point(230, 220);
            mail.Text = "Mail";
            addClientPanel.Controls.Add(mail);                      
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            addClientPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            addClientPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            db.addClient(name.Text, firstName.Text, city.Text, adress.Text, mail.Text);
            clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            name.Text = "Nom";
            firstName.Text = "Prénom";
            city.Text = "Ville";
            adress.Text = "Adresse";
            mail.Text = "Mail";
        }
    }
}
