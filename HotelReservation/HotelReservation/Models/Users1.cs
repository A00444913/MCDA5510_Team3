using System;
using System.Collections.Generic;

#nullable disable

namespace HotelReservation.Models
{
    public partial class Users1
    {
        public Users1()
        {
            Bookings1s = new HashSet<Bookings1>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Bookings1> Bookings1s { get; set; }
    }
}
