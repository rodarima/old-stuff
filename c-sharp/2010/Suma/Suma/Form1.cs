using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(TxtX.Text);
                double B = Convert.ToDouble(TxtY.Text);
                double C = A + B;
                String str = Convert.ToString(C);
                TxtZ.Text = (str);

            }
            catch
            {
                TxtZ.Text = ("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(TxtX.Text);
                double B = Convert.ToDouble(TxtY.Text);
                double C = A - B;
                String str = Convert.ToString(C);
                TxtZ.Text = (str);

            }
            catch
            {
                TxtZ.Text = ("Error");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                double A = Convert.ToDouble(TxtX.Text);
                double B = Convert.ToDouble(TxtY.Text);
                double C = A * B;
                String str = Convert.ToString(C);
                TxtZ.Text = (str);

            }
            catch
            {
                TxtZ.Text = ("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(TxtX.Text);
                double B = Convert.ToDouble(TxtY.Text);
                if (B != 0)
                {
                    double C = A / B;
                    String str = Convert.ToString(C);
                    TxtZ.Text = (str);
                }
                else
                {
                    TxtZ.Text = ("División por cero");
                
                }

            }
            catch
            {
                TxtZ.Text = ("Error");
            }
        }

        private void Top_CheckedChanged(object sender, EventArgs e)
        {
            if (Calc.ActiveForm.TopMost == true)
            {
                Calc.ActiveForm.TopMost = false;
            }
            else {
                Calc.ActiveForm.TopMost = true;
            }
        }

        private void TxtX_TextChanged(object sender, EventArgs e)
        {
            if (TxtX.Text == "pi")
            {
                TxtX.Text = "3,14159265";
            }
            if (TxtX.Text == "e")
            {
                TxtX.Text = "2,71828183";
            }
            if (TxtX.Text == "")
            {
                TxtX.Text = "0";
            }


        }

            


      

       

        private void TxtY_TextChanged(object sender, EventArgs e)
        {
            if (TxtY.Text == "pi")
            {
                TxtY.Text = "3,14159265";
            }
            if (TxtY.Text == "e")
            {
                TxtY.Text = "2,71828183";
            }
            if (TxtY.Text == "")
            {
                TxtY.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                double A = Convert.ToDouble(TxtX.Text);
                double B = Convert.ToDouble(TxtY.Text);
                double C = Math.Pow(A, B);
                String str = Convert.ToString(C);
                TxtZ.Text = (str);
            }
            catch
            {
                TxtZ.Text = ("Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                double A = Convert.ToDouble(TxtX.Text);
                double C = Math.Pow(A ,.5);
                String str = Convert.ToString(C);
                TxtZ.Text = (str);




            }
            catch
            {
                TxtZ.Text = ("Error");
            }
        }

        private void TxtZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtX.Text = TxtZ.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtY.Text = TxtZ.Text;
        }
    }
}
