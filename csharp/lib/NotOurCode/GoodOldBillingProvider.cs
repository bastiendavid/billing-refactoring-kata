using System;

namespace lib.NotOurCode
{
    /**
     * This code cannot be changed. It is provided by our billing service provider.
     */
    public class GoodOldBillingProvider
    {
        /**
         * Send the invoice to the customer
         *
         * @param invoice The invoice as String, must be something like "200€ to customerName"
         */
        public virtual void SendInvoice(string invoiceContent)
        {
            throw new Exception("You are not supposed to call this code in the kata");
        }
    }
}