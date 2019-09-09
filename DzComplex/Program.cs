﻿using System;

namespace DzComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 1);
            Complex c2 = new Complex(1, 2);

            Complex result = c1.Plus(c2);
            Console.WriteLine($"Result. Real={result.Real}; Imaginary={result.Imaginary}");
        }
    }
}
