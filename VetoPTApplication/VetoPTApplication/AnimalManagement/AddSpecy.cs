using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class AddSpecy
    {
        private Panel addSpecyPanel;

        public AddSpecy(Panel addSpecyPanel)
        {
            this.addSpecyPanel = addSpecyPanel;
            Init();
        }

        public void Init()
        {
            DataBase.DataBaseManagement db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            addSpecyPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter une espèce";
            addSpecyPanel.Controls.Add(title);
            // intitule
            TextBox specy = new TextBox();
            specy.Size = new Size(150, 30);
            specy.Location = new Point(205, 100);
            specy.Text = "Intitulé";
            addSpecyPanel.Controls.Add(specy);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 350);
            confirmButton.Text = "Confirmer";
            confirmButton.Click += (sender, eventArgs) => { db.insertSpecy(specy.Text); };
            confirmButton.Click += new EventHandler(homePage);
            addSpecyPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 350);
            cancelButton.Text = "Annuler";
            cancelButton.Click += new EventHandler(homePage);
            addSpecyPanel.Controls.Add(cancelButton);
        }

        private void homePage(object sender, EventArgs e)
        {
            new HomePage(addSpecyPanel);
        }
    }
}
