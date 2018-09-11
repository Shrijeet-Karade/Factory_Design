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
        static List<Activity> AllActivityDb = new List<Activity>();
        CacheD cache = new CacheD();
        public IEnumerable<Activity> GetActivityEntity()
        {
            using (Entities entities = new Entities())
            {
                AllActivityDb=cache.GetAllActivity();
                return AllActivityDb;

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
        public void InsertInto(Activity activity)
        {
            using (Entities entity = new Entities())
            {
                entity.Activities.Add(activity);
                entity.SaveChanges();
            }
        }

    }
}
