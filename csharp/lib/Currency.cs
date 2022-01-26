using System;

namespace lib
{
    public class Currency
    {
        public string Symbol { get; }

        private Currency(string symbol)
        {
            Symbol = symbol;
            throw new NotImplementedException();
        }
        
        public static Currency Dollar()
        {
            return new Currency("$");
        }
    }
}