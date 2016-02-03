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
        private Panel AddReminderPanel;

        public AddReminder(Panel AddReminderPanel)
        {
            this.AddReminderPanel = AddReminderPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            AddReminderPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter un rappel";
            AddReminderPanel.Controls.Add(title);
            // intitule
            TextBox name = new TextBox();
            name.Size = new Size(150, 30);
            name.Location = new Point(205, 100);
            name.Text = "Intitulé";    
            AddReminderPanel.Controls.Add(name);
            // animal
            ComboBox owner = new ComboBox();
            owner.Size = new Size(150, 30);
            owner.Location = new Point(205, 130);
            owner.Text = "Animal";
            AddReminderPanel.Controls.Add(owner);
            // Date
            MonthCalendar calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            AddReminderPanel.Controls.Add(calendar);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 350);
            confirmButton.Text = "Confirmer";
            AddReminderPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 350);
            cancelButton.Text = "Annuler";
            AddReminderPanel.Controls.Add(cancelButton);
        }

        public void RemoveText(object sender, EventArgs e)
        {

        }
    }
}
