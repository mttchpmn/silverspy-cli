using System;
using System.Collections.Generic;
using SilverspyCLI.Models;

namespace SilverspyCLI
{
    public class FinancialPeriodGenerator
    {
        public FinanceConfig Config { get; set; }

        public FinancialPeriod Generate(DateTime start, DateTime end)
        {
            var incomings = new List<PaymentDate>();
            var outgoings = new List<PaymentDate>();
            
            foreach (var payment in Config.Incomings)
                incomings.AddRange(payment.GenerateDates(start, end));
            
            foreach (var payment in Config.Outgoings)
                outgoings.AddRange(payment.GenerateDates(start, end));

            return new FinancialPeriod(start, end, incomings, outgoings);
        }
    }
}