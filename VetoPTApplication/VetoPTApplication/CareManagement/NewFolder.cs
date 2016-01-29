using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class NewFolder
    {
        private Panel myPanel;

        private Button validate;
        private Button cancel;

        private TextBox nameAnimal;
        private Label title;

        public NewFolder(Panel panel)
        {
            myPanel = panel;
            Init();
        }

        public void Init()
        {
            //suppression de tout les objets du panel
            myPanel.Controls.Clear();
            //création du boutton valider
            validate = new Button();
            validate.Size = new Size(60, 40);
            validate.Location = new Point(200, 400);
            validate.Text = "Valider";
            myPanel.Controls.Add(validate);
            validate.Click += new EventHandler(valider_Click);
            //création du boutton annuler
            cancel = new Button();
            cancel.Size = new Size(60, 40);
            cancel.Location = new Point(400, 400);
            cancel.Text = "Annuler";
            myPanel.Controls.Add(cancel);
            cancel.Click += new EventHandler(cancel_Click);
            //création du textbox nom animal
            nameAnimal = new TextBox();
            nameAnimal.Size = new Size(100, 40);
            nameAnimal.Location = new Point(100, 100);
            nameAnimal.Text = "Nom animal";
            myPanel.Controls.Add(nameAnimal);
            //création du titre
            title = new Label();
            title.Size = new Size(300, 40);
            title.Location = new Point(200, 50);
            title.Font = new Font("Arial",15,FontStyle.Bold);
            title.Text = "Nouveau dossier";
            myPanel.Controls.Add(title);

        }

        private void valider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valider");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Annuler");
        }
    }
}
