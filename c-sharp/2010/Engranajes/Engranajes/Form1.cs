using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Engranajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reproducir();
        }
        void Reproducir()
        {
    
            if (Eng1.Enabled == false){Eng1.Enabled = true;Borrar();}else{ Eng1.Enabled = false; }
            //En1 = Convert.ToInt32(E1.Text);
            //Ve1 = Convert.ToInt32(N1.Text);
            //Borrar();
            //DibEng();
            //CrearEngrDientes(100, 100, 15,10);
            //CrearEngrDientes(265, 100, 14,10);


        }
        int Grad_s1 = 0;
        int Rpm1 = 0;
        int Grad_s2 = 0;
        int Rpm2 = 0;
        int cvar = 10;
        //int En1;
        //int Ve1;
        void CrearEngrDientes(int x,int y,int Z,int Grad_s,Color ColorLinea,int Grosor)
        {
            //CrearEngranaje(100,D, Color.Black);
            System.Drawing.Pen Lap;
            System.Drawing.Graphics Vect;
            
            if (Grad_s1 > 360) Grad_s1 -= 360;
            //if (Grad_s2 > 360) Grad_s2 -= 360;
            if (Grad_s > 360) Grad_s -= 360;
            int D = 6 * Z;
            double a = 2*Math.PI/Z;
            //Calcular rpm a rad/ms
            double rad_ms = (Grad_s *Math.PI * D) /( 1000 * 60 );
            
            a +=  rad_ms/10 ;
            
            for (int i = 0; i < Z; i++)
            {
                int Rh = 3;
                int Dh = 2*Rh;
                int R = D / 2;
                double x1 = Math.Cos(a) * R;
                double y1 = Math.Sin(a) * R;
                int x1r = Convert.ToInt32( x - x1);
                int y1r = Convert.ToInt32(y - y1);
                Lap = new System.Drawing.Pen(ColorLinea, Grosor);
                Vect = Grafic.CreateGraphics();
                int Arc = Convert.ToInt32(a * 180 / Math.PI);
                Lap = new System.Drawing.Pen(Color.Silver, 1);
                Vect.DrawEllipse(Lap, x - R + (Rh / 2), y - R + (Rh / 2), D - Rh, D - Rh);
                Vect.DrawEllipse(Lap, x-3, y-3, 6, 6);
                Vect.DrawEllipse(Lap, x-1, y-1, 2, 2);
                Lap = new System.Drawing.Pen(ColorLinea, Grosor);
                Vect.DrawArc(Lap, x1r - Rh,y1r - Rh, Dh, Dh, 90+Arc, 180);
                //Vect.DrawLine(Lap, 0, 0, x, y);
                double xhe1 = Math.Cos(a - Math.PI / 2) * Rh;
                double yhe1 = Math.Sin(a - Math.PI / 2) * Rh;
                int xhe1r = Convert.ToInt32(x1r + xhe1);
                int yhe1r = Convert.ToInt32(y1r + yhe1);

                a += (Math.PI/Z);

                int Dp = D;
                int M = Dp/Z;
                int Di= Convert.ToInt32(Dp - 2.0 * M);
                int Ri = Di / 2;
                double x2 = Math.Cos(a) * Ri;
                double y2 = Math.Sin(a) * Ri;
                int x2r = Convert.ToInt32(x - x2);
                int y2r = Convert.ToInt32(y - y2);
                int Arc2 = Convert.ToInt32(a * 180 / Math.PI);
                //Vect.DrawEllipse(Lap, x - Ri, y - Ri, Di, Di);
                Vect.DrawArc(Lap, x2r - Rh, y2r - Rh, Dh, Dh, 285 + Arc, 200);
                //Vect.DrawLine(Lap, x1r, y1r, x2r, y2r);
                double xhi1 = Math.Cos(a - Math.PI / 2) * Rh;
                double yhi1 = Math.Sin(a - Math.PI / 2) * Rh;
                int xhi1r = Convert.ToInt32(x2r - xhi1);
                int yhi1r = Convert.ToInt32(y2r - yhi1);
                double xhi2 = Math.Cos(a - Math.PI / 2) * Rh;
                double yhi2 = Math.Sin(a - Math.PI / 2) * Rh;
                int xhi2r = Convert.ToInt32(x2r + xhi2);
                int yhi2r = Convert.ToInt32(y2r + yhi2);

                Vect.DrawLine(Lap, xhi1r, yhi1r, xhe1r, yhe1r);
                a +=  (Math.PI / Z);


                double x3 = Math.Cos(a) * R;
                double y3 = Math.Sin(a) * R;
                int x3r = Convert.ToInt32(x - x3);
                int y3r = Convert.ToInt32(y - y3);
                


                double xhe2 = Math.Cos(a - Math.PI / 2) * Rh;
                double yhe2 = Math.Sin(a - Math.PI / 2) * Rh;
                int xhe2r = Convert.ToInt32(x3r - xhe2);
                int yhe2r = Convert.ToInt32(y3r - yhe2);


                Vect.DrawLine(Lap, xhi2r, yhi2r, xhe2r, yhe2r);
            }
            
        }
        void Borrar()
        {
            System.Drawing.Graphics Coor;
            Coor = Grafic.CreateGraphics();
            Coor.Clear(System.Drawing.Color.White);
            //Coor.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
        }
        void DibEng()
        {
            
            Aleatorio();


            int CoordX = 100;
            CoordX = CoordX + Convert.ToInt32(E2.Text);
            CoordX = CoordX - Convert.ToInt32(E2.Text) / 2 - Convert.ToInt32(E3.Text) / 2;
            CrearEngranaje(CoordX, Convert.ToInt32(E3.Text), Color.Red);
            CoordX = CoordX + Convert.ToInt32(E3.Text);
            CrearEngranaje(CoordX, Convert.ToInt32(E4.Text), Color.Green);
            CoordX = CoordX + Convert.ToInt32(E4.Text);
        }
        void NumEngranajes(int NumEngranajes, int NumEngSolidar)
        {int CoordX = 100;
        for (int i = 0; i < NumEngranajes; i++)
        {
            CrearEngranaje(CoordX, Convert.ToInt32(E1.Text), Color.Black);
            CoordX = CoordX + Convert.ToInt32(E1.Text);
        }
            if(NumEng.Text=="2")
            {
            CrearEngranaje(CoordX, Convert.ToInt32(E1.Text), Color.Black);
            CoordX = CoordX + Convert.ToInt32(E1.Text);
            CrearEngranaje(CoordX, Convert.ToInt32(E2.Text), Color.Blue);
            }
        }
        void Aleatorio()
        {
            int min = 20;
            int max = 150;
            Random Rd = new Random();
            E1.Text = Convert.ToString(Rd.Next(min, max));
            E2.Text = Convert.ToString(Rd.Next(min, max));
            E3.Text = Convert.ToString(Rd.Next(min, max));
            E4.Text = Convert.ToString(Rd.Next(min, max));
        }
        void CrearEngranaje(int CoordX, int Diametro, System.Drawing.Color Color)
        {
            System.Drawing.Pen Lap;
            System.Drawing.Graphics Vect;
            int CoordY = 100;
            Lap = new System.Drawing.Pen(Color, 1);
            Vect = Grafic.CreateGraphics();
            Vect.DrawEllipse(Lap, CoordX, CoordY - Diametro / 2, Diametro, Diametro);
            //Vect.DrawLine(Lap, 0, 100, 500, 100);
            LineaTrazoPuntoHoriz(0, 100, 500);
            LineaTrazoPuntoVert(CoordX + Diametro / 2, 0, 300);
            Vect.Dispose();
        }
        void LineaTrazoPuntoHoriz(int x1, int y1, int x2)
         {
             System.Drawing.Pen Lap;
             System.Drawing.Graphics Vect;
             Lap = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
             Vect = Grafic.CreateGraphics();

             for (int i = 0; i < x2; i += 20)
             {
                 Vect.DrawLine(Lap, x1 + i, y1, x1 + i + 10, y1);
                 Vect.DrawLine(Lap, x1 + i + 10 + 4, y1, x1 + i + 10 + 6, y1);
             }
         }
        void LineaTrazoPuntoVert(int x1, int y1, int y2)
         {
             System.Drawing.Pen Lap;
             System.Drawing.Graphics Vect;
             Lap = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
             Vect = Grafic.CreateGraphics();

             for (int i = 0; i < y2; i += 20)
             {
                 Vect.DrawLine(Lap, x1, y1 + i, x1, y1 + i + 10);
                 Vect.DrawLine(Lap, x1, y1 + i + 10 + 4, x1 , y1+ i + 10 + 6);
             }
         }
        private void Mec_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarMec();
             }
        void CambiarMec()
        {
            if (Mec.Text == "Ruedas dentadas") { L1.Text = "Z1"; L2.Text = "Z2"; L3.Text = "Z3"; L4.Text = "Z4"; }
            if (Mec.Text == "Poleas y ruedas de friccion") { L1.Text = "D1"; L2.Text = "D2"; L3.Text = "D3"; L4.Text = "D4"; }
         
        }
        private void Eng1_Tick(object sender, EventArgs e)
        {
            Borrar();

            
            Dibujar();
        }
        void Dibujar()
        {
            //CrearEngrDientes(185, 100, En1, Grad_s1,Color.White,1);
            int Y = 200;
            int En1 = Convert.ToInt32(E1.Text);
            int Ve1 = Convert.ToInt32(N1.Text);
            int En2 = Convert.ToInt32(E2.Text);
            int GradMed = Convert.ToInt32(60);
            //int Ve2 = Convert.ToInt32(N2.Text);
            Rpm1 += Convert.ToInt32(N1.Text);
            Grad_s1 = Rpm1 * 6 / cvar;
            Rpm2 += Convert.ToInt32(N1.Text) * Convert.ToInt32(E1.Text) / Convert.ToInt32(E2.Text);
            Grad_s2 = Rpm2 * 6 / cvar;
            CrearEngrDientes((6 * En1 / 2) +200, Y, En1, Grad_s1, Color.DarkGray, 1);
            CrearEngrDientes((6 * En1) + 200 + (6 * En2/2), Y , En2, -GradMed * En2-Grad_s2, Color.DarkGray, 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.UpdateStyles();
            this.DoubleBuffered = true;
        CambiarMec();
        //Rpm1 = Grad_s1 / 6;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Borrar();
            Eng1.Enabled = false;
            Grad_s1 = 0;
            Dibujar();
        }
    }
    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            // Set the value of the double-buffering style bits to true.
            this.SetStyle(ControlStyles.DoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint,
            true);

            this.UpdateStyles();
        }
    }

}
