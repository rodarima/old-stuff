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
using System.Xml;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace GetUsersId
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public event WebBrowserNavigatedEventHandler Navigated;
        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool first = true;
        string my_id;
        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.ToString().Contains("category=people"))
            {
                if (first == true && webBrowser1.Url.ToString().Contains("category=people"))
                {
                    string code = webBrowser1.Document.Body.InnerHtml;
                    string jid = Regex.Match(code, @"xmpp(?<xmpp_number>(\d)+).tuenti.com").Value;
                    tjid.Text = jid;
                    pass_id = code.Substring(34, 43);
                        pass.Text = pass_id;
                        tpass.Text = pass_id;
                        Clipboard.SetText(pass_id);
                        string[] id = { "\"Logout.do_logout\",\"post_params\":{\"user_id\":" };
                        string[] _id = code.Split(id, StringSplitOptions.RemoveEmptyEntries);
                        my_id = _id[1].Substring(0, 8);
                        idtext.Text = my_id;
                        tuser.Text = my_id;
                    try
                    {
                        
                        string[] last = { "<A class=last onclick=\"UI.flip_pager.click('?m=Multiitemsearch&amp;func=index&amp;string=&amp;filters=%7B%22user_scope%22%3A1%7D&amp;category=people&amp;page_no=", "&amp;ajax=1&amp;store=1&amp;ajax_target=canvas', [], []); return false;" };
                        string[] _last = code.Split(last, StringSplitOptions.RemoveEmptyEntries);
                        pages = Convert.ToInt32(_last[2]);
                        first = false;
                        
                    }
                    catch { first = true; }
                }


                if (work == true)
                {

                    if (webBrowser1.Url.ToString().Contains("category=people"))
                    {
                        timer1.Start();

                    }
                }
            }
            //list_users();
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //list_users();
            //MessageBox.Show(webBrowser1.Document.ToString());
        }

        string[] user_name=new string[500];
        string[] user_id=new string[500];
        string[] splited = new string[500];
        int u = 0;
        int pag = 0;
        string pass_id;
        int pages = 1;
        bool work = false;
        void navig()
        {
            if (pag <= pages)
            {
                getusers();
                list_users();
                webBrowser1.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=" + pag.ToString());
                pag++;
            }
            else
            {
                work = false;
            }
        }
        void getusers()
        {
            string code = webBrowser1.Document.Body.InnerHtml;
            string[] s_prev = { "return false;\" href=\"http://www.tuenti.com/#m=Profile&amp;func=index&amp;user_id=" };
            splited = code.Split(s_prev, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splited.Length; i++)
            {
                if (splited[i].Substring(8, 12) == "\"><IMG alt=\"")
                {
                    if (!user_id.Contains(splited[i].Substring(0, 8)))
                    {

                        user_id[u] = splited[i].Substring(0, 8);
                        user_name[u] = splited[i].Substring(20);
                        string[] sep1 = { "\" src=\"" };
                        string[] a = user_name[u].Split(sep1, StringSplitOptions.RemoveEmptyEntries);
                        user_name[u] = a[0];
                        u++;
                    }
                }

            }
            
        }

        void list_users()
        {
            getusers();
            for (int i = 0; i < user_id.Length; i++)
            {
                if (user_id[i] != null)
                {
                    string xml = "			<contact>" + Environment.NewLine + "				<buddy account=\'";
                    xml += idtext.Text;
                    xml += "@xmpp1.tuenti.com/' proto='prpl-jabber'>" + Environment.NewLine + "					<name>";
                    xml += user_id[i];
                    xml += "@xmpp1.tuenti.com</name>" + Environment.NewLine + "					<alias>";
                    xml += user_name[i];
                    xml += "</alias>" + Environment.NewLine + "				</buddy>" + Environment.NewLine + "			</contact>";
                    textBox1.Text += xml + Environment.NewLine;
                }
            }
            user_name = null;
            user_id = null;
            splited = null;
            user_name = new string[500];
            user_id = new string[500];
            splited = new string[500];
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            work = true;
            if (!webBrowser1.Url.ToString().Contains("category=people"))
            {
                webBrowser1.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=0");
                timer1.Start();
            }
            else
            {
                navig();
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=" + pag.ToString());
            pag++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (webBrowser1.Url.ToString().Contains("category=people"))
            {
                navig();
            }
            else
            {
                pag -= 1;
                webBrowser1.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=" + pag.ToString());
                timer1.Start();
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = Environment.UserName;
            if (System.IO.Directory.Exists(@"C:\Users\"+ user + @"\AppData\Roaming\.purple\"))
            {
            MessageBox.Show("Antes de continuar asegurate de haber salido completamente de Pidgin");
            using (StreamWriter sw = new StreamWriter(@"C:\Users\"+ user + @"\AppData\Roaming\.purple\blist.xml"))
            {
                // Add some text to the file.
                sw.WriteLine("<?xml version='1.0' encoding='UTF-8' ?><purple version='1.0'><blist><group name='Tuenti'>");
                sw.WriteLine(textBox1.Text);
                sw.WriteLine("</group></blist></purple>");
                MessageBox.Show("Contactos añadidos correctamente");
            }}
                else {
                MessageBox.Show("Por favor, primero instala pidgin, y crea una cuenta como explica en la pestaña de \"Configuracion de pidgin\"");
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user = Environment.UserName;
            if (System.IO.Directory.Exists(@"C:\Users\" + user + @"\AppData\Roaming\.purple\"))
            {
                MessageBox.Show("Antes de continuar asegurate de haber salido completamente de Pidgin");
                using (StreamWriter sw = new StreamWriter(@"C:\Users\" + user + @"\AppData\Roaming\.purple\blist.xml"))
                {
                    // Add some text to the file.
                    sw.WriteLine("<?xml version='1.0' encoding='UTF-8' ?><purple version='1.0'><blist><group name='Tuenti'>");
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine("</group></blist></purple>");
                }
            }
            else
            {
                MessageBox.Show("Por favor, primero instala pidgin, y crea una cuenta como explica en la pestaña de \"Configuracion de pidgin\"");
            }
        }


    }
}
