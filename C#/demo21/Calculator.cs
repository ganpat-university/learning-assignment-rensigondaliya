using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo21
{
    delegate int ComputeHandler(int a, int b);

    class Calculator
    {
        public int Add(params int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                result += i;
            }
            return result;
        }

        public int Compute(int a, int b, ComputeHandler c)
        {
            int result = -1;
             result = c(a, b);
              return result;
        }

    }

}

