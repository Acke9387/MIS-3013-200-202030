using System;

namespace Simple_Method_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite animal? >>");
            string input = Console.ReadLine();

            string sound;

            sound = Speak(input); 

            Console.WriteLine($"A {input} makes the sound of {sound}!");
        }


        static string Speak(string animal)
        {
            string noise;

            switch (animal)
            {
                case "dog":
                    noise = "ruff";
                    break;

                case "monkey":
                    noise = "ooo eee aahhh";
                    break;

                case "goat":
                    noise = "man screaming";
                    break;

                default:
                    noise = "grr";
                    break;
            }

            return noise;
        }

    }
}
