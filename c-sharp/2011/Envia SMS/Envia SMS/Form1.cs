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
using System.Threading;

namespace Envia_SMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wBro.Navigate("http://www.enviado.es/index.php");
            //MessageBox.Show(ReadWeb("http://www.enviado.es/index.php"));
            string Code = ReadWeb("http://www.enviado.es/index.php");
            //tx.Text = Code;
            int sms = GetNumSms(Code, "<div id=\"tequedan\"><span class=\"colorfosfo\">");
            MessageBox.Show("Te quedan: " + sms.ToString() + " SMS");
            

        }

        int GetNumSms(string Text, string Start)
        {
            int loc1 = Text.LastIndexOf(Start);
            string t2 = Text.Substring(loc1+Start.Length, 1);
            int num = Convert.ToInt32(t2);
            return num;
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
                str = str.Replace("\\\"", "\"");
                builder.AppendLine(str);
                str = reader.ReadLine();
            }
            data.Close();
            return builder.ToString();
        }

        private void send_Click(object sender, EventArgs e)
        {
            
            if (wBro.ReadyState == WebBrowserReadyState.Complete) { 
                wBro.Document.GetElementById("mobile").InnerText = number.Text;
                wBro.Document.GetElementById("message").InnerText = cuerpo.Text;

                wBro.Document.GetElementById("submit0").InvokeMember("click"); }
            

                


        }
    }
}
