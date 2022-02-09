using System;

namespace Demo15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];

            employees[0] = new Employee();
            employees[0].employeeid = 1;
            employees[0].employeename = "employee 1";
            employees[0].Salary = 167900M;

            // Object Initializer
           employees[1] = new Employee()
            {
               employeeid = 2,
               employeename = "employee 2",
                Salary = 10546M
            };

            employees[2] = new Employee()
            {
                employeeid = 3,
                employeename = "Third Employee",
                Salary = 57890M
            };

            employees[3] = new Employee()
            {
                employeeid = 4,
                employeename = "Fourth Employee",
                Salary = 59000M
            };

            


            Console.WriteLine("Employees list:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine("{0} {1,-20} {2,15}", emp.employeeid, emp.employeename, emp.Salary);
            }
            Console.WriteLine();

            Array.Sort(employees);

            Console.WriteLine("  Employees After sorting list:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine("{0} {1,-20} {2,15}", emp.employeeid, emp.employeename, emp.Salary);
            }
            Console.WriteLine();

        }
    }
}
