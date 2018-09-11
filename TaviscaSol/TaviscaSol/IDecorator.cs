using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;

namespace TaviscaSol.Controllers
{
    interface IDecorator
    {
        List<Car> GetAllCar();
        List<Hotel> GetAllHotel();
        List<Activity> GetAllActivity();
        List<Air> GetAllAir();
    }
}