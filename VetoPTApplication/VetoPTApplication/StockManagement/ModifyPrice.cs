using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.StockManagement
{
    class ModifyPrice
    {
        private Panel modifyPricePanel;
        DataBase.DataBaseManagement db;

        Label title;

        ComboBox product;
        TextBox price;

        Button confirmButton;
        Button cancelButton;

        int? code;
        List<string> products;
        string productData;

        public ModifyPrice(Panel modifyPricePanel, int? code)
        {
            this.modifyPricePanel = modifyPricePanel;
            this.code = code;
            Init();
        }

        public void Init()
        {
            db = new DataBase.DataBaseManagement("VetoPTArentir");
            // suppression de tout les objets du panel
            modifyPricePanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(170, 20);
            title.Text = "Modifier un prix";
            modifyPricePanel.Controls.Add(title);
            // produit 
            product = new ComboBox();
            product.Size = new Size(100, 30);
            product.Location = new Point(230, 100);
            product.Text = "Produit";
            product.SelectedIndexChanged += new EventHandler(product_SelectedIndexChanged);
            modifyPricePanel.Controls.Add(product);
            // prix 
            price = new TextBox();
            price.Size = new Size(100, 30);
            price.Location = new Point(230, 160);
            price.Text = "Prix";
            modifyPricePanel.Controls.Add(price);                      
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            modifyPricePanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            modifyPricePanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);

            completeProducts();
        }

        private void completeProducts()
        {
            if (code == null)
            {
                products = db.DisplayProducts();
                foreach (string p in products)
                {
                    product.Items.Add(p.Split(':')[1]);
                }
            }
            else
            {
                productData = db.detailsProduct(code.Value);
                product.Items.Add(productData.Split(':')[1]);
                product.Text = productData.Split(':')[1];
                price.Text = productData.Split(':')[2];
            }
            
        }

        private void product_SelectedIndexChanged(object sender, EventArgs e)
        {
            price.Text = products[product.SelectedIndex].Split(':')[2];
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            db.modifyPrice(product.Text, float.Parse(price.Text));
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
            price.Text = "Prix";
        }
    }
}
