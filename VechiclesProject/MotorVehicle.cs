using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesProject
{
    class MotorVehicle : Vehicle
    {
        public Double EngineSize { get; set; }

        public MotorVehicle(String colour, Double engineSize) : base(colour)
        {
            Colour = colour;
            EngineSize = engineSize;
        }
    }
}
