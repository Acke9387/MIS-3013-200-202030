using System;

namespace Loops_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What # do you want to count down from? >>");
            int startingPoint;

            if (int.TryParse(Console.ReadLine(), out startingPoint) == false)
            {
                Console.WriteLine("Sorry, that is invalid.  Goodbye.");
                Environment.Exit(-50);
            }

            for (int i = startingPoint; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}
