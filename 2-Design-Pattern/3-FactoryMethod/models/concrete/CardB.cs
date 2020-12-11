namespace _3_FactoryMethod.models
{
    class CardB : CreditCard
    {
        public CardB(int creditLimit, int annualCharge)
        {
            this.Type = "Credi Cart b";
            this.Limit = creditLimit;
            this.AnnualCharge = annualCharge;
        }

    }
}