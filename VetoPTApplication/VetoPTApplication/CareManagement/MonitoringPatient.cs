using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class MonitoringPatient
    {
        private Panel myPanel;


        public MonitoringPatient(Panel panel)
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
