using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;
using System.Management;
using System.Timers;
using System.Globalization;
using System.Management.Instrumentation;

namespace Nuke
{
    class Program
    {
 
         
        static void Main(string[] args)
        {
            Iniciar();
            Cabecera();
            Console.ReadLine();
        }
        static void Iniciar()
        {

            Console.BackgroundColor = System.ConsoleColor.White;
            Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            Console.Title = "Nuke ®";
            Console.Clear();
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.CursorSize = 20;
            NukeLogo(ConsoleColor.Gray);

        }
        static void NukeLogo(System.ConsoleColor FColor)
        {
            Console.SetCursorPosition(0,6);
            int DisY = 21;
            int DisX = 60;
            Console.ForegroundColor = FColor;
            Console.SetCursorPosition(DisX, DisY);
            Console.WriteLine(@"■  ■ ■  ■ ■  ■ ■■■"); Console.SetCursorPosition(DisX, DisY + 1);
            Console.WriteLine(@"■■ ■ ■  ■ ■■■  ■■"); Console.SetCursorPosition(DisX, DisY + 2);
            Console.WriteLine(@"■ ■■ ■■■■ ■  ■ ■■■");
        }
        static PerformanceCounter theCounter;
        static PerformanceCounterCategory performanceCounterCategory;
        static PerformanceCounter performanceCounterSent;
        static PerformanceCounter performanceCounterReceived;
        static PerformanceCounter ramCounter;
        static System.Net.Sockets.Socket Cohete;
        public static void Cabecera()
        {
            theCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            performanceCounterSent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", performanceCounterCategory.GetInstanceNames()[0]);
            performanceCounterReceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", performanceCounterCategory.GetInstanceNames()[0]);
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            System.Timers.Timer aTimer = new System.Timers.Timer();
            Console.Clear();
            int DisY = 21;
            int DisX = 60;
            Console.ForegroundColor = System.ConsoleColor.DarkGray;
            Console.SetCursorPosition(DisX, DisY);
            Console.WriteLine(@"■  ■ ■  ■ ■  ■ ■■■"); Console.SetCursorPosition(DisX, DisY + 1);
            Console.WriteLine(@"■■ ■ ■  ■ ■■■  ■■"); Console.SetCursorPosition(DisX, DisY + 2);
            Console.WriteLine(@"■ ■■ ■■■■ ■  ■ ■■■");
            
            aTimer.Elapsed += new ElapsedEventHandler(OnTimer);
            aTimer.Interval = 100;
            aTimer.Enabled = true;
            aTimer.AutoReset = false;
            //Menu();
        }
        static void Menu()
        {
            int Sel = 1;
            String key = null;
            Seleccionar(ConsoleColor.Gray, ConsoleColor.DarkGreen, Sel);

            while (key!="Enter"){
                key = Convert.ToString(Console.ReadKey().Key);
                if (key == "UpArrow"){ Sel--; }
                if (key == "DownArrow"){ Sel++;}
                if (Sel < 1) Sel = 1;
                if (Sel > 3) Sel = 3;
                //Console.Clear();
                Seleccionar(ConsoleColor.Gray, ConsoleColor.DarkGreen, Sel);
            }

            if (Sel == 1)
            {
                Console.Clear();
                Console.Write("ww");
                while(true){
                key = Convert.ToString(Console.ReadKey().Key);
                if (key == "Escape")
                {
                    Console.Clear();
                    Menu();
                }
            }
            if (key == "Escape")
            {
                return;
            }

            }
        }
        static void Seleccionar(System.ConsoleColor CoFondo, System.ConsoleColor CoLetra, int Sel)
        {

            if(Sel ==1)
            {
                Console.SetCursorPosition(2, 2);
                Console.BackgroundColor = CoFondo;
                Console.ForegroundColor = CoLetra;
                Console.Write("Información del Sistema.");
                Console.SetCursorPosition(2, 3);
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write("Estado de la Red.");
                Console.SetCursorPosition(2, 4);
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write("Conversores.");
            }
            if (Sel == 2)
            {
                Console.SetCursorPosition(2, 2);
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write("Información del Sistema.");
                Console.SetCursorPosition(2, 3);
                Console.BackgroundColor = CoFondo;
                Console.ForegroundColor = CoLetra;
                Console.Write("Estado de la Red.");
                Console.SetCursorPosition(2, 4);
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write("Conversores.");
            } if (Sel == 3)
            {
                Console.SetCursorPosition(2, 2);
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write("Información del Sistema.");
                Console.SetCursorPosition(2, 3);
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write("Estado de la Red.");
                Console.SetCursorPosition(2, 4);
                Console.BackgroundColor = CoFondo;
                Console.ForegroundColor = CoLetra;
                Console.Write("Conversores.");
            }
            

        }
        static void EstadoRed(int x,int y)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "a";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
                PingReply reply = pingSender.Send("209.85.229.99", timeout, buffer, options);
                if (reply.Status == IPStatus.Success) {
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = System.ConsoleColor.White;
                    Console.ForegroundColor = System.ConsoleColor.DarkGray;
                    Console.Write("Red");
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    Console.Write("■");
                    //Console.Write("Red " + reply.RoundtripTime.ToString() + "  ");
                }
                else
                {
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = System.ConsoleColor.White;
                    Console.ForegroundColor = System.ConsoleColor.DarkGray;
                    Console.Write("Red");
                    Console.ForegroundColor = System.ConsoleColor.Gray;
                    Console.Write("■");
                }
           
          
        
        }
        static void Separador(int x, int y, System.ConsoleColor Color) {
            Console.BackgroundColor = System.ConsoleColor.White;
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(x, y); Console.Write("│");
        }
        static void Hora(int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = System.ConsoleColor.White;
            Console.ForegroundColor = System.ConsoleColor.DarkGray;
            Console.Write(DateTime.Now.ToString("hh:mm:ss"));
            Console.SetCursorPosition(x, y+1);
            Console.Write(DateTime.Now.ToString("dd/MM/yy"));
        }
        static void CpuLoad(int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x+3, y);
                double CpuLoad = theCounter.NextValue();
                //Console.Write("CPU" + Perc + "%   ");
                
                if (CpuLoad == 0)
                {
                    Console.BackgroundColor = System.ConsoleColor.White;
                    Console.ForegroundColor = System.ConsoleColor.Gray;
                    Console.SetCursorPosition(x+3, y);
                    Console.Write("■");
                }
                if (CpuLoad < 33 && CpuLoad > 1)
                {
                    Console.BackgroundColor = System.ConsoleColor.White;
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    Console.SetCursorPosition(x + 3, y);
                    Console.Write("■");
                }
                if (CpuLoad > 33 && CpuLoad < 66)
                {
                    Console.BackgroundColor = System.ConsoleColor.White;
                    Console.ForegroundColor = System.ConsoleColor.Yellow;
                    Console.SetCursorPosition(x+3, y);
                    Console.Write("■");
                } if (CpuLoad > 66)
                {
                    Console.BackgroundColor = System.ConsoleColor.White;
                    Console.ForegroundColor = System.ConsoleColor.Red;
                    Console.SetCursorPosition(x+3, y);
                    Console.Write("■");
                } Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.DarkGray;
                Console.SetCursorPosition(x, y);
                Console.Write("Cpu");
            }
            catch { }
        }
        private static void OnTimer(Object source, ElapsedEventArgs e)
        {
            System.Timers.Timer theTimer = (System.Timers.Timer)source;
            theTimer.Enabled = false;
            DibujarCabecera();
            theTimer.Enabled = true;
            

            
        }
        static void UsoRed(int x, int y)
        {
            double DesVal = performanceCounterReceived.NextValue() / 1024;
            double SubVal = performanceCounterSent.NextValue() / 1024;

            //Console.Write("CPU" + Perc + "%   ");

            if (DesVal == 0)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Gray;
                Console.SetCursorPosition(x + 1, y);
                Console.Write("■");
            }
            if (DesVal > 1 && DesVal < 10)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Green;
                Console.SetCursorPosition(x + 1, y);
                Console.Write("■");
            }
            if (DesVal > 10 && DesVal < 100)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Yellow;
                Console.SetCursorPosition(x + 1, y);
                Console.Write("■");
            } if (DesVal > 100)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.SetCursorPosition(x + 1, y);
                Console.Write("■");
            }

            if (SubVal == 0)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Gray;
                Console.SetCursorPosition(x + 3, y);
                Console.Write("■");
            }
            if (SubVal > 1 && SubVal < 10)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Green;
                Console.SetCursorPosition(x + 3, y);
                Console.Write("■");
            }
            if (SubVal > 10 && SubVal < 100)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Yellow;
                Console.SetCursorPosition(x + 3, y);
                Console.Write("■");
            } if (SubVal > 100)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.SetCursorPosition(x + 3, y);
                Console.Write("■");
            } 
            Console.BackgroundColor = System.ConsoleColor.White;
            Console.ForegroundColor = System.ConsoleColor.DarkGray;
            Console.SetCursorPosition(x, y);
            Console.Write("D");
            Console.SetCursorPosition(x+2, y);
            Console.Write("S");
        }
        static void UsoMem(int x, int y)
        {
            double MemLoad = ramCounter.NextValue();
            if (MemLoad > 500)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Green;
                Console.SetCursorPosition(x + 3, y);
                Console.Write("■");
            }
            if (MemLoad > 250 && MemLoad < 500)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Yellow;
                Console.SetCursorPosition(x + 3, y);
                Console.Write("■");
            } if (MemLoad < 250)
            {
                Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.SetCursorPosition(x + 3, y);
                Console.Write("■");
            }
            Console.BackgroundColor = System.ConsoleColor.White;
                Console.ForegroundColor = System.ConsoleColor.DarkGray;
                Console.SetCursorPosition(x, y);
                Console.Write("Mem");

        }
        static int TimerNuke;
        static void TimerNukeLogo()
        {
            TimerNuke++;
            if (TimerNuke == 100) { NukeLogo(ConsoleColor.DarkGray); }
            if (TimerNuke == 200) { NukeLogo(ConsoleColor.DarkYellow); }
            if (TimerNuke == 300) { NukeLogo(ConsoleColor.DarkGreen); }
            if (TimerNuke == 400) { NukeLogo(ConsoleColor.DarkCyan); }
            if (TimerNuke == 500) { NukeLogo(ConsoleColor.DarkBlue); }
            if (TimerNuke == 600) { NukeLogo(ConsoleColor.Black); }
            if (TimerNuke == 700) { NukeLogo(ConsoleColor.DarkMagenta); }
            if (TimerNuke == 800) { NukeLogo(ConsoleColor.DarkRed); TimerNuke = 199;}
        }
        public static void DibujarCabecera()
        {
            TimerNukeLogo();
            Hora(72, 0);
            Separador(71, 0, System.ConsoleColor.DarkGray);
            Separador(71, 1, System.ConsoleColor.DarkGray);
            EstadoRed(67, 0);
            Separador(66, 0, System.ConsoleColor.DarkGray);
            Separador(66, 1, System.ConsoleColor.DarkGray);
            CpuLoad(62, 0);
            Separador(61, 0, System.ConsoleColor.DarkGray);
            Separador(61, 1, System.ConsoleColor.DarkGray);
            UsoRed(67,1);
            UsoMem(62, 1);

            


        }
        
    }
}
