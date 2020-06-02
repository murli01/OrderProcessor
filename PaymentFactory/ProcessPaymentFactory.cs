using OrderProcessor.Domains;
using OrderProcessor.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.PaymentFactory
{
    public static class ProcessPaymentFactory
    {
        public static bool ProcessPayments(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.PhysicalProduct:
                case PaymentType.Book:
                    PhysicalProductPaymentService physicalProductPaymentService = new PhysicalProductPaymentService();
                    return physicalProductPaymentService.ProcessPayment(paymentType);
                case PaymentType.Membership:
                case PaymentType.MembershipUpgrade:
                    MembershipPaymentService membershipPaymentService = new MembershipPaymentService();
                    return membershipPaymentService.ProcessPayment(paymentType);
                case PaymentType.Video:
                    VideoPaymentService videoPaymentService = new VideoPaymentService();
                    return videoPaymentService.ProcessPayment(paymentType);
                default:
                    return false;
            }
        }
    }
}
