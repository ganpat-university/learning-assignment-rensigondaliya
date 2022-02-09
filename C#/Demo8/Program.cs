using System;

namespace Demo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constractor");

            Demo3.Demo.Run();
            Console.WriteLine();

            demo4.Demo p1 = new demo4.Demo("First Name");
            demo4.Demo p2 = new demo4.Demo("Second Name");

            Console.WriteLine("{0} {1}", p1.ID, p1.Name);
            Console.WriteLine();

           // Demo5.emo.Run();

        }
    }
}
