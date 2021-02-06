using System;
using SilverspyCLI.Config;
using SilverspyCLI.FinancialPeriods;

namespace SilverspyCLI
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------| Silverspy CLI |------");
            
            const string configPath = @"/Users/matt.c/payments.json";
            var start = DateTime.Parse("2021-02-18");
            var end = DateTime.Parse("2021-03-04");
            
            var config = PaymentConfig.FromJson(configPath);
            var financialPeriodGenerator = new FinancialPeriodGenerator() { Config = config };

            var period = financialPeriodGenerator.Generate(start, end);

            Console.WriteLine(period);
        }
    }
}