using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.StockManagement
{
    class HomePage
    {
        private Panel stockManagementPanel;

        public HomePage(Panel stockManagementPanel)
        {
            this.stockManagementPanel = stockManagementPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            stockManagementPanel.Controls.Clear();
            // MENU //
            // titre

            Label title = new Label();
            title.Size = new Size(300, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Gestion du stock";
            stockManagementPanel.Controls.Add(title);

            // bouton afficher les produits
            Button displayProductsButton = new Button();
            displayProductsButton.Location = new Point(205, 100);
            displayProductsButton.Text = "Afficher Produits";
            displayProductsButton.Size = new Size(200, 30);
            stockManagementPanel.Controls.Add(displayProductsButton);
            displayProductsButton.Click += new EventHandler(displayProducts_Click);
            // bouton ajouter un produit
            Button addProductButton = new Button();
            addProductButton.Location = new Point(205, 150);
            addProductButton.Text = "Ajouter un produit";
            addProductButton.Size = new Size(200, 30);
            stockManagementPanel.Controls.Add(addProductButton);
            addProductButton.Click += new EventHandler(addProduct_Click);
            // bouton modifier un prix
            Button modifyPriceButton = new Button();
            modifyPriceButton.Location = new Point(205, 200);
            modifyPriceButton.Text = "Modifier un prix";
            modifyPriceButton.Size = new Size(200, 30);
            stockManagementPanel.Controls.Add(modifyPriceButton);
            modifyPriceButton.Click += new EventHandler(modifyPrice_Click);
            // bouton retirer un produit
            Button deleteProductButton = new Button();
            deleteProductButton.Location = new Point(205, 250);
            deleteProductButton.Text = "Retirer un produit";
            deleteProductButton.Size = new Size(200, 30);
            stockManagementPanel.Controls.Add(deleteProductButton);
            deleteProductButton.Click += new EventHandler(deleteProduct_Click);

        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            //StockManagement.DeleteProduct dc = new StockManagement.DeleteProduct(this.stockManagementPanel);
        }

        private void modifyPrice_Click(object sender, EventArgs e)
        {
            StockManagement.ModifyPrice mc = new StockManagement.ModifyPrice(this.stockManagementPanel);
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            //StockManagement.AddProduct ac = new StockManagement.AddProduct(this.stockManagementPanel);
        }

        private void displayProducts_Click(object sender, EventArgs e)
        {
            //StockManagement.DisplayProducts dc = new StockManagement.DisplayProducts(this.stockManagementPanel);
        }
    }
}
