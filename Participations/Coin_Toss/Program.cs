using System;

namespace Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_NAME = "Instructor Ackerman";

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);
            const int HEADS = 1;
            const int TAILS = 2;

            // Used for testing purposes so I could make sure to get a wrong/right answer
            //Console.WriteLine(randomNbr);

            Console.WriteLine("Heads or Tails? >>");
            string answer = Console.ReadLine();
            int answerAsInt = -1;

            Console.WriteLine();
            if (answer == "Heads")
            {
                answerAsInt = HEADS;
            }
            else if (answer == "Tails")
            {
                answerAsInt = TAILS;
            }
            else
            {
                Console.WriteLine("Invalid input. Bye.");
                Environment.Exit(-1);
                //answerAsInt = -1;
            }

            if (randomNbr == HEADS)
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
