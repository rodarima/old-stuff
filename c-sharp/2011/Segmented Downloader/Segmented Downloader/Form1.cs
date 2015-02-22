using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyDownloader.Core;

namespace Segmented_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadManager d = new DownloadManager();
            ResourceLocation[] r= new ResourceLocation[1];
            r[0] = ResourceLocation.FromURL("http://prostopleer.com/download/3agy1zuwb1408444b7970cbe51aad65ceb8538660");

            Downloader dow = new Downloader();







            d.Add(ResourceLocation.FromURL("http://prostopleer.com/download/3agy1zuwb1408444b7970cbe51aad65ceb8538660"),r,"epale.mp3",2,false);
MessageBox.Show(d.Downloads[0].StatusMessage);
            d.Downloads[0].Start();
            
        }
    }
}
