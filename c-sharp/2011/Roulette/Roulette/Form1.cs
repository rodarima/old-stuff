using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Roulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int p = (int)max.Value;
                if (max.Value > presupuesto.Value) { p = (int)presupuesto.Value; }
                double v = 0, t = 0;
                for (t = 0; v <= p; t++)
                {
                    v += (double)Math.Pow(2, t) * (double)min.Value;
                    if (v > p) { t--; break; }
                    if (v == p) { break; }
                }
                t++;
                //int t1 = Convert.ToInt32(Math.Log10((double)presupuesto.Value +1 / (double)min.Value) / Math.Log10(2)) ;
                //MessageBox.Show(t.ToString());
                if (m.Checked == true)
                {
                    tiradas.Value = (int)t;
                }
                if (max.Value > presupuesto.Value && t > 0)
                {
                    apostar.Text = min.Value.ToString();
                }
                else
                {
                    double ap1 = Convert.ToDouble(p) / (Math.Pow(2, Convert.ToDouble( tiradas.Value )));
                    if ((ap1 * Math.Pow(2, Convert.ToDouble(tiradas.Value))) > (double)max.Value) { ap1 = (double)min.Value; }
                    apostar.Text = ((int)ap1).ToString();
                }
            }
            catch
            {
                apostar.Text = "ERROR";
            }
        }
    }
}
