using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Fig1;
using Fig2;
using Fig4;
using Fig5;

namespace Fig9
{
    public class ArbitraryTriangle : Triangle
    {
        public ArbitraryTriangle(Point pointA, Point pointB, Point pointC, LineType lineType, FillColor fillColor)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;

        }
        public override double CalculateArea()
        {
            double sideAB = CalculateDistance(PointA, PointB);
            double sideBC = CalculateDistance(PointB, PointC);
            double sideCA = CalculateDistance(PointC, PointA);

            double semiperimeter = (sideAB + sideBC + sideCA) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideAB) * (semiperimeter - sideBC) * (semiperimeter - sideCA));

            return area;
        }
    }
}
