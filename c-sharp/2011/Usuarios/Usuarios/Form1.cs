using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;

namespace Usuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AlmacenPersonas almacen;
        private void Form1_Load(object sender, EventArgs e)
        {

            almacen = new AlmacenPersonas();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=0");
        }
        
        void get_users(string code)
        {
            if (almacen.Personas_Aforo==0)
            {
               almacen.Personas_Aforo = User.get_num_users(code);
            }


            int t = Regex.Matches(code, @"user_item_(?<user_id>(\d)*) class=").Count;
            //textBox1.Text += t.ToString();

            if (t != 0 && user_num <= almacen.Personas_Aforo)
            {

                for (int i = 0; i < t; i++)
                {

                        string id = Regex.Matches(code, @"user_item_(?<user_id>(\d)*) class=")[i].Groups["user_id"].Value;
                        string nombre = Regex.Matches(code, @"<IMG( class="" outsideNetwork"")* alt=""(?<user_nombre>(\S| )*)"" src")[i].Groups["user_nombre"].Value;
                        string foto = Regex.Matches(code, @"src=""(?<user_foto>(\S)*)"" width=100 height=100")[i].Groups["user_foto"].Value;
                        string ciudad = Regex.Matches(code, @"<SPAN class=definition>Ubicación</SPAN>(\s)*(?<user_ciudad>(\w| |,|-|_)*),(\s)*<A title=""*(?<user_provincia>(\w|\s)*)""* onclick")[i].Groups["user_ciudad"].Value;
                        string provincia = Regex.Matches(code, @"<SPAN class=definition>Ubicación</SPAN>(\s)*(?<user_ciudad>(\w| |,|-|_)*),(\s)*<A title=""*(?<user_provincia>(\w|\s)*)""* onclick")[i].Groups["user_provincia"].Value;
                        almacen.AgregarPersona(id, nombre, "", "", ciudad, provincia, foto);
                        user_num++;
                }
                if (user_num <= almacen.Personas_Aforo)
                {
                    page++;
                    nav(page);
                }

            }
            else
            {
                timer_list.Enabled = false;
                DirectoryInfo DIR = new DirectoryInfo(Environment.CurrentDirectory + @"\Data");
                if (!DIR.Exists)
                {
                    DIR.Create();
                }
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\Data\" + email + ".txt"))
                {
                    for (int i = 0; i < almacen.Personas_Actuales; i++)
                    {
                        sw.WriteLine(almacen[i].Id + ";" + almacen[i].Nombre + ";" + almacen[i].Foto + ";" + almacen[i].Ciudad + ";" + almacen[i].Provincia + ";");
                        textBox1.Text += i.ToString() + ": " + almacen[i].Id + ";" + almacen[i].Nombre + ";" + almacen[i].Foto + ";" + almacen[i].Ciudad + ";" + almacen[i].Provincia + ";" + Environment.NewLine;
                    }
                }
            }

        }
        void nav(int page)
        {
            wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=" + page.ToString());
        }
        int user_num = 0;
        bool first_timer_lista_1 = true;
        bool btimer1 = false;
        int page = 0;
        string email = "xxxxxxxxx@gmail.com";
        string pass = "xxxxxxxxx";
        bool btimerlist = false;

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //textBox1.Text += wb.Url.ToString();
            if (wb.IsBusy == false)
            {
                if (wb.Url.ToString() == "http://www.tuenti.com/?m=login")
                {
                    wb.Document.GetElementById("email").InnerText = email;
                    wb.Document.GetElementById("input_password").InnerText = pass;
                    wb.Document.GetElementById("remember").SetAttribute("checked", "false");
                    wb.Document.GetElementById("submit_button").InvokeMember("click");
                }

                else if (wb.Url.ToString().Contains("category=people"))
                {
                    if (first_timer_lista_1 == true)
                    {
                        if (btimer1 == false)
                        {
                            first_timer_lista_1 = false;
                            timer_lista1.Enabled = true;
                        }
                    }

                }
            }

        }
        private void timer_lista1_Tick(object sender, EventArgs e)
        {
            if (btimer1 == true)
            {
                //btimer1 = false;
                timer_lista1.Enabled = false;
                string code = wb.Document.Body.InnerHtml;

                //MessageBox.Show(get_num_pages().ToString());
                get_users(code);
                //wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={\"user_scope\":1}&category=people&page_no=1");
                if (btimerlist == false)
                {
                    timer_list.Enabled = true;
                }

            }
            else
            {
                btimer1 = true;
            }
        }
        private void timer_list_Tick(object sender, EventArgs e)
        {
            if (btimerlist == true)
            {
                get_users(wb.Document.Body.InnerHtml);
            }
            else
            {
                btimerlist = true;
            }
        }


    }
}

