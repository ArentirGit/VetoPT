using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VetoPTApplication.AnimalManagement
{
    class ModifyAnimal
    {
        private Panel modifyAnimalPanel;
        private int code_animal;
        DataBase.DataBaseManagement db;

        private ComboBox owner;
        private int person_id;
        private List<string> people;

        private ComboBox specy;
        private int specy_id;
        private List<string> species;

        private ComboBox breed;
        private int breed_id;
        private List<string> breeds;

        public ModifyAnimal(Panel modifyAnimalPanel, int code_animal)
        {
            this.modifyAnimalPanel = modifyAnimalPanel;
            this.code_animal = code_animal;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            modifyAnimalPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Modifier un animal";
            modifyAnimalPanel.Controls.Add(title);
            int y = 100;   // ordonnee labels
            String details = db.displayAnimalDetails(code_animal);

            // nom 
            TextBox name = new TextBox();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, y);
            name.Text = details.Split(':')[0];
            modifyAnimalPanel.Controls.Add(name);
            y += 30;
            // poids 
            TextBox weight = new TextBox();
            weight.Size = new Size(100, 30);
            weight.Location = new Point(230, y);
            weight.Text = details.Split(':')[1];
            modifyAnimalPanel.Controls.Add(weight);
            y += 30;
            // proprietaire
            owner = new ComboBox();
            owner.Size = new Size(100, 30);
            owner.Location = new Point(230, y);
            owner.Text = "Propriétaire";
            people = db.getPeople();
            foreach (string p in people)
            {
                owner.Items.Add(p.Split(':')[1] + " " + p.Split(':')[2]);
            }
            owner.SelectedIndexChanged += new EventHandler(ownerChange);
            modifyAnimalPanel.Controls.Add(owner);
            y += 30;
            // date de naissance
            DateTimePicker date = new DateTimePicker();
            date.Format = DateTimePickerFormat.Short;
            date.Size = new Size(100, 30);
            date.Location = new Point(230, y);
            modifyAnimalPanel.Controls.Add(date);
            y += 30;
            // espece
            specy = new ComboBox();
            specy.Size = new Size(100, 30);
            specy.Location = new Point(230, y);
            specy.Text = "Espece";
            species = db.getSpecies();
            foreach (string s in species)
            {
                specy.Items.Add(s.Split(':')[1]);
            }
            specy.SelectedIndexChanged += new EventHandler(specyChange);
            modifyAnimalPanel.Controls.Add(specy);
            y += 30;
            // race
            breed = new ComboBox();
            breed.Size = new Size(100, 30);
            breed.Location = new Point(230, y);
            breed.Text = "Race";
            breed.SelectedIndexChanged += new EventHandler(breedChange);
            modifyAnimalPanel.Controls.Add(breed);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            confirmButton.Click += (sender, eventArgs) =>
            {
                db.UpdateAnimal(name.Text, weight.Text + " kg",
                 date.Text, person_id, breed_id, this.code_animal);
            };
            confirmButton.Click += new EventHandler(displayAnimals);
            modifyAnimalPanel.Controls.Add(confirmButton);

            // bouton retour
            Button backButton = new Button();
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(310, 310);
            backButton.Text = "Retour";
            backButton.Click += new EventHandler(displayAnimals);
            modifyAnimalPanel.Controls.Add(backButton);
            /*
            // bouton proprietaire
            Button ownerButton = new Button();
            ownerButton.Size = new Size(100, 30);
            ownerButton.Location = new Point(470, 310);
            ownerButton.Text = "Propriétaire";
            modifyAnimalPanel.Controls.Add(ownerButton);
            // bouton soins
            Button careButton = new Button();
            careButton.Size = new Size(100, 30);
            careButton.Location = new Point(580, 310);
            careButton.Text = "Soins";
            modifyAnimalPanel.Controls.Add(careButton);
            */
        }

        private void displayAnimals(object sender, EventArgs e)
        {
            new DisplayAnimals(modifyAnimalPanel);
        }

        public void ownerChange(object sender, EventArgs e)
        {
            person_id = Int32.Parse(people[owner.SelectedIndex].Split(':')[0]);
        }

        public void specyChange(object sender, EventArgs e)
        {
            specy_id = Int32.Parse(species[specy.SelectedIndex].Split(':')[0]);
            completeBreeds(specy_id);
        }

        public void breedChange(object sender, EventArgs e)
        {
            breed_id = Int32.Parse(breeds[breed.SelectedIndex].Split(':')[0]);
        }

        private void completeBreeds(int specy_id)
        {
            breeds = new List<string>();
            breeds = db.getBreedsSpecy(specy_id);
            breed.Items.Clear();
            foreach (string b in breeds)
            {
                breed.Items.Add(b);
            }
        }

    }
}