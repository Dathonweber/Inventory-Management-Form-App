using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Inventory_System
{

    static class List
    {
        private static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts { get { return allParts; } set { allParts = value; } }

        public static BindingList<Product> Products = new BindingList<Product>();
    }

    static class Inventory
    {

       
        public static int CurrentPartIndex = -3;
        public static int CurrentProductIndex = -2;
        public static Product CurrentProduct = null;
        public static Part CurrentPart = null;
        
        
        public static void AddProduct(Product product)
        {
            List.Products.Add(new Product(product.ProductID, product.Name, product.InStock, product.Price, product.Min, product.Max));
        }

        public static void AddPart(Part part)
        {

            if (part is Inhouse)
            {
                Inhouse temp = part as Inhouse;
                Inhouse IPart = new Inhouse
                (
                    part.PartID,
                    part.Name,
                    part.InStock,
                    part.Price,
                    part.Min,
                    part.Max,
                    temp.MachineID
                    
                );

                List.AllParts.Add(IPart);
            }
            else if (part is Outsourced)
            {
                Outsourced temp = part as Outsourced;
                Outsourced OPart = new Outsourced(part.PartID,part.Name, part.InStock, part.Price, part.Max, part.Min, temp.CompanyName);
               
               
                List.AllParts.Add(OPart);
            }
        }

         public static bool RemoveProduct(int currentProductIndex)
        {
            List.Products.RemoveAt(CurrentProductIndex);

           return true;
        }

        public static Part LookupPart(int i)
        {
            for (int x = 0; x <List.AllParts.Count; x++)
            {
                if (List.AllParts[x].PartID.Equals(i))
                {
                    CurrentPartIndex = x;
                    return List.AllParts[x];
                }
            }
            CurrentPartIndex = -1;
            return null;
        }
 
        public static void UpdateProduct(int ID, Product UpdatedProduct)
        {
            List.Products.Insert(ID, UpdatedProduct);
            List.Products.RemoveAt(CurrentProductIndex + 1);
        }

       public static bool DeletePart(Part deletedPart)
       {
            List.AllParts.Remove(deletedPart);

            return true;
       }

         public static void UpdatePart(int ID, Part updatedPart)
        {
            List.AllParts.Insert(ID, updatedPart);
            List.AllParts.RemoveAt(CurrentPartIndex + 1);
           
            
        }

        public static Product lookupProduct(int ID)
        {

            for (int x = 0; x < List.Products.Count; x++)
            {
                if (List.Products[x].ProductID.Equals(ID))
                {
                    CurrentProductIndex = x;
                    return List.Products[x];
                }
            }
            CurrentProductIndex = -1;
            return null;

        }

        
    }
}

