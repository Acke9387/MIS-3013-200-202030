using System;

namespace Functions_Calculator
{
    class Program
    {        
        static void Main(string[] args)
        {
            DeveloperInformation("Instructor Ackerman", "MIS 3013", "7/26/21");
            double lh, rh, result = 0;
            string answer;
            bool askUserQuestion = true;

            do
            {
                if (askUserQuestion == true)
                {
                    Console.WriteLine("Enter your left hand operand >>");
                    lh = Convert.ToDouble(Console.ReadLine()); 
                }
                else
                {
                    lh = result;
                }

                Console.WriteLine("Enter your right hand operand >>");
                rh = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What operation would you like to perform (+, -, /, *) >>");
                string operation = Console.ReadLine();

                if (operation == "+")
                {
                    result = Add(lh, rh);
                }
                else if (operation == "-")
                {
                    result = Subtract(lh, rh);
                }
                else if (operation == "*")
                {
                    result = Multiply(lh, rh);
                }
                else
                {
                    result = Divide(lh, rh);
                }

                Console.WriteLine($"{lh} {operation} {rh} = {result}");

                Console.WriteLine("Do you want to perform another calculation? yes or no");
                answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    Console.WriteLine($"Do you want {result} as your left hand operand? yes or no");

                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        askUserQuestion = false;
                    }
                    else
                    {
                        askUserQuestion = true;
                    }
                }

            } while (answer == "yes");

        }

        static double Add(double val1, double val2)
        {
            //double sum;
            //sum = val1 + val2;
            //return sum;
            return val1 + val2;
        }

        static double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        static double Divide(double val1, double val2)
        {
            return val1 / val2;
        }

        static void DeveloperInformation(string name, string course, string date)
        {
            Console.WriteLine($"{name} wrote this application for {course} on {date}.");
        }


    }
}
