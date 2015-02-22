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

namespace Tuenti_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Enchufar(string Correo, string pass)
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
                    //MessageBox.Show(cad);
                }
                string Argumentos = "email=" + Correo + "&input_password=" + pass + "&timezone=1";
                return Argumentos;
            }
            catch
            {
                return null;
            }// datos es lo que devuelve la funcion anterior
        }
        public static CookieCollection Comprobar(string Argumentos)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            Uri Lugar = new Uri("https://www.tuenti.com/?m=Login&func=do_login");
            HttpWebRequest Red = (HttpWebRequest)HttpWebRequest.Create(Lugar);
            Red.AllowAutoRedirect = false;
            Red.ProtocolVersion = HttpVersion.Version11;
            Red.Method = "POST";
            //Red.UserAgent = "Mozilla/6.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko/2008072820 Firefox/3.0.1";
            Red.ContentType = "application/x-www-form-urlencoded";
            byte[] ContenidoBytes = UTF8Encoding.UTF8.GetBytes(Argumentos);
            Red.ContentLength = ContenidoBytes.Length;
            


            try
            {
                Stream FlujoPosterior = Red.GetRequestStream();
                FlujoPosterior.Write(ContenidoBytes, 0, ContenidoBytes.Length);
                FlujoPosterior.Close();
                
            }
            catch { }
            string Galleta;
            try
            {
                HttpWebResponse Respuesta = (HttpWebResponse)Red.GetResponse();
                CookieCollection cc = Respuesta.Cookies;
                Galleta = Respuesta.GetResponseHeader("Set-Cookie");
                return cc;
            }
            catch { }

            return null;
        }
        string get_code(CookieCollection cc, string Argumentos)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            Uri Lugar = new Uri("https://www.tuenti.com/?m=Login&func=do_login");
            HttpWebRequest Red = (HttpWebRequest)HttpWebRequest.Create(Lugar);
            Red.AllowAutoRedirect = false;
            Red.ProtocolVersion = HttpVersion.Version11;
            Red.Method = "POST";
            //Red.UserAgent = "Mozilla/6.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko/2008072820 Firefox/3.0.1";
            Red.ContentType = "application/x-www-form-urlencoded";
            byte[] ContenidoBytes = UTF8Encoding.UTF8.GetBytes(Argumentos);
            Red.ContentLength = ContenidoBytes.Length;

            CookieContainer cookies = new CookieContainer();
            cookies.Add(cc);
            Red.CookieContainer = cookies;


            Stream FlujoPosterior = Red.GetRequestStream();
                FlujoPosterior.Write(ContenidoBytes, 0, ContenidoBytes.Length);
                FlujoPosterior.Close();



                StreamReader LectorDeFlujo = new StreamReader(FlujoPosterior);

                String sLine = "";
                String cad = "";

                while (sLine != null)
                {
                    sLine = LectorDeFlujo.ReadLine();
                    if (sLine != null)
                        cad += sLine + Environment.NewLine;
                    //MessageBox.Show(cad);
                }

            return cad;

        }
        private void blogin_Click(object sender, EventArgs e)
        {
            string datos = Enchufar(temail.Text, tpass.Text);
            CookieCollection cookie = Comprobar(datos);

            MessageBox.Show(get_code(cookie,datos)); 
        }
    }
}
