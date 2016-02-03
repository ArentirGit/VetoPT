using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class NewFolder
    {
        private Panel myPanel;

        private Label title;

        private Button validate;
        private Button cancel;

        private ComboBox nameAnimal;
        private ComboBox nameClient;
        private RichTextBox note;
        private DateTimePicker dateCourante;
        

        public NewFolder(Panel panel)
        {
            myPanel = panel;
            Init();
        }

        public void Init()
        {
            //suppression de tout les objets du panel
            myPanel.Controls.Clear();

            //création du titre
            title = new Label();
            title.Size = new Size(300, 40);
            title.Location = new Point(200, 25);
            title.Font = new Font("Arial", 15, FontStyle.Bold);
            title.Text = "Nouveau dossier";
            myPanel.Controls.Add(title);

            //création du textbox nom animal
            nameAnimal = new ComboBox();
            nameAnimal.Size = new Size(100, 40);
            nameAnimal.Location = new Point(100, 100);
            nameAnimal.Text = "Nom animal";
            myPanel.Controls.Add(nameAnimal);

            //création du textbox nom client
            nameClient = new ComboBox();
            nameClient.Size = new Size(100, 40);
            nameClient.Location = new Point(100, 150);
            nameClient.Text = "Nom client";
            myPanel.Controls.Add(nameClient);

            //création du textbox note
            note = new RichTextBox();
            note.Size = new Size(300, 100);
            note.Location = new Point(100, 200);
            note.Text = "Note : \nExemple : fatigue,pate droite cassée ..";
            myPanel.Controls.Add(note);
           
            //création de la date
            dateCourante = new DateTimePicker();
            dateCourante.Size = new Size(100, 40);
            dateCourante.Format = DateTimePickerFormat.Short;
            dateCourante.ValueChanged += new EventHandler(date_Change);
            dateCourante.Value = DateTime.Now.AddDays(0);
            dateCourante.Location = new Point(100, 350);
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


        }

        private void valider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valider");
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
            note.Text = "Note : \nExemple : fatigue,pate droite cassée ..";
        }
    }
}
