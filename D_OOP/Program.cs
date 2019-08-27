using System;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Caracter c = new Caracter();
            c.Hit(120);

            Console.WriteLine(c.Health);
        }
    }
}
