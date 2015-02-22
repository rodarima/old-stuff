using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Algoritmo_grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        System.Drawing.Pen myPen;
        System.Drawing.Graphics formGraphics;
        int tiemp = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            parar = false;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            myPen.Brush = Brushes.Blue;
            myPen.Width = 1;
            formGraphics = p.CreateGraphics();
            tiemp = Convert.ToInt32(tie.Text);

            fun1();
        }

        void fun1()
        {
            Random r = new Random(DateTime.Now.Millisecond);

            int banca_inicial = Convert.ToInt32(d.Text);
            int ap = Convert.ToInt32(f.Text);
            double f_d = ((double)banca_inicial) / 100;
            int[] num = new int[50];
            int color_temp = 3;
            int duplicados = 0;
            double tiradas = 0;
            double banca = banca_inicial;
            int color_apuesta = 0;
            double ganancia = 0;
            double perdida = 0;
            int exp = 0;
            double apuestas = 0;
            bool apostando = false;
            int apuestas_seguidas = 0;
            int banca_max = 0;
            double cont_o = 0;
            int y = 0;
            int cor_y_ant = 0;
            int y_lim = 350;
            double cartera = 150;
            double limite;
            limite = Convert.ToDouble(l.Text);
            //while (true)
            {
                
                double t = 0; formGraphics.Clear(Color.White);
                formGraphics.DrawLine(myPen, 0, 350, 800, 350);
                formGraphics.Clear(Color.White);
                for (int i = 0; i < 160; i++)
                {
                    formGraphics.DrawLine(Pens.LightBlue, 5 * i, 0, 5 * i, 400);
                }
                while (t != -1)
                {
                    
                    /*
                    if (banca>limite){
                        banca -= limite/2;
                        cartera += limite/2;
                        //formGraphics.Clear(Color.White);
                    }
                    */
                    t++;
                    //tiradas++;
                    int rcolor = r.Next(0, 38);
                    int color = 0;
                    if (rcolor != 0)
                    {
                        if (rcolor <= 18) { color = 1; }
                        if (rcolor >= 19) { color = 2; }
                    }

                    /*
                    for(int i=0; i<18;i++)
                    {
                        Console.Write(" " + num[i].ToString());
                    }*/

                    if (cont_o % 1 == 0)
                    {
                        //formGraphics.DrawLine(myPen, 0, 0, 200, 200);
                        float x = (float)(cont_o / 1.0);
                        int a = (int)((double)(banca - banca_inicial) / (double)f_d);
                        
                        if (x > 800)
                        {
                            cont_o = 0; formGraphics.Clear(Color.White);
                            for(int i=0;i<160;i++)
                        {
                            formGraphics.DrawLine(Pens.LightBlue, 5*i, 0, 5*i, 400);
                        }
                        } if (a > y_lim) { y += 350; y_lim += 350; cor_y_ant = a; }
                        if (Math.Abs(a - cor_y_ant) > 10) { myPen = Pens.Red; } else { myPen = Pens.Green; }
                        if (a > cor_y_ant)
                        {
                            formGraphics.DrawLine(myPen, x, 350 - a + y, x + 1, 350 - cor_y_ant + y);
                        }
                        else
                        {
                            formGraphics.DrawLine(myPen, x, 350 - cor_y_ant + y, x + 1, 350 - a  + y);
                        }
                            
                        if (color == 1) { formGraphics.DrawLine(Pens.Red, x, 400 - 20, x, 410 - 20);
                        Pen p = new Pen(Brushes.Red,50);
                        formGraphics.DrawLine(p, 0, 25, 50, 25);
                        }
                        if (color == 2) { formGraphics.DrawLine(Pens.Black, x, 400 - 25, x, 410 - 25);
                        Pen p = new Pen(Brushes.Black, 50);
                        formGraphics.DrawLine(p, 0, 25, 50, 25);
                        }
                        if (color == 0) { formGraphics.DrawLine(Pens.Green, x, 400 - 30, x, 410 - 30);
                        Pen p = new Pen(Brushes.Green, 50);
                        formGraphics.DrawLine(p, 0, 25, 50, 25);
                        }
                        Font fon = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            
                        formGraphics.DrawString(banca.ToString() + "€", fon, Brushes.White, 0, 0);
                        
                        formGraphics.DrawLine(myPen, 0, 350, 800, 350);
                        

                        cor_y_ant = a;
                    }

                    cont_o++;

                    //MessageBox.Show(" " + tiradas.ToString() + " " + ((banca - banca_inicial) / apuestas).ToString());




                    if (color_temp != 3)
                    {
                        if (color_temp == color)
                        {
                            duplicados++;
                        }
                        else
                        {
                            num[duplicados]++;
                            duplicados = 0;
                        }
                        if (apostando == true)
                        {
                            
                                // Buscar el numero de probabilidades que ira aumentando de que salgan colores que no puedes pagar, y al llegar a un determinado limite dejar de apostar hasta que salga
                                apuestas_seguidas++;
                                if (apuestas_seguidas < 100)
                                {
                                    if (color != 0)
                                    {
                                        if (color == color_apuesta)
                                        {
                                            ganancia = 2 * perdida;
                                            apostando = false;
                                            perdida = 0;
                                            exp = 0;
                                        }
                                        else
                                        {
                                            ganancia = 0;
                                            perdida = 1 * Math.Pow(2, exp);
                                            exp++;
                                        }
                                    }
                                    else
                                    {
                                        exp = 0;
                                        duplicados = 0;
                                        ganancia = perdida / 2;
                                        perdida = 0;
                                        apostando = false;
                                    }
                                }
                                else
                                {
                                    ganancia = 0;
                                    perdida = 0;
                                    exp = 0;
                                    apostando = false;
                                    apuestas_seguidas = 0;
                                }
                            

                        }
                        if (banca % 5 == -1 && banca > 100 && apostando == false)
                        {
                            formGraphics.Clear(Color.White);
                            apostando = false;
                            exp = 0;
                            perdida = 0;
                            ganancia = 0;
                            float x = (float)(cont_o / 1.0);

                            if (rcolor == 1)
                            {
                                ganancia = 35;
                                formGraphics.DrawLine(Pens.Blue, x, 350 - cor_y_ant + y, x + 1, 350 - cor_y_ant + y + 30);
                            }
                            else
                            {
                                perdida = 1;
                                formGraphics.DrawLine(Pens.Red, x, 350 - cor_y_ant + y, x + 1, 350 - cor_y_ant + y + 10);
                            }
                        }
                        if (duplicados + 1 == ap && apostando == false)
                        {
                            apuestas++;
                            apostando = true;
                            if (color == 1) { color_apuesta = 2; }
                            if (color == 2) { color_apuesta = 1; }

                        }

                        banca = banca + ganancia - perdida;
                        if (banca_max < banca) { banca_max = (int)banca; }

                        ganancia = 0;
                        //Console.Write(" " + duplicados + " " + banca + "+" + ganancia.ToString() + "-" + perdida.ToString());
                        if (banca < 0)
                        {
                            
                            float x = (float)(cont_o / 1.0);
                            tiradas = 0;
                            //cont_o = 0;
                            //banca_max = 0;
                            
                            ganancia = 0;
                            perdida = 0;
                            exp = 0;
                            apostando = false;
                            y_lim = 350;
                            y = 0;
                            /*if (cartera > 0) {banca += limite/2; cartera -= limite/2; }
                            else*/
                            {Font fon = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            formGraphics.DrawString("En " + t.ToString() + " tiros\n\r" +banca_max.ToString() + "€", fon, myPen.Brush, 350, 150);
                            formGraphics.DrawLine(Pens.Red, x, 350 - cor_y_ant + y, x + 1, 400);
                            
                                break;
                            }
                        }
                        if (parar == true) { break; }
                        /*if (cartera < 0)
                        {
                            break;
                        }*/
                    }

                    color_temp = color;
                    //Console.ReadKey();
                    Thread.Sleep(tiemp);
                }
                //Thread.Sleep(1000);

            }
        }
        bool parar = false;
        private void button2_Click(object sender, EventArgs e)
        {
            parar = true;
        }
    }

}