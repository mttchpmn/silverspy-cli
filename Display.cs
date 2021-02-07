using System;
using SilverspyCLI.Models;

namespace SilverspyCLI
{
    public class Display
    {
        public static DateTime GetStartDate()
        {
            Console.WriteLine("Enter start date in yyyy-mm-dd format:");
            var ans = Console.ReadLine();

            return DateTime.Parse(ans);
        }
        
        public static DateTime GetEndDate()
        {
            Console.WriteLine("Enter end date in yyyy-mm-dd format:");
            var ans = Console.ReadLine();

            return DateTime.Parse(ans);
        }
        public static void DisplayFinancialPeriod(FinancialPeriod period)
        {
            Console.Clear();
            Console.WriteLine($" - PAY PERIOD: {period.Start.ToString("D")} to {period.End.ToString("D")}");
            Console.WriteLine(new string('-', 56));
            
            Console.WriteLine($" - TOTAL INCOMINGS: \t\t\t{period.TotalIncomings.ToString("C")}");
            Console.WriteLine($" - TOTAL OUTGOINGS: \t\t\t{period.TotalOutgoings.ToString("C")}");
            Console.WriteLine($" - NET POSITION: \t\t\t{period.NetPosition.ToString("C")}");
            Console.WriteLine(new string('-', 56));
            
            Console.WriteLine(" - INCOMINGS:");
            foreach (var payment in period.Incomings)
            {
                Console.WriteLine($"\t{payment.Date.ToString("D")} - {payment.Name}");
                Console.WriteLine($"\t\t\t\t\t{payment.Amount.ToString("C")}");
            }
            
            Console.WriteLine(" - OUTGOINGS:");
            foreach (var payment in period.Outgoings)
            {
                Console.WriteLine($"\t{payment.Date.ToString("D")} - {payment.Name}");
                Console.WriteLine($"\t\t\t\t\t{payment.Amount.ToString("C")}");
            }
        }
    }
}