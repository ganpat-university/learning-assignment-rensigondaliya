using System;

namespace demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Overriding");

            demo D = new demo();
            D.DoSomthing();
            Console.WriteLine();

            anotherDemo A = new anotherDemo();
            A.DoSomthing();
            Console.WriteLine();


            // Object of the Base Type, with behaviours coming from the Derived Type
            demo D2 = new anotherDemo();
            D2.DoSomthing();
        }
    }
}