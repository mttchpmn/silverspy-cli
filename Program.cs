using System;
using SilverspyCLI.Models;

namespace SilverspyCLI
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------| Silverspy  CLI |-------------------");
            
            const string configPath = @"/Users/matt.c/financeConfig.json";
            var start = DateTime.Parse("2021-02-18");
            var end = DateTime.Parse("2021-03-04");
            
            var config = JsonParser<FinanceConfig>.FromJson(configPath);
            var financialPeriodGenerator = new FinancialPeriodGenerator() { Config = config };

            var period = financialPeriodGenerator.Generate(start, end);

            Console.WriteLine($" PAY PERIOD: {period.Start} to {period.End}");
            Console.WriteLine(new string('-', 56));
            
            Console.WriteLine($" - TOTAL INCOMINGS: {period.TotalIncomings}");
            Console.WriteLine($" - TOTAL OUTGOINGS: {period.TotalOutgoings}");
            Console.WriteLine($" - NET POSITION: {period.NetPosition}");
            Console.WriteLine(new string('-', 56));
            
            Console.WriteLine(" - INCOMINGS:");
            foreach (var payment in period.Incomings)
            {
                Console.WriteLine($"\t{payment.Date.ToString().Substring(0,10)} - {payment.Name}");
                Console.WriteLine($"\t\t${payment.Amount}");
            }
            
            Console.WriteLine(" - OUTGOINGS:");
            foreach (var payment in period.Outgoings)
            {
                Console.WriteLine($"\t{payment.Date.ToString().Substring(0,10)} - {payment.Name}");
                Console.WriteLine($"\t\t${payment.Amount}");
            }
        }
    }
}