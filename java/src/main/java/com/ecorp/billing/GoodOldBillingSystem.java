package com.ecorp.billing;

/**
 * This code cannot be changed. It is provided by our billing service provider.
 */
    public class GoodOldBillingSystem {

    /**
     * Send the invoice to the customer
     *
     * @param invoice The invoice as String, must be something like "200€ to customerName"
     */
    public void invoice(String invoice) {
        throw new RuntimeException("You are not supposed to call this code in the kata");
    }
}
