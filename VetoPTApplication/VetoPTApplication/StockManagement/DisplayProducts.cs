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

         public DisplayProducts(Panel DisplayProductsPanel)
        {
            this.DisplayProductsPanel = DisplayProductsPanel;
            Init();
        }

        public void Init()
        {
            // suppression de tout les objets du panel
            DisplayProductsPanel.Controls.Clear();
        }

    }
}
