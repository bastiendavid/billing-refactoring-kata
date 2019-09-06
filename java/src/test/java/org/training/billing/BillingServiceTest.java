package org.training.billing;

import com.ecorp.billing.GoodOldBillingSystem;
import org.junit.jupiter.api.Test;

import static org.mockito.Mockito.mock;
import static org.mockito.Mockito.verify;

public class BillingServiceTest {

    @Test
    void send_invoice_to_billing_system() {
        // Given
        GoodOldBillingSystem billingSystem = mock(GoodOldBillingSystem.class);
        BillingService billingService = new BillingService(billingSystem);

        // When
        billingService.invoice(new Invoice(100, Currency.DOLLAR, "Vance Refrigeration"));

        // Then
        verify(billingSystem).invoice("100$ to Vance Refrigeration");
    }
}
