using System;
using System.Collections.Generic;

namespace Collections_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<double> numbers = new List<double>();
            
            do
            {
                Console.WriteLine("Please enter a value >>");
                input = Console.ReadLine();
                double number;

                while (double.TryParse(input, out number) == false)
                {
                    Console.WriteLine($"{input} is not a valid number. Please enter a valid number >>");
                    input = Console.ReadLine();
                }

                numbers.Add(number);

                Console.WriteLine("Do you want to enter another number? yes or no >>");
                input = Console.ReadLine(); 
            } while (input.ToLower()[0] == 'y');

            numbers.Add(1);
            numbers.Add(100);
            numbers.Add(15);

            double min = numbers[0];

            foreach (double value in numbers)
            {
                if (value < min)
                {
                    min = value;
                }
            }

            Console.WriteLine($"The lowest number in your data set is {min.ToString("N2")}");
        }
    }
}
