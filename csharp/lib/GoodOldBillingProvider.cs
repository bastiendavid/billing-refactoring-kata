using System;

namespace lib
{
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
}