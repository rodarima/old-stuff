using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace BrutalConsola
{
    class Program
    {
        static string InputPass, InputPassMD5;
        static int InputLenght;
        static double PassMax;
        static void Main(string[] args)
        {
            Console.WriteLine("#Brutal - Bruteforce aleatorio y lineal");
            Console.Write("> ");
            do { InputPass = Console.ReadLine(); } while (InputPass == "");
            
                InputLenght = InputPass.Length;
                InputPassMD5 = md5(InputPass);
                PassMax = Math.Pow(27, InputLenght);
                Console.WriteLine("Lon:{0}, Max:{1}, MD5:{2}", InputLenght, PassMax, InputPassMD5);
                Timer t = new Timer(ComputeBoundOp, 5, 0, 100);
                MiStr = abc;
                BruteForceLineal();
                Console.ReadLine();
            while (true)
            {
                BruteForceRand();

            }
            Console.ReadLine();

        }
        
        static void ComputeBoundOp(Object state) {

            keys_s = curr*10;
            curr = 0;

        }
        static System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            
        public static string md5(string Value)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(Value);
            data = x.ComputeHash(data);
            string ret = "";
            for (int i = 0; i < data.Length; i++)
                ret += data[i].ToString("x2").ToLower();
            return ret;
        }


        static int proba=0, prob_max=0;
        static double curr=0, temp=0, keys_s=0, t_res, ok, veces=1, lineal=0;
        static string[] MiStr = new string[0];
        //static string[] MiStr2 = new string[61568671];
        static string[] n123 = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string[] abc = new string[27] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        static string[] abc123 = new string[37] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        static string[] ABC = new string[27] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        static string[] ABC123 = new string[37] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        static string[] abcABC123 = new string[64] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        static Thread workerThread;
        static void BruteForceLineal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var timer2 = Stopwatch.StartNew();
            var timer = Stopwatch.StartNew();
            int[] t = new int[255];
            int x, y, maxv, running = 0, bar = 0;
            
            string pass, p;

            if (MiStr.Length == 0) { Console.WriteLine("Caracteres incorrectos"); return; }

            running = 1;
            maxv = Convert.ToInt32(MiStr.Length);

            for (y = 0; y <= InputLenght; ++y) { t[y] = 0; }
            //t[maxd] = startwith;
            while (t[InputLenght] < 1)
            {
                //
                p = null;
                for (x = 0; x <= InputLenght; ++x)
                {
                    if (t[x] >= maxv)
                    {
                        t[x] = 0;
                        ++t[x + 1];
                    }
                }
                for (y = 0; y <= InputLenght - 1; ++y)
                {
                    // pass =pass+ Convert.ToBase64String(t[y]);
                    p += MiStr[t[y]];

                    //sprintf(pass, "%s%c", pass, t[y]);
                }
                pass = p;
                temp++;
                curr++;
                lineal++;
                string CheckMD5 = "";
                //string CheckMD5 = md5(pass);
                //if (CheckMD5 == InputPassMD5)
                if (pass == InputPass)
                {prob_max = Convert.ToInt32((temp / PassMax) * 100);
                    timer2.Stop();
                    Console.WriteLine(pass + " " + CheckMD5 + " " + timer2.Elapsed);
                    break;
                }
                if (temp % 100000==0)
                {
                    //timer.Stop();
                    
                    int per = Convert.ToInt32((temp / PassMax) * 100);
                    Console.WriteLine(pass + " "+per+"% " +timer.Elapsed + " " + timer2.Elapsed + " " + keys_s);
                    timer = Stopwatch.StartNew();
                }
                //key.Text = pass;
                //MessageBox.Show(pass);
                //printf(pass); printf("\n");
                //Thread.Sleep(10);
                ++t[0];
                /////////////////////////////////////////

            } 
            running = 0;
        }
        static void BruteForceRand()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var timer2 = Stopwatch.StartNew();
            var timer = Stopwatch.StartNew();
            int[] t = new int[255];
            int per=0, x, y, maxv, running = 0, bar = 0;
            string pass, p;

            if (MiStr.Length == 0) { Console.WriteLine("Caracteres incorrectos"); return; }
            temp = 0;
            running = 1;
            maxv = Convert.ToInt32(MiStr.Length);

            for (y = 0; y <= InputLenght; ++y) { t[y] = 0; }
            //t[maxd] = startwith;
            Random r = new Random(DateTime.Now.Millisecond);
            while (true)
            {
                p = null;
                for (x = 0; x < InputLenght; ++x)
                {
                    t[x]=r.Next(0, maxv);
                    p += MiStr[t[x]];
                }
                
                pass = p;
                temp++;
                curr++;
                string CheckMD5 = "";
                //string CheckMD5 = md5(pass);
                //if (CheckMD5 == InputPassMD5)
                if (curr < temp)
                {
                    veces++;
                    timer2.Stop();
                    proba = Convert.ToInt32((ok / veces) * 100);
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine(pass + " " + CheckMD5 + " " + timer2.Elapsed + " " + proba + "% " + prob_max + "% ");
                    break;
                }
                if (pass == InputPass)
                {
                    veces++;
                    per = Convert.ToInt32((temp / PassMax) * 100);
                    timer2.Stop();
                    proba=Convert.ToInt32((ok/veces)*100);
                    if (per > 100) { Console.ForegroundColor = ConsoleColor.Red; }
                    else { Console.ForegroundColor = ConsoleColor.Green; ok++; }

                    Console.WriteLine(pass + " " + CheckMD5 + " " + timer2.Elapsed + " " + proba + "% " +prob_max + "% ");
                    break;
                }
                if (temp % 500000==0)
                {
                    //timer.Stop();


                    per = Convert.ToInt32((temp / PassMax) * 100);
                    Console.WriteLine(pass + " " + per + "% " + timer.Elapsed + " " + timer2.Elapsed + " " + keys_s); 
                    timer = Stopwatch.StartNew();
                    temp=1;
                }
                //key.Text = pass;
                //MessageBox.Show(pass);
                //printf(pass); printf("\n");
                //Thread.Sleep(10);
                ++t[0];
                /////////////////////////////////////////

            }
            running = 0;
        }
        
    }
}
