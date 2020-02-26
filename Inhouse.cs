using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFM1_Inventory_System
{
    class Inhouse : Part
    {
        public int MachineID { get; set; }

           public Inhouse(string name, int instock, decimal price,  int min, int max, int machineid) : base( name, instock, price, min, max) 
        {
            MachineID = machineid;
        }

        public Inhouse(int partid, string name, int instock, decimal price, int min, int max, int machineid) : base( partid ,name, instock, price, min, max)
        {
            MachineID = machineid;
        }   

    }
}
