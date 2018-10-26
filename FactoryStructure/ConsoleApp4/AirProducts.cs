using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class AirProducts : IProduct
    {
        public string GetName()
        {
            return "Indigo";
        }

        public int GetPrice()
        {
            return 2000;
        }

        public string GetTypeofProduct()
        {
            return "AirProducts";
        }
       

    
      
    }
}
