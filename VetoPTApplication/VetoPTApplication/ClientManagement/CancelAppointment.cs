﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    class CancelAppointment
    {
        private Panel CancelAppointementPanel;

        Label title;

        ComboBox client;
        ComboBox animal;
        MonthCalendar calendar;
        Label reason;

        List<string> clients;
        List<string> animals;

        Button confirmButton;
        Button cancelButton;

        DataBase.DataBaseManagement db;

        public CancelAppointment(Panel CancelAppointementPanel)
        {
            this.CancelAppointementPanel = CancelAppointementPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            CancelAppointementPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Annuler rendez-vous";
            CancelAppointementPanel.Controls.Add(title);
            // nom
            client = new ComboBox();
            client.Size = new Size(150, 30);
            client.Location = new Point(205, 100);
            client.Text = "Nom";
            client.SelectedIndexChanged += new EventHandler(Client_SelectedIndexChanged);
            CancelAppointementPanel.Controls.Add(client);
            // animal
            animal = new ComboBox();
            animal.Size = new Size(150, 30);
            animal.Location = new Point(205, 130);
            animal.Text = "Animal";
            animal.SelectedIndexChanged += new EventHandler(Animal_SelectedIndexChanged);
            CancelAppointementPanel.Controls.Add(animal);
            // Date
            calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            CancelAppointementPanel.Controls.Add(calendar);
            // raison
            reason = new Label();
            reason.Size = new Size(150, 30);
            reason.Location = new Point(205, 350);
            reason.Text = "Objet du rendez-vous";
            CancelAppointementPanel.Controls.Add(reason);
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 400);
            confirmButton.Text = "Confirmer";
            CancelAppointementPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 400);
            cancelButton.Text = "Annuler";
            CancelAppointementPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);

            completeClient();
        }

        private void completeClient()
        {
            clients = db.DisplayClients();
            client.Items.Clear();
            foreach (string s in clients)
            {
                client.Items.Add(s.Split(':')[1] + " " + s.Split(':')[2]);
            }

        }

        private void Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            animal.Text = "";
            animals = db.getAnimalsClient(client.SelectedIndex);
            animal.Items.Clear();
            foreach (string a in animals)
            {
                animal.Items.Add(a.Split(':')[1]);
            }
        }

        private void Animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string appointment = db.getAppointment(animal.SelectedIndex);
            calendar.SelectionStart = DateTime.Parse(appointment.Split(':')[0]);
            reason.Text = appointment.Split(':')[1];
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            db.cancelAppointment(Int32.Parse(animals[animal.SelectedIndex].Split(':')[0]));
            clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            client.Text = "Nom";
            animal.Text = "Animal";
            reason.Text = "Objet du rendez-vous";

        }

    }
}
