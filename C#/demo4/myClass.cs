using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    class myClass
    {
        public int id;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("name can not be empty fill it....");
                }
                else
                {
                    _name = value;
                }
            }
        }

    }
}
