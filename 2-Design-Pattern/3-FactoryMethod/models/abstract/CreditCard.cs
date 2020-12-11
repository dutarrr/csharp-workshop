namespace _3_FactoryMethod.models
{
    abstract class CreditCard
    {
        public string Type { get; set; }
        public string Limit { get; set; }
        public string AnnualCharge { get; set; }

    }
}