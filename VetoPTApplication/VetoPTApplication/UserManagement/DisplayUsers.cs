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
        DataBase.DataBaseManagement db;

        public DisplayUsers(Panel displayUsersPanel)
        {
            this.displayUsersPanel = displayUsersPanel;
            Init();
        }

        private void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            displayUsersPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "Utilisateurs";
            displayUsersPanel.Controls.Add(title);
            // liste des utilisateurs
            Label usersList = new Label();
            usersList.Location = new Point(60, 80);
            usersList.Size = new Size(75, 1000);
            int x = 145;     // abscisse boutons 
            int y = 75;      // ordonnee boutons pour chaque utilisateur
            foreach (string s in db.displayUsers())
            {
                usersList.Text += s.Split(':')[1] + "\n\n";
                int user_id = Int32.Parse(s.Split(':')[0]);
                // bouton modifier 
                Button modUserButton = new Button();
                modUserButton.Location = new Point(x, y);
                modUserButton.Text = "Modifier";
                modUserButton.Size = new Size(75, 20);
                modUserButton.Click += (sender, eventArgs) => modifyUser(sender, eventArgs, user_id);
                displayUsersPanel.Controls.Add(modUserButton);
                x += 85;
                // bouton supprimer 
                Button delUserButton = new Button();
                delUserButton.Location = new Point(x, y);
                delUserButton.Text = "Supprimer";
                delUserButton.Size = new Size(75, 20);
                delUserButton.Click += (sender, eventArgs) => { db.deleteUser(user_id); };
                delUserButton.Click += new EventHandler(refreshUsers);
                displayUsersPanel.Controls.Add(delUserButton);
                x = 145;
                y += 27;
            }
            displayUsersPanel.Controls.Add(usersList);
        }

        public void modifyUser(object sender, EventArgs e, int user_id)
        {
            new ModifyUser(displayUsersPanel, user_id);
        }

        public void refreshUsers(object sender, EventArgs e)
        {
            new DisplayUsers(displayUsersPanel);
        }
    }
}
