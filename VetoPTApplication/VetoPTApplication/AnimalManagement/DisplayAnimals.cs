using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class DisplayAnimals
    {
        private Panel displayAnimalsPanel;

        public DisplayAnimals(Panel displayAnimalsPanel)
        {
            this.displayAnimalsPanel = displayAnimalsPanel;
            Init();
        }

        public void Init()
        {
            DataBase.DataBaseManagement db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            displayAnimalsPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Size = new Size(90, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "Animaux";
            displayAnimalsPanel.Controls.Add(title);
            // bouton afficher rendez-vous
            Button displayRemindersButton = new Button();
            displayRemindersButton.Location = new Point(0, 0);
            displayRemindersButton.Text = "Afficher rendez-vous";
            displayRemindersButton.Size = new Size(150, 30);
            displayRemindersButton.Click += new EventHandler(displayReminders);
            displayAnimalsPanel.Controls.Add(displayRemindersButton);
            // bouton ajouter animal
            Button addAnimalButton = new Button();
            addAnimalButton.Location = new Point(260, 10);
            addAnimalButton.Text = "Ajouter animal";
            addAnimalButton.Size = new Size(150, 30);
            addAnimalButton.Click += new EventHandler(addAnimal);
            displayAnimalsPanel.Controls.Add(addAnimalButton);
            // barre de recherche
            TextBox search = new TextBox();
            search.Location = new Point(450, 0);
            search.Text = "Rechercher";
            search.Size = new Size(150, 30);
            displayAnimalsPanel.Controls.Add(search);
            // liste des animaux
            Label animalsList = new Label();
            animalsList.Location = new Point(60, 80);
            foreach (string animal in db.DisplayAnimals()){
                animalsList.Text += animal;
                animalsList.Text += "\n\n";
            }
                
            //animalsList.Text = db.DisplayAnimals();
            animalsList.Size = new Size(50, 1000);
            displayAnimalsPanel.Controls.Add(animalsList);
            // bouton modifier animal
            int y = 75;
            for (int i = 0; i < db.DisplayAnimals().Count; i++)
            {
                Button modAnimalButton = new Button();
                modAnimalButton.Location = new Point(130, y);
                modAnimalButton.Text = "Modifier animal";
                modAnimalButton.Size = new Size(75, 20);
                modAnimalButton.Click += new EventHandler(modifyAnimal);
                displayAnimalsPanel.Controls.Add(modAnimalButton);
                y += 30;
            }
            

        }

        private void addAnimal(object sender, EventArgs e)
        {
            new AddAnimal(displayAnimalsPanel);
        }

        private void modifyAnimal(object sender, EventArgs e)
        {
            new ModifyAnimal(displayAnimalsPanel);
        }

        private void displayReminders(object sender, EventArgs e)
        {
            new DisplayReminders(displayAnimalsPanel);
        }
    }
}
