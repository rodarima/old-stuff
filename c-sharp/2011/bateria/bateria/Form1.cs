using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bateria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PowerStatus energia = SystemInformation.PowerStatus;
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int carga = (int)(energia.BatteryLifePercent * 100);
            label1.Text = energia.BatteryLifeRemaining + " " + carga.ToString() + " %";
        }
    }
}
