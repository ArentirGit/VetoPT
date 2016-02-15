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

         public ModifyAppointment(Panel ModifyAppointementPanel)
        {
            this.ModifyAppointementPanel = ModifyAppointementPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            ModifyAppointementPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Modifier rendez-vous";
            ModifyAppointementPanel.Controls.Add(title);
            // nom
            ComboBox name = new ComboBox();
            name.Size = new Size(150, 30);
            name.Location = new Point(205, 100);
            name.Text = "Nom";    
            ModifyAppointementPanel.Controls.Add(name);
            // animal
            ComboBox animal = new ComboBox();
            animal.Size = new Size(150, 30);
            animal.Location = new Point(205, 130);
            animal.Text = "Animal";
            ModifyAppointementPanel.Controls.Add(animal);
            // Date
            MonthCalendar calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            ModifyAppointementPanel.Controls.Add(calendar);
            // raison
            TextBox reason = new TextBox();
            reason.Size = new Size(150, 30);
            reason.Location = new Point(205, 350);
            reason.Text = "Objet du rendez-vous";
            ModifyAppointementPanel.Controls.Add(reason);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 400);
            confirmButton.Text = "Confirmer";
            ModifyAppointementPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 400);
            cancelButton.Text = "Annuler";
            ModifyAppointementPanel.Controls.Add(cancelButton);
        }

    }
}
