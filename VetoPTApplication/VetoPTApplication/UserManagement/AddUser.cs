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
        DataBase.DataBaseManagement db;

        public AddUser(Panel addUserPanel)
        {
            this.addUserPanel = addUserPanel;
            Init();
        }

        private void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            addUserPanel.Controls.Clear();
            int y = 100;
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter un utilisateur";
            addUserPanel.Controls.Add(title);
            // nom
            TextBox name = new TextBox();
            name.Size = new Size(150, 30);
            name.Location = new Point(205, y);
            name.Text = "Nom";
            addUserPanel.Controls.Add(name);
            y += 30;
            // prenom
            TextBox first_name = new TextBox();
            first_name.Size = new Size(150, 30);
            first_name.Location = new Point(205, y);
            first_name.Text = "Prénom";
            addUserPanel.Controls.Add(first_name);
            y += 30;
            // adresse mail
            TextBox mail = new TextBox();
            mail.Size = new Size(150, 30);
            mail.Location = new Point(205, y);
            mail.Text = "Adresse e-mail";
            addUserPanel.Controls.Add(mail);
            y += 30;
            // rang
            ComboBox rank = new ComboBox();
            rank.Size = new Size(150, 30);
            rank.Location = new Point(205, y);
            rank.Text = "Rang";
            List<string> ranks = new List<string>();
            ranks.Add("Administrateur"); ranks.Add("Vétérinaire"); ranks.Add("Assistant(e)"); 
            foreach (string r in ranks)
            {
                rank.Items.Add(r);
            }
            addUserPanel.Controls.Add(rank);
            y += 30;
            // nom d'utilisateur
            TextBox user_login = new TextBox();
            user_login.Size = new Size(150, 30);
            user_login.Location = new Point(205, y);
            user_login.Text = "Nom d'utilisateur";
            addUserPanel.Controls.Add(user_login);
            y += 30;
            // mot de passe
            TextBox user_password = new TextBox();
            user_password.Size = new Size(150, 30);
            user_password.Location = new Point(205, y);
            user_password.Text = "Mot de passe";
            addUserPanel.Controls.Add(user_password);
            y += 30;
            // confirmation mot de passe
            TextBox user_password_confirm = new TextBox();
            user_password_confirm.Size = new Size(150, 30);
            user_password_confirm.Location = new Point(205, y);
            user_password_confirm.Text = "Confirmation mot de passe";
            addUserPanel.Controls.Add(user_password_confirm);
            // bouton confirmer
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 350);
            confirmButton.Text = "Ajouter";
            confirmButton.Click += (sender, eventArgs) => { db.insertUser(rank.Text, user_login.Text, user_password.Text); };
            confirmButton.Click += new EventHandler(displayUsers);
            addUserPanel.Controls.Add(confirmButton);
            // bouton annuler
            Button cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 350);
            cancelButton.Text = "Annuler";
            cancelButton.Click += new EventHandler(userHomePage);
            addUserPanel.Controls.Add(cancelButton);
        }

        private void userHomePage(object sender, EventArgs e)
        {
            new UserHomePage(addUserPanel);
        }

        private void displayUsers(object sender, EventArgs e)
        {
            new DisplayUsers(addUserPanel);
        }
    }
}
