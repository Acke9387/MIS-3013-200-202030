using System;

namespace Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the minimum value >>");
            string input = Console.ReadLine();

            int min = Convert.ToInt32(input);

            Console.WriteLine("Please enter the maximum value >>");
            input = Console.ReadLine();
            int max = Convert.ToInt32(input);

            Random rand = new Random();
            int rando = rand.Next(min, max + 1);

            Console.WriteLine(rando);
            Console.WriteLine();
            int guess;

            do
            {
                Console.WriteLine("What is your guess? >>");
                input = Console.ReadLine();
                guess = Convert.ToInt32(input);


            } while (guess != rando);

            Console.WriteLine("Congratulations, you guessed correctly!");

        }
    }
}
