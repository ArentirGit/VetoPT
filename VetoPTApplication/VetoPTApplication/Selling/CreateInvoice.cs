using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.Selling
{
    class CreateInvoice
    {
        private Panel createInvoicePanel;

        Label title;

        ComboBox idCare;
        ComboBox idProduct;
        Button addIdCareButton;
        Button addIdProductButton;

        Button confirmButton;
        Button cancelButton;

        public CreateInvoice(Panel createInvoicePanel)
        {
            this.createInvoicePanel = createInvoicePanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            createInvoicePanel.Controls.Clear();
            // titre
            title = new Label();
            title.Size = new Size(500, 30);
            title.Font = new Font("Arial", 20);
            title.Location = new Point(190, 20);
            title.Text = "Créer facture";
            createInvoicePanel.Controls.Add(title);
            // id soin
            idCare = new ComboBox();
            idCare.Size = new Size(100, 30);
            idCare.Location = new Point(230, 100);
            idCare.Text = "id soin";
            createInvoicePanel.Controls.Add(idCare);
            // id produit
            idProduct = new ComboBox();
            idProduct.Size = new Size(100, 30);
            idProduct.Location = new Point(230, 160);
            idProduct.Text = "id produit";
            createInvoicePanel.Controls.Add(idProduct);
            // bouton ajouter id soin
            addIdCareButton = new Button();
            addIdCareButton.Size = new Size(100, 25);
            addIdCareButton.Location = new Point(370, 100);
            addIdCareButton.Text = "Ajouter";
            createInvoicePanel.Controls.Add(addIdCareButton);
            addIdCareButton.Click += new EventHandler(addIdCare_Click);
            // bouton ajouter id produit
            addIdProductButton = new Button();
            addIdProductButton.Size = new Size(100, 25);
            addIdProductButton.Location = new Point(370, 160);
            addIdProductButton.Text = "Ajouter";
            createInvoicePanel.Controls.Add(addIdProductButton);
            addIdProductButton.Click += new EventHandler(addIdProduct_Click);
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 310);
            confirmButton.Text = "Confirmer";
            createInvoicePanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 310);
            cancelButton.Text = "Annuler";
            createInvoicePanel.Controls.Add(cancelButton);
            cancelButton.Click += new EventHandler(cancel_Click);
        }

        private void addIdProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void addIdCare_Click(object sender, EventArgs e)
        {
            
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
            idCare.Text = "id soin";
            idProduct.Text = "id produit";
        }
    }
}
