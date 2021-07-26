using System;

namespace Functions_Calculator
{
    class Program
    {        
        static void Main(string[] args)
        {
            DeveloperInformation("Instructor Ackerman", "MIS 3013", "7/26/21");


        }

        static double Add(double val1, double val2)
        {
            //double sum;
            //sum = val1 + val2;
            //return sum;
            return val1 + val2;
        }

        static void DeveloperInformation(string name, string course, string date)
        {
            Console.WriteLine($"{name} wrote this application for {course} on {date}.");
        }


    }
}
