using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFM1_Inventory_System
{
    class Product
    {
        public static BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Product(int productID, string name, decimal price, int instock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
        }

        public static void addAssociatedPart(Part AddPart)
        {
            AssociatedParts.Add(new Part(AddPart.PartID, AddPart.Name, AddPart.Price, AddPart.InStock, AddPart.Max, AddPart.Min));
        }

        //public bool removeAssociatedPart(int removePart)
        //{

        //}

        //public Part lookupAssociatedPart(int lookupPart)
        //{

        //}

    }
}


