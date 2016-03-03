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
        private int animal_id;
        DataBase.DataBaseManagement db;

        public ModifyAnimal(Panel modifyAnimalPanel, int animal_id)
        {
            this.modifyAnimalPanel = modifyAnimalPanel;
            this.animal_id = animal_id;
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
            // nom 
            TextBox name = new TextBox();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, 100);
            name.Text = "Nom";
            modifyAnimalPanel.Controls.Add(name);
            // poids 
            TextBox weight = new TextBox();
            weight.Size = new Size(100, 30);
            weight.Location = new Point(230, 130);
            weight.Text = "Poids";
            modifyAnimalPanel.Controls.Add(weight);
            // proprietaire
            ComboBox owner = new ComboBox();
            owner.Size = new Size(100, 30);
            owner.Location = new Point(230, 160);
            owner.Text = "Propriétaire";
            List<string> people = db.getPeople();
            foreach(string p in people){
                owner.Items.Add(p.Split(':')[0] + " " + p.Split(':')[1]);
            }
            modifyAnimalPanel.Controls.Add(owner);
            // date de naissance
            DateTimePicker date = new DateTimePicker();
            date.Format = DateTimePickerFormat.Short;
            date.Size = new Size(100, 30);
            date.Location = new Point(230, 190);
            modifyAnimalPanel.Controls.Add(date);
            // espece
            ComboBox specy = new ComboBox();
            specy.Size = new Size(100, 30);
            specy.Location = new Point(230, 220);
            specy.Text = "Espece";
            List<string> species = db.getSpecies();
            foreach (string s in species){
                specy.Items.Add(s);
            }
            modifyAnimalPanel.Controls.Add(specy);
            // race
            ComboBox breed = new ComboBox();
            breed.Size = new Size(100, 30);
            breed.Location = new Point(230, 250);
            breed.Text = "Race";
            List<string> breeds = db.getBreeds();
            foreach (string b in breeds){
                breed.Items.Add(b);
            }
            modifyAnimalPanel.Controls.Add(breed);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            confirmButton.Click += (sender, eventArgs) => { db.UpdateAnimal(name.Text, weight.Text, this.animal_id); };
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

    }
}