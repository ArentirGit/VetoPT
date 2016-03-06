using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.EmployeeManagement
{
    class DisplayPaySlip
    {
        private Panel displayPaySlipPanel;
        DataBase.DataBaseManagement db;



        public DisplayPaySlip(Panel displayPaySlipPanel)
        {
            this.displayPaySlipPanel = displayPaySlipPanel;
            Init();
        }

        public void Init()
        {
        }
    }
}
