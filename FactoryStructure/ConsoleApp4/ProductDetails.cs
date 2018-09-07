using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ProductDetails
    {
        public IProduct GetProduct(string description)
        {
            switch (description)
            {
                case "Car": return new CarProduct();
                               
                default: return null;
            }

        }

    }
}
