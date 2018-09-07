using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ChooseDBType
    {
        public IRepository GetChoice(string Id)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var Now = assembly.GetTypes().FirstOrDefault(x => x.Name == Id);
            return (IRepository)Activator.CreateInstance(Now);
        }
    }
}
