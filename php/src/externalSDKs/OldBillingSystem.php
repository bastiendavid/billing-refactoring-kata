<?php


namespace externalSDKs;
/**
 * This code cannot be changed. It is provided by our billing service provider.
 */
class OldBillingSystem
{

    /**
     * Send the invoice to the customer
     *
     * @param string invoice The invoice as String, must be something like "200€ to customerName"
     */
    public function invoice(string $invoiceData)
    {
        throw new Exception("You are not supposed to call this code in the kata");
    }

}