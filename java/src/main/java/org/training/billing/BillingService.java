package org.training.billing;

import com.ecorp.billing.GoodOldBillingSystem;

public class BillingService {
    private GoodOldBillingSystem billingSystem;

    public BillingService(GoodOldBillingSystem billingSystem) {
        this.billingSystem = billingSystem;
    }

    public void invoice(Invoice invoice) {
        String invoiceForBillingSystem = String.format("%d%s to %s", invoice.amount, invoice.currency.symbol, invoice.companyName);
        billingSystem.invoice(invoiceForBillingSystem);
    }
}
