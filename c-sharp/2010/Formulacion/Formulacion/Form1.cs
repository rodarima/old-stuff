using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] SeparNum = { "-" };
            string[] Array = TxForm.Text.Split((SeparNum), StringSplitOptions.RemoveEmptyEntries);
            int LongCad = Array.Length;
            switch (LongCad)
            {
                case 1:TxNome.Text = "Metano";  break;
                case 2:TxNome.Text = "Etano";   break;
                case 3: TxNome.Text = "Propano"; break;
                case 4: TxNome.Text = "Butano"; break;
                case 5: TxNome.Text = "Pentano"; break;
                case 6: TxNome.Text = "Hexano"; break;

            }
        }
    }
}
