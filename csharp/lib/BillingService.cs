using System;

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

    public class Invoice
    {
        public int Amount { get; }
        public string Currency { get; }
        public string CompanyName { get; }

        public Invoice(int amount, string currency, string companyName)
        {
            Amount = amount;
            Currency = currency;
            CompanyName = companyName;
        }
    }
    
    public class Currency
    {

        public const String DOLLAR = "$";
    }

    /**
     * This code cannot be changed. It is provided by our billing service provider.
     */
    public class GoodOldBillingProvider
    {
        public virtual void SendInvoice(string invoiceContent)
        {
            throw new Exception("You are not supposed to call this code in the kata");
        }
    }
    
    /**
     * This code cannot be changed. It is provided by our billing service provider.
     */
    public class NewBillingProvider
    {
        /**
         * Send the invoice to the customer
         *
         * @param amount   The amount of the invoice
         * @param currency The currency of the invoice. Can be "$" or "€".
         * @param customer The customer name
         */ 
        public void SendInvoice(int amount, string currency, string companyName)
        {
            throw new Exception("You are not supposed to call this code in the kata");
        }
    }

}
