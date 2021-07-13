using System;

namespace Variables_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a lower-bound number. >>");
            string response = Console.ReadLine();
            int lower = Convert.ToInt32(response);

            Console.WriteLine("Please enter an upper-bound number. >>");
            response = Console.ReadLine();
            int upper = Convert.ToInt32(response);

            Random rand = new Random();
            int number = rand.Next(lower, upper + 1);

            Console.WriteLine(number.ToString("n0"));
        }
    }
}
