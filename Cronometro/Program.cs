using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            try
            {
                Stopwatch();
            }
            catch
            {
                Console.WriteLine("--- [ERROR] ---\nYou did something wrong.\nApplication has been closed.");
            }
        }

        static void Stopwatch()
        {
            Console.Clear();
            Console.WriteLine("S = Secund => 10s = 10 secunds");
            Console.WriteLine("M = Minute => 1m = 1 minutes");
            Console.WriteLine("0 = Exit Application");

            Console.WriteLine("How long do you want to count?");

            string data = Console.ReadLine()!.ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Time ended.");
            Thread.Sleep(2500);
            Menu();
        }
    }
}