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
        DataBase.DataBaseManagement db;

        Label title;

        ComboBox product;
        Label quantity;

        Button confirmButton;
        Button cancelButton;

        List<string> products;

        public DeleteProduct(Panel deleteProductPanel)
        {
            this.deleteProductPanel = deleteProductPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
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
            product.SelectedIndexChanged += new EventHandler(product_SelectedIndexChanged);
            deleteProductPanel.Controls.Add(product);
            // quantité 
            quantity = new Label();
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

            completeProducts();
        }

        private void completeProducts()
        {
            products = db.DisplayProducts();
            foreach (string p in products)
            {
                product.Items.Add(p.Split(':')[1]);
            }
        }

        private void product_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantity.Text = products[product.SelectedIndex].Split(':')[3];
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            db.deleteProduct(Int32.Parse(products[product.SelectedIndex].Split(':')[0]));
            product.Items.Clear();
            completeProducts();
            clear();
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
