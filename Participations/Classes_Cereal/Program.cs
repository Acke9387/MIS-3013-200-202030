using System;
using System.Collections.Generic;
using System.IO;

namespace Classes_Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0        1          2       3
            //name|manufacturer|calories|cups
            //100 % Bran | Nabisco | 70 | 0.33

            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            List<Cereal> cereals = new List<Cereal>();

            // Process all of the information from the file and store it in a collection
            for (int i = 1; i < lines.Length; i++)
            {
                string[] cerealInformation = lines[i].Split('|');

                Cereal temp = new Cereal();
                temp.Name = cerealInformation[0];
                temp.Manufacturer = cerealInformation[1];
                temp.Calories = Convert.ToDouble(cerealInformation[2]);
                temp.Cups = Convert.ToDouble(cerealInformation[3]);

                cereals.Add(temp);
            }

            OutputCerealsWithServingSize(cereals, 1);
            OutputCerealsWithCaloriesLessThan(cereals, 100);
        }

        private static void OutputCerealsWithServingSize(List<Cereal> cereals, double lowerBoundServingSize)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("".PadLeft(15, '*') + $" Serving Size >= {lowerBoundServingSize} cups " + "".PadLeft(15, '*'));
            foreach (Cereal cereal in cereals)
            {
                if (cereal.Cups >= lowerBoundServingSize)
                {
                    Console.WriteLine(cereal);
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void OutputCerealsWithCaloriesLessThan(List<Cereal> cereals, double lowerBoundCalories)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("".PadLeft(15, '*') + $" Cereals w/ <= {lowerBoundCalories} calories " + "".PadLeft(15, '*'));
            foreach (Cereal cereal in cereals)
            {
                if (cereal.Calories <= lowerBoundCalories)
                {
                    Console.WriteLine(cereal);
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
