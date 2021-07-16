using System;

namespace Loops_Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            //                 0123456790
            string sentence = "The quick brown fox jumps over the lazy dog";

            //                  01234
            //string sentence2 = "Hello";
            //Console.WriteLine(sentence2.Length); // Output: 5

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    Console.WriteLine(sentence[i]);
                }
            }

        }
    }
}
