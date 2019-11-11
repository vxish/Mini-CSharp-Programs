using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Triangle : Shape
    {
        private double Bottom;
        private double Height;

        public Triangle(double bottom, double height)
        {
            Bottom = bottom;
            Height = height;
        }

        public override double getArea
        {
            get { return (Bottom * Height) / 2; }
        }
    }
}
