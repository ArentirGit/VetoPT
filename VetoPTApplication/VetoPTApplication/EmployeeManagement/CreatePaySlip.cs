using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.EmployeeManagement
{
    class CreatePaySlip
    {
        private Panel createPaySlipPanel;
        DataBase.DataBaseManagement db;



        public CreatePaySlip(Panel createPaySlipPanel)
        {
            this.createPaySlipPanel = createPaySlipPanel;
            Init();
        }

        public void Init()
        {
        }
    }
}
