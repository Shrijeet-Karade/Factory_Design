using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CarProducts:IProduct
    {
        public string GetName()
        {
            return "GTO";
        }

        public int GetPrice()
        {
            return 1000000;
        }

        public string GetTypeofProduct()
        {
            return "CarProducts";
        }
        
    }
}
