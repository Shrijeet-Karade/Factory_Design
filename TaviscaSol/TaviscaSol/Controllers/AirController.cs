using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DBAccess;
using TaviscaSol.Models;
namespace TaviscaSol.Controllers
{
    public class AirController : ApiController
    {
        CacheD cache = new CacheD();
        static List<Air> AllFlightDb = new List<Air>();
        public IEnumerable<Air> GetAirEntity()
        {
            using (Entities entities = new Entities())
            {
                AllFlightDb = cache.GetAllAir();
                return AllFlightDb;
            }
        }
        [HttpPut]
        public void PutValue(UpdateItem item)
        {
            using (Entities entity = new Entities())
            {
                if (item.Type == "book")
                {
                    entity.Airs.Find(item.Id).isBooked = true;
                    entity.SaveChanges();
                }
                else if(item.Type=="save")
                {
                    entity.Airs.Find(item.Id).isSaved = true;
                    entity.SaveChanges();
                }
            }
        }
        [HttpPost]
        public void InsertInto(Air air)
        {
            using (Entities entity = new Entities())
            {
                entity.Airs.Add(air);
                entity.SaveChanges();
            }
        }
    }
}
