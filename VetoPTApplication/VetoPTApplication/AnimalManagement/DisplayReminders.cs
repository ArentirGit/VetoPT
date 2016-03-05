using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class DisplayReminders
    {
        private Panel displayRemindersPanel;
        private DataBase.DataBaseManagement db;

        public DisplayReminders(Panel displayRemindersPanel)
        {
            this.displayRemindersPanel = displayRemindersPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            displayRemindersPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Size = new Size(90, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "Rappels";
            displayRemindersPanel.Controls.Add(title);
            // bouton ajouter rappel
            Button addReminderButton = new Button();
            addReminderButton.Location = new Point(260, 10);
            addReminderButton.Text = "Ajouter rappel";
            addReminderButton.Size = new Size(150, 30);
            addReminderButton.Click += new EventHandler(addReminder);
            displayRemindersPanel.Controls.Add(addReminderButton);
            // barre de recherche
            TextBox search = new TextBox();
            search.Location = new Point(450, 0);
            search.Text = "Rechercher";
            search.Size = new Size(150, 30);
            displayRemindersPanel.Controls.Add(search);
            // liste des rappels
            Label remindersList = new Label();
            remindersList.Location = new Point(60, 80);
            remindersList.Size = new Size(75, 1000);
            int y = 75;     // ordonnee boutons pour chaque rappels
            foreach (string s in db.getReminders())
            {
                remindersList.Text += s.Split(':')[2] + "\n\n";
                int reminder_id = Int32.Parse(s.Split(':')[0]);
                // bouton modifier rappel
                Button modReminderButton = new Button();
                modReminderButton.Location = new Point(145, y);
                modReminderButton.Text = "Modifier rappel";
                modReminderButton.Size = new Size(75, 20);
                modReminderButton.Click += (sender, eventArgs) => modifyReminder(sender, eventArgs, reminder_id);
                displayRemindersPanel.Controls.Add(modReminderButton);
                // bouton supprimer rappel
                Button delReminderButton = new Button();
                delReminderButton.Location = new Point(230, y);
                delReminderButton.Text = "Supprimer rappel";
                delReminderButton.Size = new Size(75, 20);
                delReminderButton.Click += (sender, eventArgs) => { db.deleteReminder(reminder_id); };
                delReminderButton.Click += new EventHandler(refreshReminders);
                displayRemindersPanel.Controls.Add(delReminderButton);
                y += 27;
            }
            displayRemindersPanel.Controls.Add(remindersList);
        }

        private void addReminder(object sender, EventArgs e)
        {
            new AddReminder(displayRemindersPanel);
        }

        private void modifyReminder(object sender, EventArgs e, int reminder_id)
        {
            new ModifyReminder(displayRemindersPanel, reminder_id);
        }

        public void refreshReminders(object sender, EventArgs e)
        {
            new DisplayReminders(displayRemindersPanel);
        }
    }
}
