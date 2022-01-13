using lib.ExternalSDKs;

namespace lib
{
    public class BillingService
    {
        private readonly GoodOldBillingProvider _oldBillingProvider;

        public BillingService(GoodOldBillingProvider oldBillingProvider)
        {
            _oldBillingProvider = oldBillingProvider;
        }

        public void Invoice(Invoice invoice)
        {
            
            int amount = invoice.Amount;
            var currency = invoice.Currency;
            string companyName = invoice.CompanyName;
            string invoiceForBillingSystem = amount + currency.Symbol + " to " +  companyName;
            _oldBillingProvider.SendInvoice(invoiceForBillingSystem);

        }
    }
}
