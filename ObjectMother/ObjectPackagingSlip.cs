using AutoFixture;
using OrderProcessor.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.ObjectMother
{
    public static class ObjectPackagingSlip
    {
        public static PackagingSlip GetPackagingSlip()
        {
            return new Fixture().Create<PackagingSlip>();
        }

        public static RoyaltyPackagingSlip GetRoyaltyPackagingSlip()
        {
            return new Fixture().Create<RoyaltyPackagingSlip>();
        }
    }
}
