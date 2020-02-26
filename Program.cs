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
            Inventory.AddPart(new Inhouse("Tire",15,10,1,25,465));
            Inventory.AddPart(new Outsourced("Seat",15,8,1,25, "Davids Seats"));
            Inventory.AddProduct(new Product("Blue Bike", 5, 100, 1, 10));
            Inventory.AddProduct(new Product("Red bike", 5, 100, 1, 10));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
