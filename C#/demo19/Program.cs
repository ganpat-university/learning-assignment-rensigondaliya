using System;





namespace demo19
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Calculator C = new Calculator();
            int result;

            result = C.add(6, 5);
            Console.WriteLine( " sum of 6 and 5 is :{0} ",result);
            Console.WriteLine();


            result = C.mul(3, 5);
            Console.WriteLine("  result is :{0} ", result);
            Console.WriteLine();

            result = C.Divide(10, 2);
            Console.WriteLine("Result is: {0}", result);
            Console.WriteLine();

            result = C.div(15, 5);
            Console.WriteLine(" result  is :{0} ", result);
            Console.WriteLine();

           

            int i = 1;
            i.Author();
            result.Author();

        }
    }
}
