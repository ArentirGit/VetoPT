using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class DetailsTreatments
    {
                private Panel myPanel;

        private Label title;

        private Button validate;
        private Button cancel;

        private Label nameTreatments;
        private Label objectTreatments;
        private Label durationTreatments;
        private RichTextBox comment;
        private DateTimePicker beginingDate;
        

        public DetailsTreatments(Panel panel)
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
            title.Text = "Details Traitement";
            myPanel.Controls.Add(title);

            //création du nom traitement
            nameTreatments = new Label();
            nameTreatments.Size = new Size(300, 40);
            nameTreatments.Location = new Point(100, 70);
            nameTreatments.Text = "Nom Traitement";
            myPanel.Controls.Add(nameTreatments);

            //création du textbox nom client
            objectTreatments = new Label();
            objectTreatments.Size = new Size(300, 40);
            objectTreatments.Location = new Point(100, 120);
            objectTreatments.Text = "Objet Traitement";
            myPanel.Controls.Add(objectTreatments);

            durationTreatments = new Label();
            durationTreatments.Size = new Size(300, 40);
            durationTreatments.Location = new Point(100, 170);
            durationTreatments.Text = "Durées Traitements";
            myPanel.Controls.Add(durationTreatments);

            //création de la date
            beginingDate = new DateTimePicker();
            beginingDate.Size = new Size(300, 40);
            beginingDate.Format = DateTimePickerFormat.Short;
            beginingDate.ValueChanged += new EventHandler(date_Change);
            beginingDate.Value = new DateTime(2012,10,30);
            beginingDate.Location = new Point(100, 220);
            myPanel.Controls.Add(beginingDate);

            //création du textbox note
            comment = new RichTextBox();
            comment.Size = new Size(300, 100);
            comment.Location = new Point(100, 270);
            comment.Text = "Commentaire : \nExemple : \n - a declancher insomnie chez l'animal";
            myPanel.Controls.Add(comment);
           


            //création du boutton valider
            validate = new Button();
            validate.Size = new Size(60, 40);
            validate.Location = new Point(100, 400);
            validate.Text = "Valider";
            myPanel.Controls.Add(validate);
            validate.Click += new EventHandler(valider_Click);

            //création du boutton annuler
            cancel = new Button();
            cancel.Size = new Size(60, 40);
            cancel.Location = new Point(200, 400);
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
            beginingDate.Value = new DateTime(2012, 10, 30);
        }

        private void clear()
        {
            comment.Text = "Commentaire : \nExemple : \n - a declancher insomnie chez l'animal";
        }
    }
}
