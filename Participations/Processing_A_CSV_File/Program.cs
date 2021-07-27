using System;
using System.Collections.Generic;
using System.IO;

namespace Processing_A_CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "sales_data_sample.csv";

            string[] contents = File.ReadAllLines(file);
            /*
             ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
             10107,30,95.7,2,2871,2/24/2003 0:00,Shipped,1,2,2003,Motorcycles,95,S10_1678,Land of Toys Inc.,2125557818,897 Long Airport Avenue,,NYC,NY,10022,USA,NA,Yu,Kwai,Small
            */

            double salesFor2003 = 0;
            double salesFor2004 = 0;
            double salesFor2005 = 0;

            //double jan = 0;
            //double feb = 0;
            //double mar = 0;

            double[] monthSales = new double[13];            

            for (int i = 1; i < contents.Length; i++)
            {
                //     0              1           2             3         4
                //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
                string line = contents[i];
                string[] pieces = line.Split(',');

                double sale = Convert.ToDouble(pieces[4]);
                int year = Convert.ToInt32(pieces[9]);
                string status = pieces[6];
                int month = Convert.ToInt32(pieces[8]);

                if (status.ToLower() == "shipped")
                {
                    if (year == 2003)
                    {
                        salesFor2003 += sale;
                    }
                    else if (year == 2004)
                    {
                        salesFor2004 += sale;
                    }
                    else if (year == 2005)
                    {
                        salesFor2005 += sale;
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: No year for {year}");
                    }

                    monthSales[month] += sale;
                }

                //Console.WriteLine(sale);
            }

            Console.WriteLine($"The sales for 2003 were {salesFor2003.ToString("C")}");
            Console.WriteLine($"The sales for 2004 were {salesFor2004.ToString("C")}");
            Console.WriteLine($"The sales for 2005 were {salesFor2005.ToString("C")}");

            Console.WriteLine($"The sales for January were {monthSales[1].ToString("C")}");
            Console.WriteLine($"The sales for February were {monthSales[2].ToString("C")}");
            Console.WriteLine($"The sales for March were {monthSales[3].ToString("C")}");
            Console.WriteLine($"The sales for April were {monthSales[4].ToString("C")}");
            Console.WriteLine($"The sales for May were {monthSales[5].ToString("C")}");
            Console.WriteLine($"The sales for June were {monthSales[6].ToString("C")}");
            Console.WriteLine($"The sales for July were {monthSales[7].ToString("C")}");
            Console.WriteLine($"The sales for August were {monthSales[8].ToString("C")}");
            Console.WriteLine($"The sales for September were {monthSales[9].ToString("C")}");
            Console.WriteLine($"The sales for October were {monthSales[10].ToString("C")}");
            Console.WriteLine($"The sales for November were {monthSales[11].ToString("C")}");
            Console.WriteLine($"The sales for December were {monthSales[12].ToString("C")}");




        }
    }
}
