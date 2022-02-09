using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.demo5
{
     class demo
    {
        public static void Run()
        {
             A objA = new A();
            

             B objB = new B();
            

           
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("Instance constructor of A() called");
        }

        static A()
        {
            Console.WriteLine("Type constructor of A() called");
        }
    }


    class B : A
    {
        public B()
        {
            Console.WriteLine("Instance constructor of B() called");
        }

        static B()
        {
            Console.WriteLine("Type constructor of B() called");
        }
    }
}
