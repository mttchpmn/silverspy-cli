using System;

namespace SilverspyCLI.Models
{
    public class Income
    {
        public DateTime KnownPayday { get; set; }
        public int Day { get; set; }
        public string Frequency { get; set; }
        public decimal NetAmount { get; set; }
    }
}