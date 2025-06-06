using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Rectangle)
            {
                var rectangle = (Rectangle)shape;
                return rectangle.Height * rectangle.Width;
            }
            else if (shape is Circle)
            {
                var circle = (Circle)shape;
                return Math.PI * Math.Pow(circle.Radius, 2);
            }

            throw new ArgumentException("Unknown shape");
        }
    }

    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }
}
