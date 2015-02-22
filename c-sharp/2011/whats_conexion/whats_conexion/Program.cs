using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static byte[] md5(byte[] data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            data = x.ComputeHash(data);
            return data;
        }
        static byte[] Combine(params byte[][] arrays)
        {
            byte[] rv = new byte[arrays.Sum(a => a.Length)];
            int offset = 0;
            foreach (byte[] array in arrays)
            {
                System.Buffer.BlockCopy(array, 0, rv, offset, array.Length);
                offset += array.Length;
            }
            return rv;
        }
        static void Main(string[] args)
        {
            string ret = "";
            ret = "";
            byte[] hash1 = md5(Encoding.ASCII.GetBytes("xxxxxxxxxxxx:s.whatsapp.net:whatsapp"));
            hash1 = md5(Combine(hash1, Encoding.ASCII.GetBytes(":xxxxxxxx:xxxxxxxxx-C995-489C-BBF9-xxxxxxxxx")));
            hash1 = md5(Combine(hash1, Encoding.ASCII.GetBytes(":xxxxxxxx:00000001:xxxxxxx-C995-489C-BBF9-xxxxxxxxx:auth:"), md5(Encoding.ASCII.GetBytes("AUTHENTICATE:xmpp/s.whatsapp.net"))));


            for (int i = 0; i < hash1.Length; i++)
                ret += hash1[i].ToString("x2").ToLower();


           
            Console.WriteLine(ret);
            //Console.WriteLine(md5((md5("xxxxxxxxxx:s.whatsapp.net:PASSWORD") + ":xxxxxxx:xxxxxx-7C51-4FBF-81CE-xxxxxxxxx") + ":32403xxxx:00000001:xxxxxxx-7C51-4FBF-81CE-xxxxxxxxxxx:auth:" + md5("AUTHENTICATE:xmpp/s.whatsapp.net")));
            Console.ReadLine();
        }
    }
}
