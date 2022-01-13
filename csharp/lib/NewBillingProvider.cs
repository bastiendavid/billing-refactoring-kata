using System;

namespace lib
{
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
        public virtual void SendInvoice(int amount, string currency, string companyName)
        {
            throw new Exception("You are not supposed to call this code in the kata");
        }
    }
}