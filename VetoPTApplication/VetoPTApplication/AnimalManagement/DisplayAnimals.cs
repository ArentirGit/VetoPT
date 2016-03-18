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
        private DataBase.DataBaseManagement db;

        public DisplayAnimals(Panel displayAnimalsPanel)
        {
            this.displayAnimalsPanel = displayAnimalsPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
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
            animalsList.Size = new Size(75, 1000);
            int x = 145;     // abscisse boutons 
            int y = 75;     // ordonnee boutons pour chaque animal
            foreach (string s in db.DisplayAnimals())
            {
                animalsList.Text += s.Split(':')[1] + "\n\n";
                int animal_id = Int32.Parse(s.Split(':')[0]);
                // bouton modifier animal
                Button modAnimalButton = new Button();
                modAnimalButton.Location = new Point(x, y);
                modAnimalButton.Text = "Modifier animal";
                modAnimalButton.Size = new Size(75, 20);
                modAnimalButton.Click += (sender, eventArgs) => modifyAnimal(sender, eventArgs, animal_id);
                displayAnimalsPanel.Controls.Add(modAnimalButton);
                x += 85;
                // bouton supprimer animal
                Button delAnimalButton = new Button();
                delAnimalButton.Location = new Point(x, y);
                delAnimalButton.Text = "Supprimer animal";
                delAnimalButton.Size = new Size(75, 20);
                delAnimalButton.Click += (sender, eventArgs) => { db.DeleteAnimal(animal_id); };
                delAnimalButton.Click += new EventHandler(refreshAnimals);
                displayAnimalsPanel.Controls.Add(delAnimalButton);
                x += 85;
                // bouton afficher rendez-vous
                Button displayRemindersAnimalButton = new Button();
                displayRemindersAnimalButton.Location = new Point(x, y);
                displayRemindersAnimalButton.Text = "Rendez-vous";
                displayRemindersAnimalButton.Size = new Size(80, 20);
                displayRemindersAnimalButton.Click += (sender, eventArgs) => displayAppointmentsAnimal(sender, eventArgs, animal_id);
                displayAnimalsPanel.Controls.Add(displayRemindersAnimalButton);
                x += 90;
                // bouton soins
                Button careButton = new Button();
                careButton.Location = new Point(x, y);
                careButton.Text = "Soins";
                careButton.Size = new Size(75, 20);
                careButton.Click += (sender, eventArgs) => displayCareAnimal(sender, eventArgs, animal_id);
                displayAnimalsPanel.Controls.Add(careButton);
                x += 85;
                // bouton details
                Button detailsButton = new Button();
                detailsButton.Location = new Point(x, y);
                detailsButton.Text = "Details";
                detailsButton.Size = new Size(75, 20);
                detailsButton.Click += (sender, eventArgs) => displayAnimalDetails(sender, eventArgs, animal_id);
                displayAnimalsPanel.Controls.Add(detailsButton);
                x = 145;
                y += 27;
            }
            displayAnimalsPanel.Controls.Add(animalsList);
        }

        private void addAnimal(object sender, EventArgs e)
        {
            new AddAnimal(displayAnimalsPanel);
        }

        private void modifyAnimal(object sender, EventArgs e, int id)
        {
            new ModifyAnimal(displayAnimalsPanel, id);
        }

        private void displayReminders(object sender, EventArgs e)
        {
            new DisplayReminders(displayAnimalsPanel);
        }

        public void refreshAnimals(object sender, EventArgs e)
        {
            new DisplayAnimals(displayAnimalsPanel);
        }

        public void displayAnimalDetails(object sender, EventArgs e, int id)
        {
            new AnimalDetails(displayAnimalsPanel, id);
        }

        public void displayAppointmentsAnimal(object sender, EventArgs e, int id)
        {
            new DisplayAppointmentsAnimal(displayAnimalsPanel, id);
        }

        public void displayCareAnimal(object sender, EventArgs e, int id)
        {
            new DisplayCareAnimal(displayAnimalsPanel, id);
        }
    }
}
