using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesProject
{
    class Car : MotorVehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(String colour, Double engineSize, int numberOfDoors) : base(colour, engineSize)
        {
            Colour = colour;
            EngineSize = engineSize;
            NumberOfDoors = numberOfDoors;
        }

        public override String ToString()
        {
            return "The " + Colour + " car has " + NumberOfDoors + " doors and its engine size is " 
                + EngineSize + " liters";
        }
    }
}
