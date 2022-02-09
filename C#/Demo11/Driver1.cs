using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11
{
     class Driver1
    {
        public void Drive(Car objCar)
        {
            Console.WriteLine("Driver  driving a car");
            objCar.DriveCar();
        }

        public void Drive(Bike s)
        {
            Console.WriteLine("Driver  now driving a Bike");
            s.DriveBike();
        }
    }
}
