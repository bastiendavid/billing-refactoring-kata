package org.training.billing

import com.ecorp.billing.GoodOldBillingSystem
import io.mockk.mockk
import io.mockk.verify
import org.junit.jupiter.api.Test

class BillingServiceTest {

    @Test
    internal fun send_invoice_to_billing_system() {
        // Given
        val billingSystem = mockk<GoodOldBillingSystem>(relaxed = true)
        val billingService = BillingService(billingSystem)

        // When
        billingService.invoice(Invoice(100, Currency.DOLLAR, "Vance Refrigeration"))

        // Then
        verify { billingSystem.invoice("100$ to Vance Refrigeration") }
    }
}
