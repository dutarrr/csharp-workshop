using System;
using _3_FactoryMethod.models;

namespace _3_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Birden fazla product için tek bir tane Factory class'ı ile 
            nesne oluşturma işlemi yapılır. Her farklı product için faklı Factory classlar olusturulursa
            Abstract Factory olur
            */
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
