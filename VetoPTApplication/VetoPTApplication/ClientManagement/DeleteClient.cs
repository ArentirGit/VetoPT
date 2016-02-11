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

        public DeleteClient(Panel addAnimalPanel)
        {
            this.deleteClientPanel = addAnimalPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            deleteClientPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Supprimer un client";
            deleteClientPanel.Controls.Add(title);
            // nom 
            TextBox name = new TextBox();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, 100);
            name.Text = "Nom";
            deleteClientPanel.Controls.Add(name);
            // prénom 
            TextBox weight = new TextBox();
            weight.Size = new Size(100, 30);
            weight.Location = new Point(230, 130);
            weight.Text = "Prénom";
            deleteClientPanel.Controls.Add(weight);
            // adresse
            TextBox owner = new TextBox();
            owner.Size = new Size(100, 30);
            owner.Location = new Point(230, 160);
            owner.Text = "Adresse";
            deleteClientPanel.Controls.Add(owner);
            // mail
            TextBox birth = new TextBox();
            birth.Size = new Size(100, 30);
            birth.Location = new Point(230, 190);
            birth.Text = "Mail";
            deleteClientPanel.Controls.Add(birth);                      
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            deleteClientPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            deleteClientPanel.Controls.Add(cancelButton);
        }
    }
}
