using System;

namespace Conditionals_Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles, weight, quote, hazardousMaterialCost, discount;
            string response;

            Console.WriteLine("Welcome to the OU Shipping Store.");

            Console.WriteLine("How many miles is your shipment? >>");
            response = Console.ReadLine();
            //miles = Convert.ToDouble(response);
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.tryparse?view=net-5.0
            if (Double.TryParse(response, out miles) == false)
            {
                Console.WriteLine("Invalid miles.  Goodbye.");
                Environment.Exit(-50);
            }

            Console.WriteLine("What is the weight (in pounds) of your shipment? >>");
            response = Console.ReadLine();
            //weight = Convert.ToDouble(response);
            if (Double.TryParse(response, out weight) == false)
            {
                Console.WriteLine("Invalid weight.  Goodbye.");
                Environment.Exit(-50);
            }

            Console.WriteLine("Does your shipment contain hazardous material? yes or no >>");
            response = Console.ReadLine();

            switch (response.ToLower())
            {
                case "yes":
                    hazardousMaterialCost = 0.15 * weight;
                    break;
                case "no":
                    hazardousMaterialCost = 0;
                    break;
                default:
                    Console.WriteLine("Invalid Response. Time to terminate.");
                    Environment.Exit(-5); // Exit application with a return code
                    return; // stop executing anything in this method, which results in exiting.
                    break;
            }

            //if (response == "yes" || response == "Yes")
            //{
            //    hazardousMaterialCost = 0.15 * weight;
            //}
            //else if (response == "no")
            //{
            //    hazardousMaterialCost = 0;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Response. Time to terminate.");
            //    Environment.Exit(-5); // Exit application with a return code
            //    return; // stop executing anything in this method, which results in exiting.
            //}

            quote = 0.55 * miles + 0.73 * weight;

            if (weight > 500)// && miles < 150)
            {
                if (miles < 150)
                {
                    discount = 0.10 * quote;

                }
                else
                {
                    discount = 0;
                }
            }
            else
            {
                discount = 0;
            }

            Console.WriteLine($"Your quote is {quote.ToString("C")}");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your hazardous cost is {hazardousMaterialCost.ToString("c")}");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your discount is {discount.ToString("c")}");

            double total = quote + hazardousMaterialCost - discount;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Your grand total is {total.ToString("C")}");
        }
    }
}
