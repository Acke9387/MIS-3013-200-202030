using System;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Manufacturer = "Hasbro";
            toy1.Name = "Twister";
            toy1.Price = 14.99;
            toy1.AddNote("Crazy fun for the whole family!");
            toy1.AddNote("Ages 5+");

            Toy toy2 = new Toy("Hours of fun!");
            toy2.Manufacturer = "Nintendo";
            toy2.Name = "Switch";
            toy2.Price = 244.99;

            // Don't need to do this, since we moved the logic to our Override ToString() method inside the class
            //Console.WriteLine($"{toy1.Name} is made by {toy1.Manufacturer} and costs {toy1.Price}.  Notes: {toy1.GetNotes()}.");
            //Console.WriteLine($"{toy2.Name} is made by {toy2.Manufacturer} and costs {toy2.Price}.  Notes: {toy2.GetNotes()}.");

            Console.WriteLine(toy1);
            Console.WriteLine(toy2);

        }
    }
}
