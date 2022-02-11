using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo24_Thread
{
     class Demo2
    {

        private static void Do()
        {
            Console.WriteLine(" do this ;{0}", Thread.CurrentThread.ManagedThreadId);
        }
        public static void Run()
        {
            Console.WriteLine(" do this run ;{0}", Thread.CurrentThread.ManagedThreadId);
            Thread thread = new Thread(new ThreadStart(Demo2.Do));
            thread.Start();
            Do();
            Console.WriteLine(" do some this ;{0}", Thread.CurrentThread.ManagedThreadId);
            Thread thread2 = new Thread(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine(" this is a method of thread 2{0}", Thread.CurrentThread.ManagedThreadId);
                }); 
                 thread2.Start();
               
        }


    }
}
