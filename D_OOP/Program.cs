using System;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double avg = calc.Average(1, 2, 3, 4);

            Console.WriteLine(avg);
        }
    }
}
