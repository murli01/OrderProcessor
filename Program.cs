using OrderProcessor.Domains;
using OrderProcessor.PaymentFactory;
using System;

namespace OrderProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            repeat:
            Console.WriteLine("Welome to the Order Payment Processing system.\n**********************************************\nPlease select type of payment (type between 1 to 5)- ");
            Console.WriteLine("1. Physical Products.\n2. Membership.\n3. Video.");
            PaymentType paymentType = GetUserInput();
            Console.WriteLine($"Payment will get processed for {paymentType}");
            bool IsSuccessed = ProcessPaymentFactory.ProcessPayments(paymentType);
            Console.WriteLine($"\n\nPayment Status - {IsSuccessed.ToString()}");
            Console.WriteLine("\n\nDo you want to continue payment?(y/n)");
            string result = Console.ReadLine().ToLower();
            if (result == "y") goto repeat;
            else System.Environment.Exit(0);

        }

        public static PaymentType GetUserInput()
        {
            if (int.TryParse(Console.ReadLine(), out int val))
            {
                switch (val)
                {
                    case 1:
                        Console.WriteLine("Do you want to make payment of Book(Y/N)");
                        return Console.ReadLine().ToLower() == "y" ? PaymentType.Book : PaymentType.PhysicalProduct;
                    case 2:
                        Console.WriteLine("Do you want to activate new membership(Y/N)");
                        return Console.ReadLine().ToLower() == "y" ? PaymentType.Membership : PaymentType.MembershipUpgrade;
                    case 3:
                        return PaymentType.Video;
                }
            }
            return PaymentType.None;
        }
    }
}
