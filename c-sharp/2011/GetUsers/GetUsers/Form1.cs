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
using System.Text.RegularExpressions;
using System.Threading;

namespace GetUsers
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        CookieContainer Obtener_CookieContainer_movil(string email, string pass)
        {
            
            byte[] buffer = Encoding.ASCII.GetBytes("tuentiemail="+email+"&password="+pass+"&remember=1");
            
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Login&func=process_login");
            WebReq.Method = "POST";
            WebReq.AllowAutoRedirect = false;
            Cookie cookiename = new Cookie();
            cookiename.Name = "cookiename";
            cookiename.Value = "1";
            cookiename.Path = "/";
            cookiename.Domain = "m.tuenti.com";
            CookieContainer cc = new CookieContainer();
            cc.Add(cookiename);
            WebReq.CookieContainer = cc;
            WebReq.ContentType = "application/x-www-form-urlencoded";
            WebReq.KeepAlive = true;
            WebReq.ContentLength = buffer.Length;
            
            
            Stream PostData = WebReq.GetRequestStream();
            //Now we write, and afterwards, we close. Closing is always important!
            PostData.Write(buffer, 0, buffer.Length);
            PostData.Close();
            //Get the response handle, we have no true response yet!
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            CookieCollection co = new CookieCollection();
            WebResp.Cookies=co;
            //Let's show some information about the response
            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            //Now, we read the response (the string), and output it.
            Stream Answer = WebResp.GetResponseStream();
            string Galleta;
            Galleta = WebResp.GetResponseHeader("Set-Cookie");
            Regex r = new Regex(@"tuentiemail=(\S)* expires=(?<expires1>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com,mid=(?<mid>(\w|\d|-|_)*); path=/; domain=.tuenti.com,mid=(\w|\d|-|_)*; path=/; domain=.tuenti.com,lang=(?<lang>(\w|_))*; expires=(?<expires2>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com");
            CookieContainer myCookieContiner = new CookieContainer();
            Cookie cok = new Cookie();
            cok.Name = "tuentiemail";
            cok.Value=email;
            cok.Domain = ".tuenti.com";
            cok.Expires = DateTime.Now.AddYears(1).AddDays(-1);
            cok.Path = "/";
            myCookieContiner.Add(cok);
            cok.Name = "mid";
            cok.Value = Regex.Match(Galleta, @"mid=(?<mid>(\w|\d|-|_)*);").Groups["mid"].Value;
            cok.Path = "/";
            cok.Domain = ".tuenti.com";
            myCookieContiner.Add(cok); 
            cok.Name = "lang";
            cok.Value = Regex.Match(Galleta, @"lang=(?<lang>(\S)*); ").Groups["lang"].Value;
            cok.Expires = DateTime.Now.AddYears(1).AddDays(-6);
            cok.Path = "/";
            cok.Domain = ".tuenti.com";
            myCookieContiner.Add(cok);
            /*
            myCookieContiner.Add(WebResp.Cookies);
            
            
            StreamReader _Answer = new StreamReader(Answer);
            MessageBox.Show("response html:" + _Answer.ReadToEnd());
            for(int i =0; i< myCookieContiner.Count;i++){
                MessageBox.Show(WebResp.Cookies[i].Name + " " + WebResp.Cookies[i].Value);
            }
            */
            return myCookieContiner;
            

        }
        private int ConvertToTimestamp(DateTime value)
        {
            //create Timespan by subtracting the value provided from
            //the Unix Epoch
            TimeSpan span = (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());

            //return the total seconds (which is a UNIX timestamp)
            return (int)span.TotalSeconds;
        }
        CookieContainer Obtener_CookieContainer(string email, string pass)
        {
            int timestamp = ConvertToTimestamp(DateTime.Now);
            byte[] buffer = Encoding.ASCII.GetBytes("email=" + email + "&input_password=" + pass + "&timezone=1&timestamp="+timestamp );

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("https://secure.tuenti.com/?m=Login&func=do_login");
            WebReq.Method = "POST";
            WebReq.AllowAutoRedirect = false;/*
            Cookie cookiename = new Cookie();
            cookiename.Name = "cookiename";
            cookiename.Value = "1";
            cookiename.Path = "/";
            cookiename.Domain = "m.tuenti.com";
            CookieContainer cc = new CookieContainer();
            cc.Add(cookiename);
            WebReq.CookieContainer = cc;*/
            WebReq.ContentType = "application/x-www-form-urlencoded";
            WebReq.KeepAlive = true;
            WebReq.ContentLength = buffer.Length;


            Stream PostData = WebReq.GetRequestStream();
            //Now we write, and afterwards, we close. Closing is always important!
            PostData.Write(buffer, 0, buffer.Length);
            PostData.Close();
            //Get the response handle, we have no true response yet!
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            CookieCollection co = new CookieCollection();
            WebResp.Cookies = co;
            //Let's show some information about the response
            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            //Now, we read the response (the string), and output it.
            Stream Answer = WebResp.GetResponseStream();
            string Galleta;
            Galleta = WebResp.GetResponseHeader("Set-Cookie");
            textBox1.Text = Galleta; 
            //MessageBox.Show(Galleta);
            //Regex r = new Regex(@"tuentiemail=(\S)* expires=(?<expires1>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com,mid=(?<mid>(\w|\d|-|_)*); path=/; domain=.tuenti.com,mid=(\w|\d|-|_)*; path=/; domain=.tuenti.com,lang=(?<lang>(\w|_))*; expires=(?<expires2>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com");
            CookieContainer myCookieContiner = new CookieContainer();
            Cookie cok = new Cookie();
            cok.Name = "SignatureToken";
            cok.Value = Regex.Match(Galleta,@"SignatureToken=(?<sig>(\S)*);").Groups["sig"].Value;
            cok.Domain = ".tuenti.com";
            cok.HttpOnly = true;
            cok.Secure = true;
            cok.Path = "/";
            myCookieContiner.Add(cok);


            cok = new Cookie();
            cok.Name = "sid";
            cok.Value = Regex.Match(Galleta, @"sid=(?<sid>(\S)*);").Groups["sid"].Value;
            cok.Path = "/";
            cok.Domain = ".tuenti.com";
            myCookieContiner.Add(cok);


            cok = new Cookie();
            cok.Name = "lang";
            cok.Value = Regex.Match(Galleta, @"lang=(?<lang>(\S)*); ").Groups["lang"].Value;
            cok.Expires = DateTime.UtcNow.AddYears(1).AddDays(-6);
            cok.Path = "/";
            cok.Domain = ".tuenti.com";
            myCookieContiner.Add(cok);
            /*
            myCookieContiner.Add(WebResp.Cookies);
            
            
            StreamReader _Answer = new StreamReader(Answer);
            MessageBox.Show("response html:" + _Answer.ReadToEnd());
            for(int i =0; i< myCookieContiner.Count;i++){
                MessageBox.Show(WebResp.Cookies[i].Name + " " + WebResp.Cookies[i].Value);
            }
            */
            return myCookieContiner;
        }
        void Obtener_lista_amigos_movil(CookieContainer cc,int index)
        {/*
            if (index % 8 == 0)
            {

                HttpWebRequest WebReq1 = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com");
                WebReq1.CookieContainer = cc;
                WebReq1.ContentType = "application/x-www-form-urlencoded";
                WebReq1.AllowAutoRedirect = false;
              
                //Get the response handle, we have no true response yet!
                HttpWebResponse WebResp1 = (HttpWebResponse)WebReq1.GetResponse();
                //MessageBox.Show(WebResp.GetResponseHeader("Location"));

                //MessageBox.Show(WebResp.StatusCode.ToString());
                //MessageBox.Show(WebResp.Server);

                Stream Answer1 = WebResp1.GetResponseStream();
                Answer1.Close();
            }
            */

            if (index % 5 == 0) { MessageBox.Show(index.ToString()); }
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Friends&page="+index.ToString()+"&query=");
            WebReq.CookieContainer = cc;
            WebReq.ContentType = "application/x-www-form-urlencoded";
            WebReq.Referer = "http://m.tuenti.com/?m=Friends&page="+index.ToString()+"&query=";
            WebReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            WebReq.AllowAutoRedirect = false;
            WebReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";

            //Get the response handle, we have no true response yet!
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            //MessageBox.Show(WebResp.GetResponseHeader("Location"));
            
            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            Stream Answer = WebResp.GetResponseStream();
            StreamReader _Answer = new StreamReader(Answer);
            textBox1.Text += _Answer.ReadToEnd();
            Thread.Sleep(2000);
            _Answer.Close();
            Answer.Close();
            //MessageBox.Show("response html:" + _Answer.ReadToEnd());


        }
        int  Obtener_numero_paginas_amigos_movil(CookieContainer cc)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Friends&page=0&query=");
            WebReq.CookieContainer = cc;
            WebReq.ContentType = "application/x-www-form-urlencoded";
            WebReq.Referer = "http://m.tuenti.com/?m=Home&func=index";
            WebReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            WebReq.AllowAutoRedirect = false;
            WebReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";

            //Get the response handle, we have no true response yet!
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            //MessageBox.Show(WebResp.GetResponseHeader("Location"));
            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            Stream Answer = WebResp.GetResponseStream();
            StreamReader _Answer = new StreamReader(Answer);
            string code = _Answer.ReadToEnd();
            code = Regex.Match(code, "<small class=\"counter\">1 - 5 de (?<amigos>("+ @"\d"+")*) amigos</small>").Groups["amigos"].Value;
            int amigos = Convert.ToInt32(code);
            int pag = amigos / 5;
            MessageBox.Show(code + " " + pag.ToString());
            //textBox1.Text += _Answer.ReadToEnd();
            //MessageBox.Show("response html:" + _Answer.ReadToEnd());
            return pag;

        }
        int Obtener_numero_paginas_amigos(CookieContainer cc)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=0");
            WebReq.CookieContainer = cc;
            WebReq.ContentType = "application/x-www-form-urlencoded";
            WebReq.Referer = "http://www.tuenti.com/#m=Home&func=index";
            WebReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            WebReq.AllowAutoRedirect = false;
            WebReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";

            //Get the response handle, we have no true response yet!
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            MessageBox.Show(WebResp.GetResponseHeader("Location"));
            MessageBox.Show(WebResp.StatusCode.ToString());
            MessageBox.Show(WebResp.Server);

            Stream Answer = WebResp.GetResponseStream();
            StreamReader _Answer = new StreamReader(Answer);
            string code = _Answer.ReadToEnd();
            textBox1.Text = code;
            /*code = Regex.Match(code, "<small class=\"counter\">1 - 5 de (?<amigos>(" + @"\d" + ")*) amigos</small>").Groups["amigos"].Value;
            int amigos = Convert.ToInt32(code);
            int pag = amigos / 5;
            MessageBox.Show(code + " " + pag.ToString());*/
            //textBox1.Text += _Answer.ReadToEnd();
            //MessageBox.Show("response html:" + _Answer.ReadToEnd());
            return 0;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CookieContainer c = Obtener_CookieContainer("xxxxxxxxxxx@gmail.com", "xxxxxx");
            int pag = Obtener_numero_paginas_amigos(c);
            /*for(int i=0; i<pag;i++){
                
                Obtener_lista_amigos_movil(c,i);
            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=0");
        }

        string[] users_id;
        string[] users_nombre;
        string[] users_estado;
        string[] users_ciudad;
        string[] users_provincia;
        string[] users_foto;
int user_num = 0;


        int get_num_users(string code)
        {
            string num = Regex.Match(code, @"<SPAN class=result>\((?<num_amigos>(\d)*) resultados\) </SPAN>").Groups["num_amigos"].Value;
            if (num != "")
            {
                int n = Convert.ToInt32(num);
                users_id = new string[n];
                users_nombre= new string[n];
                users_estado= new string[n];
                users_ciudad = new string[n];
                users_provincia = new string[n];
                users_foto = new string[n];
                return n;
            }
            return 0;
        }
        int get_num_pages(int num_amigos)
        {
            double pages = (double)num_amigos / 10;
            int intpages = num_amigos / 10;
            
            if (pages - intpages != 0.0) { return intpages + 1; }
            return intpages;
        }
        

        void get_users()
        {
            string code = wb.Document.Body.InnerHtml;

            if (users_id == null)
            {
                get_num_users(code);
            }


            int t = Regex.Matches(code, @"user_item_(?<user_id>(\d)*) class=").Count;
            //textBox1.Text += t.ToString();

            if (t != 0 && user_num <= users_id.Length)
            {
                bool repetido = false;
                for (int i = 0; i < t; i++)
                {
                    try
                    {

                        users_id[user_num] = Regex.Matches(code, @"user_item_(?<user_id>(\d)*) class=")[i].Groups["user_id"].Value;
                        users_nombre[user_num] = Regex.Matches(code, @"<IMG( class="" outsideNetwork"")* alt=""(?<user_nombre>(\S| )*)"" src")[i].Groups["user_nombre"].Value;
                        users_foto[user_num] = Regex.Matches(code, @"src=""(?<user_foto>(\S)*)"" width=100 height=100")[i].Groups["user_foto"].Value;
                        users_ciudad[user_num] = Regex.Matches(code, @"<SPAN class=definition>Ubicación</SPAN>(\s)*(?<user_ciudad>(\w| |,|-|_)*),(\s)*<A title=""*(?<user_provincia>(\w|\s)*)""* onclick")[i].Groups["user_ciudad"].Value;
                        users_provincia[user_num] = Regex.Matches(code, @"<SPAN class=definition>Ubicación</SPAN>(\s)*(?<user_ciudad>(\w| |,|-|_)*),(\s)*<A title=""*(?<user_provincia>(\w|\s)*)""* onclick")[i].Groups["user_provincia"].Value;

                        repetido = false;
                        for (int j = 0; j < user_num; j++)
                        {
                            if (users_id[j] == users_id[user_num])
                            {
                                repetido = true;
                            }
                        }
                        if (repetido == false)
                        {
                            user_num++;
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("Problema con" + user_num);

                    }

                    
                }
                if (repetido == true) { page--; }
                
                
                if (user_num <= users_id.Length)
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
                    for (int i = 0; i < users_id.Length; i++)
                    {
                        sw.WriteLine(users_id[i] + ";" + users_nombre[i] + ";" + users_foto[i] + ";" + users_ciudad[i] + ";" + users_provincia[i] +";");
                        textBox1.Text += i.ToString() + ": " + users_id[i] + " - " + users_nombre[i] + " - " + users_ciudad[i] + " - " + users_provincia[i] + Environment.NewLine;
                    }
                }
            }

        }
        void nav(int page)
        {
            wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=" + page.ToString());
        }
        bool first_timer_lista_1 = true;
        bool btimer1 = false;
        int page = 0;
        string email = "xxxxxxx@gmail.com";
        string pass = "xxxxxxx";
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btimer1 == true)
            {
                //btimer1 = false;
                timer_lista1.Enabled = false;
                string code = wb.Document.Body.InnerHtml;
                
                //MessageBox.Show(get_num_pages().ToString());
                get_users();
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
                get_users();
            }
            else
            {
                btimerlist = true;
            }
        }
    }
}
