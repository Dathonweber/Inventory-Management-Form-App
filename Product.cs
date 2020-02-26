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

        public static int AvailableID;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Product(string name, int instock, decimal price, int min, int max)
        {
            ProductID = AvailableID++;
            Name = name;
            InStock = instock;
            Price = price;
            Min = min;
            Max = max;
        }
       
        public Product(int productID, string name, int instock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = instock;
            Price = price;
            Min = min;
            Max = max;
        }

        public static void addAssociatedPart(Part AddPart)
        {
           
        }

        public static bool removeAssociatedPart(int PartID)
        {
            AssociatedParts.RemoveAt(PartID);
            return true;
        }

        public static Part lookupAssociatedPart(int i)
        {
            for (int x = 0; x < List.AllParts.Count; x++)
            {
                if (List.AllParts[x].PartID.Equals(i))
                {
                    Inventory.CurrentPartIndex = x;
                    return List.AllParts[x];
                }
            }
            Inventory.CurrentPartIndex = -1;
            return null;
        }

    }
}


