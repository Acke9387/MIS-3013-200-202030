using System;
using System.Collections.Generic;

namespace Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "Joe");
            students.Add(2, "Julie");

            if (students.ContainsKey(1) == true)
            {
                students[1] = "Liz";
            }
            else
            {
                students.Add(1, "Liz");
            }

            foreach (int id in students.Keys)
            {
                string name = students[id];
                Console.WriteLine($"{name} ({id})");
            }

            Console.WriteLine("".PadLeft(10, '-'));
            foreach (KeyValuePair<int, string> item in students)
            {
                Console.WriteLine($"{item.Value} ({item.Key})");
            }
        }
    }
}
