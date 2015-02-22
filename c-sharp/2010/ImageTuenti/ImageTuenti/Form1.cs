using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageTuenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pTuenti.Visible = false;
            
            AumentarImagen();
            VerImagen();
        }
        void AumentarImagen()
        {
            if (tUrl.Text != "")
            {
                try
                {
                    string[] SeparTod = { "/" };
                    string[] TodArray = tUrl.Text.Split((SeparTod), StringSplitOptions.RemoveEmptyEntries);
                    tUrl.Text = "http://imagenes2.tuenti.net/" + TodArray[3] + "/" + TodArray[4] + "/" + TodArray[5] + "/" + "600" + "/" + TodArray[7] + "/" + TodArray[8] + "/" + TodArray[9];
                    Clipboard.SetText(tUrl.Text);
                }
                catch { }
            }
        }
        void VerImagen()
        {
            VerBarra();
            webBrowser1.Visible = true;
            string img = tUrl.Text;
            webBrowser1.Navigate(img);

        }
        void VerBarra()
        {
            pLoad.Visible = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void url_TextChanged(object sender, EventArgs e)
        {
            
            pTuenti.Visible = false;
            AumentarImagen();
            VerImagen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) {
                if (Clipboard.GetText().Contains("http://perfiles") || Clipboard.GetText().Contains("http://thumbs"))
                {
                    try
                    {
                        tUrl.Text = Clipboard.GetText();
                    }
                    catch { }
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            pLoad.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true){ImageTuenti.Form1.ActiveForm.TopMost = true;}
            else { ImageTuenti.Form1.ActiveForm.TopMost = false; }
        }
        private void ListBox1_DragEnter(object sender, DragEventArgs e)
        {
            //TODO: hacer las comprobaciones de cuándo debe permitirse arrastrar y soltar
            e.Effect = DragDropEffects.Copy;
        }

        private void ListView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            tUrl.DoDragDrop(tUrl.Text, DragDropEffects.Copy);
        }

    }
}
