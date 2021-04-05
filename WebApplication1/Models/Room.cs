using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Room
    {
        public int Rid { get; set; }
        public string Type { get; set; }
        public int? MaxGuest { get; set; }
    }
}
