using System;

namespace Loops_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite #? >>");
            string input = Console.ReadLine();
            int favoriteNumber;
            bool isValidNumber = int.TryParse(input, out favoriteNumber);

            //while (isValidNumber == false)
            //{
            //    Console.WriteLine($"{input} was not a valid integer.  Please input a number >>");
            //    input = Console.ReadLine();
            //    isValidNumber = int.TryParse(input, out favoriteNumber);
            //}

            while (int.TryParse(input, out favoriteNumber) == false)
            {
                Console.WriteLine($"{input} was not a valid integer.  Please input a number >>");
                input = Console.ReadLine();
            }

            Console.WriteLine("Thank you for telling us your favorite number.");
        }
    }
}
