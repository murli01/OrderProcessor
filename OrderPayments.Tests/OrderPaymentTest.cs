using OrderProcessor.Domains;
using OrderProcessor.PaymentFactory;
using System;
using Xunit;

namespace OrderPayments.Tests
{
    public class OrderPaymentTest
    {
        [Fact]
        public void Should_Generate_PackagingSlip_ForPhysicalProduct()
        {
            //Arrange
            //Act
            bool isSuccessed = ProcessPaymentFactory.ProcessPayments(PaymentType.PhysicalProduct);
            //Assert
            Assert.True(isSuccessed);
        }

        [FactAttribute]
        public void Should_Generate_Royalty_PackagingSlip_ForBook()
        {
            //Arrange
            //Act
            bool isSuccessed = ProcessPaymentFactory.ProcessPayments(PaymentType.Book);
            //Assert
            Assert.True(isSuccessed);
        }

        [Fact]
        public void Should_Active_Membership()
        {
            //Arrange
            //Act
            bool isSuccessed = ProcessPaymentFactory.ProcessPayments(PaymentType.Membership);
            //Assert
            Assert.True(isSuccessed);
        }

        [Fact]
        public void Should_Upgrade_Membership()
        {
            //Arrange
            //Act
            bool isSuccessed = ProcessPaymentFactory.ProcessPayments(PaymentType.MembershipUpgrade);
            //Assert
            Assert.True(isSuccessed);
        }

        [Fact]
        public void Should_SendEmail_For_MembershipActivity()
        {
            //Arrange
            //Act
            bool isSuccessed = ProcessPaymentFactory.ProcessPayments(PaymentType.MembershipUpgrade);
            //Assert
            Assert.True(isSuccessed);
        }

        [Fact]
        public void Should_Generate_Video_PackagingSlip()
        {
            //Arrange
            //Act
            bool isSuccessed = ProcessPaymentFactory.ProcessPayments(PaymentType.Video);
            //Assert
            Assert.True(isSuccessed);
        }
    }
}
