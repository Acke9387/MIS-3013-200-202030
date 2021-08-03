using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ToyBox> toyboxes = new List<ToyBox>();

            do
            {
                ToyBox tb1 = new ToyBox();
                tb1.Location = "Norman, OK";
                tb1.Owner = "Darby";

                toyboxes.Add(tb1);
                Console.WriteLine($"Do you have another ToyBox to enter? yes or no >>");
            } while (Console.ReadLine().ToLower()[0] == 'y');

            for (int i = 0; i < toyboxes.Count; i++)
            {
                Console.WriteLine($"Time to fill {toyboxes[i].Owner}'s ToyBox!");

                do
                {
                    Toy toy1 = new Toy();
                    Console.WriteLine("Enter Manufacturer of the Toy >>");
                    toy1.Manufacturer = Console.ReadLine();
                    Console.WriteLine("Enter the Name of the Toy >>");
                    toy1.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Name of the Toy >>");
                    toy1.Price = 14.99;
                    toy1.AddNote("Crazy fun for the whole family!");
                    toy1.AddNote("Ages 5+");
                   

                    Console.WriteLine($"Do you have another toy to enter for {tb1.Owner}'s ToyBox? yes or no >>");
                } while (Console.ReadLine().ToLower()[0] == 'y'); 
            }

            Toy toy2 = new Toy("Hours of fun!");
            toy2.Manufacturer = "Nintendo";
            toy2.Name = "Switch";
            toy2.Price = 244.99;
            //tb1.Toys.Add(toy1);
            tb1.Toys.Add(toy2);

            toyboxes.Add(tb1);

            foreach (ToyBox currentToyBox in toyboxes)
            {
                Console.WriteLine($"{currentToyBox.Owner}'s ToyBox is located @ {currentToyBox.Location}.  The ToyBox has {currentToyBox.Toys.Count} toys inside of it:");
                foreach (Toy toyInCurrentBox in currentToyBox.Toys)
                {
                    Console.WriteLine();
                    Console.WriteLine(toyInCurrentBox);
                }
            }
            
        }
    }
}
