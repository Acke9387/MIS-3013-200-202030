using System;
using System.Collections.Generic;

namespace All_Types_of_Collections_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();

            do
            {
                Console.WriteLine("Please enter your grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                Console.WriteLine("Do you have another grade to enter? yes or no >>");

            } while (Console.ReadLine().ToLower() != "no");

            double sum = 0;

            foreach (double grade in grades)
            {
                sum += grade;

            }
            
            double average = sum / grades.Count;
            
            Console.WriteLine($"Your average is {average.ToString("P")}");

        }
    }
}
