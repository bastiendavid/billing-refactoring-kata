package org.training.billing;

public class Invoice {
    final int amount;
    final Currency currency;
    final String companyName;

    public Invoice(int amount, Currency currency, String companyName) {
        this.amount = amount;
        this.currency = currency;
        this.companyName = companyName;
    }
}
