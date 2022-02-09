using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15
{
    class Employee
        : System.IComparable
    {
        public int employeeid { get; set; }
        public string employeename { get; set; }
        public decimal Salary { get; set; }


        #region System.IComparable interface members 

        public int CompareTo(object obj)
        {
            Employee other = obj as Employee;
            return this.employeename.CompareTo(other.employeename);
        }

        #endregion
    }
}
