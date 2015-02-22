using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ruleta2
{
    class Program
    {
        static void WriteNum(int[] num, double promedio, int num_actual)
        {
            Console.SetCursorPosition(0, 0);
            int verde = 0;
            int rojo = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < promedio)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    rojo++;
                }
                else if (promedio < num[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    verde++;
                }
                else if (promedio == num[i])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                if (num_actual == i) { Console.BackgroundColor = ConsoleColor.Magenta; }

                Console.Write(num[i].ToString());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\t");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("Verdes: " + verde.ToString() + " Rojos: " + rojo.ToString()+" Diferencia: "+ Math.Abs(rojo-verde).ToString()+ "                             ");

        }
        static void Main(string[] args)
        {
            double difmax = 0;
            Random rand = new Random(DateTime.Now.Millisecond);
            int[] array_numeros = new int[37];
            int simulaciones = 0;
            int numero_aleatorio = 0;

            while (true)
            {
                simulaciones++;
                numero_aleatorio = rand.Next(0, 37);

                array_numeros[numero_aleatorio]++;
                double teorico = Convert.ToDouble(simulaciones) / 37;
                WriteNum(array_numeros, teorico, numero_aleatorio);
                Console.SetCursorPosition(0, 5);
                
                Console.Write("Ruleta: " + numero_aleatorio.ToString()+ "  "+  teorico.ToString() +" simulaciones: " +simulaciones.ToString()+ "                               ");
                /*
                for (int i = 0; i < 37; i++)
                {
                    
                    double d = Math.Abs(Convert.ToDouble(array_numeros[i]) - teorico);
                    if (d > difmax) difmax = d;
                    Console.WriteLine(i.ToString() + "->" + array_numeros[i].ToString() + "(" + teorico.ToString() + ") " + (((double)d * 100) / (double)simulaciones).ToString());
                }*/
                //Console.WriteLine("Diferencia maxima: "+difmax.ToString() +" "+ (difmax*100/(double)simulaciones).ToString() );
                Console.ReadLine();
                //Console.Clear();
            }
            Console.Clear();
        }
    }
}
