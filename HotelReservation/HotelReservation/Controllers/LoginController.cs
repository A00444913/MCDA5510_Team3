using HotelReservation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Controllers
{
    public class LoginController : Controller
    {
        private readonly hotelContext _db;

        public LoginController(hotelContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
