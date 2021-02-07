using System;
using System.Collections.Generic;
using System.Linq;
using SilverspyCLI.Models;

namespace SilverspyCLI.Models
{
    public class FinancialPeriod
    {
        public readonly DateTime Start;
        public readonly DateTime End; 
        public List<PaymentDate> Incomings { get; }
        public List<PaymentDate> Outgoings { get; }

        public FinancialPeriod(DateTime start, DateTime end, List<PaymentDate> incomings, List<PaymentDate> outgoings)
        {
            this.Start = start;
            this.End = end;
            this.Incomings = incomings;
            this.Outgoings = outgoings;
        }
        
        public double TotalIncomings => Incomings.Select(p => p.Amount).Sum();
        public double TotalOutgoings => Outgoings.Select(p => p.Amount).Sum();
        public double NetPosition => TotalIncomings - TotalOutgoings;
    }
}