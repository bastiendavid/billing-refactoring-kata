<?php


class Currency
{
    public string $symbol;

    public function __construct(string $symbol)
    {
        $this->symbol = $symbol;
    }

    public static function dollar()
    {
        return new Currency("$");
    }
}