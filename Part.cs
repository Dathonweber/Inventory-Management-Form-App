using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Inventory_System
{
     abstract class Part
    {
        public static int AvailableID;

        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        
        public Part(string name, int instock, decimal price, int min, int max)
        {
            PartID = AvailableID++;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;

        }

        public Part(int partID, string name, int instock, decimal price, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
        }

       
    }
}
