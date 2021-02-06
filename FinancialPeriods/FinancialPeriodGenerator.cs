using System;
using System.Collections.Generic;
using System.Linq;
using SilverspyCLI.Config;
using SilverspyCLI.FinancialPeriods;
using SilverspyCLI.Models;

namespace SilverspyCLI.FinancialPeriods
{
    public class FinancialPeriodGenerator
    {
        public PaymentConfig Config { get; set; }

        public FinancialPeriod Generate(DateTime start, DateTime end)
        {
            var payments = new List<PaymentDate>();
            
            foreach (var payment in Config.Weekly)
                payments.AddRange(payment.GenerateDates(start, end));
            foreach (var payment in Config.Fortnightly)
                payments.AddRange(payment.GenerateDates(start, end));
            foreach (var payment in Config.Monthly)
                payments.AddRange(payment.GenerateDates(start, end));

            return new FinancialPeriod(start, end, payments);
        }
    }
}