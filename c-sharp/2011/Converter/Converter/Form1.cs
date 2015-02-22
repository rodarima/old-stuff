using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void limpiar_campos()
        {
            entero_hex_dec.Text = "";
            entero_dec_hex.Text = "";
            entero_dec_oct.Text = "";
            entero_oct_dec.Text = "";
            texto_hex_ascii.Text = "";
            texto_ascii_hex.Text = "";
            texto_ascii_hex.Text = "";
            texto_hex_ascii.Text = "";
            texto_base64_ascii.Text = "";
            texto_ascii_base64.Text = "";
            texto_md5.Text = "";
            texto_sha1.Text = "";
            texto_tamaño.Text = "";
        }
        public static string SHA1(string str)
        {
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public static string MD5(string Value)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(Value);
            data = x.ComputeHash(data);
            string ret = "";
            for (int i = 0; i < data.Length; i++)
                ret += data[i].ToString("x2").ToLower();
            return ret;
        }
        private string Ascii2Hex(string i_asciiText)
        {
            StringBuilder sBuffer = new StringBuilder();
            for (int i = 0; i < i_asciiText.Length; i++)
            {
                sBuffer.Append(Convert.ToInt32(i_asciiText[i]).ToString("x"));
            }
            return sBuffer.ToString().ToUpper();
        }
        private string Hex2Ascii(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= hexString.Length - 2; i += 2)
            {
                int ch = Int32.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
                if (ch == 0)
                {
                    sb.Append("<EOF>");
                }
                else
                {
                    sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber))));
                }
            }
            return sb.ToString();
        }
        public static string EncodeTo64(string toEncode)
        {

            byte[] toEncodeAsBytes

                  = System.Text.Encoding.ASCII.GetBytes(toEncode);

            string returnValue

                  = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;

        }
        public static string DecodeFrom64(string encodedData)
        {
            try
            {
                byte[] encodedDataAsBytes

                    = System.Convert.FromBase64String(encodedData);

                string returnValue =

                   System.Text.Encoding.ASCII.GetString(encodedDataAsBytes);

                return returnValue;
            }
            catch
            {
                return "No es una cadena cifrada en base64";
            }

        }
        private void texto_insertar_TextChanged(object sender, EventArgs e)
        {
            
            string texto = texto_insertar.Text;

            int longitud = texto.Length;
            if (texto == "")
            {
                limpiar_campos();
                return;
            }
            texto_tamaño.Text = longitud.ToString();
            bool tieneletras = false;
            bool eshexadecimal = false;
            bool esdecimal=false;
            bool esoctal = false;
            bool esbase64 = false;
            string texto_tohex = texto;
            if (texto_ignorar.Text != "")
            {
                for (int i = 0; i < texto_ignorar.Text.Length; i++)
                {

                    string caracter = texto_ignorar.Text.Substring(i, 1);
                    texto_tohex = texto_tohex.Replace(caracter, "");
                }
            }
            if (!Regex.Match(texto, @"\d+").Success) { tieneletras = true; }
            if (Regex.Matches(texto_tohex, @"[ABCDEFabcdef0123456789]").Count == texto_tohex.Length)
            {
                eshexadecimal = true;
            }
            if (Regex.Matches(texto, @"[01234567]").Count == longitud)
            {
                esoctal = true;
            }
            if (Regex.Matches(texto, @"[0123456789]").Count == longitud)
            {
                esdecimal = true;
            }
            if (Regex.Match(texto, "([ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/]{4})*([ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/]{3}=|[ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/]{2}==)").Success)
            {
                esbase64 = true;
            }
            if (eshexadecimal)
            {
                
                texto_hex_ascii.Text = Hex2Ascii(texto_tohex);

                if (texto_tohex.Length > 16)
                {
                    entero_hex_dec.Text = "Desbordamiento";
                }
                else if (texto_tohex.Length > 0)
                {

                    long decValue = Convert.ToInt64(texto_tohex, 16);
                    entero_hex_dec.Text = decValue.ToString();
                }
                else
                {
                    entero_hex_dec.Text = "No es hexadecimal";
                    texto_hex_ascii.Text = "No es hexadecimal";
                }
            }
            else
            {
                entero_hex_dec.Text = "No es hexadecimal";
                texto_hex_ascii.Text = "No es hexadecimal";
            }
            
            if (esdecimal)
            {
                if (longitud < 19)
                {
                    long ent_dec = Convert.ToInt64(texto);
                    string ent_oct_str = Convert.ToString(ent_dec, 8);
                    entero_dec_hex.Text = String.Format("{0:x2}", ent_dec).ToUpper();
                    entero_dec_oct.Text = ent_oct_str;
                }
                else
                {
                    entero_dec_hex.Text = "Desbordamiento";
                    entero_dec_oct.Text = "Desbordamiento";
                }

            }
            else
            {
                entero_dec_hex.Text = "No es decimal";
                entero_dec_oct.Text = "No es decimal";
            }

            if (esoctal)
            {
                if (longitud < 22)
                {
                    long ent_oct_num = Convert.ToInt64(texto, 8);
                    entero_oct_dec.Text = Convert.ToString(ent_oct_num);
                }
                else
                {
                    entero_oct_dec.Text = "Desbordamiento";
                }
            }
            else
            {
                entero_oct_dec.Text = "No es octal";
            }
            texto_ascii_hex.Text = Ascii2Hex(texto);
            texto_ascii_base64.Text = EncodeTo64(texto);
            if (esbase64)
            {
                texto_base64_ascii.Text = DecodeFrom64(texto);
            }
            else
            {
                texto_base64_ascii.Text = "No es una cadena cifrada en base64";
            }
            texto_md5.Text = MD5(texto).ToUpper();
            texto_sha1.Text = SHA1(texto).ToUpper();
        }


    }
}
