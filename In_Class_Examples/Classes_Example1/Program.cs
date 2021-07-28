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

            Circle c1 = new Circle();
            Circle c2 = new Circle();

            c1.Radius = 5.5;
            c2.Radius = 5;
            Console.WriteLine();
            Console.WriteLine($"The area of c1 is {c1.CalculateArea()}");
            Console.WriteLine($"The perimeter of c1 is {c1.CalculatePerimeter()}");
            Console.WriteLine();
            Console.WriteLine($"The area of c2 is {c2.CalculateArea()}");
            Console.WriteLine($"The perimeter of c2 is {c2.CalculatePerimeter()}");

        }
    }
}
