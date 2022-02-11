using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo26
{
     class Demo1
    {

        private  static void DoSomething()
        {
            Console.WriteLine("Task laibrary");
        }
        public static void Run()
        {
            Thread t1 = new Thread(new ThreadStart(Demo1.DoSomething));
            t1.Start(); 

            ThreadStart t2 = new ThreadStart(() =>
            {
                Demo1.DoSomething();
            });
            t2.Invoke();
            

        }
    }
}
