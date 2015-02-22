using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ruleta
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            Console.Write("Dinero inicial: ");
            
            int banca_inicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de colores seguidos para empezar a apostar (4): ");
            int ap = Convert.ToInt32(Console.ReadLine());
            int f_d = banca_inicial / 100;
            int[] num = new int[50];
            int color_temp = 3;
            int duplicados = 0;
            double tiradas = 0;
            double banca = banca_inicial;
            int color_apuesta=0;
            double ganancia =0;
            double perdida = 0;
            int exp = 0;
            double apuestas = 0;
            bool apostando = false;
            int apuestas_seguidas = 0;
            int banca_max = 0;
            int cont_o = 0;
            while (true)
            {
                double t = 0;
                while (t!=-1)
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
                        Console.Write("Rojo ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (color == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Negro");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (color == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Cero ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                for(int i=0; i<18;i++)
                {
                    Console.Write(" " + num[i].ToString());
                }

                    /*if (cont_o == 1000)
                    {
                        cont_o = 0;
                        int a = (int)((double)(banca - banca_inicial) / (double)f_d);
                        for (int i = 0; i < a; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("o");
                    }*/
                    cont_o++;
                    Console.WriteLine(" " + tiradas.ToString() + " " + ((banca - banca_inicial) / apuestas).ToString());




                    if (color_temp != 3)
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
                        if (apostando == true)
                        {
                            /*if (banca % 5 == 0 && banca>80)
                            {
                                apostando = false;
                                perdida = 0;
                                ganancia = 0;
                                Console.Write("***");
                                if (rcolor == 1)
                                {
                                    ganancia = 35;
                                }
                                else
                                {
                                    perdida = 1;
                                }
                            }
                            else*/
                            {
                                // Buscar el numero de probabilidades que ira aumentando de que salgan colores que no puedes pagar, y al llegar a un determinado limite dejar de apostar hasta que salga
                                apuestas_seguidas++;
                                if (apuestas_seguidas < 100)
                                {
                                    if (color != 0)
                                    {
                                        if (color == color_apuesta)
                                        {
                                            ganancia = 2 * perdida;
                                            apostando = false;
                                            perdida = 0;
                                            exp = 0;
                                        }
                                        else
                                        {
                                            ganancia = 0;
                                            perdida = 1 * Math.Pow(2, exp);
                                            exp++;
                                        }
                                    }
                                    else
                                    {
                                        exp = 0;
                                        duplicados = 0;
                                        ganancia = perdida / 2;
                                        perdida = 0;
                                        apostando = false;
                                    }
                                }
                                else
                                {
                                    ganancia = 0;
                                    perdida = 0;
                                    exp = 0;
                                    apostando = false;
                                    apuestas_seguidas = 0;
                                }
                            }

                        }
                        if (duplicados + 1 == ap && apostando == false)
                        {
                            apuestas++;
                            apostando = true;
                            if (color == 1) { color_apuesta = 2; }
                            if (color == 2) { color_apuesta = 1; }

                        }

                        banca = banca + ganancia - perdida;
                        if (banca_max < banca) { banca_max = (int)banca; }

                        ganancia = 0;
                        Console.Write(" " + duplicados + " " + banca + "+" + ganancia.ToString() + "-" + perdida.ToString());
                        if (banca < 0)
                        {
                            tiradas = 0;
                            Console.WriteLine("Bancarrota " + banca_max); Console.ReadKey();
                            banca_max = 0;
                            banca = banca_inicial;
                            ganancia = 0;
                            perdida = 0;
                            exp = 0;
                            apostando = false;
                        }
                    }

                    color_temp = color;
                    //Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
