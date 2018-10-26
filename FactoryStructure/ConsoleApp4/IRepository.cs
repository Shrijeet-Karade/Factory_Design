using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IRepository
    {
        string GetDBType();

        void Book(string id, int price, string typeOfProduct, bool book);
        void Save(string id, int price, string typeOfProduct, bool save);

    }
}
