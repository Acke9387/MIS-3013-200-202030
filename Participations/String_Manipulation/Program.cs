using System;

namespace String_Manipulation
{
    class Program
    {
        static string Sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots.So far, the universe is winning.";
        
        static void Main(string[] args)
        {

            Console.WriteLine(Sentence);

            Console.WriteLine("\nWhat word would you like to search for? >>");
            string search = Console.ReadLine();
            Console.WriteLine($"What word would you like to replace {search} with? >>");
            string replace = Console.ReadLine();

            if (Sentence.Contains(search) == true)
            {
                Sentence = Sentence.Replace(search, replace);
                Console.WriteLine();
                Console.WriteLine(Sentence);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {search}.");

                for (int i = search.Length-1; i >= 0; i--)
                {
                    Console.Write(search[i]);
                }
            }


        }
    }
}
