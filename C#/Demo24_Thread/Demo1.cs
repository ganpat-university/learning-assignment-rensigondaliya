using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo24_Thread
{
    class Demo1
    {
        private static void Do()
        {
            Console.WriteLine(" do this ;{0}", Thread.CurrentThread.ManagedThreadId);
        }
        public static void Run()
        {
            Console.WriteLine(" do this ;{0}", Thread.CurrentThread.ManagedThreadId);
            Do ();
            Console.WriteLine(" do some this ;{0}", Thread.CurrentThread.ManagedThreadId);

        }
    }
}
