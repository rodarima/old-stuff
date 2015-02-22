using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritmo_juego1
{
    class Program
    {
        static int write_cont =0;
        static void Writea(string a)
        {
            if (write_cont == 1000)
            {
                write_cont = 0;
                Console.WriteLine(a);
            }
            else
            {
                write_cont++;
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int banca_inicial = 80;
            int ap = 4;
            string text = "";
            int[] num = new int[50];
            int color_temp = 3;
            int duplicados = 0;
            double tiradas = 0;
            double banca = banca_inicial;
            while (true)
            {
                num = new int[50];
                double t = 0;
                while (t != 10000000)
                {
                    t++;
                    tiradas++;
                    int rcolor = r.Next(0, 38);
                    int color = 0;
                    if (rcolor != 0)
                    {
                        if (rcolor <= 18) { color = 1; }
                        if (rcolor >= 19) { color = 2; }
                    }

                    if (color == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        text = "Rojo ";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (color == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        text = "Negro";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (color == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        text = "Cero ";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    for (int i = 0; i < 50; i++)
                    {
                        
                        string c = " ";
                        int ant=0;
                        if (i == 0)
                        {
                            ant = (int)t/4;
                        }
                        else
                        {
                            ant = (int)((double)num[i - 1] *(0.5));
                        }
                        if (ant > num[i])
                        {
                            c = "-";
                        }
                        else if (ant < num[i])
                        {
                            c = "+";
                        }
                        else if (ant == num[i])
                        {
                            c = "=";
                        }
                        text += ""+c  ;
                    }
                Writea(text + " "+t.ToString());


                if (color != 0)
                {
                    if (color_temp == color)
                    {
                        duplicados++;
                    }
                    else
                    {
                        num[duplicados]++;
                        duplicados = 0;
                    }
                }
                else
                {
                    duplicados = 0;
                }
                    color_temp = color;
                    //Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
