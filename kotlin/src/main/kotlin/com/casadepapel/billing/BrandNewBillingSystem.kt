package com.casadepapel.billing

/**
 * This code cannot be changed. It is provided by our billing service provider.
 */
class BrandNewBillingSystem {

    /**
     * Send the invoice to the customer
     *
     * @param amount   The amount of the invoice
     * @param currency The currency of the invoice. Can be "$" or "€".
     * @param customer The customer name
     */
    fun invoice(amount: Int, currency: String, customer: String) {
        throw RuntimeException("You are not supposed to call this code in the kata")
    }
}
