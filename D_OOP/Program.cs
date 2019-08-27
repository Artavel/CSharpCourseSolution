using System;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            //double square1 = calc.CalcTriangleSquare(10, 20);
            double square2 = calc.CalcTriangleSquare(15, 40, 20);

            Console.WriteLine($"Square2 = {square2}");
        }
    }
}
