using System;

namespace Loops_For
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i < 101; i = i + 2)
            {
                Console.WriteLine(i);
            }

            int sum = 0; //accumulator, just used to accumulate values

            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
                //sum += i;
            }

            Console.WriteLine($"The summation from 1 to 100 is {sum.ToString("N0")}");

        }
    }
}
