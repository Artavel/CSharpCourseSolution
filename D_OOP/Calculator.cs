using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {
        public double CalcTriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double CalcTriangleSquare(double b, double h, int alpha)
        {
            double rads = alpha * Math.PI / 180;
            return 0.5 * b * h * Math.Sin(rads);
        }
    }
}
