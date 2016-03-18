using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.UserManagement
{
    class ModifyUser
    {
        private Panel modifyUserPanel;
        private int user_id;
        private DataBase.DataBaseManagement db;

        private List<String> ranks;
        private ComboBox rank;
        private int rank_id;

        public ModifyUser(Panel modifyUserPanel, int user_id)
        {
            this.modifyUserPanel = modifyUserPanel;
            this.user_id = user_id;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            modifyUserPanel.Controls.Clear();
            // titre
            Label title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Modifier un utilisateur";
            modifyUserPanel.Controls.Add(title);
            int y = 100;   // ordonnee labels
            //String details = db.displayAnimalDetails(user_id);
            // nom 
            TextBox name = new TextBox();
            name.Size = new Size(100, 30);
            name.Location = new Point(230, y);
            name.Text = "Nom";
            modifyUserPanel.Controls.Add(name);
            y += 30;
            // prenom 
            TextBox first_name = new TextBox();
            first_name.Size = new Size(100, 30);
            first_name.Location = new Point(230, y);
            first_name.Text = "Prénom";
            modifyUserPanel.Controls.Add(first_name);
            y += 30;
            // mail
            TextBox mail = new TextBox();
            mail.Size = new Size(100, 30);
            mail.Location = new Point(230, y);
            mail.Text = "Mail";
            modifyUserPanel.Controls.Add(mail);
            y += 30;
            // rang
            rank = new ComboBox();
            rank.Size = new Size(100, 30);
            rank.Location = new Point(230, y);
            rank.SelectedText = "Rang";
            rank_id = db.findSpecyIdByName(rank.SelectedText);
            ranks = new List<String>();
            ranks.Add("Administrateur"); ranks.Add("Vétérinaire"); ranks.Add("Assistant(e)"); 
            foreach (string r in ranks) {
                rank.Items.Add(r);
            }
            //rank.SelectedIndexChanged += new EventHandler(rankChange);
            modifyUserPanel.Controls.Add(rank);
            y += 30;
            // identifiant
            TextBox login = new TextBox();
            login.Size = new Size(100, 30);
            login.Location = new Point(230, y);
            login.Text = "Login";
            modifyUserPanel.Controls.Add(login);
            y += 30;
            // mot de passe
            TextBox password = new TextBox();
            password.Size = new Size(100, 30);
            password.Location = new Point(230, y);
            password.Text = "Mot de passe";
            modifyUserPanel.Controls.Add(password);
            y += 30;
            // nouveau mot de passe
            TextBox new_password = new TextBox();
            new_password.Size = new Size(100, 30);
            new_password.Location = new Point(230, y);
            new_password.Text = "Nouveau mot de passe";
            modifyUserPanel.Controls.Add(new_password);
            y += 30;
            // confirmation nouveau mot de passe
            TextBox new_password_confirm = new TextBox();
            new_password_confirm.Size = new Size(100, 30);
            new_password_confirm.Location = new Point(230, y);
            new_password_confirm.Text = "Confirmation nouveau mot de passe";
            modifyUserPanel.Controls.Add(new_password_confirm);
            // bouton modifier
            Button confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 360);
            confirmButton.Text = "Modifier";
            confirmButton.Click += (sender, eventArgs) => {db.updateUser(rank.Text, login.Text, new_password.Text , user_id);};
            confirmButton.Click += new EventHandler(displayUsers);
            modifyUserPanel.Controls.Add(confirmButton);
            // bouton Annuler
            Button backButton = new Button();
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(310, 360);
            backButton.Text = "Annuler";
            backButton.Click += new EventHandler(displayUsers);
            modifyUserPanel.Controls.Add(backButton);
        }

        public void rankChange(object sender, EventArgs e)
        {
            rank_id = Int32.Parse(ranks[rank.SelectedIndex].Split(':')[rank.SelectedIndex]);
        }

        public void displayUsers(object sender, EventArgs e)
        {
            new DisplayUsers(modifyUserPanel);
        }
    }
}
