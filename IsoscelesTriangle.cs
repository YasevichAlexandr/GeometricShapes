using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fig1;
using Fig2;
using Fig4;
using Fig5;


namespace Fig7
{
    public class IsoscelesTriangle : Triangle
    {

        public IsoscelesTriangle(Point pointA, Point pointB, Point pointC, LineType lineType, FillColor fillColor)
        {

            PointA = pointA;
            PointB = pointB;
            PointC = pointC;

            if (!IsIsoscelesTriangle())
            {
                throw new ArgumentException("It's not an isosceles triangle");
            }
        }

        public override double CalculateArea()
        {
            double sideAB = CalculateDistance(PointA, PointB);
            double sideCA = CalculateDistance(PointC, PointA);

            double height = Math.Sqrt(Math.Pow(sideCA, 2) - Math.Pow(sideAB / 2, 2));
            double area = 0.5 * sideAB * height;
            return area;
        }
    }

}
