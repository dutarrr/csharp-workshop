using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                // for (int i = 0; i < 100; i++)
                // {
                //     Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "---- Method 1");
                //     Task.Delay(100).Wait();
                // }

                Task.Delay(4000).Wait();
            });
            Console.WriteLine("***************1*******************");
        }
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "----- Method 2");
                //Task.Delay(100).Wait();
            }
        }
    }
}
