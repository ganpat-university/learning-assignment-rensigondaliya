using System;

namespace Demo20_AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee()
            {
                employeeID = 1,
                employeeName = "employee 1"
            };
            E.employeeName = E.employeeName.ToUpper();
            Console.WriteLine("{0} {1}",E.employeeID, E.employeeName);

            int i;
            var j = 10;
            

            var emp2 = new { ID = 8, Name = " name" };
            Console.WriteLine("{0} {1}", emp2.ID, emp2.Name);


            var arr = new[]
            {
                new { ID = 1, Name = " employee1"},
                new { ID = 2, Name = " employee2"},
                new { ID = 3, Name = " employee3" }
            };
            foreach (var item in arr)
            {
                Console.WriteLine("{0} {1}", item.ID, item.Name);
            }
        }
    }

    class Employee
    {
        public int employeeID { get; set; }

        public string employeeName { get; set; }
    }
}
