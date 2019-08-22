using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void LoginPassDz8()
        {
            string login = "Alex";
            string password = "a13131313";

            int counter = 3;
            if (counter >= 1)
            {
                do
                {
                    Console.WriteLine("Enter login and password");
                    login = Console.ReadLine();
                    password = Console.ReadLine();
                    Console.WriteLine($"login {login}");
                    Console.WriteLine($"password {password}");

                    if (login == "Alex" && password == "a13131313")
                    {
                        Console.WriteLine("Enter the System");
                        return;
                    }

                    Console.WriteLine("Your login or password is incorrect");
                    counter--;

                }
                while (counter >= 1);
            }

            if (counter == 0)
            {
                Console.WriteLine("The number of available tries have been exceeded");
                return;
            }
        }

        static void FactorialDz7()
        {
            Console.WriteLine("Enter factorial");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i =1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

            //int proizved = new int();

            //int x = 1;

            //if (n == 0 || n == 1)
            //{
            //    proizved = 1;
            //}

            //int counter = n--;

            //if (n > 0)
            //{
            //    do
            //    {
            //        proizved = x * n * counter;
            //        n--;
            //        counter = 1;
            //        x = proizved;
            //    }
            //    while (n > 1);

            //}

            //Console.WriteLine(proizved);

            Console.ReadLine();
        }

        static void SredneeDz6()
        {
            Console.WriteLine("Enter 10 numbers % 3 or press 0 to stop");
            int[] numbers = new int[10];

            int counter = 0;
            while (counter < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[counter] = number;

                counter++;

                if (number == 0)
                    break;
            }

            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }

            double average = (double)sum / count;
            Console.WriteLine(average);
        }

        static void FibonacciDz5()
        {
            Console.WriteLine("How many numbers of Fibonacci you want to see?");
            int n = int.Parse(Console.ReadLine());

            int[] fib = new int[n];

            int a0 = 0;
            int a1 = 1;

            fib[0] = a0;
            fib[1] = a1;

            for (int i = 2; i < n; i++)
            {
                int a = a0 + a1;
                fib[i] = a;

                a0 = a1;
                a1 = a;
            }

            foreach (int cur in fib)
            {
                Console.Write($" {cur}");
            }
            Console.ReadLine();
        }

        static void SwitchCase()
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);

            Console.ReadLine();

            int weddingYears = int.Parse(Console.ReadLine());
            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    break;
                    name = "Деревянная свадьба";
                case 10:
                    break;
                    name = "Оловянная свадьба";
                case 15:
                    break;
                    name = "Хрустальная свадьба";
                case 20:
                    break;
                    name = "Фарфоровая свадьба";
                case 25:
                    name = "Серебрянная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;

                default:
                    name = "Не знаем такого юбилея!";
                    break;
            }
            Console.WriteLine(name);
        }

        static void BreakContinue()
        {
            int[] numbers = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };

            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                    continue;
                Console.WriteLine(n);
            }

            Console.ReadLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number={numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write($" {letters[j]}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            int[] numbers2 = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter == 3)
                    break;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }
            }
        }

        static void WhileDoWhile()
        {
            int age = 30;

            //if age > 18 while is not working
            while (age < 18)
            {
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);
            Console.WriteLine("Good!");

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }

            Console.WriteLine("Good!");
        }

        static void PairTriplets()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];


                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }
                }
            }
        }

        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.Write(numbers[j] + " ");
                }
            }

            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }
        }

        static void IfElse()
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height:");
            double height = double.Parse(Console.ReadLine());

            double imt = weight / (height * height);

            bool isTooLow = imt <= 18.5;
            bool isNormal = imt > 18.5 && imt < 25;
            bool isAboveNormal = imt >= 25 && imt <= 30;
            bool isTooFat = imt > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight!");
            }
            else
            {
                Console.WriteLine("Oh, you're in a good shape!");
            }

            //if(isFat == false)
            if (!isFat)
            {
                Console.WriteLine("You're definitely not fat!");
            }

            if (isTooLow)
            {
                Console.WriteLine("Not enough weight.");
            }
            else if (isNormal)
            {
                Console.WriteLine("You're OK!");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful!!!");
            }
            else
            {
                Console.WriteLine("You're need to some weight.");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Anyway it's time to get on diet");
            }

            //ternary operation
            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";

            Console.WriteLine(description);
        }
    }
}
