using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maths2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _x, _y, _z;
        string op;
        Random r = new Random(DateTime.Now.Millisecond);
        void Make_Numbers(int _a, int _b)
        {
        text_x.Text = r.Next(1, _a).ToString();
        text_y.Text = r.Next(1, _b).ToString();
        }
        private void z_TextChanged(object sender, EventArgs e)
        {
            this.text_z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
            
        }

        void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Make_Numbers(10, 10);
            }
        }
        private void z_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                
                Make_Numbers(10, 10);
                e.Handled = true;
            }
        }

    }

}
