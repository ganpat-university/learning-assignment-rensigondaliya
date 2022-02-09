using System;

namespace demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("Method Overloading");

            
            demo01 d = new demo01();
            d.DoSomething(3);
            d.DoSomething("Rensi");
            d.DoSomething(true);



            int i = 10;
            bool b = false;

            object o = i;          
            int j = (int)o;         


            demo02 d2 = new demo02();
            d2.DoSomething(5);           
            d2.DoSomething(true);
        }
    }
}