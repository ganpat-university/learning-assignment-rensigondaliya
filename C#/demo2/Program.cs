using System;

namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Type");
            int i = 5;
            bool b = false;
            string s = "Rensi is student";
            char c = 'A';

            int a = int.MaxValue;
            i = a + 1;

            long l = a;                

            l = long.MaxValue;
          
            a = (int)l;                

            Console.WriteLine("l (long) = {0}, a (int) = {1}", l, a);


        }
    }
}