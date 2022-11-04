using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 0: return new Shoes();
                case 1: return new Unicycle();
                case 2: return new Motorcycle();
                case 3: return new Roadster();
                case 4: return new Car();
                case 5: return new Pentacycle();
                default: return new Shoes();
            }
           
        }
    }
}
