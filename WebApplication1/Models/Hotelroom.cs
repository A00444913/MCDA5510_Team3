using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Hotelroom
    {
        public int Hid { get; set; }
        public string Type { get; set; }
        public int? AvailNum { get; set; }
        public DateTime? AvailDate { get; set; }
    }
}
