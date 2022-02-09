using System;

namespace Demo21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator C = new Calculator();
            int result;

            result = C.Add(3);
            result = C.Add(3,4,5,6,7);

  
            result = C.Compute(20, 80, Program.Multiply);             

            ComputeHandler c1 = new ComputeHandler(Program.Multiply);     
            result = C.Compute(20, 80, c1);

            ComputeHandler c2 = delegate (int a, int b)
            {
                return a * b;
            };
            result = C.Compute(20, 80, c2);

            ComputeHandler c3
                = (int a, int b) =>                   
                {
                    return a * b;
                };
            result = C.Compute(20, 80, c3);

            ComputeHandler c4
                = (a, b) =>                    
                {
                    return a * b;
                };
            result = C.Compute(20, 80, c4);

        

        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}