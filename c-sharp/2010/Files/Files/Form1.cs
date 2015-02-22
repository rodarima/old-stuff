using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Xml;
namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] Array;
        public string[] Array2;
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const string fic = @"data.db";
                string database;

                System.IO.StreamReader sr = new System.IO.StreamReader(fic);
                database = sr.ReadToEnd();
                sr.Close();

                string[] Separ = { "\r\n" };
                Array = database.Split((Separ), StringSplitOptions.RemoveEmptyEntries);

                int LenArr = Array.Length;
                DBase[] arr = new DBase[LenArr];
                string[] Sep1 = { ";" };
                for (int i = 0; i < LenArr; i++)
                {
                    Array2 = Array[i].Split((Sep1), StringSplitOptions.RemoveEmptyEntries);

                    arr[i] = new DBase(Array2[0], Array2[1]);
                }

                dataGridView1.DataSource = arr;
                dataGridView1.Rows[1].Cells[1].Style.BackColor = System.Drawing.Color.Aqua;




                

            }
            catch { }
        }
    }
}
