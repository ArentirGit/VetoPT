using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.AnimalManagement
{
    class DisplayAnimals
    {
        private Panel displayAnimalsPanel;

        public DisplayAnimals(Panel displayAnimalsPanel)
        {
            this.displayAnimalsPanel = displayAnimalsPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            displayAnimalsPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "PAGE AFFICHER ANIMAUX";
            displayAnimalsPanel.Controls.Add(title);
        }
    }
}
