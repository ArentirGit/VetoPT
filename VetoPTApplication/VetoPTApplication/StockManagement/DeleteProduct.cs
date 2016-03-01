using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.StockManagement
{
    class DeleteProduct
    {
        private Panel deleteProductPanel;

        Label title;

        ComboBox product;
        TextBox quantity;

        Button confirmButton;
        Button cancelButton;

        public DeleteProduct(Panel deleteProductPanel)
        {
            this.deleteProductPanel = deleteProductPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            deleteProductPanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Retirer un produit";
            deleteProductPanel.Controls.Add(title);
            // produit 
            product = new ComboBox();
            product.Size = new Size(100, 30);
            product.Location = new Point(230, 100);
            product.Text = "Produit";
            deleteProductPanel.Controls.Add(product);
            // quantité 
            quantity = new TextBox();
            quantity.Size = new Size(100, 30);
            quantity.Location = new Point(230, 160);
            quantity.Text = "Quantité";
            deleteProductPanel.Controls.Add(quantity);                      
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            deleteProductPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            deleteProductPanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmer");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            product.Text = "Produit";
            quantity.Text = "Quantité";
        }
    }
}
