using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class AddTreatment
    {
        private Panel myPanel;

        private DataBase.DataBaseManagement db = new DataBase.DataBaseManagement("VetoPTArentir");

        private Label title;

        private Button validate;
        private Button cancel;

        private TextBox nom;
        private TextBox duree;
        private RichTextBox note;
        private DateTimePicker dateCourante;

        private ComboBox nameAnimal;
        private ComboBox nameClient;
        private List<string> clients;
        private List<string> animals;
        private string animalSelect;
        

        public AddTreatment(Panel panel)
        {
            myPanel = panel;
            Init();
        }

        public void Init()
        {
            //suppression de tout les objets du panel
            myPanel.Controls.Clear();

            animalSelect = null;

            //création du titre
            title = new Label();
            title.Size = new Size(300, 40);
            title.Location = new Point(200, 25);
            title.Font = new Font("Arial", 15, FontStyle.Bold);
            title.Text = "Nouveau Traitement";
            myPanel.Controls.Add(title);

            //création du Combobox nom client
            nameClient = new ComboBox();
            nameClient.Size = new Size(100, 40);
            nameClient.Location = new Point(100, 60);
            nameClient.Text = "Nom client";
            nameClient.SelectedIndexChanged += new EventHandler(nameClient_SelectedIndexChanged);
            myPanel.Controls.Add(nameClient);

            //création du Combox nom animal
            nameAnimal = new ComboBox();
            nameAnimal.Size = new Size(100, 40);
            nameAnimal.Location = new Point(100, 110);
            nameAnimal.Text = "Nom animal";
            nameAnimal.SelectedIndexChanged += new EventHandler(nameAnimal_SelectedIndexChanged);
            myPanel.Controls.Add(nameAnimal);

            nom = new TextBox();
            nom.Size = new Size(100, 40);
            nom.Location = new Point(100, 160);
            nom.Text = "Nom";
            myPanel.Controls.Add(nom);

            //création du TextBox durée
            duree = new TextBox();
            duree.Size = new Size(100, 40);
            duree.Location = new Point(100, 200);
            duree.Text = "Durée";
            myPanel.Controls.Add(duree);

            //création du textbox note
            note = new RichTextBox();
            note.Size = new Size(300, 100);
            note.Location = new Point(100, 250);
            note.Text = "Note : \nExemple : fatigue,pate droite cassée ..";
            myPanel.Controls.Add(note);
           
            //création de la date
            dateCourante = new DateTimePicker();
            dateCourante.Size = new Size(100, 40);
            dateCourante.Format = DateTimePickerFormat.Short;
            dateCourante.ValueChanged += new EventHandler(date_Change);
            dateCourante.Value = DateTime.Now.AddDays(0);
            dateCourante.Location = new Point(100, 360);
            myPanel.Controls.Add(dateCourante);

            //création du boutton valider
            validate = new Button();
            validate.Size = new Size(60, 40);
            validate.Location = new Point(200, 400);
            validate.Text = "Valider";
            myPanel.Controls.Add(validate);
            validate.Click += new EventHandler(valider_Click);

            //création du boutton annuler
            cancel = new Button();
            cancel.Size = new Size(60, 40);
            cancel.Location = new Point(400, 400);
            cancel.Text = "Annuler";
            myPanel.Controls.Add(cancel);
            cancel.Click += new EventHandler(cancel_Click);

            this.completeClient();

        }

        private void completeClient()
        {
            clients = new List<string>();
            clients = db.DisplayClients();
            foreach (string s in clients)
            {
                nameClient.Items.Add(s.Split(':')[1] + " " + s.Split(':')[2]);
            }

        }

        private void completeAnimal(int idClient)
        {
            animals = new List<string>();
            animals = db.getAnimalsClient(idClient);
            nameAnimal.Items.Clear();
            foreach (string s in animals)
            {
                nameAnimal.Items.Add(s.Split(':')[1]);
            }

        }

        private void valider_Click(object sender, EventArgs e)
        {
            db.addTreatments(animalSelect, nom.Text, dateCourante.Text, duree.Text,note.Text);
            clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();            
        }

        private void date_Change(object sender, EventArgs e)
        {
            dateCourante.Value = DateTime.Now.AddDays(0);
        }

        private void clear()
        {
            nameAnimal.Text = "Nom animal";
            nameClient.Text = "Nom client";
            this.completeClient();
            animals = new List<string>();
            nameAnimal.Items.Clear();
            note.Text = "Note : \nExemple : fatigue,pate droite cassée ..";
            nom.Text = "Nom";
            duree.Text = "Durée";
        }

        private void nameClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            completeAnimal(Int32.Parse(clients[nameClient.SelectedIndex].Split(':')[0]));
        }
        private void nameAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            animalSelect = animals[nameAnimal.SelectedIndex];
        }
    }
}
