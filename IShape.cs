using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fig1;
using Fig2;


namespace Fig3
{
    public interface IShape
    {
        LineType LineType { get; set; }
        FillColor FillColor { get; set; }
        double CalculateArea();
    }

}
