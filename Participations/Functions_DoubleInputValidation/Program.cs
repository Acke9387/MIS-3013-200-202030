using System;

namespace Functions_DoubleInputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = GetDoubleInputFromUser("Please enter your value >>");

            Console.WriteLine($"{input.ToString("N2")} * 5 = {(input*5).ToString("N2")}");

        }

        static double GetDoubleInputFromUser(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            double value;
            while (double.TryParse(response, out value) == false)
            {
                Console.WriteLine("Invalid input.  Please input a valid number.>>");
                response = Console.ReadLine();
            }

            return value;
        }
    }
}
