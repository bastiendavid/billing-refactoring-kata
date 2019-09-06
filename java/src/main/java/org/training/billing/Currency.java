package org.training.billing;

public enum Currency {
    EURO("€"),
    DOLLAR("$");

    public String symbol;

    Currency(String symbol) {
        this.symbol = symbol;
    }
}
