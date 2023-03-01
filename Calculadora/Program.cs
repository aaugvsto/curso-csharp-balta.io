using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\n--- [ERROR] ---\nWrongly entered data, Calculator has been closed.\n");
                System.Environment.Exit(0);
            }
        }

        static void Calculator()
        {
            Console.Clear();
            Console.WriteLine("--- CALCULATOR ---\n");
            Console.WriteLine("Type one of the options below:\n 1 - Sum\n 2 - Subtraction\n 3 - Division\n 4 - Exit Application");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                Sum();
                break;

                case 2:
                Subtraction();
                break;

                case 3:
                Division();
                break;

                case 4:
                System.Environment.Exit(0);
                break;

                default:
                Calculator();
                break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("-- Sum --\n");
            Console.WriteLine("First Value: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Secund Value: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double result = v1 + v2;
            Console.WriteLine($"The sum of values is {result}");
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("-- Subtraction --\n");
            Console.WriteLine("First Value: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Secund Value: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double result = v1 - v2;
            Console.WriteLine($"The subtraction of values is {result}");
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("-- Division --\n");
            Console.WriteLine("First Value: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Secund Value: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double result = v1 / v2;
            Console.WriteLine($"The division of values is {result}");
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("-- Multiplication --\n");
            Console.WriteLine("First Value: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Secund Value: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double result = v1 * v2;
            Console.WriteLine($"The multiplication of values is {result}");
        }
    }
}