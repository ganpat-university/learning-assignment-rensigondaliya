using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Demo25_parallel
{
    internal class Program
    {
        private static void display(int a)
        {
            Console.WriteLine("i= {0} on thread {1} ",a , Thread.CurrentThread.ManagedThreadId);
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("for loop");    
            Stopwatch stopwatch = new Stopwatch();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            stopwatch.Start();
            for (int i = 0; i < a.Length; i++)
            {
                display(a[i]);
            }
            stopwatch.Stop();
            Console.WriteLine("take time {0}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            Console.WriteLine();

            stopwatch.Start();
            foreach (int i in a)
            {
                display(i);
            }
            stopwatch.Stop();
            Console.WriteLine("take time {0}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);


            Console.WriteLine(" pareller for loop");

            stopwatch.Start();
            Parallel.For (0, a.Length, i =>
           {
               display(a[i]);
           }) ;
            stopwatch.Stop();
            Console.WriteLine("take time {0}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            Console.WriteLine();

            stopwatch.Start();
            Parallel.ForEach( a , i  =>
           {
               display(i);
           });
            stopwatch.Stop();
            Console.WriteLine("take time {0}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);


        }
    }
}
