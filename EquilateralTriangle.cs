using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fig1;
using Fig2;
using Fig4;
using Fig5;

namespace Fig6
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(Point pointA, Point pointB, Point pointC, LineType lineType, FillColor fillColor)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;

            if (!IsEquilateralTriangle())
            {
                throw new ArgumentException("It's not an equilateral triangle");
            }
        }

        public override double CalculateArea()
        {
            double sideAB = CalculateDistance(PointA, PointB);

            double area = (Math.Sqrt(3) / 4) * Math.Pow(sideAB, 2);
            return area;
        }

    }
}
