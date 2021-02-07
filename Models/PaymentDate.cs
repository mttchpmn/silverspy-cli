using System;

namespace SilverspyCLI.Models
{
    public class PaymentDate
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}