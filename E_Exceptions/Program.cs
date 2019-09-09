using System;

namespace E_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");

            string result = Console.ReadLine();

            int number = 0;

            try
            {
                number = int.Parse(result);
            }

            //Only for FormatException
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("A format exception has occured.");
            //    Console.WriteLine("Information is below:");
            //    Console.WriteLine(ex.ToString());
            //}

            //For all Exceptions
            catch (Exception ex)
            {
                Console.WriteLine("A format exception has occured.");
                Console.WriteLine("Information is below:");
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(result);
        }
    }
}
