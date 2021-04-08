using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Findroom()
        {
            return View();
        }

        public IActionResult Roomlist()
        {
            return View();
        }

        public IActionResult RoomDetail()
        {
            return View();
        }
    }
}
