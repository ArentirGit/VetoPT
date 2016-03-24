using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.StockManagement
{
    class AddProduct
    {
        private Panel AddProductPanel;
        DataBase.DataBaseManagement db;

        Label title;

        TextBox reference;
        TextBox quantite;
        TextBox prix;

        Button confirmButton;
        Button cancelButton;
        public AddProduct(Panel AddProductPanel)
        {
            this.AddProductPanel = AddProductPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            AddProductPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Ajouter un produit";
            AddProductPanel.Controls.Add(title);
            // référence
            reference = new TextBox();
            reference.Size = new Size(150, 30);
            reference.Location = new Point(205, 100);
            reference.Text = "Référence";
            AddProductPanel.Controls.Add(reference);
            // quantité
            quantite = new TextBox();
            quantite.Size = new Size(150, 30);
            quantite.Location = new Point(205, 135);
            quantite.Text = "Quantité";
            AddProductPanel.Controls.Add(quantite);
            // prix
            prix = new TextBox();
            prix.Size = new Size(150, 30);
            prix.Location = new Point(205, 170);
            prix.Text = "Prix";
            AddProductPanel.Controls.Add(prix);
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 220);
            confirmButton.Text = "Confirmer";
            AddProductPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 220);
            cancelButton.Text = "Annuler";
            AddProductPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            db.addProduct(reference.Text, Int32.Parse(quantite.Text), Double.Parse(prix.Text));
            clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            reference.Text = "Référence";
            quantite.Text = "Quantité";
            prix.Text = "Prix";

        }
    }
}
