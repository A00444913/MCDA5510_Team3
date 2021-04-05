using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Transaction
    {
        public int Uid { get; set; }
        public int Hid { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Amount { get; set; }
        public string Paymethod { get; set; }
        public string Status { get; set; }
    }
}
