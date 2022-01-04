<?php

class Invoice
{
    public $amount;
    public $currency;
    public string $customer;

    public function __construct(int $amount, \Currency $currency, string $customer)
    {
        $this->amount = $amount;
        $this->currency = $currency;
        $this->customer = $customer;
    }
}