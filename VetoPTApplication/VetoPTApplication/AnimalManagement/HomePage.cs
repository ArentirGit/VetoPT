using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class HomePage
    {
        private Panel animalManagementPanel;

        public HomePage(Panel animalManagementPanel)
        {
            this.animalManagementPanel = animalManagementPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            animalManagementPanel.Controls.Clear();
                // MENU //
            // titre
            Label title = new Label();
            title.Size = new Size(300,30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Gestion des animaux";
            animalManagementPanel.Controls.Add(title);
            // bouton afficher animaux
            Button displayAnimalsButton = new Button();
            displayAnimalsButton.Location = new Point(205, 100);
            displayAnimalsButton.Text = "Afficher animaux";
            displayAnimalsButton.Size = new Size(200,30);
            displayAnimalsButton.Click += new EventHandler(displayAnimals);
            animalManagementPanel.Controls.Add(displayAnimalsButton);
            // bouton ajouter animaux
            Button addAnimalButton = new Button();
            addAnimalButton.Location = new Point(205, 150);
            addAnimalButton.Text = "Ajouter un animal";
            addAnimalButton.Size = new Size(200, 30);
            addAnimalButton.Click += new EventHandler(addAnimal);
            animalManagementPanel.Controls.Add(addAnimalButton);
            // bouton ajouter rappel
            Button displayRemindersButton = new Button();
            displayRemindersButton.Location = new Point(205, 200);
            displayRemindersButton.Text = "Afficher rappels";
            displayRemindersButton.Size = new Size(200, 30);
            displayRemindersButton.Click += new EventHandler(displayReminders);
            animalManagementPanel.Controls.Add(displayRemindersButton);
            // bouton afficher rappel
            Button addReminderButton = new Button();
            addReminderButton.Location = new Point(205, 250);
            addReminderButton.Text = "Ajouter un rappel";
            addReminderButton.Size = new Size(200, 30);
            addReminderButton.Click += new EventHandler(addReminder);
            animalManagementPanel.Controls.Add(addReminderButton);
        }

        private void displayAnimals(object sender, EventArgs e)
        {
            new DisplayAnimals(animalManagementPanel);
        }

        private void addAnimal(object sender, EventArgs e)
        {
            new AddAnimal(animalManagementPanel);
        }

        private void displayReminders(object sender, EventArgs e)
        {
            new DisplayReminders(animalManagementPanel);
        }

        private void addReminder(object sender, EventArgs e)
        {
            new AddReminder(animalManagementPanel);
        }
    }
}
