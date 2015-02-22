using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading;

namespace Socket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                EstadoRed();
                Thread.Sleep(100);
            }
        }
        static int num=0;
        static void EstadoRed()
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = false;

            // Create a buffer of 32 bytes of data to be transmitted.   209.85.229.99
            string data = "..................................";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1;
            PingReply reply = pingSender.Send("209.85.229.99", timeout, buffer, options);
            Console.SetCursorPosition(0, 0);
            Console.Write("Red" + " "+ num);
            if (reply.Status == IPStatus.Success) { Console.Write(" OK"); }
            else { Console.Write(" MAL"); };
            num++;



        }
    }
}
