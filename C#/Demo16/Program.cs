// See https://aka.ms/new-console-template for more information
using System;

namespace Demo16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo02();
        }

        static void Demo02()
        {
            Calculator cal = new Calculator();

            int result;
            result = cal.Add(6, 8);
            Console.WriteLine("Sum of 6 and 8 is  = {0}", result);

            result = cal.Compute(6, 8, Program.Multiply);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();

            Console.WriteLine();
            result = Program.Multiply(7, 2);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();

           
        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Demo01()
        {
            Car C= new Car();
            Bike B = new Bike();
            Driver D = new Driver();

            D.Drive(C.DriveCar);
            D.Drive(B.DriveBike);
        }
    }
}
