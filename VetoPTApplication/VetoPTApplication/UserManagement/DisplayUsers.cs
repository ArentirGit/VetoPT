using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.UserManagement
{
    class DisplayUsers
    {
        private Panel displayUsersPanel;

        public DisplayUsers(Panel displayUsersPanel)
        {
            this.displayUsersPanel = displayUsersPanel;
            Init();
        }

        private void Init()
        {
            displayUsersPanel.Controls.Clear();

            Label title = new Label();
            title.Size = new Size(300, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Liste des Utilisateurs";
            displayUsersPanel.Controls.Add(title);
        }
    }
}
