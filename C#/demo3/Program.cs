
using System;

namespace demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Perametors");
            int i;
            i = 3;
            Console.WriteLine("i = {0}", i);
            DemoOfPassByValue(i);
            Console.WriteLine("i now = {0}", i);
           
            i = 3;
            Console.WriteLine("i = {0}", i);
            DemoOfPassByReference(ref i);
            Console.WriteLine("i now = {0}", i);

            i = 3;
            Console.WriteLine("i = {0}", i);
            DemoOfPassByOut(out i);
            Console.WriteLine("i now = {0}", i);

            DemoOfVariableNumberOfParameters();
            DemoOfVariableNumberOfParameters(5, 28);
            DemoOfVariableNumberOfParameters(6);
            DemoOfVariableNumberOfParameters(6, 8, 10, 24, 54);
        }

        static void DemoOfPassByValue(int a)
        {
            Console.WriteLine(" Received a = {0}", a);
            a = 68;
            Console.WriteLine("after value  change, a = {0}", a);
        }

        static void DemoOfPassByReference(ref int a)
        {
            Console.WriteLine(" Received a = {0}", a);
            a = 30;
            Console.WriteLine("after change value , a = {0}", a);
        }

        static void DemoOfPassByOut(out int a)
        {
            
            a = 54;
            Console.WriteLine("-- after change, a = {0}", a);
        }

      
        static void DemoOfVariableNumberOfParameters(params int[] arr)
        {

        }

    }
}