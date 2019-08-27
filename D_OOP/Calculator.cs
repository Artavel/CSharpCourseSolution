using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public static class Calculator
    {
        public static bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if(divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }

        public static double Average(params int[] numbers)
        {
            int sum = 0;
            
            foreach(int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }

        public static double CalcTriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double CalcTriangleSquare(double b, double h, int alpha, bool isInRadians = false)
        {
            if (isInRadians)
            {
                return 0.5 * b * h * Math.Sin(alpha);
            }
            else
            {
                double rads = alpha * Math.PI / 180;
                return 0.5 * b * h * Math.Sin(rads);
            }
        }
        //public static double CalcTriangleSquare(double b, double h, int alpha)
        //{
        //        double rads = alpha * Math.PI / 180;
        //        return 0.5 * b * h * Math.Sin(rads);
        //}
    }
}
