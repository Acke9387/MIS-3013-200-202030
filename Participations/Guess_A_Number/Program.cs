using System;

namespace Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int min, max;

            do
            {
                do
                {
                    Console.WriteLine("Please enter the minimum value >>");
                    input = Console.ReadLine();
                } while (int.TryParse(input, out min) == false);

                // int min = Convert.ToInt32(input);

                do
                {
                    Console.WriteLine("Please enter the maximum value >>");
                    input = Console.ReadLine();
                } while (int.TryParse(input, out max) == false);
                //int max = Convert.ToInt32(input); 

                if (min >= max)
                {
                    Console.WriteLine("The minimum must be less than the maximum.");
                }
            } while (min >= max);


            Random rand = new Random();
            int rando = rand.Next(min, max + 1);

            //Was just used for testing
            //Console.WriteLine(rando);
            Console.WriteLine();
            int guess;
            int guessCount = 0;
            do
            {
                do
                {
                    Console.WriteLine("What is your guess? >>");
                    input = Console.ReadLine();
                } while (int.TryParse(input, out guess) == false);
                //guess = Convert.ToInt32(input);



                guessCount++;

                if (guess > rando)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You guessed too high.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (guess < rando)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You guessed too low.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }


            } while (guess != rando);

            switch (guessCount)
            {
                case 1:
                    Console.WriteLine($"Congratulations, it took you {guessCount.ToString("n0")} guess to get it correct!");
                    break;

                default:
                    Console.WriteLine($"Congratulations, it took you {guessCount.ToString("n0")} guesses to get it correct!");
                    break;
            }

        }
    }
}
