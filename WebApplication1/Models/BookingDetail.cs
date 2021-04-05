using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class BookingDetail
    {
        public int Cid { get; set; }
        public int Uid { get; set; }
        public int Rid { get; set; }
        public int Hid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GuestCount { get; set; }
        public string Status { get; set; }
    }
}
