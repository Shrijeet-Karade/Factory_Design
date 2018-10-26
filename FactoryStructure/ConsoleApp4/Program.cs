using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class Program 
    {
       public static void Main(string[] args)
        {
            bool value = false;
            int price = 0;
            string name = "";
            int val = 0;
            while (val != 1)
            {
                try
                {
                    Logger log = Logger.GetInstance();
                    log.LogMessages("-----------------------------------------------new Entry-------------------------------------------");
                    log.LogMessages("");

                    ProductAndDetails objPnD = new ProductAndDetails();
                    Console.WriteLine("         Enter the Type of product you want");
                    Console.WriteLine("Enter 'CarProducts' for CarProducts \nEnter 'AirProducts' for AirProducts\nEnter 'HotelProducts'for hotel products \nEnter'ActivityProducts' for Activity");
                    string desc = Console.ReadLine();
                    IProduct prod = objPnD.GetProduct(desc);

                    log.LogMessages("Product Searched ="+desc);
                    log.LogMessages("");

                    ChooseDBType objCDBT = new ChooseDBType();
                    Console.WriteLine("         Enter the type of Storage you want to use");
                    Console.WriteLine("Enter 'DBWriter' for using Database \nEnter 'FileWriter' for Using FileSystem");
                    string storageType = Console.ReadLine();
                    IRepository repoObject = objCDBT.GetChoice(storageType);

                    log.LogMessages("Storage System chosen ="+storageType);
                    log.LogMessages("");

                    Console.WriteLine("enter --book-- to Book That Product \n Enter --save-- To Save that product");
                    string choice = Console.ReadLine();
                    if (choice == "book")
                    {
                        log.LogMessages("booking");
                        log.LogMessages("");

                        desc =prod.GetTypeofProduct();
                        name=prod.GetName();
                        price=prod.GetPrice();
                        value = true;
                        repoObject.Book(name,price,desc,value);

                    }
                    else if (choice == "save")
                    {
                        log.LogMessages("saving");
                        log.LogMessages("");

                        desc = prod.GetTypeofProduct();
                        name = prod.GetName();
                        price = prod.GetPrice();
                        value = true;
                        repoObject.Save(name, price, desc, value);
                    }
                    else
                    {
                        Console.WriteLine("invalid function chosen, exiting ");
                    }
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Logger log = Logger.GetInstance();
                    log.LogMessages("Caught exception : " + e);
                    log.LogMessages("    ");
                    Console.WriteLine(e);
                    
                }
               
                Console.WriteLine("enter 1 to exit");
                Console.WriteLine("enter any other number to continue browsing");
                val = Convert.ToInt32(Console.ReadLine());
            }
        }

      
    }
    
}
