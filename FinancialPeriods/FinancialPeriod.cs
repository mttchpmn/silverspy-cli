using System;
using System.Collections.Generic;
using SilverspyCLI.Models;

namespace SilverspyCLI.FinancialPeriods
{
    public class FinancialPeriod
    {
        public readonly DateTime Start;
        public readonly DateTime End; 
        public List<PaymentDate> Payments { get; }
        public decimal TotalOutgoings => 999.00m;

        public FinancialPeriod(DateTime start, DateTime end, List<PaymentDate> payments)
        {
            this.Start = start;
            this.End = end;
            this.Payments = payments;
        }

        public string ToJson()
        {
            return "todo";
        }
    }
}