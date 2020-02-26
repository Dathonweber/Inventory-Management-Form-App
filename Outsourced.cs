using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFM1_Inventory_System
{
      class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string name, int instock, decimal price, int min, int max, string companyname)
            : base(name, instock, price, min, max) 
        {
            CompanyName = companyname;
        }

        public Outsourced(int partID, string name, int instock, decimal price, int min, int max, string companyname) : base(partID, name, instock, price, min, max)
        {
            CompanyName = companyname;
        }

    }
}
