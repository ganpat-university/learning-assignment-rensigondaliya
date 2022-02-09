using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
     class Class1
    {
        private string _name;
        private int _age;

        public string Name
        {

            get {
                return _name; 
            }
            set { 
                _name = value; 
            }
        }
        public int Age
        {
            get { return _age; }
            set {
                if (value >= 18 && value <= 65)
                    _age = value;
                else
                    Console.WriteLine("this age is not valid");
            
            }

        }
    }

}
