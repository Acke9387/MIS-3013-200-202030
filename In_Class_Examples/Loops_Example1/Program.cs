using System;

namespace Loops_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to count by? >>");
            int whatToCountBy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What number would you like to count up to? >>");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            /*Special characters:
             * /n = hitting enter
             * /t = tab
             */

            for (int i = whatToCountBy; i <= upperBound; i = i + whatToCountBy)
            {
                if (i + whatToCountBy <= upperBound)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i);
                }
            }

            int counter = whatToCountBy;
            Console.WriteLine("\nNow the while Loop way ... ");
            bool isFirstTimeThru = true;
            while (counter <= upperBound)
            {
                if (isFirstTimeThru == true)
                {
                    Console.Write(counter);
                    isFirstTimeThru = false;
                }
                else
                {
                    Console.Write(", " + counter );
                }

                counter = counter + whatToCountBy;
            }

        }
    }
}
