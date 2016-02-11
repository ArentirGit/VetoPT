using System;
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
        public DisplayClient(Panel displayClientsPanel)
        {
            this.displayClientsPanel = displayClientsPanel;
            Init();
        }

        public void Init()
        {
         // suppression de tout les objets du panel
            displayClientsPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Size = new Size(90, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "Clients";
            displayClientsPanel.Controls.Add(title);
            // bouton afficher rendez-vous
            Button displayRemindersButton = new Button();
            displayRemindersButton.Location = new Point(0, 0);
            displayRemindersButton.Text = "Afficher rendez-vous";
            displayRemindersButton.Size = new Size(150, 30);
            displayClientsPanel.Controls.Add(displayRemindersButton);
            // bouton ajouter animal
            Button addAnimalButton = new Button();
            addAnimalButton.Location = new Point(260, 10);
            addAnimalButton.Text = "Ajouter client";
            addAnimalButton.Size = new Size(150, 30);
            displayClientsPanel.Controls.Add(addAnimalButton);
            // barre de recherche
            TextBox search = new TextBox();
            search.Location = new Point(450, 0);
            search.Text = "Rechercher";
            search.Size = new Size(150, 30);
            displayClientsPanel.Controls.Add(search);
        }
    }
    
}
