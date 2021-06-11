using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Aync_and_Await_in_csharp
{
    class FindingNoofCharctersin_File
    {
        public static void Main()
        {
            var task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.WriteLine();
        }
        public static async void CallMethod()
        {
            string filePath = @"C:\Users\DjS\source\repos\Aync and Await in csharp\Aync and Await in csharp\abc.txt";
            Task<int> task = ReadFile(filePath);
            Console.WriteLine("Other work to do...");
            Console.WriteLine("Other work to do...");
            Console.WriteLine("Other work to do...");
            int length = await task;
            Console.WriteLine("Total No of Charcters in File is: " + length);


        }

        public static async Task<int> ReadFile(string filePath)
        {
            int len = 0;
            Console.WriteLine("File Reading is started.......");
            StreamReader sr = new StreamReader(filePath);
            string s = await sr.ReadToEndAsync();
            len = s.Length;
            Console.WriteLine("File Reading is Ended.......");
            return len;
        }
    }
}
