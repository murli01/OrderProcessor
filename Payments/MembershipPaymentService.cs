using OrderProcessor.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor
{
    public class MembershipPaymentService : IPaymentService
    {
        public bool ProcessPayment(PaymentType paymentType)
        {
            ActivateMemberShip();
            if (paymentType == PaymentType.MembershipUpgrade)
                UpgradeMemberShip();
            Console.WriteLine("An email has been sent to owner regarding Subscription/Upgradation.");
            return true;
        }

        public void ActivateMemberShip()
        {
            Console.WriteLine("***************************************************\nMembership Activation");
            Console.WriteLine("Your membership has been activated.");
        }

        public void UpgradeMemberShip()
        {
            Console.WriteLine("***************************************************\nMembership Upgration");
            Console.WriteLine("Your membership has been upgraded.");
        }
    }
}
