<?php


use externalSDKs\OldBillingSystem;

class BillingService
{
    private $oldBillingSystem;

    /**
     * @param $oldBillingSystem
     */
    public function __construct(OldBillingSystem $oldBillingSystem)
    {
        $this->oldBillingSystem = $oldBillingSystem;
    }

    public function invoice(Invoice $invoice)
    {

        // Imagine loads of existing code here
        // ...

        $invoiceForBillingSystem = sprintf("%d%s to %s", $invoice->amount, $invoice->currency->symbol, $invoice->customer);
        $this->oldBillingSystem->invoice($invoiceForBillingSystem);

        // ...
        // Imagine loads of existing code here


    }
}