using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        public double Var1 = 0;
        public double Var2 = 0;
        public double Var3 = 0;
        public string Acc1 = "";
        public int BorrP = 0;
        void CurDer()
        {
            TxPant.SelectionStart = TxPant.Text.Length;
            TxPant.ScrollToCaret();
            TxPant.Refresh();
        }
        void AccBorrPant()
        {
            if (BorrP==1)
            {
                TxPant.Text = "";
                BorrP = 0;
            }
        }
        void IgualoVar1()
        {
            if (Var1 != 0) 
            {
                BorrP = 1;

                try
                {
                    Var2 = Convert.ToDouble(TxPant.Text);
                    switch (Acc1)
                    {
                        case "+":
                            TxPant.Text = Convert.ToString(Var1 + Var2);
                            break;
                        case "-":
                            TxPant.Text = Convert.ToString(Var1 - Var2);
                            break;
                        case "*":
                            TxPant.Text = Convert.ToString(Var1 * Var2);
                            break;
                        case "/":
                            TxPant.Text = Convert.ToString(Var1 / Var2);
                            break;
                        case "RaiN":
                            Var1 = 1 / Var1;
                            Var3 = Math.Pow(Var2, Var1);
                            TxPant.Text = Convert.ToString(Var3);
                            break;
                        case "EleN":
                            Var3 = Math.Pow(Var1, Var2);
                            TxPant.Text = Convert.ToString(Var3);
                            break;
                        default:
                            break;
                    }
                    Acc1 = null;
                    Var1 = 0;
                    Var2 = 0;
                    Var3 = 0;
                }
                catch { }
            }
        }

        void GetVar1()
        {
            if (TxPant.Text != "")
            {
                try
                {
                    Var1 = Convert.ToDouble(TxPant.Text);
                    BorrP = 1;
                    //TxPant.Text = "";
                    //TxPant.Focus();
                }
                catch
                {
                    Var1 = 0;
                    TxPant.Text = "Error";
                    //TxPant.Focus();
                }
            }
        }
        void ConvGraToRad()
        {
            try { Var1 = Var1 * Math.PI / 180; }
                catch{Var1 = 0;}
        }
        void ConvRadToGra()
        {
            try { Var1 = Var1 / Math.PI * 180; }
                catch{Var1 = 0;}
        }



        private void BtSum_Click(object sender, EventArgs e)
        {
            IgualoVar1();
            GetVar1();
            Acc1 = "+";
        }

        private void BtRes_Click(object sender, EventArgs e)
        {
            IgualoVar1();
            GetVar1();
            Acc1 = "-";
        }

        private void BtMul_Click(object sender, EventArgs e)
        {
            IgualoVar1();
            GetVar1();
            Acc1 = "*";
        }

        private void BtDiv_Click(object sender, EventArgs e)
        {
            IgualoVar1();
            GetVar1();
            Acc1 = "/";
        }

        private void BtRaiC_Click(object sender, EventArgs e)
        {
                BorrP = 1;
                GetVar1();
                TxPant.Text = Convert.ToString(System.Math.Pow(Var1, .5));
            
        }

        private void BtRaizN_Click(object sender, EventArgs e)
        {
            IgualoVar1();
            GetVar1();
            Acc1 = "RaiN";
        }

        private void BtCua_Click(object sender, EventArgs e)
        {
            BorrP = 1;
            GetVar1();
            TxPant.Text = Convert.ToString(System.Math.Pow(Var1, 2));
        }

        private void BtEleN_Click(object sender, EventArgs e)
        {
            IgualoVar1();
            GetVar1();
            Acc1 = "EleN";
        }

        private void BtLog10_Click(object sender, EventArgs e)
        {
            GetVar1();
            TxPant.Text = Convert.ToString(System.Math.Log10(Var1));
        }

        private void BtLogN_Click(object sender, EventArgs e)
        {
            GetVar1();
            TxPant.Text = Convert.ToString(System.Math.Log(Var1, Math.E));
        }

        private void BtIgu_Click(object sender, EventArgs e)
        {
            BorrP = 1;

            try {
                Var2 = Convert.ToDouble(TxPant.Text);
                switch (Acc1)
                {
                    case "+":
                        TxPant.Text = Convert.ToString(Var1 + Var2);
                        break;
                    case "-":
                        TxPant.Text = Convert.ToString(Var1 - Var2);
                        break;
                    case "*":
                        TxPant.Text = Convert.ToString(Var1 * Var2);
                        break;
                    case "/":
                        TxPant.Text = Convert.ToString(Var1 / Var2);
                        break;
                    case "RaiN":
                        Var1 = 1 / Var1;
                        Var3 = Math.Pow(Var2, Var1);
                        TxPant.Text = Convert.ToString(Var3);
                        break;
                    case "EleN":
                        Var3 = Math.Pow(Var1, Var2);
                        TxPant.Text = Convert.ToString(Var3);
                        break;
                    default:
                        break;
                }
                Acc1 = null;
                Var1 = 0;
                Var2 = 0;
                Var3 = 0;
            }
            catch { }
        }

        private void TxPant_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxPant.Text == "")
                {
                    
                    TxPant.Text = "";
                    TxPant.Focus();
                }
                else
                {
                    
                }
            }
            catch
            { 
            TxPant.Text = "0";
            TxPant.Focus();
            }
        }

        private void BtCe_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        void ClearAll() {
            if (TxPant.Text != "")
            {
                TxPant.Text = "";
            }
            else
            {
                Var1 = 0;
                Var2 = 0;
                Var3 = 0;
                TxPant.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "9";
        }

        private void BtComa_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + ",";
        }

        private void Bt2Ceros_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "00";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            TxPant.Text = TxPant.Text + "0";
        }

        private void BtPi_Click(object sender, EventArgs e)
        {
            AccBorrPant();
            BorrP = 1;
            TxPant.Text = "3,1415926535897932384626433832795";
        }

        
        private void BtSenx_Click(object sender, EventArgs e)
        {
            BorrP = 1;
            GetVar1();
            ConvGraToRad();
            TxPant.Text = Convert.ToString(System.Math.Sin(Var1));
            CurDer();
        }

        private void BtCosx_Click(object sender, EventArgs e)
        {
            BorrP = 1;
            GetVar1();
            ConvGraToRad();
            TxPant.Text = Convert.ToString(System.Math.Cos(Var1));
            CurDer();
        }
              
        private void BtTanx_Click(object sender, EventArgs e)
        {
            BorrP = 1;
            GetVar1();
            ConvGraToRad();
            TxPant.Text = Convert.ToString(System.Math.Tan(Var1));
            CurDer();
        }

        private void BtE_Click(object sender, EventArgs e)
        {
            BorrP = 1;
            TxPant.Text = "2,7182818284590452353602874713527";
        }

        private void BtAsenx_Click(object sender, EventArgs e)
        {
            BorrP = 1;
            GetVar1();
            Var1 = System.Math.Asin(Var1);
            ConvRadToGra();
            TxPant.Text = Convert.ToString(Var1);
            CurDer();
        }

        private void BtAcosx_Click(object sender, EventArgs e)
        {
            BorrP = 1;
            GetVar1();
            Var1 = System.Math.Acos(Var1);
            ConvRadToGra();
            TxPant.Text = Convert.ToString(Var1);
            CurDer();
        }

        private void BtAtanx_Click(object sender, EventArgs e)
        {
            BorrP = 1;
            GetVar1();
            Var1 = System.Math.Atan(Var1);
            ConvRadToGra();
            TxPant.Text = Convert.ToString(Var1);
            CurDer();
        }



        


          
    }
}
