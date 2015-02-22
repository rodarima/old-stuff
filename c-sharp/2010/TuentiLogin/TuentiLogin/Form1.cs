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
using System.Xml.Schema; 

using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace TuentiLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer, true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wBro.Visible = true;
            wBro.Navigate("http://www.tuenti.com/");
        }

        private void wBro_DocumentCompleted(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (wBro.Url.ToString() == "http://www.tuenti.com/#m=home&func=view_home")
            {
                pReg.Visible = false;
                //wBro.Visible = false;

                tx1.Text = wBro.DocumentText;
            }
        }
        private string ReadWeb(string pURL)
        {

            StringBuilder builder = new StringBuilder();
            WebClient client = new WebClient();
            Stream data = client.OpenRead(pURL);
            StreamReader reader = new StreamReader(data);
            string str = "";
            str = reader.ReadLine();
            while (str != null)
            {
                builder.AppendLine(str);
                str = reader.ReadLine();
            }
            data.Close();
            return builder.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (wBro.Document != null)
            {
                wBro.Document.GetElementById("email").InnerText = txEmail.Text;
                wBro.Document.GetElementById("input_password").InnerText = txPass.Text;
                wBro.Document.GetElementById("remember").SetAttribute("checked", "true");
                wBro.Document.GetElementById("submit_button").InvokeMember("click");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e){txEmail.Text = "";}
        private void txPass_TextChanged(object sender, EventArgs e) { txPass.Text = ""; txPass.PasswordChar = '*'; }

        private void Form1_Load(object sender, EventArgs e)
        {
            wBro.Visible = true;
            //wBro.Navigate("http://www.tuenti.com/");
            Lvisitas.Text = views();
        }

        private void txPass_TextChanged_1(object sender, EventArgs e)
        {
            txPass.PasswordChar = '*';
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tx1.Text = wBro.Document.Body.OuterHtml;
            //tx1.Text = wBro.Document.Body.InnerText;
            //wBro.Document.GetElementById("new events").InnerText = "ewr";
            string[] EventosSep = { "href=\"http://www.tuenti.com/#m=Agenda&amp;func=view_event_invitations\">", "</A></LI></UL></DIV></DIV>" };
            string[] Eventos = tx1.Text.Split((EventosSep), StringSplitOptions.RemoveEmptyEntries);
            
            tx1.Text = Eventos[3];

        }

        private void txEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            tx2.Text = views();

            }

        string views()
        {
            try
            {
                string code = wBro.Document.Body.OuterHtml.ToLower();
                int views1 = code.IndexOf("<div class=views><strong>") + 25;
                int views2 = code.IndexOf("</strong> visitas a tu perfil</div>");
                return code.Substring(views1, views2 - views1);
            }
            catch
            {
                return "Error";
            }
            }
        
        
    }
}
