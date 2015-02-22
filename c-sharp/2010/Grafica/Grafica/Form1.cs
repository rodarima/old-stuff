using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string [] ItemArray={"Vectores" , "Gráfica"};
            for (int i = 0; i < ItemArray.Length; i++) 
            {
                SelItem.Items.Add(ItemArray[i]);

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
