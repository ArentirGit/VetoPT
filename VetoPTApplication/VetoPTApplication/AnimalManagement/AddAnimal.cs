﻿using System;
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
            weight.Text = "Poids (en kg)";
            addAnimalPanel.Controls.Add(weight);
            // proprietaire
            ComboBox owner = new ComboBox();
            owner.Size = new Size(100, 30);
            owner.Location = new Point(230, 160);
            owner.Text = "Propriétaire  ";
            List<string> people = db.getPeople();
            foreach (string p in people){
                owner.Items.Add(p.Split(':')[0] + " " + p.Split(':')[1]);
            }
            addAnimalPanel.Controls.Add(owner);
            ////////
            string person_name = "";
            string person_firstname = "";
            int person_id = -1;
            if (owner.SelectedItem != null && owner.SelectedItem.ToString() != "Propriétaire")
            {
                person_name = owner.SelectedText.Split(' ')[0];
                person_firstname = owner.SelectedText.Split(' ')[1];
                person_id = db.findPersonIdByName(person_name, person_firstname);
            }   
            // date de naissance
            DateTimePicker date = new DateTimePicker();
            date.Format = DateTimePickerFormat.Short;
            date.Size = new Size(100, 30);
            date.Location = new Point(230, 190);
            addAnimalPanel.Controls.Add(date);
            // espece
            ComboBox specy = new ComboBox();
            specy.Size = new Size(100, 30);
            specy.Location = new Point(230, 220);
            specy.Text = "Espece";
            List<string> species = db.getSpecies();
            foreach (string s in species){
                specy.Items.Add(s);
            }
            addAnimalPanel.Controls.Add(specy);
            // race
            ComboBox breed = new ComboBox();
            breed.Size = new Size(100, 30);
            breed.Location = new Point(230, 250);
            breed.Text = "Race";
            breed.SelectedValueChanged += new EventHandler()
            List<string> breeds = db.getBreeds();
            foreach (string b in breeds){
                breed.Items.Add(b);
            }
            addAnimalPanel.Controls.Add(breed);
            ////////
            string breed_name = breed.SelectedText;
            int breed_id = -1;
            if (breed.SelectedItem != null)
                breed_id = db.findBreedIdByName(breed_name);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            confirmButton.Click += (sender, eventArgs) => { db.InsertAnimal(name.Text, weight.Text + " kg", date.Text, person_id, breed_id); };
            confirmButton.Click += new EventHandler(displayAnimals);
            addAnimalPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            cancelButton.Click += new EventHandler(homePage);
            addAnimalPanel.Controls.Add(cancelButton); 

            
        }

        private void homePage(object sender, EventArgs e)
        {
            new HomePage(addAnimalPanel);
        }

        private void displayAnimals(object sender, EventArgs e)
        {
            new DisplayAnimals(addAnimalPanel);
        }

        public void refreshAnimals(object sender, EventArgs e)
        {
            new AddAnimal(addAnimalPanel);
        }

    }
}