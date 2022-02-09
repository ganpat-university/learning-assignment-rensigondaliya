using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11
{
      class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is been drive by driver");
        }

        public void DriveBike()
        {
            Console.WriteLine("Bike is now drive by driver");
        }
    }
}
