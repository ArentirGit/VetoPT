using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class AnimalDetails
    {
        private Panel animalDetailsPanel;
        private DataBase.DataBaseManagement db;
        private int animal_id;
        private int owner_id;

        public AnimalDetails(Panel animalDetailsPanel, int animal_id)
        {
            this.animalDetailsPanel = animalDetailsPanel;
            this.animal_id = animal_id;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            animalDetailsPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Détails animal";
            animalDetailsPanel.Controls.Add(title);
            int y = 100;   // ordonnee labels
            String details = db.displayAnimalDetails(animal_id);
            // nom 
            Label name = new Label();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, y);
            name.Text = "Nom : " + details.Split(':')[0];
            animalDetailsPanel.Controls.Add(name);
            y += 30;
            // poids 
            Label weight = new Label();
            weight.Size = new Size(100, 30);
            weight.Location = new Point(230, y);
            weight.Text = "Poids : " + details.Split(':')[1];
            animalDetailsPanel.Controls.Add(weight);
            y += 30;
            // date de naissance
            Label date = new Label();
            date.Size = new Size(200, 30);
            date.Location = new Point(230, y);
            date.Text = "Date de naissance : " + details.Split(':')[2];
            animalDetailsPanel.Controls.Add(date);
            y += 30;
            // proprietaire
            Label owner = new Label();
            owner.Size = new Size(300, 30);
            owner.Location = new Point(230, y);
            owner.Text = "Propriétaire : " + details.Split(':')[3] + " " + details.Split(':')[4];
            animalDetailsPanel.Controls.Add(owner);
            y += 30;
            // espece
            Label specy = new Label();
            specy.Size = new Size(100, 30);
            specy.Location = new Point(230, y);
            specy.Text = "Espece : " + details.Split(':')[5];
            animalDetailsPanel.Controls.Add(specy);
            y += 30;
            // race
            Label breed = new Label();
            breed.Size = new Size(100, 30);
            breed.Location = new Point(230, y);
            breed.Text = "Race : " + details.Split(':')[6];
            animalDetailsPanel.Controls.Add(breed);
            // bouton proprietaire
            Button ownerButton = new Button();
            ownerButton.Size = new Size(100, 30);
            ownerButton.Location = new Point(310, 310);
            ownerButton.Text = "Propriétaire";
            owner_id = Int32.Parse(details.Split(':')[7]);
            ownerButton.Click += (sender, eventArgs) => displayOwner(sender, eventArgs, owner_id);
            animalDetailsPanel.Controls.Add(ownerButton);
            // bouton soins
            Button careButton = new Button();
            careButton.Size = new Size(100, 30);
            careButton.Location = new Point(425, 310);
            careButton.Text = "Soins";
            animalDetailsPanel.Controls.Add(careButton);

            // bouton retour
            Button backButton = new Button();
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(150, 310);
            backButton.Text = "Retour";
            backButton.Click += new EventHandler(displayAnimals);
            animalDetailsPanel.Controls.Add(backButton);
        }

        private void displayAnimals(object sender, EventArgs e)
        {
            new DisplayAnimals(animalDetailsPanel);
        }

        private void displayOwner(object sender, EventArgs e, int owner_id)
        {
            new ClientManagement.DetailsClient(animalDetailsPanel, owner_id);
        }
    }
}
