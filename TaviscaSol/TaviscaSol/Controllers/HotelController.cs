﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DBAccess;
using TaviscaSol.Models;
namespace TaviscaSol.Controllers
{
    public class HotelController : ApiController
    {
        public IEnumerable<Hotel> GetHotelEntity()
        {
            using (Entities entities = new Entities())
            {
                return entities.Hotels.ToList();
            }
        }
        [HttpPut]
        public void PutValue(UpdateItem item)
        {
            using (Entities entity = new Entities())
            {
                if (item.Type == "book")
                {
                    entity.Hotels.Find(item.Id).isBooked = true;
                    entity.SaveChanges();
                }
                else if(item.Type=="save")
                {
                    entity.Hotels.Find(item.Id).isSaved = true;
                    entity.SaveChanges();
                }
            }
        }
        [HttpPost]
        public void InsertInto([FromBody]Hotel hotel)
        {
            using (Entities entity = new Entities())
            {
                entity.Hotels.Add(hotel);
                entity.SaveChanges();
            }
        }
    }
}
