﻿using System;
using System.Collections.Generic;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
           var ms = new MyStack<int>();
            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            foreach(var item in ms)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            while (ms.Count != 0)
            {
                Console.WriteLine(ms.Peek());
                ms.Pop();
            }

            Console.WriteLine(ms.Peek());

            ms.Pop();

            Console.WriteLine(ms.Peek());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            Console.WriteLine(ms.Peek());

            Console.ReadLine();
        }

        static void ProblemOfRepresentatives()
        {
            IShape rect = new Rect() { Height = 2, Width = 5 };
            IShape square = new Square() { SideLength = 10 };

            Console.WriteLine($"Rect area = {rect.CalcSquare()}");
            Console.WriteLine($"Square area = {square.CalcSquare()}");

            //Rect rect = new Rect { Height = 2, Width = 5 };
            //int rectArea = AreaCalculator.CalcSquare(rect);
            //Console.WriteLine($"Rect area = {rectArea}");

            //Rect square = new Square { Height = 2, Width = 10 };
            //AreaCalculator.CalcSquare(square);

            Console.ReadLine();
        }

        static void CollingInterface()
        {
            List<object> list = new List<object>() { 1, 2, 3 };
            IBaseCollection collection = new BaseList(4);
            collection.AddRange(list);
            collection.Add(1);
        }

        static void Inhritance2()
        {
            //Shape shape = new Shape();

            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
            }

            Console.ReadLine();
        }

        static void Inhritance()
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
