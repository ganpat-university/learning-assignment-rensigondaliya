using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.Demo3
{
    class Demo
    {
        public static void Run()
        {
            MyDerivedClass obj = new MyDerivedClass(10);
        }
    }

    class MyBaseClass
    {
        public MyBaseClass(int id)
        {
            Console.WriteLine("Base class Parameterized constructor called");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass(int id) : base(id)
        {
            Console.WriteLine("Parameterized constructor of the derived class called");
        }
    }
}
