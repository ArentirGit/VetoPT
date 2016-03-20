using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.StockManagement
{
    class DisplayProducts
    {
        private Panel DisplayProductsPanel;
        Label title;

        Label productsList;

        DataBase.DataBaseManagement db;

        public DisplayProducts(Panel DisplayProductsPanel)
        {
            this.DisplayProductsPanel = DisplayProductsPanel;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            DisplayProductsPanel.Controls.Clear();

            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Size = new Size(90, 30);
            title.Font = new Font("Arial", 15);
            title.Location = new Point(170, 20);
            title.Text = "Clients";
            DisplayProductsPanel.Controls.Add(title);
            // liste des clients
            productsList = new Label();
            productsList.Location = new Point(60, 80);
            productsList.Size = new Size(75, 1000);
            completeProductsList();
            DisplayProductsPanel.Controls.Add(productsList);
        }

        private void completeProductsList()
        {
            int y = 75;     // ordonnee boutons pour chaque produit
            foreach (string p in db.DisplayProducts())
            {
                productsList.Text += p.Split(':')[1] + "\n\n";
                int product_id = Int32.Parse(p.Split(':')[0]);
                // bouton modifier prix
                Button modifyPriceButton = new Button();
                modifyPriceButton.Location = new Point(145, y);
                modifyPriceButton.Text = "Modifier le prix";
                modifyPriceButton.Size = new Size(75, 20);
                modifyPriceButton.Click += (sender, eventArgs) => modifyPrice_Click(sender, eventArgs, product_id);
                DisplayProductsPanel.Controls.Add(modifyPriceButton);
                // bouton retirer
                Button deleteProductButton = new Button();
                deleteProductButton.Location = new Point(230, y);
                deleteProductButton.Text = "Retirer";
                deleteProductButton.Size = new Size(75, 20);
                deleteProductButton.Click += (sender, eventArgs) => deleteProduct_Click(sender, eventArgs, product_id);
                DisplayProductsPanel.Controls.Add(deleteProductButton);
                y += 27;
            }
        }

        private void deleteProduct_Click(object sender, EventArgs eventArgs, int product_id)
        {
            db.deleteProduct(product_id);
            Init();
        }

        private void modifyPrice_Click(object sender, EventArgs eventArgs, int product_id)
        {
            new ModifyPrice(DisplayProductsPanel, product_id);
        }
    }
}
