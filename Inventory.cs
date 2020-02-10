using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Inventory_System
{
    static class Inventory
    {

        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void AddProduct(Product product)
        {
            Products.Add(new Product(product.ProductID, product.Name, product.Price, product.InStock, product.Min, product.Max));
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(new Part(part.PartID, part.Name, part.Price, part.InStock, part.Min, part.Max));
        }

        /*
         
         public static bool removeProduct(int x)
        {
            
        }

        */

        /*
        public static Product lookupProduct(int Lookup)
        {

          
        }
        
         */
        public static void updateProduct(int Name, Product UpdatedProduct)
        {

        }


        

       // public static bool deletePart(Part deletedPart)
       //{
            
       //}

       


        /*
         
         public static void updatePart(int ID, Part updatedPart)
        {

        }

        */
       
        /*

        public static Part lookupPart(int ID)
        {

        }

        */
    }
}

