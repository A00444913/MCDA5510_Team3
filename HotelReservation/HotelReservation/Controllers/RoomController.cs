using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Models;

namespace HotelReservation.Controllers
{
    public class RoomController : Controller
    {
        private readonly hotelContext _db;

        /*public RoomController(hotelContext db)
        {
            _db = db;
        }*/

        public IActionResult Findroom()
        {
            return View();
        }

        //private readonly hotelContext _db;

        public IActionResult Roomlist()
        {
            return View();
        }

        public IActionResult RoomDetail()
        {
            return View();
        }

        public IActionResult KingDetail()
        {
            return View();
        }

        public IActionResult DoubleDetail()
        {
            return View();
        }
    }
}
