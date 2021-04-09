using HotelReservation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Controllers
{
    public class BookingController : Controller
    {
        private hotelContext _db;

        public BookingController(hotelContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchRoom(DateTime From, DateTime To, string city, int room,string type, int guest)
        {

            TempData["StartDate"] = From;
            TempData["EndDate"] = To;
            TempData["GuestCount"] = guest;
            TempData["Hid"] = city.Equals("Halifax") ? 1 : city.Equals("Toronto") ? 2 : 3; 


            int id;
             id = city.Equals("Halifax") ? 1 : city.Equals("Toronto") ? 2 : 3 ;
            IEnumerable<AvailableHotelRoom1> obj =null;
            int flag = 0; 


            for (var day = From.Date; day.Date <= To.Date; day = day.AddDays(1))
            {
                IQueryable<AvailableHotelRoom1> availableHotelRoom1s = _db.AvailableHotelRoom1s.Where(a => a.Date == day && a.Type == type && a.HotelId == id);
                IEnumerable<AvailableHotelRoom1> temp = availableHotelRoom1s;
                
                
                foreach(AvailableHotelRoom1 i in temp)
                {
                    if(i.AvailRoom != null && i.AvailRoom >= 10)
                    {
                        flag = 1;
                        break;
                    }
                }

                /*
                if (temp != null && temp.A)
                {
                    message = "room not availabel";
                    break;
                    
                }*/


              //  if(temp != null)
               // obj = obj.Concat(temp);
                
            }
            TempData["x"] = flag;

                return RedirectToAction("Index");
        }

        public IActionResult CustomerInfo()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCustomer(Customer1 obj)
        {
            int id = _db.Customer1s.Max(c => c.CustomerId);
            TempData["CId"] = id+1;

            _db.Customer1s.Add(obj);
            _db.SaveChanges();

            return View();
        }




        public IActionResult Payment(string paymethod)
        {
            TempData["paymethod"] = paymethod;
            Bookings1 booking=new Bookings1
            {
            Cid = (int)TempData["Cid"],
            Uid = (int)TempData["Uid"],
            Hid = (int)TempData["Hid"],
            StartDate = (DateTime)TempData["StartDate"],
            EndDate = (DateTime)TempData["EndDate"],
            GuestCount = (int)TempData["GuestCount"],
            };

            _db.Bookings1s.Add(booking);
            TempData["BookingId"] = _db.Bookings1s.Max(c => c.BookingId);
            _db.SaveChanges();

            Transaction1 transaction = new Transaction1
            {
                BookingId = (int)TempData["BookingId"],
                TransactionDate = DateTime.Today,
                Amount= "150",
                Paymethod=(string)TempData["Paymethod"]
        };
            _db.Transaction1s.Add(transaction);
            _db.SaveChanges();
            
        return View();

        }
    }
}
