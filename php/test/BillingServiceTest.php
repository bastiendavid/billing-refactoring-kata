<?php


use PHPUnit\Framework\TestCase;

class BillingServiceTest extends TestCase
{
    /** @test */
    public function Name()
    {

        $oldBillingSystem = $this->createMock(OldBillingSystem::class);
        $billingService = new BillingService();
        $billingService->invoice(new Invoice(100, "dollar", "destination compnay"));


        $this->assertEquals(1, 2);

    }


}
