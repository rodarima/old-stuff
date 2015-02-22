using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public int V1CX;//en pixeles
        public int V1CY;
        public int V2CX;
        public int V2CY;

        public int Vec1X;//en coordenada (1 coordenada por cada 10 pixeles)
        public int Vec1Y;
        public int Vec2X;
        public int Vec2Y;

        public double ModV1;
        public double ModV2;
        public double ModVt;

        public const int CoorX = 100, CoorY = 100; 

        public void DibCoord()
        {
            
            int CoorX = 0, CoorY = 0;
            System.Drawing.Graphics Coor;
            Coor = PGra.CreateGraphics();
            Coor.Clear(System.Drawing.Color.White);
            for (int i = 0; i < 20; i++)
                {
                    CoorX = CoorX + 10;
                    CoorY = CoorY + 10;
                    System.Drawing.Pen Lap;
                    System.Drawing.Graphics Vect;

                    Lap = new System.Drawing.Pen(System.Drawing.Color.Gainsboro, 1);
                    Vect = PGra.CreateGraphics();
                    Vect.DrawLine(Lap, 0, CoorX, 200, CoorY);
                    Vect.DrawLine(Lap, CoorX, 0, CoorX, 200);
                    Vect.Dispose();

                }
            CoorX = 0;
            CoorY = 0;
            for (int i = 0; i < 4; i++)
            {
                CoorX = CoorX + 50;
                CoorY = CoorY + 50;
                System.Drawing.Pen Lap;
                System.Drawing.Graphics Vect;

                Lap = new System.Drawing.Pen(System.Drawing.Color.Silver, 1);
                Vect = PGra.CreateGraphics();

                Vect.DrawLine(Lap, 0, CoorX, 200, CoorY);
                Vect.DrawLine(Lap, CoorX, 0, CoorX, 200);
                Vect.Dispose();

                
            }
            
        }

        public void DibVector1()
        {

            DibCoord();

                System.Drawing.Pen Lap;
                System.Drawing.Graphics Vect;

                Lap = new System.Drawing.Pen(System.Drawing.Color.Blue, 4);
                Vect = PGra.CreateGraphics();
                //Random objeto = new Random();
                //int Rnd = objeto.Next(-5, 5);
                Vec1X = Convert.ToInt32(V1CoorX.Text);
                Vec1Y = Convert.ToInt32(V1CoorY.Text);
                V1CoorX.Text = Convert.ToString(Vec1X);
                V1CoorY.Text = Convert.ToString(Vec1Y);
                Lap.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                //Lap.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                V1CX = Vec1X* 10;
                V1CY = Vec1Y* 10;
                Vect.DrawLine(Lap, CoorX, CoorY, CoorX + V1CX , CoorY - V1CY );

                

                Vect.Dispose();
                TxModSRV1.Text = "√" + Convert.ToString(Math.Pow(Vec1X, 2) + Math.Pow(Vec1Y, 2));
            ModV1 = Math.Sqrt(Math.Pow(Vec1X,2)+Math.Pow(Vec1Y,2));
            TxModV1.Text = Convert.ToString(ModV1);
                   
            
        }
        public void DibVector2()
        {

            //DibCoord();

            System.Drawing.Pen Lap;
            System.Drawing.Graphics Vect;

            Lap = new System.Drawing.Pen(System.Drawing.Color.Green, 4);
            Vect = PGra.CreateGraphics();



            //Random objeto = new Random();
            Vec2X = Convert.ToInt32(V2CoorX.Text);
            Vec2Y = Convert.ToInt32(V2CoorY.Text);

            if (VecRes.Checked == true)
            {
                Vec2X = -Vec2X;
                Vec2Y = -Vec2Y;

            }

            //V2CoorX.Text = Convert.ToString(Vec2X);
            //V2CoorY.Text = Convert.ToString(Vec2Y);

            Lap.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            //Lap.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;

            V2CX =  Vec2X * 10;
            V2CY = Vec2Y * 10;

            Vect.DrawLine(Lap, CoorX, CoorY,CoorX + V2CX , CoorY - V2CY );
            
            






            //Vector Suma:
            Lap = new System.Drawing.Pen(System.Drawing.Color.DarkGray, 2);
            int VtCX = CoorX + (V1CX + V2CX);
            int VtCY = CoorY - (V1CY + V2CY);
            VtCoorX.Text = Convert.ToString((V1CX + V2CX)/10);
            VtCoorY.Text = Convert.ToString((V1CY + V2CY)/10);

            Vect.DrawLine(Lap, CoorX + V1CX, CoorY - V1CY, VtCX, VtCY);
            Vect.DrawLine(Lap, CoorX + V2CX, CoorY - V2CY, VtCX, VtCY);

            Lap = new System.Drawing.Pen(System.Drawing.Color.Red, 4);
            Lap.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            Vect.DrawLine(Lap, CoorX, CoorY, VtCX, VtCY);
            
            int VecTotX = Convert.ToInt32(VtCoorX.Text);
            int VecTotY = Convert.ToInt32(VtCoorY.Text);
            
            TxModSRV2.Text = "√" + Convert.ToString(Math.Pow(Vec2X, 2) + Math.Pow(Vec2Y, 2)) ;
            TxModSRV3.Text = "√" + Convert.ToString(Math.Pow(VecTotX, 2) + Math.Pow(VecTotY, 2)) ;
            double ModV2 = Math.Sqrt(Math.Pow(Vec2X, 2) + Math.Pow(Vec2Y, 2));
            TxModV2.Text = Convert.ToString(ModV2);

            double ModVt = Math.Sqrt(Math.Pow(VecTotX, 2) + Math.Pow(VecTotY, 2));
            TxModVt.Text = Convert.ToString(ModVt);


            //Calculamos u·v
            int PrEscUV = Vec1X * Vec2X + Vec1Y * Vec2Y;
            int PrEscUW = Vec1X * VecTotX + Vec1Y * VecTotY;
            int PrEscWV = Vec2X * VecTotX + Vec2Y * VecTotY;
            double PrMo1Mo2 = ModV1 * ModV2;
            double PrMo1Mot = ModV1 * ModVt;
            double PrMo2Mot = ModV2 * ModVt;
            //double PrMo1Mot = ModV1 * ModVt;

            TxProEscUV.Text = Convert.ToString(PrEscUV);

            double AngUV = 180 * Math.Acos(PrEscUV / PrMo1Mo2) / Math.PI;
            double AngUW = 180 * Math.Acos(PrEscUW / PrMo1Mot) / Math.PI;
            double AngWV = 180 * Math.Acos(PrEscWV / PrMo2Mot) / Math.PI;
            TxAngUV.Text = Convert.ToString(AngUV) + "º";
            TxAngUW.Text = Convert.ToString(AngUW) + "º";
            TxAngWV.Text = Convert.ToString(AngWV) + "º";

            



        }

        public int ot = 0;
        protected override void OnPaint(PaintEventArgs e)
        {
            if (ot == 0)
            {
                DibCoord();
                /*
                V1CoorX.Text = "3";
                V1CoorY.Text = "2";
                V2CoorX.Text = "-1";
                V2CoorY.Text = "3";
                */
                int min = -5;
                int max = 5;
                Random Rd = new Random();
                V1CoorX.Text = Convert.ToString(Rd.Next(min, max));
                V1CoorY.Text = Convert.ToString(Rd.Next(min, max));
                V2CoorX.Text = Convert.ToString(Rd.Next(min, max));
                V2CoorY.Text = Convert.ToString(Rd.Next(min, max));
                try
                {
                    DibVector1();
                    DibVector2();
                }
                catch { }
                ot = 1;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        //DibCoord();

            /*
            int min = -5;
            int max = 5;
            Random Rd = new Random();
            V1CoorX.Text = Convert.ToString(Rd.Next(min, max));
            V1CoorY.Text = Convert.ToString(Rd.Next(min, max));
            V2CoorX.Text = Convert.ToString(Rd.Next(min, max));
            V2CoorY.Text = Convert.ToString(Rd.Next(min, max));
            */

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    DibVector1();
                    DibVector2();
                }
                catch { }
            }
        private void BtnRand_Click(object sender, EventArgs e)
        {
            int min = -5;
            int max = 5;
            Random Rd = new Random();
            V1CoorX.Text = Convert.ToString(Rd.Next(min, max));
            V1CoorY.Text = Convert.ToString(Rd.Next(min, max));
            V2CoorX.Text = Convert.ToString(Rd.Next(min, max));
            V2CoorY.Text = Convert.ToString(Rd.Next(min, max));
            try
            {
                DibVector1();
                DibVector2();
            }
            catch { }
        }
        private void VetSum_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DibVector1();
                DibVector2();
            }
            catch { }
        }
        private void VecRes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DibVector1();
                DibVector2();
            }
            catch { }
        }
        

    }
}
