using System;

namespace Sum_Of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MAGIC_NUMBER = 7.777;
            double val1, val2;
            string input;
            Console.WriteLine("Please enter your first #: >>");
            input = Console.ReadLine();
            val1 = Convert.ToDouble(input);

            Console.WriteLine("Please enter your second #: >>");
            val2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your third #: >>");
            double val3 = Convert.ToDouble(Console.ReadLine());

            double sum = (val1 + val2 + val3);

            Console.WriteLine($"The sum of your #'s is {sum.ToString("n3")}");
                       
            double secondOutput = sum * MAGIC_NUMBER;

            Console.WriteLine($"{sum.ToString("n3")} * the magic number is {secondOutput.ToString("n3")}");
        }
    }
}
