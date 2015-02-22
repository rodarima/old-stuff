using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace TuChat_Interfaz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int x = 0;


        private void Form2_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip( button3, "Ventana principal del chat");

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (timer_chats.Enabled == false)
            {
                x -= 31*4;
                timer_chats.Enabled = true;
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (timer_chats.Enabled == false)
            {
                x += 31*4;
                timer_chats.Enabled = true;
            }
        }
        int avance=16*4;
        private void timer_chats_Tick(object sender, EventArgs e)
        {
            timer_chats.Enabled = false;
            if (panel1.Location.X==x) { timer_chats.Enabled = false; avance = 16*4; return; }
            int x_temp = panel1.Location.X;
            if (x < x_temp)
            {
                panel1.Location = new Point(x_temp - avance, 0);
            }
            else
            {
                panel1.Location = new Point(x_temp + avance, 0);
            }
            avance = avance / 2;
            timer_chats.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            System.IO.StreamReader sr = new System.IO.StreamReader(Environment.CurrentDirectory + @"\lista.txt");
            string lista = sr.ReadToEnd();
            int lines = Regex.Matches(lista, @"(\d)*;(\S| )*;(?<foto>(\S)*);(\S| )*;(\S| )*;").Count;
            for (int i = 0; i < 10; i++)
            {
                string foto = Regex.Matches(lista, @"(\d)*;(\S| )*;(?<foto>(\S)*);(\S| )*;(\S| )*;")[i].Groups["foto"].Value;
                string nombre = Regex.Matches(lista, @"(\d)*;(?<nombre>(\S| )*);(\S)*;(\S| )*;(\S| )*;")[i].Groups["nombre"].Value;
                //imageList1.Images.Add(LoadPicture(foto));
                ListViewItem item = new ListViewItem(nombre,i%9);
                list.Items.Add(item);
            }
            sr.Close();
        }

        private Image LoadPicture(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Image bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }

    }
}
