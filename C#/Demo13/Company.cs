using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13
{
    class Company
         : System.Collections.IEnumerator
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


        private int _currentPosition;

        public object Current
        {
            get
            {
                return this.theEmployees[_currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (_currentPosition < this.theEmployees.Count - 1)
            {
                _currentPosition++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _currentPosition = -1;
        }



        public void AddEmployee(string name)
        {
            Employee E = new Employee();
            E.Empid = ++this.counter;
            E.Empname = name;

            if (this.theEmployees == null)
            {
                this.theEmployees = new System.Collections.ArrayList();
            }
            this.theEmployees.Add(E);
        }


        public void DisplayEmployees()
        {
            Console.WriteLine(" THIS IS EMPLOYEE {0}", this.CompanyName);
            foreach (Employee E in this.theEmployees)
            {
                Console.WriteLine("{0} {1}", E.Empid, E.Empname);
            }
        }
    }
}
