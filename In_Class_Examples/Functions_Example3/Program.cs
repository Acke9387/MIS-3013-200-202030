using System;

namespace Functions_Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int ranNumber = rand.Next(1, 101);
            string result = FizzBuzzResult(ranNumber);
            Console.WriteLine($"{ranNumber} is {result}");

            Console.WriteLine("".PadLeft(20, '-'));
            for (int i = 1; i < 100; i++)
            {
                result = FizzBuzzResult(i);
                Console.WriteLine(result);
            }

        }

        static string FizzBuzzResult(int number)
        {
            string result;
            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "Fizzbuzz";
            }
            else if (number % 3 == 0)
            {
                result = "Fizz";
            }
            else if (number % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = number.ToString("n0");
            }

            return result;
        }

    }
}
