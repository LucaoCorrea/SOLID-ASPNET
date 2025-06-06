using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class RectangleSolution : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }

    public class CircleSolution : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class AreaCalculatorSolution
    {
        public double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}
