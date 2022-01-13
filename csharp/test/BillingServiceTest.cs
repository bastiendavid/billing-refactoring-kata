using System;
using lib;
using lib.ExternalSDKs;
using Moq;
using Xunit;

namespace test
{
    public class BillingServiceTest
    {
        [Fact]
        public void TestBillingService()
        {

            var billingProviderMock = new Mock<GoodOldBillingProvider>();
            var service = new BillingService(billingProviderMock.Object);
            
            service.Invoice(new Invoice(100, Currency.Dollar(), "Vance Refrigeration"));
            
            billingProviderMock.Verify(provider => provider.SendInvoice("100$ to Vance Refrigeration"));
        }
    }

}
