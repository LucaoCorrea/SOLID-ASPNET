using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public abstract class Shape
    {
        public abstract int CalculateArea();
    }

    public class RectangleSolution : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int CalculateArea()
        {
            return Height * Width;
        }
    }

    public class SquareSolution : Shape
    {
        public int Side { get; set; }

        public override int CalculateArea()
        {
            return Side * Side;
        }
    }
}
