using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.Selling
{
    class HomePage
    {
        private Panel sellingPanel;

        public HomePage(Panel sellingPanel)
        {
            this.sellingPanel = sellingPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            sellingPanel.Controls.Clear();
            // MENU //
            // titre

            Label title = new Label();
            title.Size = new Size(300, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(260, 20);
            title.Text = "Vente";
            sellingPanel.Controls.Add(title);

            // bouton vendre produits
            Button sellProductsButton = new Button();
            sellProductsButton.Location = new Point(205, 100);
            sellProductsButton.Text = "Vendre produit";
            sellProductsButton.Size = new Size(200, 30);
            sellingPanel.Controls.Add(sellProductsButton);
            sellProductsButton.Click += new EventHandler(sellProducts_Click);
            // bouton afficher facture
            Button displayInvoiceButton = new Button();
            displayInvoiceButton.Location = new Point(205, 150);
            displayInvoiceButton.Text = "Afficher facture";
            displayInvoiceButton.Size = new Size(200, 30);
            sellingPanel.Controls.Add(displayInvoiceButton);
            displayInvoiceButton.Click += new EventHandler(displayInvoice_Click);
            // bouton créer facture
            Button createInvoiceButton = new Button();
            createInvoiceButton.Location = new Point(205, 200);
            createInvoiceButton.Text = "Créer une facture";
            createInvoiceButton.Size = new Size(200, 30);
            sellingPanel.Controls.Add(createInvoiceButton);
            createInvoiceButton.Click += new EventHandler(createInvoice_Click);
            // bouton imprimer facture
            Button printInvoiceButton = new Button();
            printInvoiceButton.Location = new Point(205, 250);
            printInvoiceButton.Text = "Imprimer une facture";
            printInvoiceButton.Size = new Size(200, 30);
            sellingPanel.Controls.Add(printInvoiceButton);
            printInvoiceButton.Click += new EventHandler(printInvoice_Click);

        }

        private void printInvoice_Click(object sender, EventArgs e)
        {
            //Selling.PrintInvoice pi = new Selling.PrintInvoice(this.sellingPanel);
        }

        private void createInvoice_Click(object sender, EventArgs e)
        {
            Selling.CreateInvoice ci = new Selling.CreateInvoice(this.sellingPanel);
        }

        private void displayInvoice_Click(object sender, EventArgs e)
        {
            //Selling.DisplayInvoice di = new Selling.DisplayInvoice(this.sellingPanel);
        }

        private void sellProducts_Click(object sender, EventArgs e)
        {
            //Selling.SellProduct sp = new Selling.SellProduct(this.sellingPanel);
        }
    }
}
