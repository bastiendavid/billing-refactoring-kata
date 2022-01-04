<?php


use PHPUnit\Framework\TestCase;

class BillingServiceTest extends TestCase
{
    /** @test */
    public function Name()
    {

        $oldBillingSystem = $this->createMock(OldBillingSystem::class);
        $billingService = new BillingService($oldBillingSystem);

        $oldBillingSystem->expects($this->once())
            ->method('invoice')
            ->with($this->equalTo("100$ to destination company"));

        $billingService->invoice(new Invoice(100, Currency::dollar(), "destination company"));


    }


}
