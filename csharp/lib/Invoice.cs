namespace lib
{
    public class Invoice
    {
        public int Amount { get; }
        public string Currency { get; }
        public string CompanyName { get; }

        public Invoice(int amount, string currency, string companyName)
        {
            Amount = amount;
            Currency = currency;
            CompanyName = companyName;
        }
    }
}