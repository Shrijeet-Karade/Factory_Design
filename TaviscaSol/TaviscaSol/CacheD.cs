using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBAccess;
using System.Runtime.Caching;

namespace TaviscaSol.Controllers
{
    public class CacheD : IDecorator
    {
        static List<Hotel> AllHotelDb = new List<Hotel>();
        static List<Air> AllFlightDb = new List<Air>();
        static List<Activity> AllActivityDb = new List<Activity>();
        static List<Car> AllCarDb = new List<Car>();
        public List<Activity> GetAllActivity()
        {           
                using (Entities entity = new Entities())
                {
                    if (AllActivityDb.Count == 0)
                    {
                        var cache = new MemoryCache("MyTestCache");
                        cache["ActivityList"] = entity.Activities.ToList();         
                        AllActivityDb = (List<Activity>)cache["ActivityList"]; 
                                                                                       
                        return entity.Activities.ToList();
                    }
                    else
                    {
                        return AllActivityDb;
                    }
                }          
        }
        public List<Air> GetAllAir()
        {            
                using (Entities entity = new Entities())
                {
                    if (AllFlightDb.Count == 0)
                    {
                        var cache = new MemoryCache("MyTestCache");
                        cache["FlightList"] = entity.Airs.ToList();                
                        AllFlightDb = (List<Air>)cache["FlightList"];        
                                                                            
                        return entity.Airs.ToList();
                    }
                    else
                    {
                        return AllFlightDb;
                    }
                }
        }
        public List<Car> GetAllCar()
        {
            var cache = new MemoryCache("MyTestCache");

                using (Entities entity = new Entities())
                {
                    if (AllCarDb.Count == 0)
                    {
                        cache["CarList"] = entity.Cars.ToList();                
                        AllCarDb = (List<Car>)cache["CarList"]; 
                                                                      
                        return entity.Cars.ToList();
                    }
                    else
                    {
                        return AllCarDb;
                    }
                }
            
        }

        public List<Hotel> GetAllHotel()
        {
            
                using (Entities entity = new Entities())
                {
                    if (AllHotelDb.Count == 0)
                    {
                        var cache = new MemoryCache("MyTestCache");
                        cache["ObjectList"] = entity.Hotels.ToList();                 
                        AllHotelDb = (List<Hotel>)cache["ObjectList"]; 
                                                                            
                        return entity.Hotels.ToList();
                    }
                    else
                    {
                        return AllHotelDb;
                    }
                }

        }
    }
}