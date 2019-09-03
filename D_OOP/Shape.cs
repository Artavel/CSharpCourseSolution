using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Created");
        }

        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimeter();
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double ac;
        private readonly double bc;

        public Triangle(double ab, double ac, double bc)
        {
            this.ab = ab;
            this.ac = ac;
            this.bc = bc;

            Console.WriteLine("Triangle Created.");
        }

        public override double Area()
        {
            double s = (ab + ac + bc) / 2;
            return Math.Sqrt(s * (s - ab) * (s - ac) * (s - bc));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle...");
        }

        public override double Perimeter()
        {
            return ab + ac + bc;
        }
    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle Created.");
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
}
