using System.Collections.Generic;
using SilverspyCLI.Models;


namespace SilverspyCLI.Config
{
    public interface IPaymentConfig
    {
        public List<Payment> Weekly { get; set; }
        public List<Payment> Fortnightly { get; set; }
        public List<Payment> Monthly { get; set; }
    }
}