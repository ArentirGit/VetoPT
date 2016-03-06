using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.EmployeeManagement
{
    class AddLeavePeriod
    {
        private Panel AddLeavePeriodPanel;
        DataBase.DataBaseManagement db;

        Label title;

        ComboBox employee;
        ComboBox nbDays;
        MonthCalendar calendar;

        Label employeeLabel;
        Label nbDaysLabel;
        Label calendarLabel;

        Button confirmButton;
        Button cancelButton;

        public AddLeavePeriod(Panel AddLeavePeriodPanel)
        {
            this.AddLeavePeriodPanel = AddLeavePeriodPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            AddLeavePeriodPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter un client";
            AddLeavePeriodPanel.Controls.Add(title);
            // employee 
            employee = new ComboBox();
            employee.Size = new Size(100, 30);
            employee.Location = new Point(230, 100);
            employee.Text = "Employé";
            AddLeavePeriodPanel.Controls.Add(employee);
            // nb jours de congés 
            nbDays = new ComboBox();
            nbDays.Size = new Size(100, 30);
            nbDays.Location = new Point(230, 130);
            nbDays.Text = "Nombre de jours";
            AddLeavePeriodPanel.Controls.Add(nbDays);
            // Date
            calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            AddLeavePeriodPanel.Controls.Add(calendar);
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            AddLeavePeriodPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            AddLeavePeriodPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            employee.Text = "Employé";
            nbDays.Text = "Nombre de jours";
        }
    }
}
