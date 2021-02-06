using System;
using System.Collections.Generic;
using SilverspyCLI.Models;

namespace SilverspyCLI.FinancialPeriods
{
    public interface IFinancialPeriod
    {
        public DateTime Start { get; }
        public DateTime End { get; }
        public List<Payment> Payments { get; }
        public decimal TotalOutgoings { get; }
    }
}