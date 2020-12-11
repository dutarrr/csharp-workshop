namespace _3_FactoryMethod.models
{
    class CardAFactory : CardFactory
    {
        public int CreditLimit { get; set; }
        public int AnnualCharge { get; set; }

        public CardAFactory(int creditLimit, int annualCharge)
        {
            CreditLimit = creditLimit;
            AnnualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new CardA(CreditLimit, AnnualCharge);
        }
    }
}