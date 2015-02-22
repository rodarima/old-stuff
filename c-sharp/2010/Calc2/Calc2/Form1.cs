using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double[] Var;
        public string[] Ope;


        public double Var1 = 0;
        private void BtnIgu_Click(object sender, EventArgs e)
        {
            TxSal.Text = TxSal.Text + TxEnt.Text;
            string[] SeparTod = { "\r\n" };
            string[] TodArray = TxSal.Text.Split((SeparTod), StringSplitOptions.RemoveEmptyEntries);
            string[] SeparOpe = { "+", "-", "*", "/", "=", " " };
            string[] NumArray = TxSal.Text.Split((SeparOpe), StringSplitOptions.RemoveEmptyEntries);
            string[] SeparNum = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
            string[] OpeArray = TxSal.Text.Split((SeparNum), StringSplitOptions.RemoveEmptyEntries);
            Var1 = Convert.ToDouble(NumArray[0]);
            
            for (int iNum = 0; iNum < OpeArray.LongLength; iNum++)
            {
                    if (OpeArray[iNum] == "+")
                    {
                        Var1 = Var1 + Convert.ToDouble(NumArray[iNum + 1]);
                    }
                    if (OpeArray[iNum] == "-")
                    {
                        Var1 = Var1 - Convert.ToDouble(NumArray[iNum + 1]);
                    }
                    if (OpeArray[iNum] == "*")
                    {
                        Var1 = Var1 * Convert.ToDouble(NumArray[iNum + 1]);
                    }
                    if (OpeArray[iNum] == "/")
                    {
                        Var1 = Var1 / Convert.ToDouble(NumArray[iNum + 1]);
                    }
                }

            TxSal.Text = TxSal.Text + " = " + Convert.ToString(Var1) + "\r\n";
            TxEnt.Text = Convert.ToString(Var1);
            Var1 = 0;
            NumArray = null;
            OpeArray = null;
            TxEnt.Focus();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            if (TxEnt.Text != "")
            {
                TxSal.Text = TxSal.Text + TxEnt.Text + "+";
                TxEnt.Text = "";
                TxEnt.Focus();
            }
        }
        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (TxEnt.Text != "")
            {
                TxSal.Text = TxSal.Text + TxEnt.Text + "-";
                TxEnt.Text = "";
                TxEnt.Focus();
            }
        }

        private void TxSal_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
