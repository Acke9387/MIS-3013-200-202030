using System;

namespace Conditionals_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);
            
            int remainder = number % 3;
            bool isDivisibleBy3 = remainder == 0;
                        
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (isDivisibleBy3 == true) // (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
           
        }
    }
}
