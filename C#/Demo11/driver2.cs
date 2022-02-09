using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11
{
    class driver2
    {
        public void Drive(object objVehicle)                // boxing
        {
            Console.WriteLine("Driver is driving a vehicle");
            if (objVehicle is Car)                           // type checking
            {
                Car objCar = objVehicle as Car;             // unboxing type casting
                objCar.DriveCar();
            }
            else if (objVehicle is Bike)
            {
                Bike B = objVehicle as Bike;
                B.DriveBike();
            }
        }
    }
}
