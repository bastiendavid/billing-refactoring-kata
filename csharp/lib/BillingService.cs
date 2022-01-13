using lib.NotOurCode;

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
            string currency = invoice.Currency;
            string companyName = invoice.CompanyName;
            string invoiceForBillingSystem = amount + currency + " to " +  companyName;
            _oldBillingProvider.SendInvoice(invoiceForBillingSystem);

        }
    }
}
