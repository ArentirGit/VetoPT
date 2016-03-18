using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class DisplayAppointmentsAnimal
    {
        private Panel displayAppointmentsPanel;
        private DataBase.DataBaseManagement db;
        private int animal_id;

        public DisplayAppointmentsAnimal(Panel displayAppointmentsPanel, int animal_id)
        {
            this.displayAppointmentsPanel = displayAppointmentsPanel;
            this.animal_id = animal_id;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            displayAppointmentsPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(150, 20);
            title.Text = "Rendez-vous de cet animal";
            displayAppointmentsPanel.Controls.Add(title);
            int y = 100;   // ordonnee labels
            // rendez-vous en rapport avec l'animal
            foreach (String s in db.getAppointmentsAnimal(animal_id))
            {
                Label appointment = new Label();
                appointment.Size = new Size(500, 30);
                appointment.Font = new Font("Arial", 20);
                appointment.Location = new Point(145, y);
                appointment.Text = s;
                y += 50;
            }

            // bouton retour
            Button backButton = new Button();
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(150, 310);
            backButton.Text = "Retour";
            backButton.Click += new EventHandler(displayAnimals);
            displayAppointmentsPanel.Controls.Add(backButton);
        }

        private void displayAnimals(object sender, EventArgs e)
        {
            new DisplayAnimals(displayAppointmentsPanel);
        }
    }
}
