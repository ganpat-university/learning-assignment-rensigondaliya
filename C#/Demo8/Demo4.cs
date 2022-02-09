using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.demo4
{
     class Demo
    {
        public readonly int ID;
        public readonly string Name;

        static private int counter;

        static Demo()
        {
            Demo.counter = 0;
        }

        public Demo(string name)
        {
            this.ID = ++Demo.counter;
            this.Name = name;
        }
    }
}
