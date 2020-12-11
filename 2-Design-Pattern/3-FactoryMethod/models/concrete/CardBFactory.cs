namespace _3_FactoryMethod.models
{
    class CardBFactory : CardFactory
    {
        public int CreditLimit { get; set; }
        public int AnnualCharge { get; set; }

        public CardBFactory(int creditLimit, int annualCharge)
        {
            CreditLimit = creditLimit;
            AnnualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new CardB(CreditLimit, AnnualCharge);
        }
    }
}