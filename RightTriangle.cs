using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Fig1;
using Fig2;
using Fig4;
using Fig5;

namespace Fig8
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(Point pointA, Point pointB, Point pointC, LineType lineType, FillColor fillColor)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;

            if (!IsRightTriangle())
            {
                throw new ArgumentException("It's not a right triangle");
            }
        }

        public override double CalculateArea()
        {
            double sideAB = CalculateDistance(PointA, PointB);
            double sideBC = CalculateDistance(PointB, PointC);
            double sideCA = CalculateDistance(PointC, PointA);

            double area = 0.5 * sideAB * sideBC;
            return area;
        }
    }
}
