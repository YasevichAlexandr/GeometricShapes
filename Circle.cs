using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fig1;
using Fig2;
using Fig3;
using Fig4;

namespace Fig11
{
    public class Circle : IShape
    {
        public LineType LineType { get; set; }
        public FillColor FillColor { get; set; }

        public Point Center { get; set; }
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
