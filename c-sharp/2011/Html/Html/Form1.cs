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

namespace Html
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pURL = "http://www.tuenti.com/?m=login";
            //tx.Text = ReadWeb(pURL);

            ServicePointManager.CertificatePolicy = new MyCertPolicy();
            ServicePointManager.Expect100Continue = false;
            // creating login data
            ASCIIEncoding encoding = new ASCIIEncoding();
            string userName = "xxxxxxxxxxxx";
            string passwd = this.Passwd;
            string timeZone = "1";
            string remember = "1";
            string postData = "email=" + userName + "&input_password="
                + passwd + "&timezone=" + timeZone + "&remember=" + remember;
            byte[] data = encoding.GetBytes(postData);


            // login request to tuenti
            HttpWebRequest hwr =
                (HttpWebRequest)WebRequest.Create(
                        "http://www.tuenti.com/?m=Login&func=do_login");
            Console.WriteLine(hwr.RequestUri.AbsoluteUri);
            hwr.Method = "POST";
            hwr.ContentType = "application/x-www-form-urlencoded";
            hwr.ContentLength = data.Length;
            Stream newStream = hwr.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();
            hwr.AllowAutoRedirect = false;


            HttpWebResponse response = (HttpWebResponse)hwr.GetResponse();
            string cookieString = response.GetResponseHeader("set-cookie");
            this.cookie = new Cookie("sid", cookieString.Substring(4, 70));
            this.cookie.Expires = DateTime.Parse(cookieString.Substring(84, 29));
            this.cookie.Domain = ".tuenti.com";
            this.cookie.Path = "/";



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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
class MyCertPolicy : ICertificatePolicy
{
    public bool CheckValidationResult(ServicePoint sp, X509Certificate cert,
        WebRequest request, int problem)
    {
        return true;
    }
}
