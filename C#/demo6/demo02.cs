using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo6
{
     class demo02
    {
        public void DoSomething(object o)
        {
            if (o is int)

            {
                int i = (int)o;
                Console.WriteLine("Received integer: {0}", i);
            }
            else if (o is bool)
            {
                bool b = (bool)o;
                Console.WriteLine("Received Boolean: {0}", b);
            }
        }
    }
}
