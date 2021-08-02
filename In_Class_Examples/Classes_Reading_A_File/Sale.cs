using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Reading_A_File
{
    public class Sale
    {
        public int OrderNumber { get; set; }
        public int QuantityOrdered { get; set; }
        public double PriceEach { get; set; }
        public int OrderLineNumber { get; set; }
        public double Sales { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int Quarter_ID { get; set; }
        public int Month_ID { get; set; }
        public int Year_ID { get; set; }
        public string ProductLine { get; set; }
        public double MSRP { get; set; }
        public string ProductCode { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Territory { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string DealSize { get; set; }

        public Sale()
        {
            OrderNumber         = 0;
            QuantityOrdered     = 0;
            PriceEach           = 0;
            OrderLineNumber     = 0;
            Sales               = 0;
            OrderDate           = DateTime.Now;
            Status              = string.Empty;
            Quarter_ID          = 0;
            Month_ID            = 0;
            Year_ID             = 0;
            ProductLine         = string.Empty;
            MSRP                = 0;
            ProductCode         = string.Empty;
            CustomerName        = string.Empty;
            Phone               = string.Empty;
            AddressLine1        = string.Empty;
            AddressLine2        = string.Empty;
            City                = string.Empty;
            State               = string.Empty;
            PostalCode          = string.Empty;
            Country             = string.Empty;
            Territory           = string.Empty;
            ContactLastName     = string.Empty;
            ContactFirstName    = string.Empty;
            DealSize            = string.Empty;
        }

        public Sale(string lineOfFile)
        {
            string[] pieces = lineOfFile.Split(',');
            //     0	         1	          2	           3	      4	     5	         6	    7	     8	      9	     10	       11	      12	     13	           14	     15	            16	      17	   18	   19	     20	      21	          22	           23	          24
            //ORDERNUMBER QUANTITYORDERED PRICEEACH ORDERLINENUMBER SALES ORDERDATE   STATUS QTR_ID  MONTH_ID YEAR_ID PRODUCTLINE MSRP    PRODUCTCODE CUSTOMERNAME    PHONE ADDRESSLINE1    ADDRESSLINE2 CITY    STATE POSTALCODE  COUNTRY TERRITORY   CONTACTLASTNAME 

            OrderNumber =     Convert.ToInt32(pieces[0]);
            QuantityOrdered = Convert.ToInt32(pieces[1]);
            PriceEach = Convert.ToDouble(pieces[2]);
            OrderLineNumber = Convert.ToInt32(pieces[3]);
            Sales = Convert.ToDouble(pieces[4]);
            OrderDate = Convert.ToDateTime(pieces[5]);
            Status = pieces[6];
            Quarter_ID = Convert.ToInt32(pieces[7]);
            Month_ID =   Convert.ToInt32(pieces[8]);
            Year_ID =    Convert.ToInt32(pieces[9]);
            ProductLine = pieces[10];
            MSRP = Convert.ToDouble(pieces[11]);
            ProductCode = pieces[12];
            CustomerName = pieces[13];
            Phone = pieces[14];
            AddressLine1 = pieces[15];
            AddressLine2 = pieces[16];
            City = pieces[17];
            State = pieces[18];
            PostalCode = pieces[19];
            Country =   pieces[20];
            Territory = pieces[21];
            ContactLastName = pieces[22];
            ContactFirstName = pieces[23];
            DealSize = pieces[24];
        }

        /// <summary>
        /// Returns the profit of the sale
        /// </summary>
        /// <returns>
        /// <c>Positive if you made money</c>
        /// <c>Negative if you made money</c>
        /// </returns>
        public double Profit()
        {
            return (MSRP * QuantityOrdered) - Sales;
        }


        public override string ToString()
        {
            return $"{OrderNumber} {OrderDate.ToShortDateString()} - {CustomerName}";
        }

    }
}
