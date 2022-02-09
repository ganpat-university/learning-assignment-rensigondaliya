using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.demo1
{
     class Demo
    {
        static public void Run()
        {
            Employee e = new Employee("First Employee Name");
            Console.WriteLine("{0}", e.Name);
        }
    }

    class Employee
    {
        public Employee(string name)
        {
            _name = name;
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
