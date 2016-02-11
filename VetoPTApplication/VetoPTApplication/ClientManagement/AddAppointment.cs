﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class AddAppointment
    {
         private Panel AddAppointementPanel;

         public AddAppointment(Panel AddAppointementPanel)
        {
            this.AddAppointementPanel = AddAppointementPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            AddAppointementPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter rendez-vous";
            AddAppointementPanel.Controls.Add(title);
            // nom
            ComboBox name = new ComboBox();
            name.Size = new Size(150, 30);
            name.Location = new Point(205, 100);
            name.Text = "Nom";    
            AddAppointementPanel.Controls.Add(name);
            // animal
            ComboBox animal = new ComboBox();
            animal.Size = new Size(150, 30);
            animal.Location = new Point(205, 130);
            animal.Text = "Animal";
            AddAppointementPanel.Controls.Add(animal);
            // Date
            MonthCalendar calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            AddAppointementPanel.Controls.Add(calendar);
            // raison
            TextBox reason = new TextBox();
            reason.Size = new Size(150, 30);
            reason.Location = new Point(205, 350);
            reason.Text = "Objet du rendez-vous";
            AddAppointementPanel.Controls.Add(reason);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 400);
            confirmButton.Text = "Confirmer";
            AddAppointementPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 400);
            cancelButton.Text = "Annuler";
            AddAppointementPanel.Controls.Add(cancelButton);
        }

        public Control animal { get; set; }
    }
}
