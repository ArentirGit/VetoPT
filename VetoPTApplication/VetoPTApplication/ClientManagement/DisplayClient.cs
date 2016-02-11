using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.ClientManagement
{
    
    class DisplayClient
    {
        private Panel displayClientsPanel;
        public DisplayClient(Panel displayClientsPanel)
        {
            this.displayClientsPanel = displayClientsPanel;
            Init();
        }

        public void Init()
        {
         // suppression de tout les objets du panel
            displayClientsPanel.Controls.Clear();
            // titre
            /*
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "PAGE AFFICHER ANIMAUX";
            displayClientsPanel.Controls.Add(title);
            */
        }
    }
    
}
