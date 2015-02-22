using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Maths
{
    class Program
    {
        static int best =0;
        static void Main(string[] args)
        {
            try{
            using (System.IO.StreamReader file = new System.IO.StreamReader("best.txt", true))
            {
                
                    best = Convert.ToInt32(file.ReadToEnd());
                    file.Close();
                }
            }catch{}
            
            int _r=1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("     Ronda: " + _r + "     Mejor: "+ best);
                Console.WriteLine("------------------------------------");
                int fallos = 0;
                int _x = 30;
                int _y = 30;
                int _rondas = 5;
                string _op = "+";
                DateTime t1 = DateTime.Now;
                for (int i = 0; i < _rondas; i++)
                {
                    Random r = new Random(DateTime.Now.Millisecond);
                    int x = r.Next(1, _x);
                    int y = r.Next(1, _y);
                    Console.Write("\t" +x + "+" + y + " = ");
                    int z = 0;
                    try
                    {
                        while (z == 0)
                        {
                            z = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    catch {}
                    if (_op == "+")
                    {
                        if (z != x + y)
                        {
                            //Console.WriteLine("Fallo");
                            i--;
                            fallos++;
                            Console.Write("->"+(x + y) + "!");
                        }
                    }
                    if (_op == "*")
                    {
                        if (z != x * y)
                        {
                            //Console.WriteLine("Fallo");
                            i--;
                            fallos++;
                            Console.Write("->" + (x * y) + "!");
                        }
                    }
                    
                }
                _r++;
                DateTime t2 = DateTime.Now;
                
                TimeSpan tiempo = new TimeSpan(t2.Ticks - t1.Ticks);
                int puntos = Convert.ToInt32(((1 / tiempo.TotalSeconds) * 10000) / (fallos + 1));
                //Console.WriteLine("\n\t" + puntos + " puntos " + tiempo.TotalSeconds + " " + ((1 / tiempo.TotalSeconds) * 10000) + " "+ fallos);
                Console.WriteLine("\n\t" +puntos + " puntos");
                if (best < puntos) { best = puntos;
                File.Delete("best.txt");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("best.txt", true))
                {
                    string f = file.ToString();
                    file.Write(best);
                    
                    file.Close();
                }

                }
                //Ya puedes mostrar en pantalla o guardar en una cadena
                // (o lo que sea) el tiempo transcurrido (con total precisión)
                //System.Console.WriteLine(tiempo.ToString() + " Numero de fallos: " + fallos.ToString());
                //Console.ReadLine();
                string line = _rondas.ToString() + "  |   " + _x.ToString() + "    " + _y.ToString() + "    |        " + _op +
                "        |     " + fallos.ToString() + "     |  " + tiempo.ToString() + " |     " + puntos.ToString();
                

                using (System.IO.StreamWriter file = new System.IO.StreamWriter("stats.txt", true))
                {
                    
                    file.WriteLine(line);
                    file.Close();
                }
                Console.ReadKey();
            }
        }
    }
}
