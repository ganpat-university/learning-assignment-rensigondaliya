using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
     class Company
    {
        public string CompanyName { get; private set; }

     
        private System.Collections.ArrayList theEmployees { get; set; }
        private int counter;



        public Employee this[int id]
        {
            get
            {
                Employee emp = null;

                foreach (Employee emp1 in this.theEmployees)
                {
                    if (emp.EmployeeID == id)
                    {
                        emp = emp1;
                        break;
                    }
                }

                return emp;
            }
        }

        public Employee this[string name]
        {
            get
            {
                Employee emp = null;

                foreach (Employee emp1 in this.theEmployees)
                {
                    if (emp.EmployeeName == name)
                    {
                        emp = emp1;
                        break;
                    }
                }

                return emp;
            }
        }

        public Company(string name)
        {
            this.CompanyName = name;

            this.theEmployees = null;                 
            this.counter = 0;
        }

        public void AddEmployee(string name)
        {
            Employee empNew = new Employee();
            empNew.EmployeeID = ++this.counter;
            empNew.EmployeeName = name;

            if (this.theEmployees == null)              
                this.theEmployees = new System.Collections.ArrayList();
            }

           
          
        }

      
}
