using System;
using System.Collections.Generic;
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
        

        public DisplayTreatment(Panel panel)
        {
            myPanel = panel;
            Init();
        }

        public void Init()
        {
            //suppression de tout les objets du panel


            myPanel.Controls.Clear();

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
            myGrid.Dock = DockStyle.Fill;

            
            myPanel.Controls.Add(myGrid);
            remplirGrid();


        }
        private void remplirGrid()
        {
            string[] row = { "traitement 1", "2h", "2012" };
            myGrid.Rows.Insert(0, row);
        }

        private void myGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DetailsTreatments d = new DetailsTreatments(myPanel);
            }
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show(" Imprimer ");
            }
        }

    }
}
