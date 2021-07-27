using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            Dictionary<double, int> examGrades2 = new Dictionary<double, int>();
            // [50] : 2
            // [100] : 1
            do
            {
                Console.WriteLine("Enter your exam grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                examGrades.Add(grade);

                if (examGrades2.ContainsKey(grade) == false)
                {
                    examGrades2.Add(grade, 1);
                }
                else
                {
                    examGrades2[grade]++;
                }



                Console.WriteLine("Do you have another exam grade to add? yes or no >>");
            } while (Console.ReadLine().ToLower() == "yes");


            double sum = 0;

            double min = examGrades[0];
            double max = examGrades[0];

            int mode = 1;

            foreach (double grade in examGrades2.Keys)
            {
                sum = sum + examGrades2[grade] * grade;
                if (mode < examGrades2[grade])
                {
                    mode = examGrades2[grade];
                }
            }

            foreach (double grade in examGrades2.Keys)//Output any keys(grades) that have a value of the mode
            {
                sum = sum + examGrades2[grade] * grade;
                if (mode == examGrades2[grade])
                {
                    Console.WriteLine(grade);
                }
            }

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
            Console.WriteLine($"Your average is {sum / examGrades.Count}");
            Console.WriteLine($"Your lowest score is {min}");
            Console.WriteLine($"Your highest score is {max}");
        }
    }
}
