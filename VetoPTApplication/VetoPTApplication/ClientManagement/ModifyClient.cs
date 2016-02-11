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

        public ModifyClient(Panel addAnimalPanel)
        {
            this.modifyClientPanel = addAnimalPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            modifyClientPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Modifier un client";
            modifyClientPanel.Controls.Add(title);
            // nom 
            TextBox name = new TextBox();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, 100);
            name.Text = "Nom";
            modifyClientPanel.Controls.Add(name);
            // prénom 
            TextBox weight = new TextBox();
            weight.Size = new Size(100, 30);
            weight.Location = new Point(230, 130);
            weight.Text = "Prénom";
            modifyClientPanel.Controls.Add(weight);
            // adresse
            TextBox owner = new TextBox();
            owner.Size = new Size(100, 30);
            owner.Location = new Point(230, 160);
            owner.Text = "Adresse";
            modifyClientPanel.Controls.Add(owner);
            // mail
            TextBox birth = new TextBox();
            birth.Size = new Size(100, 30);
            birth.Location = new Point(230, 190);
            birth.Text = "Mail";
            modifyClientPanel.Controls.Add(birth);                      
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            modifyClientPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            modifyClientPanel.Controls.Add(cancelButton);
        }
    }
}
