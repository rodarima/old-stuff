using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Media;

namespace Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double prim(double a)
        {
            double cont = 0, contneg = 0;
            for (int b = 1; a >= b; b++)
            {
                double c = a / b;
                double d = c % 2;
                if (d == 0 || d == 1)
                {
                    cont++;
                }
                else
                {
                    contneg++;
                }
            }
            if (cont == 2)
            {
                return a;
            }
            else
            {
                int g = 0;
                return g;
            }
        }
        void AddDebug(string texto)
        {
            debug.Text += texto;
            //debug.SelectionStart = debug.Text.Length;
            //debug.ScrollToCaret();
            //debug.Refresh();
            //Linfo.Text = texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {

                double max = Convert.ToDouble(n.Text);
                double tot = 0;
                double mip = 0;
                for (int w = 1; w <= max; w++)
                {
                    double t = prim(w);
                    if (t > 0)
                    {
                        //Console.WriteLine("Nuevo primo encontrado ------------------> "+t);
                        tot++;
                        mip = t;
                        //primos[contl] = t;

                    }
                    AddDebug(mip + ", ");
                }


        }
    }
}