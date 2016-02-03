using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class DisplayFolder
    {
        private Panel myPanel;
        

        public DisplayFolder(Panel panel)
        {
            myPanel = panel;
            Init();
        }

        public void Init()
        {
            //suppression de tout les objets du panel
            myPanel.Controls.Clear();          


        }
    }
}
