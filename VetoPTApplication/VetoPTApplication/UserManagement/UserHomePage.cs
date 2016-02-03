﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.UserManagement
{
    class UserHomePage
    {
        private Panel userManagementPanel;

        public UserHomePage(Panel userManagementPanel)
        {
            this.userManagementPanel = userManagementPanel;
            Init();
        }

        private void Init()
        {
            userManagementPanel.Controls.Clear();

            Label title = new Label();
            title.Size = new Size(300, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Gestion des utilisateurs";
            userManagementPanel.Controls.Add(title);

            Button displayUsersButton = new Button();
            displayUsersButton.Location = new Point(205, 150);
            displayUsersButton.Text = "Liste des utilisateurs";
            displayUsersButton.Size = new Size(200, 30);
            displayUsersButton.Click += new EventHandler(displayUsers);
            userManagementPanel.Controls.Add(displayUsersButton);

            Button addUserButton = new Button();
            addUserButton.Location = new Point(205, 300);
            addUserButton.Text = "Ajouter un utilisateur";
            addUserButton.Size = new Size(200, 30);
            //displayUsersButton.Click += new EventHandler(addUser);
            userManagementPanel.Controls.Add(addUserButton);
        }

        private void displayUsers(object sender, EventArgs e)
        {
            new DisplayUsers(userManagementPanel);
        }
    }
}
