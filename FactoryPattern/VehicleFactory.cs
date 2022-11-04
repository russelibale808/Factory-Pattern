using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string carType)
        {
            switch (carType.ToLower())
            {
                case "car":
                    return new Car();
                case "motorcycle":
                    return new Motorcycle();
                    default:
                    return new Car();
            }
        }
    }
}
