namespace lib
{
    public class Invoice
    {
        public int Amount { get; }
        public Currency Currency { get; }
        public string CompanyName { get; }

        public Invoice(int amount, Currency currency, string companyName)
        {
            Amount = amount;
            Currency = currency;
            CompanyName = companyName;
        }
    }
}