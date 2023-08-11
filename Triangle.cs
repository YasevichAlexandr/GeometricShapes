using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fig1;
using Fig2;
using Fig3;
using Fig4;

namespace Fig5
{
    public class Triangle : IShape
    {
        public LineType LineType { get; set; }
        public FillColor FillColor { get; set; }

        protected Point PointA
        {
            get;
            set;
        }
        protected Point PointB
        {
            get;
            set;
        }
        protected Point PointC
        {
            get;
            set;
        }
        public bool IsTriangle()
        {
            double sideAB = CalculateDistance(PointA, PointB);
            double sideBC = CalculateDistance(PointB, PointC);
            double sideCA = CalculateDistance(PointC, PointA);

            return sideAB + sideBC > sideCA && sideBC + sideCA > sideAB && sideCA + sideAB > sideBC;
        }

        private bool IsPythagorean(double side1, double side2, double hypotenuse)
        {
            return Math.Abs(Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(hypotenuse, 2)) < double.Epsilon;
        }
        public bool IsRightTriangle()
        {
            if (!IsTriangle())
            {
                return false;
            }
            double sideAB = CalculateDistance(PointA, PointB);
            double sideBC = CalculateDistance(PointB, PointC);
            double sideCA = CalculateDistance(PointC, PointA);

            return IsPythagorean(sideAB, sideBC, sideCA) || IsPythagorean(sideBC, sideCA, sideAB) || IsPythagorean(sideCA, sideAB, sideBC);
        }

        public bool IsEquilateralTriangle()
        {
            if (!IsTriangle())
            {
                return false;
            }

            double sideAB = CalculateDistance(PointA, PointB);
            double sideBC = CalculateDistance(PointB, PointC);
            double sideCA = CalculateDistance(PointC, PointA);


            //??? double.Epsilon ???
            //return (Math.Abs(sideAB - sideBC)) < double.Epsilon && (Math.Abs(sideBC - sideCA)) < double.Epsilon;
            return Math.Abs(sideAB - sideBC) < 0.0001 && Math.Abs(sideBC - sideCA) < 0.0001;
        }

        public bool IsIsoscelesTriangle()
        {
            if (!IsTriangle())
            {
                return false;
            }
            double sideAB = CalculateDistance(PointA, PointB);
            double sideBC = CalculateDistance(PointB, PointC);
            double sideCA = CalculateDistance(PointC, PointA);

            return (sideAB - sideBC) < double.Epsilon || (sideBC - sideCA) < double.Epsilon || (sideCA - sideAB) < double.Epsilon;
        }
        public virtual double CalculateArea()
        {
            return 0;
        }
        public double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }

}
