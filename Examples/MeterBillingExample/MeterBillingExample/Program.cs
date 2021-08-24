using System;

namespace MeterBillingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meter Billing Example...");
            Console.WriteLine("Enter the current meter reading:");
            int cmr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the previous meter reading:");
            int pmr = int.Parse(Console.ReadLine());
            cType: Console.WriteLine("Connection type: 'D' for Domestic and 'N' for Non-domestic/Commercial");
            string connectionType = Console.ReadLine();

            int consumption = cmr - pmr;
            double billAmount = 0.0D;

            if (connectionType == "D")
            {
                for (int i = 1; i <= consumption; i++)
                {
                    if (i <= 200)
                    {
                        billAmount += 5.0D;
                    } else if (i <= 300)
                    {
                        billAmount += 7.2D;
                    } else if (i <= 400)
                    {
                        billAmount += 8.5D;
                    } else if (i <= 800)
                    {
                        billAmount += 9.0D;
                        Console.WriteLine("billAmount = {0}, i = {1}", billAmount, i);
                    } else
                    {
                        billAmount += 9.5D;
                        Console.WriteLine("billAmount = {0}, i = {1}", billAmount, i);
                    }
                }
            } else if (connectionType == "N")
            {
                for (int i = 1; i <= consumption; i++)
                {
                    if (i <= 100)
                    {
                        billAmount += 7.5D;
                    }
                    else if (i <= 300)
                    {
                        billAmount += 8.9D;
                    }
                    else if (i <= 500)
                    {
                        billAmount += 9.4D;
                    }
                    else
                    {
                        billAmount += 10.0D;
                    }
                }
            } else
            {
                Console.WriteLine("Invalid connection type selected. Try again");
                goto cType;
            }
            Console.WriteLine("Your bill will come to R {0}.", Math.Round(billAmount, 2));
        }
    }
}
