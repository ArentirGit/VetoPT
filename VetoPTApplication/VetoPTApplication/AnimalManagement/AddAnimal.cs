using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VetoPTApplication.AnimalManagement
{
    class AddAnimal
    {
        private Panel addAnimalPanel;
        DataBase.DataBaseManagement db = new DataBase.DataBaseManagement("VetoPTArentir");

        public AddAnimal(Panel addAnimalPanel)
        {
            this.addAnimalPanel = addAnimalPanel;
            Init();
        }

        public void Init()
        {
            DataBase.DataBaseManagement db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            addAnimalPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter un animal";
            addAnimalPanel.Controls.Add(title);
            // nom 
            TextBox name = new TextBox();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, 100);
            name.Text = "Nom";
            addAnimalPanel.Controls.Add(name);
            // poids 
            TextBox weight = new TextBox();
            weight.Size = new Size(100, 30);
            weight.Location = new Point(230, 130);
            weight.Text = "Poids";
            addAnimalPanel.Controls.Add(weight);
            // proprietaire
            ComboBox owner = new ComboBox();
            owner.Size = new Size(100, 30);
            owner.Location = new Point(230, 160);
            owner.Text = "Propriétaire";
            addAnimalPanel.Controls.Add(owner);
            // date de naissance
            TextBox birth = new TextBox();
            birth.Size = new Size(100, 30);
            birth.Location = new Point(230, 190);
            birth.Text = "Date de naissance";
            addAnimalPanel.Controls.Add(birth);
            // espece
            ComboBox specy = new ComboBox();
            specy.Size = new Size(100, 30);
            specy.Location = new Point(230, 220);
            specy.Text = "Espece";
            addAnimalPanel.Controls.Add(specy);
            // race
            ComboBox breed = new ComboBox();
            breed.Size = new Size(100, 30);
            breed.Location = new Point(230, 250);
            breed.Text = "Race";
            addAnimalPanel.Controls.Add(breed);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            confirmButton.Click += (sender, eventArgs) => { db.InsertAnimal(name.Text, weight.Text, birth.Text); };
            addAnimalPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            addAnimalPanel.Controls.Add(cancelButton); 
        }

        /*
        private void InsertAnimal(object sender, EventArgs e)
        {
            db.InsertAnimal(name.Text, weight.Text, birth.Text);
        }
        */
    }
}