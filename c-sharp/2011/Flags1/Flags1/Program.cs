using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Flags
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoFlags i = new InfoFlags();
            i.info = 63;
            Console.WriteLine(i.Masculino.ToString());
            Console.ReadLine();
        }
    }

    class InfoFlags
    {
        byte _byte;
        public byte info
        {
            set
            {
                _byte = value;
                byte[] b = new byte[1];
                b[0] = _byte;
                BitArray bits = new BitArray(b);
                Conectado = bits[0];
                Ausente = bits[1];
                WebCam = bits[2];
                Juegos= bits[3];
                Movil= bits[4];
                Push= bits[5];
                Amigo= bits[6];
                Masculino = bits[7];
                
            }
            get { 
                BitArray bits = new BitArray(8);
                bits[0] = Conectado;
                bits[1] = Ausente;
                bits[2] = WebCam;
                bits[3] = Juegos;
                bits[4] = Movil;
                bits[5] = Push;
                bits[6] = Amigo;
                bits[7] = Masculino;

                for (int i = 0; i < 8; i++)
                {
                    string t="0";
                    if (bits[i]) t = "1";
                    Console.Write(t);
                } Console.WriteLine();
                byte[] b = new byte[1];
                bits.CopyTo(b,0);
                _byte = b[0];
                return _byte;
            }

        }

        public bool Conectado;
        public bool Ausente;

        public bool WebCam;
        public bool Juegos;

        public bool Movil;
        public bool Push;

        public bool Amigo;
        public bool Masculino;
    }
}
