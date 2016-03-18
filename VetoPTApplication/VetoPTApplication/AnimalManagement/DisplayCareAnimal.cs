using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class DisplayCareAnimal
    {
        private Panel displayCareAnimalPanel;
        private DataBase.DataBaseManagement db;
        private int animal_id;

        public DisplayCareAnimal(Panel displayCareAnimalPanel, int animal_id)
        {
            this.displayCareAnimalPanel = displayCareAnimalPanel;
            this.animal_id = animal_id;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            displayCareAnimalPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(150, 20);
            title.Text = "Soins de cet animal";
            displayCareAnimalPanel.Controls.Add(title);
            int y = 100;   // ordonnee labels
            // rendez-vous en rapport avec l'animal
            foreach (String s in db.getCaresAnimal(animal_id))
            {
                Label care = new Label();
                care.Size = new Size(500, 30);
                care.Font = new Font("Arial", 20);
                care.Location = new Point(145, y);
                care.Text = s;
                y += 50;
            }

            // bouton retour
            Button backButton = new Button();
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(150, 310);
            backButton.Text = "Retour";
            backButton.Click += new EventHandler(displayAnimals);
            displayCareAnimalPanel.Controls.Add(backButton);
        }

        private void displayAnimals(object sender, EventArgs e)
        {
            new DisplayAnimals(displayCareAnimalPanel);
        }
    }
}
