using OrderProcessor.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor
{
    public class PhysicalProductPaymentService : IPaymentService
    {
        public bool ProcessPayment(PaymentType paymentType)
        {
            GeneratePackagingSlip();
            if (paymentType == PaymentType.Book)
                GenerateRoyaltySlip();
            return true;
        }

        public void GeneratePackagingSlip()
        {
            Console.WriteLine("***************************************************\nPackaging Slip");
            PackagingSlip packagingSlip = ObjectMother.ObjectPackagingSlip.GetPackagingSlip();
            Console.WriteLine($"CompanyName - {packagingSlip.Company.Name}" );
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

        public void GenerateRoyaltySlip()
        {
            Console.WriteLine("***************************************************\nRoyalty Packaging Slip");
            RoyaltyPackagingSlip royaltyPackagingSlip = ObjectMother.ObjectPackagingSlip.GetRoyaltyPackagingSlip();
            Console.WriteLine($"Royalty CompanyName - {royaltyPackagingSlip.RoyaltyCompanyName}");
            Console.WriteLine($"Royalty CompanyAddress - {royaltyPackagingSlip.RoyaltyCompanyAddress}");
        }

    }
}
