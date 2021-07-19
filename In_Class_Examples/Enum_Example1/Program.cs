using System;

namespace Enum_Example1
{
    class Program
    {
        enum Coin : int
        {
            HEADS = 1,
            TAILS = 3
        }

        static void Main(string[] args)
        {

            const string DEVELOPER_NAME = "Instructor Ackerman";

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);

            //Console.BackgroundColor = (ConsoleColor)10;

            // Used for testing purposes so I could make sure to get a wrong/right answer
            //Console.WriteLine(randomNbr);

            Console.WriteLine("Heads or Tails? >>");
            string answer = Console.ReadLine().ToLower();
            int answerAsInt = -1;

            Console.WriteLine();
            if (answer == "heads")
            {
                answerAsInt = (int)Coin.HEADS;
            }
            else if (answer == "tails")
            {
                answerAsInt = (int)Coin.TAILS;
            }
            else
            {
                Console.WriteLine("Invalid input. Bye.");
                Environment.Exit(-1);
                //answerAsInt = -1;
            }

            if (randomNbr == (int)Coin.HEADS)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }

            if (randomNbr == answerAsInt)
            {
                Console.WriteLine("Congratulations, you guessed correct!");
            }
            else
            {
                Console.WriteLine("Sorry, you guessed incorrect :(");
            }

            Console.WriteLine($"\nDeveloped by: {DEVELOPER_NAME}");
        }
    }
}
