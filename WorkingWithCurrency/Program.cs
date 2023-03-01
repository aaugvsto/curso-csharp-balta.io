using System;
using System.Globalization;

namespace Currency
{
    class Program 
    {
        static void Main(String[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));

            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pr-BR")));

        }
    }
}