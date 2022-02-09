using System;

namespace demo1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("hello world");
            System.Console.WriteLine("Hello world");
            Console.WriteLine("it is another world");

            Console.Write("Your name: ");
            string name = Console.ReadLine();

            Console.Write("Your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("{0}. You are  {1} year : ", name, age);
        }
    }
}