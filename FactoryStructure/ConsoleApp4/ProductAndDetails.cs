using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ProductAndDetails
    {
        public IProduct GetProduct(string description)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var Now = assembly.GetTypes().FirstOrDefault(x=>x.Name==description);
            return (IProduct)Activator.CreateInstance(Now);


            

        }

    }
}
