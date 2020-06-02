using OrderProcessor.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor
{
    public interface IPaymentService
    {
        bool ProcessPayment(PaymentType paymentType);
    }
}
