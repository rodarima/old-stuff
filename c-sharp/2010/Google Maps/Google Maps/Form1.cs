using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Google_Maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://maps.google.es/maps/ms?ie=UTF8&hl=es&t=k&msa=0&msid=113315219920275671055.00048e354d609945d0ff5&ll=43.280252,-8.211014&spn=0.00931,0.021136&z=16");
        }
    }
}
