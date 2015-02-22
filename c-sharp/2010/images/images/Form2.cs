using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace images
{
    public partial class Form1 : Form
    {
        fn f = new fn();
        public Form1()
        {
            InitializeComponent();
        }
        static string fname1, fname2;
        Bitmap patron, pat_fail;
        int count1 = 0, count2 = 0, c3 = 0;
        bool flag = true;

        double indent(Bitmap img)
        {


            img = f.rec(img);
            rec.Image = img;

            /*
            int img_w = img.Width;
            int img_h = img.Height;
            //ratio = x/y
            double ratio = Convert.ToDouble(img_w) / Convert.ToDouble(img_h);
            int cont_height = 30;
            int width = Convert.ToInt32(ratio * cont_height);

            img = f.resize(img, width, cont_height);
            mod.Image = img2;
            */



            img = f.resize(img, patron.Width, patron.Height);
            img = f.contrast(img, 400);
            //img = f.to_bn(img);
            //patron = f.to_bn(patron);

            Bitmap i = f.alisar(img, 0.3);
            Bitmap p = f.alisar(patron, 0.3);


            mod.Image = i;
            pat.Image = p;

            double img_patron = f.cmpDouble(i, p, 0.3);
            img_pt.Text = img_patron.ToString();
            cmp_img_patron.Image = f.cmpBitmap(i, p, 0.3);


            Bitmap sob_x = f.sobel_x(i);
            Bitmap pt_sob_x = f.sobel_x(p);

            sob_x_img.Image = sob_x;
            sob_x_pat.Image = pt_sob_x;

            double sob_x_double = f.cmpDouble(sob_x, pt_sob_x, 0.3);
            sx.Text = sob_x_double.ToString();
            cmp_sobel_x.Image = f.cmpBitmap(sob_x, pt_sob_x, 0.3);

            Bitmap sob_y = f.sobel_y(i);
            Bitmap pt_sob_y = f.sobel_y(p);

            sob_y_img.Image = sob_y;
            sob_y_pat.Image = pt_sob_y;

            double sob_y_double = f.cmpDouble(sob_y, pt_sob_y, 0.3);
            sy.Text = sob_y_double.ToString();
            cmp_sobel_y.Image = f.cmpBitmap(sob_y, pt_sob_y, 0.3);

            double s = (img_patron + sob_x_double + sob_y_double) / 3;
            tt.Text = s.ToString();

            /*
            mod1.Image = sob_x;
            pat1.Image = pt_sob_x;
            sob_x = f.cmpBitmap((Bitmap)mod1.Image, (Bitmap)pat1.Image, 0.3);
            //sx.Text = f.comp(sob_x, pt_sob_x, 0.1).ToString();
            cmp_sobel_x.Image = sob_x;
            //mod1_f.Image = f.pat_fail;
            */
            //MessageBox.Show(comp(img2, patron).ToString());
            /*
            mod2.Image = f.sobel_y(orig);


            
            pat2.Image = f.sobel_y(patron);


            */



            //Comparar con la letra

            return s;



            //MessageBox.Show(similitud.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.FileName = ""; // Setting the opefiledialog to default 
            openFileDialog1.Title = "Images"; // Title of the dialog 
            openFileDialog1.Filter = "All Images|*.jpg; *.bmp; *.png"; // In the filter you should write all the types of image 

            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString() != "")
            {
                fname1 = openFileDialog1.FileName.ToString();
            }
            Bitmap img = new Bitmap(fname1);
            this.original.Image = img;
        }
        string[] let = { "a", "b", "c", "d", "e", "f", "g" }; int i = 0;
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            double aciert = 0;
            string letter = "";
            Bitmap img = new Bitmap(fname1);
            for (int i = 0; i < let.Length; i++)
            {
                fname2 = @"patron\patron_" + let[i] + ".png";
                patron = new Bitmap(fname2);
                //this.pat.Image = patron;
                double compar = indent(img);
                if (compar > aciert)
                {
                    aciert = compar;
                    letter = let[i];
                }
            }
            fname2 = @"patron\patron_" + letter + ".png"; patron = new Bitmap(fname2); double c = indent(img);
            //textBox1.Text = letter.ToUpper() + " " + (aciert*100).ToString() + " %";
            l.Text = letter.ToUpper();

            long millisecondsnow = stop.ElapsedMilliseconds;
            stop.Reset();
            MessageBox.Show(millisecondsnow.ToString());
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (i >= let.Length) { i = 0; }
            double aciert = 0;
            string letter = "";
            Bitmap img = new Bitmap(fname1);
            fname2 = @"patron\patron_" + let[i] + ".png";
            patron = new Bitmap(fname2);
            //this.pat.Image = patron;
            double compar = indent(img);

            aciert = compar;
            letter = let[i];


            //textBox1.Text = letter.ToUpper() + " " + (aciert * 100).ToString() + " %";
            l.Text = letter.ToUpper();
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap img = new Bitmap(fname1);
            Bitmap[] sepp = f.letras(img);
            l.Text = "";
            for (int numi = 0; numi < sepp.Length; numi++)
            {
                double aciert = 0;
                string letter = "";
                if (sepp[numi] == null)
                {
                    letter = " ";
                }
                else
                {
                    for (int i = 0; i < let.Length; i++)
                    {
                        fname2 = @"patron\patron_" + let[i] + ".png";
                        patron = new Bitmap(fname2);
                        //this.pat.Image = patron;
                        double compar = indent(sepp[numi]);
                        if (compar > aciert)
                        {
                            aciert = compar;
                            letter = let[i];
                        }
                    }
                    fname2 = @"patron\patron_" + letter + ".png"; patron = new Bitmap(fname2); double c = indent(sepp[numi]);
                }
                //textBox1.Text = letter.ToUpper() + " " + (aciert*100).ToString() + " %";
                l.Text += letter.ToUpper();
                //rec.Image = sepp[numi];
            }
        }


    }
}
