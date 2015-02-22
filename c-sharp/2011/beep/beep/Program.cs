using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Media;

namespace beep
{
    class Program
    {  
        static ReproductorMp3.Reproductor Sonido = new ReproductorMp3.Reproductor();
        [DllImport("Kernel32.dll")]
            public static extern bool Beep(UInt32 frequency, UInt32 duration);

        /// <summary>
        /// Emite un pitido
        /// </summary>
        /// <param name="t">Tono</param>
        /// <param name="d">Duración</param>
        /// <param name="s">Tiempo en ms entre tonos</param>
        /// <param name="l">Repeticiones</param>
        public static void beepTime(uint t, uint d, int s, int l)
        {
            for (int i = 0; i < l; i++)
            {
                Beep(t, d);
                Thread.Sleep(s);
            }
        }
        [DllImport("winmm.dll")]
private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);


        static void Main(string[] args)
        {

            beepTime(600, 100, 1000, 4);
            beepTime(600, 1000, 1000, 1);
            /*
            Thread workerThread = new Thread(beepTime);

            // Start the worker thread.
            workerThread.Start();
            Console.WriteLine("main thread: Starting worker thread...");
            workerThread.Join();
            Console.WriteLine("main thread: Worker thread has terminated.");

            */
            Console.Read();
        }
    }
}
