// See https://aka.ms/new-console-template for more information
using System;

namespace Demo14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("einfochips");
            company.AddEmployee("Rensi");
            company.AddEmployee("Aditya");

            company.DisplayEmployees();

            Console.WriteLine();
            Console.WriteLine("Employee Implimentation");
            foreach (Employee E in company)
            {
                Console.WriteLine("{0} {1}", E.Employeeid, E.Employeename);
            }

        }
    }
}
