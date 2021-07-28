using System;
using System.Collections.Generic;

namespace Functions_Example2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> mis3013Grades = new List<double>();
            List<double> mis3033Grades = new List<double>();

            mis3013Grades = PopulateDataIntoList(50);
            mis3033Grades = PopulateDataIntoList(90);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("MIS 3013 Grades");
            OutputLetterGrade(mis3013Grades);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MIS 3033 Grades");
            OutputLetterGrade(mis3033Grades);

            Random rand = new Random();
            int randomIndexOfGrade = rand.Next(0, mis3013Grades.Count); // get a random int that corresponds with the bounds of our list
            double randomGrade = mis3013Grades[randomIndexOfGrade];     // get the grade at that random position
            char letter = ConvertGradeToLetterGrade(randomGrade);       // convert that grade to a letter grade

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{randomGrade} is a {letter}.");
            string s = Console.ReadLine();

        }

        /// <summary>
        /// Generate a list of random numbers
        /// </summary>
        /// <param name="number">The number of values to generate</param>
        /// <returns>A list of size {number} of random values</returns>
        static List<double> PopulateDataIntoList(int number)
        {
            List<double> values = new List<double>();
            Random rand = new Random();

            for (int i = 0; i < number; i++)
            {
                values.Add(rand.NextDouble());
            }

            return values;
        }

        static void OutputLetterGrade(List<double> values)
        {
            foreach (double value in values)
            {
                char letter = ConvertGradeToLetterGrade(value);
                Console.WriteLine($"{value.ToString("p")} is an {letter}");                
            }

        }

        /// <summary>
        /// Converts a double into a letter grade
        /// </summary>
        /// <param name="value">A value between 0 and 1</param>
        /// <returns>The letter grade on a typical grading scale associated with the value passed in</returns>
        static char ConvertGradeToLetterGrade(double value)
        {
            char letter;
            if (value >= .9)
            {
                letter = 'A';
            }
            else if (value >= .8)
            {
                letter = 'B';
            }
            else if (value >= .7)
            {
                letter = 'C';
            }
            else if (value >= .6)
            {
                letter = 'D';
            }
            else
            {
                letter = 'F';
            }

            return letter;
        }

    }
}
