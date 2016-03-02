﻿using System;
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

         Label title;

         ComboBox reference;
         ComboBox quantite;
         MonthCalendar calendar;
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
            reference = new ComboBox();
            reference.Size = new Size(150, 30);
            reference.Location = new Point(205, 100);
            reference.Text = "Référence";    
            AddProductPanel.Controls.Add(reference);
            // quantité
            quantite = new ComboBox();
            quantite.Size = new Size(150, 30);
            quantite.Location = new Point(205, 130);
            quantite.Text = "Quantité";
            AddProductPanel.Controls.Add(quantite);
            // Date
            calendar = new MonthCalendar();
            calendar.Location = new Point(165, 170);
            AddProductPanel.Controls.Add(calendar);
            // raison
            prix = new TextBox();
            prix.Size = new Size(150, 30);
            prix.Location = new Point(205, 350);
            prix.Text = "Prix";
            AddProductPanel.Controls.Add(prix);
            // bouton confirmer
            confirmButton = new Button();
            confirmButton.Size = new Size(100, 30);
            confirmButton.Location = new Point(150, 400);
            confirmButton.Text = "Confirmer";
            AddProductPanel.Controls.Add(confirmButton);
            confirmButton.Click += new EventHandler(confirm_Click);
            // bouton annuler
            cancelButton = new Button();
            cancelButton.Size = new Size(100, 30);
            cancelButton.Location = new Point(310, 400);
            cancelButton.Text = "Annuler";
            AddProductPanel.Controls.Add(cancelButton);
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
            reference.Text = "Référence";
            quantite.Text = "Quantité";
            prix.Text = "Prix";
           
        }
    }
}