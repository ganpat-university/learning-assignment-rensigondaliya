using System;

namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Interface");

            Console.WriteLine("  methods Overloaded");
            Demo01();
            Console.WriteLine();

            Console.WriteLine("Boxing and Unboxing");
            Demo02();
            Console.WriteLine();

            Console.WriteLine(" using Interface");
            Demo03();
            Console.WriteLine();
        }

        static void Demo01()
        {
            Car C = new Car();
            Bike B = new Bike();
            Driver1 D = new Driver1();

            D.Drive(C);
            D.Drive(B);

        }

        static void Demo02()
        {
            Car C = new Car();
            Bike B = new Bike();
            driver2 D = new driver2();

            D.Drive(C);
            D.Drive(B);

        }


        static void Demo03()
        {
            Car C = new Car();
            Bike B = new Bike();
            Driver3 D = new Driver3();

            D.Drive(C);
            D.Drive(B);

        }

    }
}