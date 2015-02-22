using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] AND = {{0,0},
                          {0,1}};


            int[] N = { 1, 0, 0 };
            float[] W = { 0, 0, 0 };



             int r = 1;
             Console.WriteLine("b x y z  δ");
             while (r == 1)
             {
                 r = 0;
                 
                 for (int x = 0; x < 2; x++)
                 {
                     for (int y = 0; y < 2; y++)
                     {

                         N[1] = x;
                         N[2] = y;
                         int δ = AND[N[1], N[2]];
                         float α = 1F;
                         float s = N[0] * W[0] + N[1] * W[1] + N[2] * W[2];
                         int z = 0;
                         if (s > 0) { z = 1; }

                         Console.Write(N[0] + " "+ x + " " + y + " " + z + " (" + δ+") ");
                         //Console.WriteLine("pesos " + W[0] + " " + W[1] + " " + W[2]);
                         if (z != δ)
                         {
                             r = 1;
                            
                             Console.Write("  ("+W[0] + " " + W[1] + " " + W[2] + ")  -->  (");
                             for (int i = 0; i < N.Length; i++)
                             {
                                 W[i] = W[i] + α * (δ - z) * N[i];

                             }
                             Console.Write(W[0] + " " + W[1] + " " + W[2]+")");
                         }
                         //Console.ReadKey();
                         Console.Write("\n");
                     }

                 }
                 Console.Write("\n");
                 Console.ReadKey();
                 
             }
             Console.WriteLine("Me he aprendido la leccion");
             Console.WriteLine("pesos " + W[0] + " " + W[1] + " " + W[2]);
             Console.ReadKey();



        }
    }
}