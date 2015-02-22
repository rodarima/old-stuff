using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using agsXMPP;

namespace sockets
{
    class Program
    {
        
        static byte[] stringtobyte(string s)
        {
            byte[] b = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i = i + 2)
            {
                b[i / 2] = (byte)Convert.ToInt32(s[i] + "" + s[i + 1], 16);
            }
            return b;
        }
        static string HexString2Ascii(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= hexString.Length - 2; i += 2)
            {
                sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber))));
            }
            return sb.ToString();
        }
        static string md5(string Value)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(Value);
            data = x.ComputeHash(data);
            string ret = "";
            for (int i = 0; i < data.Length; i++)
                ret += data[i].ToString("x2").ToLower();
            return ret;
        }
        static string Encode(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }
        static string Decode(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
        static String ConvertToBase(int num, int nbase)
        {
            String chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // check if we can convert to another base
            if (nbase < 2 || nbase > chars.Length)
                return "";

            int r;
            String newNumber = "";

            // in r we have the offset of the char that was converted to the new base
            while (num >= nbase)
            {
                r = num % nbase;
                newNumber = chars[r] + newNumber;
                num = num / nbase;
            }
            // the last number to convert
            newNumber = chars[num] + newNumber;

            return newNumber;
        }
        static long NextInt64(Random rnd)
        {
            long l;
            
                var buffer = new byte[sizeof(Int64)];
                rnd.NextBytes(buffer);
                l = BitConverter.ToInt64(buffer, 0);
                
            return l;
        }
        
        static string tobase(long n, int b)
        {
            string N ="";
            n = Math.Abs(n);
            while(n>0)
            {
                N+= (n%b).ToString();
                n /= b;
            }
            string num="";
            for (int i = 0; i < N.Length; i++)
            {
                num += N.Substring(N.Length-1 - i, 1);
            }
                return num;
        }
        static string ToHex(string value)
        {
            return String.Format("0x{0:X}", value);
        }
        static string ConvertToHex(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }
        static String ToBase(long num, int nbase)
        {
            num = Math.Abs(num);
            String chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // check if we can convert to another base
            if (nbase < 2 || nbase > chars.Length)
                return "";

            int r;
            String newNumber = "";

            // in r we have the offset of the char that was converted to the new base
            while (num >= nbase)
            {
                r = Convert.ToInt32(num % nbase);
                newNumber = chars[r] + newNumber;
                num = num / nbase;
            }
            // the last number to convert
            newNumber = chars[(int)num] + newNumber;

            return newNumber;
        }
        static void xmpp_OnSaslStart(object sender, agsXMPP.sasl.SaslEventArgs args) {
        args.Auto = false;
        args.Mechanism = agsXMPP.protocol.sasl.Mechanism.GetMechanismName(agsXMPP.protocol.sasl.MechanismType.NONE);
        }
        static byte[] StringToBytes(String cadena)
        {
            System.Text.ASCIIEncoding codificador = new System.Text.ASCIIEncoding();
            return codificador.GetBytes(cadena);
        }
        static byte[] Combine(byte[] a, byte[] b)
        {
            byte[] c = new byte[a.Length + b.Length];
            System.Buffer.BlockCopy(a, 0, c, 0, a.Length);
            System.Buffer.BlockCopy(b, 0, c, a.Length, b.Length);
            return c;
        }
        static void Main(string[] args)
        {
            
            /*while (true)
            {
                Random r = new Random();
                long a = NextInt64(r);

                Console.WriteLine(ulong.MaxValue.ToString() + " --- " + a.ToString());
                Console.WriteLine(ConvertToHex(ToBase(a, 0x24)) + " " + ConvertToHex(ToBase(a, 0x24)).Length);
                Console.ReadLine();
            }
            /*string nonce = "3807xxxxxxx";
            Console.WriteLine(nonce);
            string telefono = "xxxxxxxxxx";
            string response2 = "username=\"" + telefono + "\",realm=\"s.whatsapp.net\",nonce=\"" + nonce + "\",cnonce=\"xxxxxxxxx-942B-49AF-B02B-xxxxxxxxxxx\",nc=00000001,qop=auth,digest-uri=\"xmpp/s.whatsapp.net\",response=xxxxxxxxxxxxxxxxc143b557e09,charset=utf-8";
            /*
            string hash = "";
            string m = md5("xxxxxxxxxxxxxxxxxxxxxxxxxxx83cfa6b06");
                string hA1data = md5(telefono + ":s.whatsapp.net:auth");
                //Console.WriteLine(hA1data);
                hA1data += ":" + nonce + ":xxxxxxxx-942B-49AF-B02B-xxxxxxxx";
                //Console.WriteLine(hA1data);
                string hA1 = md5(hA1data);
                //Console.WriteLine(hA1);
                string hA2 = md5("AUTHENTICATE:xmpp/s.whatsapp.net");
                //Console.WriteLine(hA2);
                hash = md5(hA1 + ":" + nonce + ":00000001:xxxxxxxx-942B-49AF-B02B-xxxxxxxxxx:auth" + hA2);
                */
            Console.WriteLine(md5((md5("xxxxxxxxx:s.whatsapp.net:PASSWORD") + ":xxxx330548:xxxxxxx-7C51-4FBF-81CE-0xxxxxxxxx") + ":xxxxxx48:00000001:xxxxxxxx-7C51-4FBF-81CE-xxxxxxxxxxxx:auth:" + md5("AUTHENTICATE:xmpp/s.whatsapp.net")));
                


            /*
            string host = "bin-short.whatsapp.net";
            IPAddress direc = Dns.GetHostEntry(host).AddressList[0];
            int source_port = 5222;
            IPEndPoint Ep = new IPEndPoint(direc, source_port);

            Console.WriteLine("Conectando a " + host+":"+source_port.ToString()+ " - "+direc.ToString());
            
            
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Ttl = 64;
            socket.Connect(Ep);
            if (socket.Connected == true)
            {
                Console.WriteLine("Conectado");
            }
            else
            {
                Console.WriteLine("Error al conectar");
                Console.ReadLine();
            }

            byte[] b = { 0x57, 0x41, 0x01, 0x00 };
            Console.WriteLine("Enviando " +b[0].ToString() +b[1].ToString() +b[2].ToString() +b[3].ToString() );
            socket.Send(b);
            string request1 = "0019f80501a08a84fc115475636861742d322e362e342d353232320008f80296f801f8017e0007f8050f5a2abda7";
            b = stringtobyte(request1);
            string rec = "";
            socket.Send(b);
            
            for (int j = 0; j < 3; j++)
            {
                int loading = 0;
                while (socket.Available == 0) { if (loading == 500) { Console.Write("."); loading = 0; } loading++; }
                Console.WriteLine();
                byte[] buf = new byte[socket.Available];
                socket.Receive(buf);
                if (j == 2)
                {
                    for (int i = 0; i < buf.Length; i++)
                    {
                        rec += buf[i].ToString("X2");
                        //Console.Write(buf[i].ToString("X2"));
                    }
                }
            }
            Console.WriteLine(rec);
            rec = rec.Substring(9 * 2);
            Console.WriteLine();
            string response1 = Decode(HexString2Ascii(rec));
            Console.WriteLine(response1);
            string nonce = Regex.Match(response1, @"nonce=""(?<nonce>\d*)""").Groups["nonce"].Value;
            string telefono = "34xxxxxxxx";
            string response2 = "username=\"" + telefono + "\",realm=\"s.whatsapp.net\",nonce=\"" + nonce + "\",cnonce=\"xxxxxxxxxx-942B-49AF-B02B-xxxxxxxxxx\",nc=00000001,qop=auth,digest-uri=\"xmpp/s.whatsapp.net\",response=xxxxxxxxxxxxxxxx7adc143b557e09,charset=utf-8";
            response2 = Encode(response2);
            string a = "0131f80486bda7fd000128";
            byte[] bb1 = StringToBytes(response2) ;
            byte[] bb2 = stringtobyte(a);
            byte[] bb3 = Combine(bb2, bb1);

            socket.Send(bb3);
            
                int loadinge = 0;
                while (socket.Available == 0) { if (loadinge == 500) { Console.Write("."); loadinge = 0; } loadinge++; }
                Console.WriteLine();
                byte[] bufe = new byte[socket.Available];
                socket.Receive(bufe);
                
                    for (int i = 0; i < bufe.Length; i++)
                    {
                        rec += bufe[i].ToString("X2");
                        //Console.Write(buf[i].ToString("X2"));
                    }
                    Console.WriteLine(rec);
             

            /*bool rec = false;
            while (socket.Connected == true)
            {
                if (socket.Available > 0)
                {
                    rec = true;
                    byte[] buf = new byte[socket.Available];
                    socket.Receive(buf);
                    for (int i = 0; i < buf.Length; i++)
                    {
                        Console.Write(buf[i].ToString("X2"));
                    }
                    Console.WriteLine();
                }
                if (rec == true && socket.Available == 0)
                {
                //    break;
                }
            }*/
            /*
            Byte[] RecvBytes = new Byte[255];
            int bytes;
            Console.WriteLine("Recibiendo:");
            Console.WriteLine(); Console.WriteLine();
            bytes = socket.Receive(RecvBytes,RecvBytes.Length,SocketFlags.None); //Recibimos la respuesta en bloques de 255 bytes
            for (int i = 0; i < bytes; i++)
            {
                Console.Write(RecvBytes[i].ToString("X2"));
            }
            Console.WriteLine(); Console.WriteLine();
            RecvBytes = new Byte[255];
            bytes = 0;
            bytes = socket.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None); //Recibimos la respuesta en bloques de 255 bytes
            for (int i = 0; i < bytes; i++)
            {
                Console.Write(RecvBytes[i].ToString("X2"));
            }
            Console.WriteLine(); Console.WriteLine();
            RecvBytes = new Byte[307];
            bytes = 0;
            bytes = socket.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None); //Recibimos la respuesta en bloques de 255 bytes
            for (int i = 0; i < bytes; i++)
            {
                Console.Write(RecvBytes[i].ToString("X2"));
            }
            Console.WriteLine(); Console.WriteLine();
            
            b = stringtobyte("000ff80574a21161fc07526f647269676f");
            Console.WriteLine("Enviando: 000ff80574a21161fc07526f647269676f");
            socket.Send(b);
            Byte[] RecvBytes = new Byte[255];
            int bytes = 0;
            bytes = socket.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None); //Recibimos la respuesta en bloques de 255 bytes
            for (int i = 0; i < bytes; i++)
            {
                Console.Write(RecvBytes[i].ToString("X2"));
            }
            Console.WriteLine(); Console.WriteLine();
            socket.Close();*/
            Console.ReadLine();
            
        }
    }
}
