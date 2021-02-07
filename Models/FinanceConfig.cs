using System.Collections.Generic;

namespace SilverspyCLI.Models
{
    public class FinanceConfig
    {
        public List<Payment> Incomings { get; set; }
        public List<Payment> Outgoings { get; set; }
    }
}