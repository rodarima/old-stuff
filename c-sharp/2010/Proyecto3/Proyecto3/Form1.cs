using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tEmail_Refresh(object sender, EventArgs e)
        {
            if (tEmail.Text == "E-mail")
            {
              tEmail.Text = "";
              
            }
            tEmail.ForeColor = Color.Black;
            lEmail.Text = "";
        }
        private void tEmail_Check(object sender, EventArgs e)
        {
            if (!tEmail.Text.Contains("@") || !tEmail.Text.Contains("."))
            {
                lEmail.Text = "Email incorrecto";
            }
        }
        private void tPass_Refresh(object sender, EventArgs e)
        {
            if (tPass.Text == "Contraseña")
            {
                tPass.Text = "";
                
            }
            tPass.ForeColor = Color.Black;
                tPass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}
