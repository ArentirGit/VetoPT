using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class DisplayReminders
    {
        private Panel displayRemindersPanel;

        public DisplayReminders(Panel displayRemindersPanel)
        {
            this.displayRemindersPanel = displayRemindersPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            displayRemindersPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Size = new Size(90, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "Rappels";
            displayRemindersPanel.Controls.Add(title);
            // bouton ajouter rappel
            Button addReminderButton = new Button();
            addReminderButton.Location = new Point(260, 10);
            addReminderButton.Text = "Ajouter rappel";
            addReminderButton.Size = new Size(150, 30);
            //displayAnimals.Click += new EventHandler(displayRemindersButton);
            displayRemindersPanel.Controls.Add(addReminderButton);
            // barre de recherche
            TextBox search = new TextBox();
            search.Location = new Point(450, 0);
            search.Text = "Rechercher";
            search.Size = new Size(150, 30);
            displayRemindersPanel.Controls.Add(search);
        }
    }
}
