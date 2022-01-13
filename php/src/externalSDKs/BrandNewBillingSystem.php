<?php


namespace externalSDKs;
/**
 * This code cannot be changed. It is provided by our new billing service provider.
 */
class BrandNewBillingSystem
{

    /**
     * Send the invoice to the customer
     *
     * @param int $amount The amount of the invoice
     * @param string $currencySymbol The currency of the invoice. Can be "$" or "€".
     * @param string $customerName The customer name
     */
    public function invoice(int $amount, string $currencySymbol, string $customerName)
    {
        throw new Exception("You are not supposed to call this code in the kata");
    }

}