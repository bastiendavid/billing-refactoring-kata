package org.training.billing

import com.ecorp.billing.GoodOldBillingSystem

class BillingService(private val billingSystem: GoodOldBillingSystem) {

    fun invoice(invoice: Invoice) {
        val invoiceForBillingSystem =
            String.format("%d%s to %s", invoice.amount, invoice.currency.symbol, invoice.companyName)
        billingSystem.invoice(invoiceForBillingSystem)
    }
}
