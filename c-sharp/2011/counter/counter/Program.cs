using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static double num=0;
        static void Main(string[] args)
        {
            while (true)
            {
                num = 0;
                Thread t1 = new Thread(bucle);
                t1.Priority = ThreadPriority.Highest;
                t1.Start();
                Thread.Sleep(1000);
                t1.Abort();
                t1.Join();
                int nn = Convert.ToInt32(num /*/ 1000000*/);
                Console.WriteLine(nn.ToString() + " millones de numeros/s");
            }
        }
        static void bucle()
        {
            while (true)
            {
                num++;
            }
        }
    }
}
