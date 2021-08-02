using System;
using System.Collections.Generic;
using System.IO;

namespace Classes_Reading_A_File
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] lines = File.ReadAllLines("sales_data_sample.csv");

            List<Sale> sales = new List<Sale>();
            for (int i = 1; i < lines.Length; i++)
            {
                Sale s = new Sale(lines[i]);
               
                // If we were doing the setting of values in our Main method vs our constructor
                //string[] pieces = new string[3];
                //s.OrderNumber = Convert.ToInt32(pieces[0]);
                //s.QuantityOrdered = Convert.ToInt32(pieces[1]);
                //s.PriceEach = Convert.ToDouble(pieces[2]);
                sales.Add(s);
            }

            //OutputAllSalesFromCountry(sales, "USA");
            //OutputAllSalesFromCountry(sales, "France");
            OutputAllSalesWithAProfit(sales);
            OutputAllSalesWithALoss(sales);

        }

        private static void OutputAllSalesWithAProfit(List<Sale> sales)
        {
            string s = "".PadLeft(10, '*') + $"Sales with a Profit" + "".PadRight(10, '*');
            Console.WriteLine(s);
            int count = 0;
            foreach (Sale sale in sales)
            {
                if (sale.Profit() > 0)
                {
                    Console.Write(sale+"\t" );
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(sale.Profit());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    count++;
                }
            }
            Console.WriteLine($"\nThere were {count} # of sales with a profit.");
            Console.WriteLine("".PadLeft(s.Length, '*'));
        }

        private static void OutputAllSalesWithALoss(List<Sale> sales)
        {
            string s = "".PadLeft(10, '*') + $"Sales with a Loss" + "".PadRight(10, '*');
            Console.WriteLine(s);
            int count = 0;
            foreach (Sale sale in sales)
            {
                if (sale.Profit() < 0)
                {
                    Console.Write(sale + "\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(sale.Profit());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    count++;
                }
            }
            Console.WriteLine($"\nThere were {count} # of sales with a loss.");
            Console.WriteLine("".PadLeft(s.Length, '*'));
        }

        private static void OutputAllSalesFromCountry(List<Sale> sales, string country)
        {
            Console.WriteLine("".PadLeft(10,'*') + $"{country} Sales" + "".PadRight(10, '*'));
            foreach (Sale sale in sales)
            {
                if (sale.Country.ToUpper() == country.ToUpper())
                {
                    Console.WriteLine(sale) ;
                }
            }
        }
    }
}
