using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.EmployeeManagement
{
    class HomePage
    {
        private Panel employeeManagementPanel;

        public HomePage(Panel employeeManagementPanel)
        {
            this.employeeManagementPanel = employeeManagementPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            employeeManagementPanel.Controls.Clear();
            // MENU //
            // titre
            Label title = new Label();
            title.Size = new Size(300, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Gestion des salariés";
            employeeManagementPanel.Controls.Add(title);
            // bouton afficher fiches de paie
            Button displayPaySlipButton = new Button();
            displayPaySlipButton.Location = new Point(205, 100);
            displayPaySlipButton.Text = "Afficher fiches de paie";
            displayPaySlipButton.Size = new Size(200, 30);
            displayPaySlipButton.Click += new EventHandler(displayPaySlip);
            employeeManagementPanel.Controls.Add(displayPaySlipButton);
            // bouton créer fiche de paie
            Button createPaySlipButton = new Button();
            createPaySlipButton.Location = new Point(205, 150);
            createPaySlipButton.Text = "Créer fiche de paie";
            createPaySlipButton.Size = new Size(200, 30);
            createPaySlipButton.Click += new EventHandler(createPaySlip);
            employeeManagementPanel.Controls.Add(createPaySlipButton);
            // bouton ajouter période de congés
            Button addLeavePeriodButton = new Button();
            addLeavePeriodButton.Location = new Point(205, 200);
            addLeavePeriodButton.Text = "Ajouter période de congés";
            addLeavePeriodButton.Size = new Size(200, 30);
            addLeavePeriodButton.Click += new EventHandler(addLeavePeriod);
            employeeManagementPanel.Controls.Add(addLeavePeriodButton);
            
        }

        private void displayPaySlip(object sender, EventArgs e)
        {
            new DisplayPaySlip(employeeManagementPanel);
        }

        private void createPaySlip(object sender, EventArgs e)
        {
            new CreatePaySlip(employeeManagementPanel);
        }

        private void addLeavePeriod(object sender, EventArgs e)
        {
            new AddLeavePeriod(employeeManagementPanel);
        }
    }
}
