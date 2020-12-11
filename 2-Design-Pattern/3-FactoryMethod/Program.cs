using System;
using _3_FactoryMethod.models;

namespace _3_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            CreditCard card = null;

            factory = new CardAFactory(10, 2);
            card = factory.GetCreditCard();
            Console.WriteLine($"Type: {card.Type} Limit: {card.Limit} AnnualCharge: {card.AnnualCharge}");

            Console.WriteLine("----------------------------------------");

            factory = new CardBFactory(25, 5);
            card = factory.GetCreditCard();
            System.Console.WriteLine($"Type: {card.Type} Limit: {card.Limit} AnnualCharge: {card.AnnualCharge}");

            Console.ReadKey();
        }
    }
}
