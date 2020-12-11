namespace _3_FactoryMethod.models
{
    abstract class CreditCard
    {
        public string Type { get; set; }
        public int Limit { get; set; }
        public int AnnualCharge { get; set; }

    }
}