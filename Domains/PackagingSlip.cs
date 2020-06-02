using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.Domains
{
    public class PackagingSlip
    {
        public Company Company { get; set; }
        public ShipTo ShipTo { get; set; }
        public BillTo BillTo { get; set; }
        public Order Order { get; set; }

    }

    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
    public class ShipTo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
    public class BillTo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public int Ordernumber { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
