using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string fname1, fname2;
        Bitmap img1, img2;
        int count1 = 0, count2 = 0, c3=0;
        bool flag = true;




        private void button1_Click_1(object sender, EventArgs e)
        {
            progressBar1.Visible = true;

            string img1_ref, img2_ref;
            double r1, g1, b1, r2, g2, b2;
            double rr, gg, bb, rgb, por=0;
            double similitud;
            img1 = new Bitmap(fname1);
            img2 = new Bitmap(fname2);

            progressBar1.Maximum = img1.Width;
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {

                        r1 = img1.GetPixel(i, j).R;
                        g1 = img1.GetPixel(i, j).G;
                        b1 = img1.GetPixel(i, j).B;

                        r2 = img2.GetPixel(i, j).R;
                        g2 = img2.GetPixel(i, j).G;
                        b2 = img2.GetPixel(i, j).B;

                        rr = Math.Abs(r1 - r2) / 256;
                        gg = Math.Abs(g1 - g2) / 256;
                        bb = Math.Abs(b1 - b2) / 256;
                        rgb = (rr + gg + bb) / 3;
                        por += rgb;
                        c3++;
                        //MessageBox.Show(Convert.ToString(rgb * 100));
                        //img2_ref = img2.GetPixel(i, j).B.ToString();

                        if (rgb>0.05)
                        {
                            //MessageBox.Show(img1_ref + "/" + img2_ref);
                            count2++;
                            flag = false;
                            break;

                        }
                        count1++;

                    }
                    progressBar1.Value++;
                }
                similitud = 100 - ((por / c3) * 100);

                if (flag == false)
                    MessageBox.Show("Sorry, Images are not same , " + count2 + " wrong pixels found, " + similitud.ToString("0.00") + "% the same");
                else
                    MessageBox.Show(" Images are same , " + count1 + " same pixels found  and " + count2 + " wrong pixels found");
            }
            else
                MessageBox.Show("can not compare this images");

            this.Dispose();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;



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
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog2.FileName = ""; // Setting the opefiledialog to default 
            openFileDialog2.Title = "Images"; // Title of the dialog 
            openFileDialog2.Filter = "All Images|*.jpg; *.bmp; *.png"; // In the filter you should write all the types of image 

            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName.ToString() != "")
            {
                fname2 = openFileDialog2.FileName.ToString();
            }
        }

    }
}
