using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Goear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Path.Text = desktopPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogoRuta = new FolderBrowserDialog();
            if (dialogoRuta.ShowDialog() == DialogResult.OK)
            {
                Path.Text = dialogoRuta.SelectedPath;
            }
            Bar.Value+=10;
        }
    }
}
