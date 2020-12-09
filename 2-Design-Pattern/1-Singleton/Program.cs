using System;

namespace _1_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var instanceOne = Singleton.GetInstance();
            var InstanceTwo = Singleton.GetInstance();

            Console.WriteLine(instanceOne.GetHashCode());
            Console.WriteLine(InstanceTwo.GetHashCode());

            if(instanceOne.GetHashCode() == InstanceTwo.GetHashCode())
            System.Console.WriteLine("Bu iki obje eşittir..");

            Console.ReadKey();

        }
    }

     class Singleton
    {
        private static Singleton Instance;

        protected Singleton(){}

        public static Singleton GetInstance()
        {
            if(Instance == null)
                Instance = new Singleton();
            return Instance;
        }
    }
    
}


