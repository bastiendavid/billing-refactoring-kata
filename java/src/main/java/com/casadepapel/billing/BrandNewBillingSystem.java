package com.casadepapel.billing;

/**
 * This code cannot be changed. It is provided by our billing service provider.
 */
public class BrandNewBillingSystem {

    /**
     * Send the invoice to the customer
     *
     * @param amount   The amount of the invoice
     * @param currency The currency of the invoice. Can be "$" or "€".
     * @param customer The customer name
     */
    public void invoice(int amount, String currency, String customer) {
        throw new RuntimeException("You are not supposed to call this code in the kata");
    }
}
