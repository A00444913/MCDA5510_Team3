using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerInfo()
        {
            return View();
        }
    }
}
