using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo18
{
     class Employee
    {
        public int EmployeeId { get; set; } 
        public string EmployeeName { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1}", this.EmployeeId, this.EmployeeName);
        }
    }
}
