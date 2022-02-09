using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11

   {
    interface IVehicle
    {
        void Drive();
    }

    class Driver3
    {
        public void Drive(IVehicle V)
        {
            Console.WriteLine(" DRIVER IS DRIVING NOW");
            V.Drive();
        }
    }
}

