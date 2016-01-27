using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class NewFolder
    {
        private Panel myPanel;
        NewFolder(Panel panel)
        {
            myPanel = panel;
        }

        void execute()
        {
            myPanel.Controls.Clear();
        }

    }
}
