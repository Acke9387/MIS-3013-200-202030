using System;

namespace All_Types_of_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = new string[3];
            int[] crns = new int[3];

            for (int i = 0; i < crns.Length; i++)
            {
                Console.WriteLine("Please enter a subject >>");
                string subject = Console.ReadLine();
                subjects[i] = subject;

                Console.WriteLine("Please enter the course number >>");
                crns[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{subjects[i]}{crns[i]}");
            }


        }
    }
}
