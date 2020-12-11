namespace _3_FactoryMethod.models
{
    class CardA : CreditCard
    {
        public CardA(int creditLimit, int annualCharge)
        {
            this.Type = "Credi Cart A";
            this.Limit = creditLimit;
            this.AnnualCharge = annualCharge;
        }
    }
}