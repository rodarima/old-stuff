using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace quiz_taco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.facebook.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (i < 40)
                {
                    timer1.Stop();
                    webBrowser1.Navigate("javascript:a154089927959840_do_vote('55006','100001684248655',true);");
                    i++;
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    i = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
