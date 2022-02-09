using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11
{
     class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("car is drive by driver");
        }

        public void DriveCar()
        {
            Console.WriteLine("car is drive by driver");
        }
    }
}
