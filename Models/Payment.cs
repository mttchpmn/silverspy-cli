using System;
using System.Collections.Generic;
using System.Linq;

namespace SilverspyCLI.Models
{
    public class Payment
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Frequency { get; set; }
        public double Amount { get; set; }
        public int Day { get; set; }
        public DateTime KnownDate { get; set; }

        public List<PaymentDate> GenerateDates(DateTime startDate, DateTime endDate)
        {
            var result = new List<PaymentDate>();
            var refDate = this.KnownDate;

            while (refDate < endDate)
            {
                var paymentDate = new PaymentDate()
                {
                    Name = this.Name,
                    Code = this.Code,
                    Amount = this.Amount,
                    Date = refDate
                };
                result.Add(paymentDate);
                
                if (String.Equals(this.Frequency, "weekly"))
                    refDate = refDate.AddDays(7);
                if (String.Equals(this.Frequency, "fortnightly"))
                    refDate = refDate.AddDays(14);
                if (String.Equals(this.Frequency, "monthly"))
                    refDate = refDate.AddMonths(1);
            }

            result = result.Where(p => p.Date >= startDate).ToList();
            
            return result;
        }
    }
}