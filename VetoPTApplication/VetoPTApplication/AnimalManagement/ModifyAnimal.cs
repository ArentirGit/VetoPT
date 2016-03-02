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

        public ModifyAnimal(Panel modifyAnimalPanel)
        {
            this.modifyAnimalPanel = modifyAnimalPanel;
            Init();
        }

        public void Init()
        {
            DataBase.DataBaseManagement db = new DataBase.DataBaseManagement("VetoPTArentir");
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
            modifyAnimalPanel.Controls.Add(owner);
            // date de naissance
            TextBox birth = new TextBox();
            birth.Size = new Size(100, 30);
            birth.Location = new Point(230, 190);
            birth.Text = "Date de naissance";
            modifyAnimalPanel.Controls.Add(birth);
            // espece
            ComboBox specy = new ComboBox();
            specy.Size = new Size(100, 30);
            specy.Location = new Point(230, 220);
            specy.Text = "Espece";
            string[] species = db.displaySpecies();
            for (int i = 0; i < species.Length; i++)
            {
                if (species[i] != null)
                    specy.Items.Add(species[i]);
            }
            modifyAnimalPanel.Controls.Add(specy);
            // race
            ComboBox breed = new ComboBox();
            breed.Size = new Size(100, 30);
            breed.Location = new Point(230, 250);
            breed.Text = "Race";
            modifyAnimalPanel.Controls.Add(breed);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            confirmButton.Click += (sender, eventArgs) => { db.InsertAnimal(name.Text, weight.Text, birth.Text); };
            confirmButton.Click += new EventHandler(displayAnimals);
            modifyAnimalPanel.Controls.Add(confirmButton);
            // bouton retour
            Button backButton = new Button();
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(310, 310);
            backButton.Text = "Retour";
            backButton.Click += new EventHandler(displayAnimals);
            modifyAnimalPanel.Controls.Add(backButton);
        }

        private void displayAnimals(object sender, EventArgs e)
        {
            new DisplayAnimals(modifyAnimalPanel);
        }

    }
}