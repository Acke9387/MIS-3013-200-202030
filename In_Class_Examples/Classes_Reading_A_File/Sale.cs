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

    }
}
