using System;
using _4_AbstractFactory.models;

namespace _4_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Her product için ayrı ayrı Factory class'ları oluşturulur. Bu classlar Client (creator) sınıflardan 
            çağrılarak kullanılır.            
            */
            var nokiaFactory = new NokiaFactory();
            var nokiaClient = new MobileClient(nokiaFactory);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            var samsungFactory = new SamsungFactory();
            var samsungClient = new MobileClient(samsungFactory);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

            Console.ReadKey();
        }
    }
}
