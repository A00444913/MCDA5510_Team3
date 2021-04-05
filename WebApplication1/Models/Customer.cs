using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Customer
    {
        public int Cid { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Streetno { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
