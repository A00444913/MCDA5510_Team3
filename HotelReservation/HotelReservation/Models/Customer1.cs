using System;
using System.Collections.Generic;

#nullable disable

namespace HotelReservation.Models
{
    public partial class Customer1
    {
        public Customer1()
        {
            Bookings1s = new HashSet<Bookings1>();
        }

        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string StreetNo { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public int? PhoneNo { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Bookings1> Bookings1s { get; set; }
    }
}
