package org.training.billing;

import com.ecorp.billing.GoodOldBillingSystem;

public class BillingService {
    private GoodOldBillingSystem billingSystem;

    public BillingService(GoodOldBillingSystem billingSystem) {
        this.billingSystem = billingSystem;
    }

    public void invoice(Invoice invoice) {
        int amount = invoice.amount;
        Currency currency = invoice.currency;
        String companyName = invoice.companyName;
        String invoiceForBillingSystem = String.format("%d%s to %s", amount, currency.symbol, companyName);
        billingSystem.invoice(invoiceForBillingSystem);
    }
}
