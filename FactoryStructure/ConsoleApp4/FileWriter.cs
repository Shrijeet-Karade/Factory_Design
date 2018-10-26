using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp4
{
    public class FileWriter : IRepository
    {
        public string GetDBType()
        {
            return "FileWriter";
        }

        public void Save(string id, int price, string typeOfProduct, bool save)
        {
            FileStream fsObj = new FileStream("c:\\Save.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swObj = new StreamWriter(fsObj);
            swObj.WriteLine("Saved => " + id);
            swObj.Flush();
            swObj.Close();
            fsObj.Close();

        }

        public void Book(string id, int price, string typeOfProduct, bool book)
        {
            FileStream fsObj = new FileStream("c:\\Book.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swObj = new StreamWriter(fsObj);
            swObj.WriteLine("Booked => " + id);
            swObj.Flush();
            swObj.Close();
            fsObj.Close();
        }

       
    }
}
