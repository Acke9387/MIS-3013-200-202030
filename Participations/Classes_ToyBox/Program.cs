using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> toyboxes = new List<ToyBox>();

            // Have the user input as many ToyBoxes as they want
            do
            {
                ToyBox tb1 = new ToyBox();
                Console.WriteLine("Who is the owner of the ToyBox? >>");
                tb1.Owner = Console.ReadLine();
                Console.WriteLine($"Where is {tb1.Owner}'s ToyBox Located? >>");
                tb1.Location = Console.ReadLine();

                toyboxes.Add(tb1);
                Console.WriteLine($"Do you have another ToyBox to enter? yes or no >>");
            } while (Console.ReadLine().ToLower()[0] == 'y');

            for (int i = 0; i < toyboxes.Count; i++)
            {
                Console.WriteLine($"Time to fill {toyboxes[i].Owner}'s ToyBox w/ Toys!");

                do
                {
                    Toy toy1 = new Toy();
                    Console.WriteLine("Enter Manufacturer of the Toy >>");
                    toy1.Manufacturer = Console.ReadLine();
                    Console.WriteLine($"Enter the Name of the Toy made by {toy1.Manufacturer} >>");
                    toy1.Name = Console.ReadLine();
                    Console.WriteLine($"Enter the price of the {toy1.Name}>>");
                    toy1.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"What notes do you have for {toy1.Name}? Seperate each one with a \\n");
                    toy1.AddNote(Console.ReadLine());

                    toyboxes[i].Toys.Add(toy1);

                    Console.WriteLine($"Do you have another toy to enter for {toyboxes[i].Owner}'s ToyBox? yes or no >>");
                } while (Console.ReadLine().ToLower()[0] == 'y'); 
            }

            foreach (ToyBox currentToyBox in toyboxes)
            {
                Console.WriteLine($"{currentToyBox.Owner}'s ToyBox is located @ {currentToyBox.Location}.  The ToyBox has {currentToyBox.Toys.Count} toys inside of it:");
                foreach (Toy toyInCurrentBox in currentToyBox.Toys)
                {
                    Console.WriteLine();
                    Console.WriteLine(toyInCurrentBox);
                }

                Console.WriteLine("".PadLeft(10,'-') + "Random Toy!" + "".PadLeft(10, '-'));
                Toy randomToyFromToyBox = currentToyBox.GetRandomToy();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(randomToyFromToyBox);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
        }
    }
}
