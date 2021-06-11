using System;
using System.Threading.Tasks;

namespace Aync_and_Await_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CallMethod();
            Console.ReadLine();
        }


        public static async Task CallMethod()
        {
            Method2();
            var count = await Method1();
            Method3(count);
        }
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method1:" + i);
                    count++;
                }
                Task.Delay(100).Wait();
            });
            return count;
        }
        public static async Task Method2()
        { 
                for (int i = 0; i < 25; i++)
                    Console.WriteLine("Method2:" + i);
                Task.Delay(100).Wait();
            
        }

        public static void  Method3(int count)
        {
            Console.WriteLine("Total COunt is ="+count);
        }
    }
}
