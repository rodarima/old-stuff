using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace LoginTuentiHttps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Enchufar(string Correo, string pass)
        {
            HttpWebRequest Red = (HttpWebRequest)WebRequest.Create("http://www.tuenti.com/?");
            Red.Method = "GET";
            //Red.UserAgent = "Mozilla/6.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko/2008072820 Firefox/3.0.1";
            Red.ContentType = "application/x-www-form-urlencoded";

            try
            {
                Stream Flujo = Red.GetResponse().GetResponseStream();
                StreamReader LectorDeFlujo = new StreamReader(Flujo);

                String sLine = "";
                String cad = "";

                while (sLine != null)
                {
                    sLine = LectorDeFlujo.ReadLine();
                    if (sLine != null)
                    cad += sLine + Environment.NewLine;
                    MessageBox.Show(cad);
                }
                string Argumentos = "email=" + Correo + "&input_password=" + pass + "&timezone=1";
                return Argumentos;
            }
            catch
            {
                return null;
            }// datos es lo que devuelve la funcion anterior
        }
        public void Home()
        {
            HttpWebRequest Red = (HttpWebRequest)WebRequest.Create("http://www.tuenti.com/");
            Red.AllowAutoRedirect = true;
            Red.Method = "GET";
            Red.UserAgent = "Mozilla/6.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko/2008072820 Firefox/3.0.1";
            Red.ContentType = "application/x-www-form-urlencoded";
            Red.CookieContainer = myCookies;

            try
            {
                Stream Flujo = Red.GetResponse().GetResponseStream();
                StreamReader LectorDeFlujo = new StreamReader(Flujo);

                String sLine = "";
                String cad = LectorDeFlujo.ReadToEnd();
                    
                         
                    MessageBox.Show(cad);
                
                
            }
            catch
            {
                
            }// datos es lo que devuelve la funcion anterior
        }
        CookieContainer myCookies = new CookieContainer();
        public string Comprobar(string Argumentos)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            Uri Lugar = new Uri("https://www.m.tuenti.com/?m=Login&func=do_login");
            HttpWebRequest Red = (HttpWebRequest)HttpWebRequest.Create(Lugar);
            Red.AllowAutoRedirect = false;
            Red.ProtocolVersion = HttpVersion.Version11;
            Red.Method = "POST";
            //Red.UserAgent = "Mozilla/6.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko/2008072820 Firefox/3.0.1";
            Red.ContentType = "application/x-www-form-urlencoded";
            byte[] ContenidoBytes = UTF8Encoding.UTF8.GetBytes(Argumentos);
            Red.ContentLength = ContenidoBytes.Length;



            try {
                Stream FlujoPosterior = Red.GetRequestStream();
                FlujoPosterior.Write(ContenidoBytes, 0, ContenidoBytes.Length);
                FlujoPosterior.Close();
                }
            catch { }
            string Galleta;
            
                HttpWebResponse Respuesta = (HttpWebResponse)Red.GetResponse();
                Galleta = Respuesta.GetResponseHeader("Set-Cookie");
                Cookie c = new Cookie();

                c.Value = Regex.Match(Galleta, @"sid=(\S).{42}").Value.Substring(4);
                c.Domain = ".tuenti.com";
                c.Name = "sid";
                c.Path = "/";
                myCookies.Add(c);
                c.Value = "m=Home&func=view_home";
                c.Domain = "www.tuenti.com";
                c.Name = "tempHash";
                c.Path = "/";
                myCookies.Add(c);
                return Galleta;
                

            return null;
        }
        private static string Codificar(string Clave)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(Clave);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return Regex.Replace(BitConverter.ToString(encodedBytes), "-", "");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string datos = Enchufar("xxxxxxxxx@xxx.com", "xxxxxxxxxx");
            string val = Comprobar(datos);
            textBox1.Text = val;
            Home();
        }
    }
}
