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
    public class CarController : ApiController
    {
        public IEnumerable<Car> GetCarEntity()
        {
            using (Entities entities = new Entities())
            {
                return entities.Cars.ToList();
            }
        }
        [HttpPut]
        public void Put(UpdateItem item)
        {
            using (Entities entity = new Entities())
            {
                if (item.Type == "book")
                {
                    entity.Cars.Find(item.Id).isBooked = true;
                    entity.SaveChanges();
                }
                else if(item.Type=="save")
                {
                    entity.Cars.Find(item.Id).isSaved = true;
                    entity.SaveChanges();
                }
            }
        }
        [HttpPost]
        public void InsertInto(Car car)
        {
            using (Entities entity = new Entities())
            {
                entity.Cars.Add(car);
                entity.SaveChanges();
            }
        }
    }
}
