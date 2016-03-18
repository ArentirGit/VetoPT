using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class ModifyReminder
    {
        private Panel addReminderPanel;
        private int reminder_id;
        DataBase.DataBaseManagement db;

        public ModifyReminder(Panel addReminderPanel, int reminder_id)
        {
            this.addReminderPanel = addReminderPanel;
            this.reminder_id = reminder_id;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            addReminderPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Modifier un rappel";
            addReminderPanel.Controls.Add(title);
            // intitule
            TextBox name = new TextBox();
            name.Size = new Size(150, 30);
            name.Location = new Point(205, 100);
            name.Text = db.getReminder(reminder_id);
            addReminderPanel.Controls.Add(name);
            // animal
            ComboBox animal = new ComboBox();
            animal.Size = new Size(150, 30);
            animal.Location = new Point(205, 130);
            animal.Text = "Animal";
            List<string> animals = db.getAnimals();
            foreach (string a in animals) {
                animal.Items.Add(a);
            }
            addReminderPanel.Controls.Add(animal);
            // Date
            DateTimePicker date = new DateTimePicker();
            date.Format = DateTimePickerFormat.Long;
            date.Size = new Size(150, 30);
            date.Location = new Point(205, 160);
            addReminderPanel.Controls.Add(date);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 350);
            confirmButton.Text = "Confirmer";
            confirmButton.Click += (sender, eventArgs) => { db.updateReminder(this.reminder_id, date.Text, name.Text); };
            confirmButton.Click += new EventHandler(displayReminders);
            addReminderPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 350);
            cancelButton.Text = "Annuler";
            cancelButton.Click += new EventHandler(displayReminders);
            addReminderPanel.Controls.Add(cancelButton);
        }

        private void displayReminders(object sender, EventArgs e)
        {
            new DisplayReminders(addReminderPanel);
        }
    }
}
