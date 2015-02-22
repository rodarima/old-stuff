using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            System.Drawing.Graphics Coor;
            Coor = Graph.CreateGraphics();
            Coor.Clear(System.Drawing.Color.White);


        }
        public void DibCoord(int Ancho)
        {

            
            System.Drawing.Graphics Coor;
            Coor = Graph.CreateGraphics();
            Coor.Clear(System.Drawing.Color.White);
            System.Drawing.Pen Lap;
            System.Drawing.Graphics Vect;
            

            int CoorX = 150, CoorY = 150;
            for (int i = 0; i < 300/Ancho; i++)
            {
                int X = Ancho * i;
                int Y = Ancho * i;
                Lap = new System.Drawing.Pen(System.Drawing.Color.Gainsboro, 1);
                Vect = Graph.CreateGraphics();
                Vect.DrawLine(Lap, CoorX - X, CoorY - 150, CoorX - X, CoorY + 150);
                Vect.DrawLine(Lap, CoorX + X, CoorY - 150, CoorX + X, CoorY + 150);

                Vect.DrawLine(Lap, CoorX - 150, CoorY - Y, CoorX + 150, CoorX - X);
                Vect.DrawLine(Lap, CoorX - 150, CoorY + Y, CoorX + 150, CoorX + X);

                Vect.Dispose();

            }
            CoorX = 150;
            CoorY = 150;
            for (int i = 0; i < 300 / (Ancho*5); i++)
            {
                int X = Ancho * i * 5;
                int Y = Ancho * i * 5;
                Lap = new System.Drawing.Pen(System.Drawing.Color.Silver, 1);
                Vect = Graph.CreateGraphics();

                Vect.DrawLine(Lap, CoorX - X, CoorY - 150, CoorX - X, CoorY + 150);
                Vect.DrawLine(Lap, CoorX + X, CoorY - 150, CoorX + X, CoorY + 150);

                Vect.DrawLine(Lap, CoorX - 150, CoorY - Y, CoorX + 150, CoorX - X);
                Vect.DrawLine(Lap, CoorX - 150, CoorY + Y, CoorX + 150, CoorX + X);

                /*
                Vect.DrawLine(Lap, 0, CoorX, 300, CoorY);
                Vect.DrawLine(Lap, CoorX, 0, CoorX, 300);
                
                 */
                Vect.Dispose();


            }

        }

        void Representar(int X, int Y,int X2,int Y2, int Z)
        {
            try
            {
                int CoordX = 150;
                int CoordY = 150;
                int PxU = Z;
                X = CoordX + PxU * X;
                Y = CoordY - PxU * Y;
                X2 = CoordX + PxU * X2;
                Y2 = CoordY - PxU * Y2;

                System.Drawing.Pen Dot;
                System.Drawing.Graphics Line;
                Dot = new System.Drawing.Pen(Color.Black, 1);
                Line = Graph.CreateGraphics();
                Line.DrawLine(Dot, X, Y, X2, Y2);
            }
            catch { }
        }
        int Y0 = 0;
        int funcion_X_Y(int X)
        {
                int Y = 0;
                string OperandoX = "";
                double ExponenteX = 1;
                double MultiplicadorX = 1;
                double TerminoIndependienteX = 0;
                if (OperX.Text == "") { OperandoX = ""; } else { OperandoX = OperX.Text; }
                if (ExpX.Text == "") { ExponenteX = 1; } else { ExponenteX = Convert.ToDouble(ExpX.Text); }
                if (MultiX.Text == "") { MultiplicadorX = 1; } else { MultiplicadorX = Convert.ToDouble(MultiX.Text); }
                if (TerIndX.Text == "") { TerminoIndependienteX = 0; } else { TerminoIndependienteX = Convert.ToDouble(TerIndX.Text); }


                if (OperandoX == "")
                {
                    Y = Convert.ToInt32((MultiplicadorX * (Math.Pow(X, ExponenteX))));
                }
                if (OperandoX == "+")
                {
                    Y = Convert.ToInt32((MultiplicadorX * (Math.Pow(X, ExponenteX))) + TerminoIndependienteX);
                }
                if (OperandoX == "-")
                {
                    Y = Convert.ToInt32((MultiplicadorX * (Math.Pow(X, ExponenteX))) - TerminoIndependienteX);
                }
                return Y;

            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int xAnt = 0;
            int yAnt = 0;
            for (int i = -150; i < 20;i++ )
            {
                int x = i;
                int y = Convert.ToInt32(Math.Pow(i, 2));

                //Representar(x, y, xAnt, yAnt, Color.Black, 2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcularYdibujar();
        }
        void CalcularYdibujar()
        {
            
                Limpiar();
                int Y;
                int Y2;
                int Z = Zoom.Value;
                vert.Text = "(0," + Convert.ToString(funcion_X_Y(0)) + ")";
                DibCoord(Z * 5);
                for (int X = -100; X < 100; X++)
                {try
            {
                    Y = funcion_X_Y(X);
                    Y2 = funcion_X_Y((X + 1));

                    Representar(X, Y, (X + 1), Y2, Z);}catch { }
                
            }
            
        }

        private void Zoom_Scroll(object sender, EventArgs e)
        {
            CalcularYdibujar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //CalcularYdibujar();
        }

    }
}
