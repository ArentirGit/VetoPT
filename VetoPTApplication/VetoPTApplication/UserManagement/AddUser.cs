using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.UserManagement
{
    class AddUser
    {
        private Panel addUserPanel;

        public AddUser(Panel addUserPanel)
        {
            this.addUserPanel = addUserPanel;
            Init();
        }

        private void Init()
        {
            addUserPanel.Controls.Clear();

            Label title = new Label();
            title.Size = new Size(300, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter un utilisateur";
            addUserPanel.Controls.Add(title);
        }
    }
}
