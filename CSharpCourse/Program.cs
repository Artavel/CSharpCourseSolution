using System;
using System.Text;
using System.Threading;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void DZ4()
        {
            Console.WriteLine("Enter first integer:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            int b = int.Parse(Console.ReadLine());

            //int max = a > b ? a : b;
            //Console.WriteLine(max);

            bool maxA = a > b;
            bool maxB = a < b;
            
            if (maxA)
            {
                Console.WriteLine($"Max number is: {a}");
            }
            else if (maxB)
            {
                Console.WriteLine($"Max number is: {b}");
            }
            else
            {
                Console.WriteLine("Numbers are equals");
            }
        }

        static void DZ3()
        {
            Console.WriteLine("Enter your full name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height:");
            double height = double.Parse(Console.ReadLine());

            double imt = weight / (height * height);

            string profile = 
                $"{Environment.NewLine}Your profile:{Environment.NewLine}"
               +$"Full name: {name}{Environment.NewLine}"
               +$"Age: {age}{Environment.NewLine}"
               +$"Weight: {weight}{Environment.NewLine}"
               +$"Height: {height}{Environment.NewLine}"
               +$"Body Mass Index: {imt}{Environment.NewLine}";
            Console.WriteLine(profile);
        }
        static void DZ2()
        {
            Console.WriteLine("Enter first integer of triangle:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer of triangle:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer of triangle:");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(Math.Round(s, 2));
        }

        static void DZ1()
        {
            //1
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            Console.WriteLine($"Your name: {name}");
            
            //2
            Console.WriteLine("Enter first integer:");
            string int1 = Console.ReadLine();
            
            Console.WriteLine("Enter second integer:");
            string int2 = Console.ReadLine();

            Console.WriteLine($"{int1}, {int2}");
            Console.WriteLine($"{int2}, {int1}");
            
            //3
            Console.WriteLine("Enter an integer:");
            string intX = Console.ReadLine();
            Console.WriteLine(intX.Length);
        }

        static void IntroDateTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDt = dt.AddDays(1);
            Console.WriteLine(newDt);

            TimeSpan ts = now - dt;
            //ts = now.Subtract(dt);
            Console.WriteLine(ts.Days);
        }

        static void IntroToArray()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 2, 4, 3, 5 };

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 6;
            Console.WriteLine(a4[4]);

            string s1 = "kjlsdhgf";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine($"First:{first}. Last:{last}");
        }

        static void CastingAndParsing()
        {
            byte b = 3; //0000 0011
            int i = b; //0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; //0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011
            float f = i; //3.0

            b = (byte)i;

            string str = "1";
            //i = (int)str;
            i = int.Parse(str);
            Console.WriteLine($"Parsed i={i}");
        }

        static void ConsoleBasics()
        {
            Console.WriteLine("Hi ,please tell me your name");

            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Hi, please tell me your age.");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            string sentence2 = $"your age is {age}";
            Console.WriteLine(sentence2);

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("New style \n");
            Console.Write("New style \n");
        }

        static void ComparingString()
        {
            string str1 = "abc";
            string str2 = "abc";
            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);
            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
        }

        static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = $"My name is {name} and I'm {age}"; //знак $ = string.Format()
            //string str2 = "My name is " + name + " and I'm " + age;

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            string str3 = "My name is \nJohn"; //"\n" работает только под windows
            str3 = $"My name is {Environment.NewLine}John"; //Работает под любой системой вместо "\n"
            Console.WriteLine(str3);

            string str4 = "I'm \t30"; //\t = TAB
            Console.WriteLine(str4);

            //string str5 = "I'm John and I'm a "good" programmer"; = error
            string str5 = "I'm John and I'm a \"good\" programmer";
            Console.WriteLine(str5);

            //string str6 = "C:\\tmp\\test_file.txt";
            string str6 = @"C:\tmp\test_file.txt"; //verbatim strings = @ 
            Console.WriteLine(str6);

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            string result3 = string.Format("{0:f}", answer);
            string result4 = string.Format("{0:f4}", answer);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money);
            result = $"{money:C2}";
            Console.WriteLine(result);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(money.ToString("C2")); //знак $ вместо рублей
        }

        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }

        static void StringModification()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            nameConcat = "My " + "name " + "is " + "John";
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(nameConcat);

            string data = "12;28;34;25;64";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);

            string third = splitData[2];
            Console.WriteLine(third);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());
        }

        static void StringEmptiness()
        {
            string str = string.Empty; //same as " "

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpace);
        }

        static void QuerryingStrings()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length);

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 3);

            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFromTo);
        }

        static void StaticAndInstanceMembers()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);
        }

        static void ComparisonOperators()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            bool result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);
        }

        static void MathOperations()
        {
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = z * 2;
            int c = k / 2;
            Console.WriteLine(b);
            Console.WriteLine(c);

            a = 4 % 2; // остаток от деления
            b = 5 % 2; // остаток от деления
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a;
            //a = a * a * a;
            Console.WriteLine(a);

            a = 2 + 2 * 2;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 2;
            Console.WriteLine(a);
        }

        static void IncrementDecrementDemo()
        {
            int x = 1;
            x = x + 1;

            Console.WriteLine(x);

            // increments
            x++; // postfix
            Console.WriteLine(x);

            ++x; // infix
            Console.WriteLine(x);

            x = x - 1;
            // decrements
            x--; // postfix
            Console.WriteLine(x);

            --x; // infix
            Console.WriteLine(x);

            Console.WriteLine("Learn about increments");
            Console.WriteLine($"Last x state is {x}");

            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2; // x = x + 2
            Console.WriteLine(x);

            j -= 2; // j = j - 2
            Console.WriteLine(j);
        }

        static void Overflow()
        {
            checked // overflow exception
            {
                uint x = uint.MaxValue;

                Console.WriteLine(x);

                x = x + 1;

                Console.WriteLine(x);

                x = x - 1;

                Console.WriteLine(x);
            }
        }

        static void Literals()
        {
            // binar
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b1001_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            // 16
            x = 0x1F;
            y = 0xFF0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine(4.5e2); // = 4.5*10^2
            Console.WriteLine(3.1E-1); // = 3.1*10^-1

            Console.WriteLine();

            Console.WriteLine('\x78'); //  = x
            Console.WriteLine('\x5A'); // = Z
            Console.WriteLine('\u0420'); // = P
            Console.WriteLine('\u0421'); // = C
        }

        static void VariablesScope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c);
            }
            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
        }
    }
}
