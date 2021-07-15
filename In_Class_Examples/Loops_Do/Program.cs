using System;

namespace Loops_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // lots of times you see this as i
            double sum = 0; // Referred to as an accumulator
            string answer;
            do
            {
                Console.WriteLine("Enter your homework grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());

                //sum = sum + grade;
                sum += grade;

                //counter = counter + 1;
                //counter += 1;
                counter++;

                Console.WriteLine("Do you have another grade to enter? yes or no >>");
                answer = Console.ReadLine();
            } while (answer == "yes");


        }
    }
}
