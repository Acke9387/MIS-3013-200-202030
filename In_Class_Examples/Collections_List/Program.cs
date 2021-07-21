using System;
using System.Collections.Generic;

namespace Collections_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> data = new List<double>();

            data.Add(382.28);
            data.Add(39.28);
            data.Add(2892);

            double sum = 0;
            foreach (double item in data)
            {
                //sum = sum + item;
                sum += item;
                Console.WriteLine(item);
            }

            sum = 0; //reset to starting point since we already added them up

            for (int i = 0; i < data.Count; i++)
            {
                sum += data[i];
            }

            Console.WriteLine($"\nThe sum of all the numbers is {sum.ToString("N3")}");
            //data[0] = 5;

            //foreach (double item in data)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
