<?php


use externalSDKs\OldBillingSystem;

class BillingService
{
    private $oldBillingSystem;

    public function __construct(OldBillingSystem $oldBillingSystem)
    {
        $this->oldBillingSystem = $oldBillingSystem;
    }

    public function invoice(Invoice $invoice)
    {

        // Imagine loads of existing code here
        // ...

        $amount = $invoice->amount;
        $symbol = $invoice->currency->symbol;
        $customer = $invoice->customer;
        $invoiceForBillingSystem = sprintf("%d%s to %s", $amount, $symbol, $customer);
        $this->oldBillingSystem->invoice($invoiceForBillingSystem);

        // ...
        // Imagine loads of existing code here


    }
}