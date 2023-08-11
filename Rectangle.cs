using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fig1;
using Fig2;
using Fig3;
using Fig4;

namespace Fig10
{
    public class Rectangle : IShape
    {
        public LineType LineType { get; set; }
        public FillColor FillColor { get; set; }

        public Point TopLeft { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
