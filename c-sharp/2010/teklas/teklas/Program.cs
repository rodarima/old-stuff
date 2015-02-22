using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace teklas
{
    class Program
    {
        static string tit = "";
        static bool exit = false;
        static void Main(string[] args)
        {
            inicio();
            string insert="";
            
            while (exit == false)
            {
                Func(readcom());
            }
        }
        static void inicio()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Teklas";
            Console.Clear();
            Console.SetBufferSize(80, 25);
            //Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.CursorSize = 100;

Console.WriteLine("\n    d8b                   888      888               888    ");
Console.WriteLine("    Y8P                   888      888               888    ");
Console.WriteLine("                          888      888               888    ");
Console.WriteLine("   8888  8888b.   .d8888b 888  888 88888b.   .d88b.  888888 ");
Console.WriteLine("   '888     '88b d88P'    888 .88P 888 '88b d88''88b 888    ");
Console.WriteLine("    888 .d888888 888      888888K  888  888 888  888 888    ");
Console.WriteLine("    888 888  888 Y88b.    888 '88b 888 d88P Y88..88P Y88b.  ");
Console.WriteLine("    888 'Y888888  'Y8888P 888  888 88888P'   'Y88P'   'Y888 ");
Console.WriteLine("    888                                                     ");
Console.WriteLine("   d88P                                                     ");
Console.WriteLine(" 888P'");



        }
        static void Write(string text, ConsoleColor font)
        {
            ConsoleColor b1=Console.ForegroundColor;
            Console.ForegroundColor = font;
            Console.Write(text);
            Console.ForegroundColor = b1;
        }
        static string readcom(){
            tit = Environment.CurrentDirectory.ToString();
            if (tit.Length > 10)
            {
                tit = "."+ tit.Substring(tit.Length - 10, 10);
            }
            Write(tit , ConsoleColor.Gray);
            Write(" > ",ConsoleColor.DarkGreen);
            string insert = Console.ReadLine();
            return insert;
        }
        static void list(string lug)
        {
            Console.WriteLine("Ficheros en "+lug);
            if (lug.Substring(lug.Length - 1, 1) != @"\")
            {
                lug += @"\";
            }
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@lug);

            foreach (System.IO.FileInfo file in dir.GetFiles("*.*"))
            {
                Console.WriteLine("{0}   {1}", file.Name, file.Length);
            }
        }
        static void Func(string com)
        {
            if (com == "quit" || com == "q" || com == "bye" || com == "exit" || com == "salir")
            {
                exit = true;
                return;
            }

            if (com == "ls")
            {
                list(Environment.CurrentDirectory.ToString());
                return;
            }
            Write("[ - ] ", ConsoleColor.Red);
            Write("Comando "+com+" no encontrado \n", ConsoleColor.DarkRed);
        }
    }
}
