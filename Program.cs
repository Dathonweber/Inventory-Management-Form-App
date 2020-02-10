using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Inventory_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Part Wheel = new Part(15, "Wheel", 25, 20,5,50 );
            Inventory.AddProduct(new Product(5, "Blue Bike", 100,5,1,10));
            Inventory.AddProduct(new Product(4, "Red bike", 100, 5, 1, 10));
            Product.addAssociatedPart(new Part(150, "Frame", 100, 10, 1, 10));
            Inventory.AddPart(Wheel);
            Inventory.AddPart(new Part(01, "Chain", 20, 20, 1, 25));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
