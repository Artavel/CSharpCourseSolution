using System;
using System.IO;

namespace E_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = null;
            try
            {
                file = File.Open("temp.txt", FileMode.Open);
            }

            catch(IOException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                file?.Dispose();
            }

            Console.ReadLine();

            Console.WriteLine("Please input a number");

            string result = Console.ReadLine();

            int number = 0;

            try
            {
                number = int.Parse(result);
            }

            //Only for FormatException
            catch (FormatException ex)
            {
                Console.WriteLine("A format exception has occured.");
                Console.WriteLine("Information is below:");
                Console.WriteLine(ex.ToString());
            }

            //For all Exceptions
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(number);
        }
    }
}
