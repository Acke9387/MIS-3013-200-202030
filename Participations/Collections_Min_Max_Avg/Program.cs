using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();

            do
            {
                Console.WriteLine("Enter your exam grade >>");
                examGrades.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you have another exam grade to add? yes or no >>");
            } while (Console.ReadLine().ToLower() == "yes");


            double sum = 0;

            double min = examGrades[0];
            double max = examGrades[0];

            foreach (double grade in examGrades)
            {
                Console.Write(grade + "  ");
                sum += grade;

                if (grade < min)
                {
                    min = grade;
                }

                if (grade > max)
                {
                    max = grade;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Your average is {sum/examGrades.Count}");
            Console.WriteLine($"Your lowest score is {min}");
            Console.WriteLine($"Your highest score is {max}");
        }
    }
}
