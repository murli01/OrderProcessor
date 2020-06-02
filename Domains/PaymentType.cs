using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.Domains
{
    public enum PaymentType
    {
        None = 0,
        PhysicalProduct = 1,
        Book = 2,
        Membership = 3,
        MembershipUpgrade = 4,
        Video = 5
    }
}
