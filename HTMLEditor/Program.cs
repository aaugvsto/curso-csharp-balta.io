using System;

namespace EditorHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu.Show();
            }
            catch
            {
                Console.WriteLine("--- [ERROR] ---\nYou did something wrong.\nApplication has been closed.");
            }
        }
    }
}