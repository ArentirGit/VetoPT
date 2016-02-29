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

        Label title;

        ComboBox product;
        TextBox price;

        Button confirmButton;
        Button cancelButton;

        public ModifyPrice(Panel modifyPricePanel)
        {
            this.modifyPricePanel = modifyPricePanel;
            Init();
        }

        public void Init()
        {
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
            price.Text = "Prix";
        }
    }
}
