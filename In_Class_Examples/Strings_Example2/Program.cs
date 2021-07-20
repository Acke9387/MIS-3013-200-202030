using System;

namespace Strings_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            //              012345678901234567890
            string names = "Scooby Christina JENN clarke";

            // Trying to figure out how to use substring, etc.
            //string name1 = names.Substring(0, 6);
            //string name2 = names.Substring(7, 9);
            //string name3 = names.Substring(17, 4);
            //Console.WriteLine($"{name1}\n{name2}\n{name3}");


            //      First way to solve the problem
            //string name = "";
            //for (int i = 0; i < names.Length; i++)
            //{
            //    char currentLetter = names[i];

            //    if (currentLetter == ' ')
            //    {
            //        Console.WriteLine(name);
            //        name = "";
            //    }
            //    else
            //    {
            //        name += currentLetter;
            //    }
            //}
            //Console.WriteLine(name);

            bool shouldContinueIterating = true;
            int indexOfLastSpace = 0;
            //01234567890123456
            //Scooby Christina JENN clarke";
            while (shouldContinueIterating)
            {
                string name;
                int startingPosition = indexOfLastSpace;
                indexOfLastSpace = names.IndexOf(' ', indexOfLastSpace + 1);
                if (indexOfLastSpace == -1)
                {
                    name = names.Substring(startingPosition + 1);
                    
                }
                else
                {
                    int length = indexOfLastSpace - startingPosition;

                    name = names.Substring(startingPosition, length);
                    name = name.Trim();
                    
                    //  Another way to do it
                    //if (startingPosition == 0)
                    //{
                    //    name = names.Substring(startingPosition, length); 
                    //}
                    //else
                    //{
                    //    name = names.Substring(startingPosition + 1, length);
                    //}
                }

                name = name.ToLower();
                name = name.ToUpper()[0] + name.Substring(1);

                Console.WriteLine(name);

                if (indexOfLastSpace == -1)
                {
                    shouldContinueIterating = false;
                }
            }

        }
    }
}
