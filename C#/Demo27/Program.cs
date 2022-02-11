using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = Program.ProcessJob(10);
            Console.WriteLine(result);
            Task<bool> retVal = processjobasy(100);
            retVal.Wait();
            result = retVal.Result;
            Console.WriteLine(result);

        }

        private static async Task<bool> processjobasy(int a)
        {
            return await Task.Run(() => ProcessJob(a));

        }
        private static bool ProcessJob(int a)
        {
            Thread.Sleep(5000);
            Console.WriteLine("process job a = {0} thread {1}",a,Thread.CurrentThread.ManagedThreadId);
            return true;
        }
    }
}
