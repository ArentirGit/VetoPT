﻿using System;
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

            myGrid = new DataGridView();
            myGrid.CellClick += new DataGridViewCellEventHandler(myGrid_CellClick);
            myGrid.ColumnCount = 3;
            myGrid.Columns[0].Name = "Traitement";
            myGrid.Columns[1].Name = "Durée traitement";
            myGrid.Columns[2].Name = "Date traitement";
            myGrid.Columns.Add(detail);
            myGrid.Dock = DockStyle.Fill;
            string[] row = { "traitement 1", "2h", "2012" };
            myGrid.Rows.Insert(0, row);

            myPanel.Controls.Add(myGrid);          


        }

        private void myGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                MessageBox.Show(" Details ");
            }
        }

    }
}
