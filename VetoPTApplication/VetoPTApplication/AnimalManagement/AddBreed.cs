using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class AddBreed
    {
        private Panel addBreedPanel;

        public AddBreed(Panel addBreedPanel)
        {
            this.addBreedPanel = addBreedPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            addBreedPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter une race";
            addBreedPanel.Controls.Add(title);
            // intitule
            TextBox breed = new TextBox();
            breed.Size = new Size(150, 30);
            breed.Location = new Point(205, 100);
            breed.Text = "Intitulé";
            addBreedPanel.Controls.Add(breed);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 350);
            confirmButton.Text = "Confirmer";
            addBreedPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 350);
            cancelButton.Text = "Annuler";
            addBreedPanel.Controls.Add(cancelButton);
        }
    }
}
