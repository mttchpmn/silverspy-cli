using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SilverspyCLI.Models;

namespace SilverspyCLI.Config
{
    public class PaymentConfig : IPaymentConfig
    {
        public List<Payment> Weekly { get; set; }
        public List<Payment> Fortnightly { get; set; }
        public List<Payment> Monthly { get; set; }

        public static PaymentConfig FromJson(string path)
        {
            var rawJson = File.ReadAllText(path);
            var result = JsonSerializer.Deserialize<PaymentConfig>(rawJson, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return result;
        }
    }
    
    
}