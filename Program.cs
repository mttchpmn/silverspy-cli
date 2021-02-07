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
            var start = Display.GetStartDate();
            var end = Display.GetEndDate();
            
            var config = JsonParser<FinanceConfig>.FromJson(configPath);
            var financialPeriodGenerator = new FinancialPeriodGenerator() { Config = config };

            var period = financialPeriodGenerator.Generate(start, end);
            
            Display.DisplayFinancialPeriod(period);
        }
    }
}