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
        Bitmap img, img1, img2, patron, pat_fail;
        int count1 = 0, count2 = 0, c3=0;
        bool flag = true;
        private void button1_Click_1(object sender, EventArgs e)
        {
            comparar();
        }
        double comparar(){
            img1 = new Bitmap(fname1);
            //img2 = new Bitmap(fname2);
            img2 = f.rec(img1);

            rec.Image = img2;
            int img_w = img2.Width;
            int img_h = img2.Height;
            //ratio = x/y
            double ratio = Convert.ToDouble(img_w) / Convert.ToDouble(img_h);
            int cont_height = 30;
            int width = Convert.ToInt32(ratio * cont_height);

            img2 = f.resize(img_temp, width, cont_height);
            mod.Image = img2;





            img2 = f.resize(img2, patron.Width, patron.Height);
            img2 = f.cont(img2,400);



            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            g.DrawImage(img2, 0, 0, img2.Width, img2.Height);
            // Create a Matrix object, call its Rotate method,
            // and set it as Graphics.Transform
            Matrix X = new Matrix();
            X.Shear(1, 2);
            g.Transform = X;
            // Draw image
            g.DrawImage(img2,
                new Rectangle(205, 0, 200, 200),
                0, 0, img2.Width,
                img2.Height,
                GraphicsUnit.Pixel);
            // Dispose of objects
            g.Dispose();



            mod.Image = img2;
            pat.Image = patron;

            double sim = 0;


            sim = f.comp(img2, patron,0.4);

            //MessageBox.Show(comp(img2, patron).ToString());
            Bitmap orig = img2;
            Bitmap pt = patron;
            img2 = Sobel_x(orig);
            patron = Sobel_x(patron);
            mod1.Image = img2;
            pat1.Image = patron;

            sim += f.comp(img2, patron,0.4);
            //MessageBox.Show(comp(img2, patron).ToString());

            mod2.Image = Sobel_y(orig);


            
            pat2.Image = Sobel_y(patron);






            //Comparar con la letra A

            return f.comp(img2,patron,0.4);
                

            
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
            img = new Bitmap(fname1);
            this.original.Image = img;
        }
        string[] let = { "a", "b", "c", "d", "e", "f", "g" }; int i = 0;
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double aciert = 0;
            string letter = "";
            for (int i = 0; i < let.Length; i++)
            {
                fname2 = @"patron\patron_" + let[i] + ".png";
                patron = new Bitmap(fname2);
                //this.pat.Image = patron;
                double compar = comparar();
                if (compar > aciert)
                {
                    aciert = compar;
                    letter = let[i];
                }
            }
            fname2 = @"patron\patron_" + letter + ".png"; patron = new Bitmap(fname2); double c = comparar();
            textBox1.Text = letter.ToUpper() + " " + (aciert*100).ToString() + " %";
            l.Text = letter.ToUpper();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (i >= let.Length) { i = 0; }
            double aciert = 0;
            string letter = "";

                fname2 = @"patron\patron_" + let[i] + ".png";
                patron = new Bitmap(fname2);
                //this.pat.Image = patron;
                double compar = comparar();

                    aciert = compar;
                    letter = let[i];

            
            textBox1.Text = letter.ToUpper() + " " + (aciert * 100).ToString() + " %";
            l.Text = letter.ToUpper();
            i++;
        }
    }
}
