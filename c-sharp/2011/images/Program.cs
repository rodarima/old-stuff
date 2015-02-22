using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace images
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                int w = Console.WindowWidth;

                Console.Write(w);

                Console.Read();
            }
            else
            {
                Console.WriteLine("images.exe <imagen.jpg>");
            }
        }
    }
}
