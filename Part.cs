using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Inventory_System
{
    class Part
    {
        private DataGridViewSelectedRowCollection selectedRows;

        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Part(int partID, string name, decimal price, int instock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;

        }

        public Part(DataGridViewSelectedRowCollection selectedRows)
        {
            this.selectedRows = selectedRows;
        }
    }
}
