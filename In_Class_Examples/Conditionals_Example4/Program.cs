using System;

namespace Conditionals_Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color? >>");
            string color = Console.ReadLine().ToLower();

            color = color.ToLower();

            switch (color.ToLower())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.WriteLine("Please enter an integer between 37 to 32,767. >>");
            string input = Console.ReadLine();
            //int input1 = Convert.ToInt32(input);
            int input1;

            bool isInputAValidInteger = int.TryParse(input, out input1);

            if (isInputAValidInteger == true)
            {
                if (input1 >= 37 &&
                    input1 <= 32767)
                {
                    Console.WriteLine("Yay a valid input!");
                }
                else
                {
                    Console.WriteLine("Sorry, your # is not within the bounds.  Goodbye.");
                    Environment.Exit(-5);
                }
            }
            else
            {
                Console.WriteLine("Invalid number.  Press any key to exit the application. >>");
                Console.ReadKey();
                Environment.Exit(-50);
            }

            Console.Beep(input1, 500);
            Console.WriteLine("I did this for you ...");

        }
    }
}
