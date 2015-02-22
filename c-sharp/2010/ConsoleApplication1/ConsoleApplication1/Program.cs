using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            Console.BackgroundColor = System.ConsoleColor.Gray;
            Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(13, 13); Console.Write("Introducir numero: ");
                string num = Console.ReadLine();
                Console.SetCursorPosition(13, 14); Console.Write(Convert.ToInt32(num) * 2);

                Console.ReadKey();
            }
        }
    }
}
