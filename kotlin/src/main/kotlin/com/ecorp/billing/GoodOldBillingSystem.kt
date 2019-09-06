package com.ecorp.billing

/**
 * This code cannot be changed. It is provided by our billing service provider.
 */
class GoodOldBillingSystem {

    /**
     * Send the invoice to the customer
     *
     * @param invoice The invoice as String, must be something like "200€ to customerName"
     */
    fun invoice(invoice: String) {
        throw RuntimeException("You are not supposed to call this code in the kata")
    }
}
