using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo26
{
    class Demo2
    {
        public static void Run()
        {
            Task t1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("running thread1{0}",
                    Thread.CurrentThread.ManagedThreadId);
            });
            Task t2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("running thread2{0}",
                    Thread.CurrentThread.ManagedThreadId);
            });
            Task t3 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("running thread3{0}",
                    Thread.CurrentThread.ManagedThreadId);
            });

              Task.WaitAll(t1, t2, t3);
               Console.WriteLine("finish");

            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("this is thread aegyu {0}",
                      Thread.CurrentThread.ManagedThreadId);
            })
                  .ContinueWith((t) =>{ 

                Console.WriteLine("this is thread aegyu {0}",
                       Thread.CurrentThread.ManagedThreadId);
            })
                  .ContinueWith((t) => { 
                     Console.WriteLine("this is thread aegyu {0}",
                      Thread.CurrentThread.ManagedThreadId);

            });

        }
    }
}
