using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int CalculateArea()
        {
            return Height * Width;
        }
    }

    public class Square : Rectangle
    {
        public override int Height
        {
            set { base.Height = base.Width = value; }
        }

        public override int Width
        {
            set { base.Height = base.Width = value; }
        }
    }
}
