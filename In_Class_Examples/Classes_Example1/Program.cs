using System;

namespace Classes_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();

            // Example code used for explaining get/set
            //r1.Width = 5;
            //r1.SetWidth(5);
            //double val = r1.Width;
            //val = r1.GetWidth();

            r1.Length = 10;
            r1.Width = 5;

            Rectangle r2 = new Rectangle();
            r2.Length = 5;
            r2.Width = 5;

            double a = r1.CalculateArea();
            double p = r1.CalculatePerimeter();

            Console.WriteLine($"The area of r1 is {a}");
            Console.WriteLine($"The perimeter of r1 is {p}");

            a = r2.CalculateArea();
            p = r2.CalculatePerimeter();

            Console.WriteLine($"The area of r2 is {a}");
            Console.WriteLine($"The perimeter of r2 is {p}");

        }
    }
}
