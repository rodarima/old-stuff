using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using NAudio.Wave;
using System.Threading;

namespace Streaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string now_playing_url = "http://live.goear.com/listen/37ad67d763007345e6bce454b0014458/4d6073f7/sst/mp3files/12082006/1d9f8b782e9167e9c4d40815fca5eea6.mp3";
 
        WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback());
        Stream ms = new MemoryStream();
        Stream mp = new MemoryStream();
        Stream mp1 = new MemoryStream();
        int pos = 0;
        public delegate void Upd();
        //byte[] mp3 = new byte[10240000];
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
 

        void PlayMp3FromUrl()
        {
            wplayer.URL = now_playing_url;
            wplayer.controls.play();
            wplayer.settings.volume = 2;
            

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PlayMp3FromUrl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
