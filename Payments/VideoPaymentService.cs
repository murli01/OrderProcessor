using OrderProcessor.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.Payments
{
    public class VideoPaymentService : IPaymentService
    {
        public bool ProcessPayment(PaymentType paymentType)
        {
            GeneratePackingSlip();
            GenerateFreeVideoPackagingSlip();
            return true;
        }

        public void GeneratePackingSlip()
        {
            Console.WriteLine("***************************************************\nVideo Packaging Slip");
            PackagingSlip packagingSlip = ObjectMother.ObjectPackagingSlip.GetPackagingSlip();
            Console.WriteLine($"CompanyName - {packagingSlip.Company.Name}");
            Console.WriteLine($"CompanyAddress - {packagingSlip.Company.Address}");
            Console.WriteLine($"CompanyMobile - {packagingSlip.Company.Mobile}");
            Console.WriteLine($"ShipTo - ");
            Console.WriteLine($"ShipToCompanyName - {packagingSlip.ShipTo.Name}");
            Console.WriteLine($"ShipToMobile - {packagingSlip.Company.Mobile}");
            Console.WriteLine($"BillTo - ");
            Console.WriteLine($"BillToName - {packagingSlip.BillTo.Name}");
            Console.WriteLine($"BillToMobile - {packagingSlip.BillTo.Mobile}");
            Console.WriteLine($"OrderDetails - ");
            Console.WriteLine($"OrderDate - {packagingSlip.Order.OrderDate}");
            Console.WriteLine($"OrderNumber - {packagingSlip.Order.Ordernumber}");

        }
        public void GenerateFreeVideoPackagingSlip()
        {
            Console.WriteLine("***************************************************\nFree Video Packaging Slip");
            PackagingSlip packagingSlip = ObjectMother.ObjectPackagingSlip.GetPackagingSlip();
            Console.WriteLine($"CompanyName - {packagingSlip.Company.Name}");
            Console.WriteLine($"CompanyAddress - {packagingSlip.Company.Address}");
            Console.WriteLine($"CompanyMobile - {packagingSlip.Company.Mobile}");
            Console.WriteLine($"ShipTo - ");
            Console.WriteLine($"ShipToCompanyName - {packagingSlip.ShipTo.Name}");
            Console.WriteLine($"ShipToMobile - {packagingSlip.Company.Mobile}");
            Console.WriteLine($"BillTo - ");
            Console.WriteLine($"BillToName - {packagingSlip.BillTo.Name}");
            Console.WriteLine($"BillToMobile - {packagingSlip.BillTo.Mobile}");
            Console.WriteLine($"OrderDetails - ");
            Console.WriteLine($"OrderDate - {packagingSlip.Order.OrderDate}");
            Console.WriteLine($"OrderNumber - {packagingSlip.Order.Ordernumber}");

        }
    }
}
