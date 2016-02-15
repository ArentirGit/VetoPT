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

        Label title;

        TextBox name;
        TextBox firstName;
        TextBox adress;
        TextBox mail;

        Button confirmButton;
        Button cancelButton;
        public DeleteClient(Panel deleteClientPanel)
        {
            this.deleteClientPanel = deleteClientPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            deleteClientPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Supprimer un client";
            deleteClientPanel.Controls.Add(title);
            // nom 
            name = new TextBox();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, 100);
            name.Text = "Nom";
            deleteClientPanel.Controls.Add(name);
            // prénom 
            firstName = new TextBox();
            firstName.Size = new Size(100, 30);
            firstName.Location = new Point(230, 130);
            firstName.Text = "Prénom";
            deleteClientPanel.Controls.Add(firstName);
            // adresse
            adress = new TextBox();
            adress.Size = new Size(100, 30);
            adress.Location = new Point(230, 160);
            adress.Text = "Adresse";
            deleteClientPanel.Controls.Add(adress);
            // mail
            mail = new TextBox();
            mail.Size = new Size(100, 30);
            mail.Location = new Point(230, 190);
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
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmer");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            name.Text = "Nom";
            firstName.Text = "Prénom";
            adress.Text = "Adresse";
            mail.Text = "Mail";
        }
    }
}
