using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Console1
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.Title = "";
            Console.BackgroundColor = System.ConsoleColor.White;
            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = true;
            Console.CursorSize = 20;
            Console.Clear();


            Hora workerObject = new Hora();
            Thread workerThread = new Thread(workerObject.MostrarHora);
            workerThread.Start();




            
            Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            int n = 1;
            Console.SetCursorPosition(1, n); Console.Write(">>");
            
            String key = null;
            int Sel = 1;
            while (key != "Escape")
            {

                Console.SetCursorPosition(2, 24); key = Convert.ToString(Console.ReadKey().Key);
                Console.ReadKey();
                //Console.Clear();
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.SetCursorPosition(0, 24);
                Console.WriteLine("{0:##:##:##,###}\r\n", DateTime.Now.TimeOfDay);
                Console.Write("> " + key);
                for (int i = 0; i < 25; i++)
                {
                    Console.ForegroundColor = System.ConsoleColor.DarkGray;
                    Console.SetCursorPosition(15, i); Console.Write("│");
                }
            }
        }
    }
    class Hora
    {
        // This method will be called when the thread is started.
        public void MostrarHora()
        {
            while (true)
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.ForegroundColor = System.ConsoleColor.DarkGray;
                    Console.SetCursorPosition(15, i); Console.Write("│");
                }

                Console.SetCursorPosition(74, 0);
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write(DateTime.Now.ToString("hh:mm:ss"));
                Thread.Sleep(1000);
                
            }

        }

    }

}
