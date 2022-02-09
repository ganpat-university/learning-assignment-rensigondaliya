using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14
{
    class Company
        : System.Collections.IEnumerable
    {
        private System.Collections.ArrayList theEmployees;
        private int counter;

        public string CompanyName { get; private set; }

        public Company(string companyName)
        {
            this.CompanyName = companyName;

            this.theEmployees = null;
            this.counter = 0;
        }

        public void AddEmployee(string name)
        {
            Employee E = new Employee();
            E.Employeeid = ++this.counter;
            E.Employeename = name;

            if (this.theEmployees == null)
            {
                this.theEmployees = new System.Collections.ArrayList();
            }
            this.theEmployees.Add(E);
        }


        public System.Collections.IEnumerator GetEnumerator()
        {
            if (this.theEmployees != null)
            {
                foreach (Employee E in this.theEmployees)
                {
                    yield return E;
                }
            }
            else
            {
                yield break;
            }
        }
        public void DisplayEmployees()
        {
            Console.WriteLine("Emp IS {0}", this.CompanyName);
            foreach (Employee emp in this.theEmployees)
            {
                Console.WriteLine("{0} {1}", emp.Employeeid, emp.Employeename);
            }
        }
    }
}
