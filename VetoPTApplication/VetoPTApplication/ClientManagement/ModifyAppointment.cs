using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class ModifyAppointment
    {
         private Panel ModifyAppointementPanel;

         Label title;

         ComboBox name;
         ComboBox animal;

         MonthCalendar calendar;
         TextBox reason;

         Button confirmButton;
         Button cancelButton;

         public ModifyAppointment(Panel ModifyAppointementPanel)
        {
            this.ModifyAppointementPanel = ModifyAppointementPanel;
            Init();
        }

        public void Init()
        {
            DataBase.DataBaseManagement db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            ModifyAppointementPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Modifier rendez-vous";
            ModifyAppointementPanel.Controls.Add(title);
            // nom
            name = new ComboBox();
            name.Size = new Size(150, 30);
            name.Location = new Point(205, 100);
            name.Text = "Nom";    
            ModifyAppointementPanel.Controls.Add(name);
            // animal
            animal = new ComboBox();
            animal.Size = new Size(150, 30);
            animal.Location = new Point(205, 130);
            animal.Text = "Animal";
            ModifyAppointementPanel.Controls.Add(animal);
            // Date
            calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            ModifyAppointementPanel.Controls.Add(calendar);
            // raison
            reason = new TextBox();
            reason.Size = new Size(150, 30);
            reason.Location = new Point(205, 350);
            reason.Text = "Objet du rendez-vous";
            ModifyAppointementPanel.Controls.Add(reason);
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 400);
            confirmButton.Text = "Confirmer";
            ModifyAppointementPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 400);
            cancelButton.Text = "Annuler";
            ModifyAppointementPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmer");
        }

        private void clear()
        {
            name.Text = "Nom";
            animal.Text = "Animal";
            reason.Text = "Objet du rendez-vous";
        }


    }
}
