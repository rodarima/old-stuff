using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;

namespace image
{
    class main
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]

        static Bitmap resize(Bitmap b, int nWidth, int nHeight)                     //Redimensiona el bitmap segun el tamaño especificado
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            //result.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            Graphics g = Graphics.FromImage((Image)result);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }
        static ConsoleColor rgb_to_color(int r, int g, int b, int ratio)
        {
            if (r == 0 && g == 0 && b == 0) return ConsoleColor.Black;
            if (r == 255 && g == 255 && b == 255) return ConsoleColor.White;
            int n = ratio;
            int a1 = n / 4;
            int a2 = 2*a1;
            int a3 = 3*a1;
            int a4 = 4*a1;

            if (r < a1) r = 1;
            if (r >= a1 && r < a2) r = 2;
            if (r >= a2 && r < a3) r = 3;
            if (r >= a3) r = 4;

            if (g < a1) g = 1;
            if (g >= a1 && g < a2) g = 2;
            if (g >= a2 && g < a3) g = 3;
            if (g >= a3) g = 4;

            if (b < a1) b = 1;
            if (b >= a1 && b < a2) b = 2;
            if (b >= a2 && b < a3) b = 3;
            if (b >= a3) b = 4;

            
            if (r == 4 && g == 4 && b == 4) return ConsoleColor.White;
            if (r == 3 && g == 3 && b == 3) return ConsoleColor.Gray;
            if (r == 2 && g == 2 && b == 2) return ConsoleColor.DarkGray;
            if (r == 1 && g == 1 && b == 1) return ConsoleColor.Black;


            if (r == 4 && g <= 2 && b <= 2) return ConsoleColor.Red;
            if (r == 3 && g <= 2 && b <= 2) return ConsoleColor.DarkRed;

            if (r <= 2 && g == 4 && b <= 2) return ConsoleColor.Green;
            if (r <= 2 && g == 3 && b <= 2) return ConsoleColor.DarkGreen;

            if (r <= 2 && g <= 2 && b == 4) return ConsoleColor.Blue;
            if (r <= 2 && g <= 2 && b == 3) return ConsoleColor.DarkBlue;
            
            if (r <= 2 && g == 3 && b == 4) return ConsoleColor.Cyan;
            if (r <= 2 && g >= 3 && b >= 3) return ConsoleColor.DarkCyan;

            if (r == 4 && g <= 2 && b == 4) return ConsoleColor.Magenta;
            if (r >= 3 && g <= 2 && b >= 3) return ConsoleColor.DarkMagenta;

            if (r == 4 && g == 4 && b <= 2) return ConsoleColor.Yellow;
            if (r >= 3 && g >= 3 && b <= 2) return ConsoleColor.DarkYellow;
            
            
            
            


            /*
            if (r > 150) return ConsoleColor.DarkGray;
            if (g > 220) return ConsoleColor.DarkGreen;
            if (b > 220) return ConsoleColor.DarkBlue;*/
            return ConsoleColor.DarkGray;
            
        }
        static void Write(string text, ConsoleColor font)
        {
            ConsoleColor b1 = Console.ForegroundColor;
            Console.ForegroundColor = font;
            Console.Write(text);
            Console.ForegroundColor = b1;
        }
        static void Main(string[] args)
        {
            AttachConsole(ATTACH_PARENT_PROCESS);
            // redirect console output to parent process;
            // must be before any calls to Console.WriteLine()


            // to demonstrate where the console output is going
            //int argCount = args == null ? 0 : args.Length;
            if (args.Length >= 1)
            {
                Console.WriteLine();
                int cw = Console.WindowWidth-1;
                try
                {
                    
                    int ratio = 150;
                    if (args.Length >=2) { ratio = Convert.ToInt32(args[1]); }
                    string ch = "█";
                    if (args.Length >=3) { ch = args[2]; }
                    Bitmap img = new Bitmap(args[0]);
                    int h = img.Height;
                    int w = img.Width;
                    int rh = (int)(((double)h * (double)cw) / (double)w * (2.0 / 3.3));
                    img = resize(img, cw, rh);
                    Console.WriteLine(cw+"x"+rh +" de "+w+"x"+h);
                    for (int y = 0; y < rh; y++)
                    {
                        for (int x = 0; x < cw; x++)
                        {

                            int r = img.GetPixel(x, y).R;
                            int g = img.GetPixel(x, y).G;
                            int b = img.GetPixel(x, y).B;
                            //█
                            Write(ch, rgb_to_color(r, g, b,ratio));
                        }
                        Console.WriteLine();
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("image.exe <image.jpg> <ratio> <char>");
            }

            // launch the WinForms application like normal
        }

    }
}
