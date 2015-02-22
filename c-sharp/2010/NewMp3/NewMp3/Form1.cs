using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Resources;
using System.IO;


namespace NewMp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ReproductorMp3.Reproductor Sonido = new ReproductorMp3.Reproductor();
        
      
        bool p = false;
        bool p1 = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sonido.NombreDeArchivo = "sandstorm.mp3";
            if (p == false)
            {if (p1 == true){
                    p1 = false;
                    p = true;
                    Sonido.Reproducir();
                    BtnSound.BackgroundImage = Properties.Resources.Sound;
                }else{Sonido.Continuar();
                    BtnSound.BackgroundImage = Properties.Resources.Sound;
                    p = true;}
            }else{Sonido.Pausar();
                BtnSound.BackgroundImage = Properties.Resources.Mute;
                p = false;}
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
