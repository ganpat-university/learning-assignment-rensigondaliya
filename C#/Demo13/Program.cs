using System;

namespace Demo13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company C = new Company("eInfochips");
            C.AddEmployee("Rensi");
            C.AddEmployee("Aditya");

            C.DisplayEmployees();

            Console.WriteLine();
            Console.WriteLine("Employee list");

            C.Reset();
            while (C.MoveNext())
            {
                Employee emp = C.Current as Employee;
                Console.WriteLine("{0} {1}", emp.Empid, emp.Empname);
            }

        }
    }
}