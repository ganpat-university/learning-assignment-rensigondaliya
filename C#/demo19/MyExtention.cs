using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo19
{
    static class MyExtention
    {
        public static int mul(this Calculator C  , int a , int b)
        {
            return a* b;
        }
        public static int Divide(this Calculator C, int a, int b)
        {
            return a / b;
        }

        public static void Author(this object o)
        {
            Console.WriteLine("Rensi Gondaliya");
        }
    }
}
