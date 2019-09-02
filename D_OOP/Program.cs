using System;
using System.Collections.Generic;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelXTerminal terminal = new ModelXTerminal("123");
            terminal.Connect();

            Console.ReadLine();
        }

        static void Boxing_Unboxing()
        {
            int x = 1;
            object obj = x; //boxing

            int y = (int)obj; //unboxing

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)(double)obj1;
        }

        static void Do(object obj)
        {
            //variant 1
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                //exception or smth else
            }

            //variant 2
            PointRef pr1 = obj as PointRef;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {
                //exception or smth else
            }
        }

        static void NRE_NullReferenceException()
        {
            PointVal? pv = null;
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }
            else
            {
                //
            }

            PointVal pv3 = pv.GetValueOrDefault();

            PointRef c = null;
            Console.WriteLine(c.X); //NullReferenceException
        }

        static void PassByRefDemo()
        {
            int a = 1;
            int b = 2;

            Swap(ref a, ref b);

            Console.WriteLine($"a={a}, b={b}");

            Console.ReadLine();

            var list = new List<int>();
            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a={a}, b={b}");
        }

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
    }
}
