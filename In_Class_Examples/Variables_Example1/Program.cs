using System;

//This a comment

/*  This 
 *  is
 *  a
 *  multi-line
 *  comment
 */

namespace Variables_Example1
{
    class Program
    {
        int number = 0; // this is a class level variable

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

            Console.WriteLine($"The difference between your income and expenses is {netIncome.ToString("c3")}.");
            //Console.WriteLine("The difference between your income and expenses is " + netIncome +".");

        }
    }
}
