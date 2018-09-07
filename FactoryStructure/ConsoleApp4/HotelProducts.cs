using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class HotelProducts : IProduct
    {
        public string GetName()
        {
            return "Taj";
        }

        public int GetPrice()
        {
            return 6000;
        }

        public string GetTypeofProduct()
        {

            return "HotelProducts";
        }
    }
}
