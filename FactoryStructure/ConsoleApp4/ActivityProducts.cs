using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ActivityProducts : IProduct
    {
        public string GetName()
        {
            return "Party";
        }

        public int GetPrice()
        {
            return 1500;
        }

        public string GetTypeofProduct()
        {
            return "ActivityProducts";
        }
    }
}
