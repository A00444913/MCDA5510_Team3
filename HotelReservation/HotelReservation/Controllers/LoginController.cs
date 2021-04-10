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
        [HttpPost]
        public IActionResult Login(Users1 obj)
        {
            foreach (Users1 i in _db.Users1s)
            {
                if (obj.Email.Equals(i.Email) & obj.Password.Equals(i.Password))
                {
                    TempData["Uid"] = i.Id;
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            TempData.Remove("Uid");
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
