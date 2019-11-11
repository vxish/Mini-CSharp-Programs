using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Circle : Shape
    {
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double getArea
        {
            get { return Math.PI * (Radius * 2); }
        }
    }
}
