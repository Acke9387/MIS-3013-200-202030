using System;

namespace Conditionals_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application! What is your name? >>");
            string name = Console.ReadLine(); // this is a local variable

            Console.WriteLine(name + ", what is your monthly income? >>");
            string response = Console.ReadLine();
            double monthlyIncome = Convert.ToDouble(response); // Convert a string (response) to a double

            Console.WriteLine(name + ", what is your monthly expenses? >>");
            double monthlyExpenses = Convert.ToDouble(Console.ReadLine());

            double netIncome = monthlyIncome - monthlyExpenses;

            if (netIncome >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            
            Console.WriteLine($"The difference between your income and expenses is {netIncome.ToString("c3")}.");


        }
    }
}
