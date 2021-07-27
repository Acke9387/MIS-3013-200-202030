using System;
using System.Collections.Generic;

namespace All_Types_of_Collections_Pt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();

            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.95);
            courseGrades["MIS3013"].Add(0.5);
            courseGrades["MIS3013"].Add(0.7);

            courseGrades.Add("MIS3033", new List<double>());
            courseGrades["MIS3033"].Add(.6);
            courseGrades["MIS3033"].Add(0.4);
            courseGrades["MIS3033"].Add(1.0);

            courseGrades.Add("MIS2113", new List<double>());
            courseGrades["MIS2113"].Add(0.75);
            courseGrades["MIS2113"].Add(0.85);
            courseGrades["MIS2113"].Add(0.95);

            // Extra portion
            do // allows the user to enter all of the course codes
            {
                Console.WriteLine("Please enter the course code >>");
                string courseCode = Console.ReadLine().ToUpper(); //e.g. mis3013

                if (courseGrades.ContainsKey(courseCode) == false)
                {
                    courseGrades.Add(courseCode, new List<double>()); 
                }

                do // allow the user to enter all the grades for the course code
                {
                    Console.WriteLine($"Enter the students grade for {courseCode} >>");
                    double grade = Convert.ToDouble(Console.ReadLine());
                    courseGrades[courseCode].Add(grade);

                    Console.WriteLine("Do you have another grade to enter? yes or no >>");
                } while (Console.ReadLine().ToLower() == "yes");

                Console.WriteLine("Do you have another course to enter grades for? yes or no >>");
            } while (Console.ReadLine().ToLower() == "yes");

            foreach (string course in courseGrades.Keys)
            {
                
                double sum = 0;
                foreach (double grade in courseGrades[course])
                {
                    sum += grade;
                }
                double avg = sum / courseGrades[course].Count;
                Console.WriteLine($"{course} : {avg.ToString("P")}");
            }

        }
    }
}
