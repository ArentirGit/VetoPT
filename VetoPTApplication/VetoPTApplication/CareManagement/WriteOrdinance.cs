using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class WriteOrdinance
    {
        private Panel myPanel;

        private Label title;
        private DateTimePicker dateCourante;
        private TextBox nomRemede;
        private TextBox duree;
        private Button validate;
        private Button cancel;


        public WriteOrdinance(Panel panel)
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
            title.Text = "Rédiger Ordonance";
            myPanel.Controls.Add(title);

            nomRemede = new TextBox();
            nomRemede.Size = new Size(100, 40);
            nomRemede.Location = new Point(100, 100);
            nomRemede.Text = "Nom du remède";
            myPanel.Controls.Add(nomRemede);

            duree = new TextBox();
            duree.Size = new Size(100, 40);
            duree.Location = new Point(100, 160);
            duree.Text = "Durée";
            myPanel.Controls.Add(duree);
            //création de la date
            dateCourante = new DateTimePicker();
            dateCourante.Size = new Size(100, 40);
            dateCourante.Format = DateTimePickerFormat.Short;
            dateCourante.ValueChanged += new EventHandler(date_Change);
            dateCourante.Value = DateTime.Now.AddDays(0);
            dateCourante.Location = new Point(100, 220);
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

        private void date_Change(object sender, EventArgs e)
        {
            dateCourante.Value = DateTime.Now.AddDays(0);
        }

        private void valider_Click(object sender, EventArgs e)
        {
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            nomRemede.Text = "Nom du remède";
            duree.Text = "Durée";
        }
    }
}
