using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace TOP
{
    class Program
    {
        static PerformanceCounter theCounter;
        static void Main(string[] args)
        {
            theCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            //________________________________________________________________________________
            
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimer);
            aTimer.Interval = 500;
            aTimer.Enabled = true;
            aTimer.AutoReset = false;
            Console.ReadLine();
        }
        static int CpuLoad()
        {
            int load = 0;
            load = Convert.ToInt32(theCounter.NextValue());
            return load;
        }
        static void DrawProgressBar(int x, int y, int Percent)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("▓");
            }
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Percent / 10; i++)
            {
                Console.Write("█");
            }
        }
        private static void OnTimer(Object source, ElapsedEventArgs e)
        {
            System.Timers.Timer theTimer = (System.Timers.Timer)source;
            theTimer.Enabled = false;
            Console.SetCursorPosition(0, 0);
            Console.Clear();

            int cpu = CpuLoad();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(cpu.ToString("00")+"% CPU");
            DrawProgressBar(7, 0, cpu);



            theTimer.Enabled = true;



        }
    }
}
