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
    public class ActivityController : ApiController
    {
        public IEnumerable<Activity> GetActivityEntity()
        {
            using (Entities entities = new Entities())
            {
                return entities.Activities.ToList();
            }
        }

        [HttpPut]
        public void PutValue(UpdateItem item)
        {
            using (Entities entity = new Entities())
            {
                if (item.Type == "book")
                {
                    entity.Activities.Find(item.Id).isBooked = true;
                    entity.SaveChanges();
                }
                else if(item.Type=="save")
                {
                    entity.Activities.Find(item.Id).isSaved = true;
                    entity.SaveChanges();
                }
            }
        }
        [HttpPost]
        public void InsertInto([FromBody]Activity activity)
        {
            using (Entities entity = new Entities())
            {
                entity.Activities.Add(activity);
                entity.SaveChanges();
            }
        }

    }
}
