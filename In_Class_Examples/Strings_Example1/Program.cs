using System;

namespace Strings_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //                 0123456790
            string sentence = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine($"There are {sentence.Length.ToString("n0")} characters in the sentence.");

            Console.WriteLine();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    Console.WriteLine();
                    continue;
                }
                
                Console.Write(sentence[i]);
            }

            Console.WriteLine("Which letter do you want to know the count of? >>");
            string letter = Console.ReadLine();



        }
    }
}
