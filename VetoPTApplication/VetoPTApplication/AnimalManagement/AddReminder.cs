using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class AddReminder
    {
        private Panel addReminderPane;

        public AddReminder(Panel addReminderPane)
        {
            this.addReminderPane = addReminderPane;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            addReminderPane.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter un rappel";
            addReminderPane.Controls.Add(title);
            // intitule
            TextBox name = new TextBox();
            name.Size = new Size(150, 30);
            name.Location = new Point(205, 100);
            name.Text = "Intitulé";    
            addReminderPane.Controls.Add(name);
            // animal
            ComboBox owner = new ComboBox();
            owner.Size = new Size(150, 30);
            owner.Location = new Point(205, 130);
            owner.Text = "Animal";
            addReminderPane.Controls.Add(owner);
            // Date
            MonthCalendar calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            addReminderPane.Controls.Add(calendar);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 350);
            confirmButton.Text = "Confirmer";
            confirmButton.Click += new EventHandler(displayReminders);
            addReminderPane.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 350);
            cancelButton.Text = "Annuler";
            cancelButton.Click += new EventHandler(homePage);
            addReminderPane.Controls.Add(cancelButton);
        }

        private void homePage(object sender, EventArgs e)
        {
            new HomePage(addReminderPane);
        }

        private void displayReminders(object sender, EventArgs e)
        {
            new DisplayReminders(addReminderPane);
        }
    }
}
