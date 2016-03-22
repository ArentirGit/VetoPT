using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoPTApplication.CareManagement
{
    class DisplayTreatment
    {
        private Panel myPanel;
        private DataGridView myGrid;
        private DataGridViewButtonColumn detail;
        private DataGridViewButtonColumn print;
        private List<string> treatments = new List<string>();
        private DataBase.DataBaseManagement db = new DataBase.DataBaseManagement("VetoPTArentir");
        private ComboBox nameAnimal;
        private ComboBox nameClient;
        private List<string> clients;
        private List<string> animals;
        private string animalSelect;

        

        public DisplayTreatment(Panel panel)
        {
            myPanel = panel;
            Init();
        }

        public void Init()
        {
            //suppression de tout les objets du panel

            myPanel.Controls.Clear();


            //création du Combobox nom client
            nameClient = new ComboBox();
            nameClient.Size = new Size(100, 40);
            nameClient.Location = new Point(100, 60);
            nameClient.Text = "Nom client";
            nameClient.SelectedIndexChanged += new EventHandler(nameClient_SelectedIndexChanged);
            nameClient.Dock = DockStyle.Top;
            myPanel.Controls.Add(nameClient);

            //création du Combox nom animal
            nameAnimal = new ComboBox();
            nameAnimal.Size = new Size(100, 40);
            nameAnimal.Location = new Point(150, 60);
            nameAnimal.Text = "Nom animal";
            nameAnimal.SelectedIndexChanged += new EventHandler(nameAnimal_SelectedIndexChanged);
            nameAnimal.Dock = DockStyle.Top;
            myPanel.Controls.Add(nameAnimal);

            detail = new DataGridViewButtonColumn();
            detail.HeaderText = "Details";
            detail.Text = "Details";
            detail.Name = "Details";
            detail.UseColumnTextForButtonValue = true;

            print = new DataGridViewButtonColumn();
            print.HeaderText = "Imprimer";
            print.Text = "Imprimer";
            print.Name = "Imprimer";
            print.UseColumnTextForButtonValue = true;

            myGrid = new DataGridView();
            myGrid.CellClick += new DataGridViewCellEventHandler(myGrid_CellClick);
            myGrid.ColumnCount = 3;
            myGrid.Columns[0].Name = "Traitement";
            myGrid.Columns[1].Name = "Durée traitement";
            myGrid.Columns[2].Name = "Date traitement";
            myGrid.Columns.Add(detail);
            myGrid.Columns.Add(print);
            myGrid.Dock = DockStyle.Top;

            
            myPanel.Controls.Add(myGrid);
            this.remplirGrid();
            this.completeClient();


        }
        private void remplirGrid()
        {
            myGrid.Rows.Clear();
            treatments = new List<string>();
            treatments = db.DisplayTreatments();
            string[] row = new string[] {};
            int i = 0;
            foreach (string s in treatments)
            {
                row = new string[] { s.Split(':')[3], s.Split(':')[2], s.Split(':')[1] };
                myGrid.Rows.Insert(i, row);
                i++;
            }
            
            
        }

        private void remplirGrid(List<string> animals)
        {
            myGrid.Rows.Clear();
            treatments = new List<string>();
            foreach (string a in animals)
            {
                treatments = db.getTreatments(a);
                string[] row = new string[] { };
                int i = 0;
                foreach (string s in treatments)
                {
                    row = new string[] { s.Split(':')[3], s.Split(':')[2], s.Split(':')[1] };
                    myGrid.Rows.Insert(i, row);
                    i++;
                }
            }


        }

        private void remplirGrid(string animal)
        {
            myGrid.Rows.Clear();
            treatments = new List<string>();
            treatments = db.getTreatments(animal);
            string[] row = new string[] { };
            int i = 0;
            foreach (string s in treatments)
            {
                row = new string[] { s.Split(':')[3], s.Split(':')[2], s.Split(':')[1] };
                myGrid.Rows.Insert(i, row);
                i++;
            }
        }

        private void myGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DetailsTreatments d = new DetailsTreatments(myPanel,treatments[myGrid.CurrentRow.Index]);
            }
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show(" Imprimer ");
            }
        }

        private void completeClient()
        {
            clients = new List<string>();
            clients = db.DisplayClients();
            foreach (string s in clients)
            {
                nameClient.Items.Add(s.Split(':')[1] + " " + s.Split(':')[2]);
            }

        }

        private void completeAnimal(int idClient)
        {
            animals = new List<string>();
            animals = db.getAnimalsClient(idClient);
            nameAnimal.Items.Clear();
            foreach (string s in animals)
            {
                nameAnimal.Items.Add(s.Split(':')[1]);
            }

        }

        private void nameClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            completeAnimal(Int32.Parse(clients[nameClient.SelectedIndex].Split(':')[0]));
            remplirGrid(animals);
        }
        private void nameAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            animalSelect = animals[nameAnimal.SelectedIndex];
            remplirGrid(animalSelect);
        }
    }
}
