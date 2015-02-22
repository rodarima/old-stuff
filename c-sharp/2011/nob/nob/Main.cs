using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using System.Globalization;
using System.Diagnostics;


namespace nob
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //lvwColumnSorter = new ListViewColumnSorter();
            //this.lv.ListViewItemSorter = lvwColumnSorter;
            
        }
        struct lista{
            public string[] titulo;
            public string[] url;
        }
        lista lis;
        int num = 0;
        

        public delegate void UpdateTextCallback(string message , string cosa);
        public delegate void UpdateTextFin();
        public void goear()
        {
           
            int ind = 0;
            bool cont=true;
            int res = 0;
            while (cont == true)
            {
                try
                {

                    WebRequest request = WebRequest.Create("http://www.goear.com/search/" + t_buscar.Text + "/" + ind);

                    // If required by the server, set the credentials.
                    request.Credentials = CredentialCache.DefaultCredentials;
                    // Get the response.
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    // Display the status.
                    //dbg(response.StatusDescription);
                    // Get the stream containing content returned by the server.
                    Stream dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    //dbg(responseFromServer);
                    // Cleanup the streams and the response.
                    reader.Close();
                    dataStream.Close();
                    response.Close();

                    //string t = " <a title=\"Escuchar Dire Straits - Where do you think you\'re going de dire straits\" href=\"listen/2172709/dire-straits-where-do-you-think-youre-going-dire-straits\" class=\"b1\">Dire Straits - Where do you think you\'re going</a>";
                    // Define a regular expression for repeated words.
                    //Regex rx = new Regex("href=\"listen/[a-zA-Z1-9/-]+\" ");
                    Regex rx = new Regex("href=\"listen/[\\S]+ class=\"b1\">[^<]+</a>");



                    // Find matches.
                    MatchCollection matches = rx.Matches(responseFromServer);

                    // Report the number of matches found.

                    //MessageBox.Show(matches.Count + " matches found.");
                    // Report on each match.
                    res += matches.Count;
                    foreach (Match match in matches)
                    {
                        string word = match.Value;
                        //int index = match.Index;
                        string cod = word.Substring(13, 7);

                        Regex ti = new Regex(">[^>]+[^<]<");



                        // Find matches.
                        MatchCollection m1 = ti.Matches(word);

                        // Report the number of matches found.

                        //MessageBox.Show(matches.Count + " matches found.");
                        // Report on each match.
                  
                        foreach (Match m2 in m1)
                        {
                            string title = m2.Value;
                            //int index = match.Index;
                            title = title.Substring(1, title.Length-2);
                            title = title.ToLower();
                            title = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title);

                            lv.BeginInvoke(new UpdateTextCallback(add), new object[] {  title,cod });



                        }
                        
                        if (num_can.InvokeRequired)
                        {
                            num_can.Invoke(new EventHandler(
                                delegate
                                {

                                    num_can.Text = res.ToString() ;
                                }));
                        } 
                            

                
                        }
                    //if (res >= 30) { cont = false; }
                    if (matches.Count == 0) { cont = false; }
                        ind++;
                        
                    
                }
                catch (Exception ex)
                {
                    cont = false;
                    MessageBox.Show(ex.Message);
                }
                

            }searching = false;
                lv.BeginInvoke(new UpdateTextFin(close));
        }
        public void url_goear()
        {
            if (num_can.InvokeRequired)
            {
                num_can.Invoke(new EventHandler(
                    delegate
                    {
                        lurl.Text = "Descargando "+ nowtitle;
                    }));
            }
            //MessageBox.Show(nowcode);
            string link = "http://www.goear.com/tracker758.php?f=" + nowcode;
            WebRequest w = WebRequest.Create(link);

            // If required by the server, set the credentials.
            w.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse r = (HttpWebResponse)w.GetResponse();
            // Display the status.
            //dbg(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream1 = r.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader1 = new StreamReader(dataStream1);
            // Read the content.
            string responseFromServer1 = reader1.ReadToEnd();
            // Display the content.
            //dbg(responseFromServer);
            // Cleanup the streams and the response.
            reader1.Close();
            dataStream1.Close();
            r.Close();
            //MessageBox.Show(responseFromServer1);
            string code = responseFromServer1;
            //MessageBox.Show(code);
            Regex path = new Regex("path=\"[^\"]+\"");



            // Find matches.
            MatchCollection mpath = path.Matches(code);

            // Report the number of matches found.

            //MessageBox.Show(mpath.Count + " matches found.");
            // Report on each match.
            foreach (Match mp in mpath)
            {
                string mp3_path = mp.Value;


                //int index = match.Index;
                //MessageBox.Show(mp.Value);
                mp3_path = mp3_path.Substring(13, mp3_path.Length - 14);
                /*WebClient wc=new WebClient();
                wc.DownloadFile(mp3_path,nowtitle + ".mp3");
                */
                if (num_can.InvokeRequired)
                {
                    num_can.Invoke(new EventHandler(
                        delegate
                        {
                            lurl.Text = "Descarga completa";
                        }));
                }
                System.Diagnostics.Process.Start("mms://"+mp3_path); 
                /*Process p = new Process();
                p.StartInfo.FileName = mp3_path;
                p.StartInfo.CreateNoWindow = true;
                p.Start();*/
                //dbg(mp3_path);
                //li.Text = mp3_path;
                //lv.BeginInvoke(new UpdateTextCallback(add), new object[] { word, mp3_path });
                

            }

        }

        private void checkfin(){
            if (lv.Items.Count == 0)
            {
                lv.Items.Add("No se encontraron resultados").SubItems.Add("");
            }
        }
        
        private void add(string s, string u)
        {

            //lv.BeginUpdate();

                lv.Items.Add(s).SubItems.Add(u);
                // it exists
            


        }
        private void close()
        {

            pg.Visible = false;


        }
        Thread thr, thr2;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            search();
            
        }
        bool searching = false;
        void search()
        {
            pg.Visible = true;
            lv.Items.Clear();

            if (searching == false)
            {
                thr = new Thread(new ThreadStart(goear));
                thr.IsBackground = true;
                thr.Start();
                searching = true;
            }
            else
            {
                thr.Abort();
                thr = new Thread(new ThreadStart(goear));
                thr.IsBackground = true;
                thr.Start();
                searching = true;
            }
            

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Aborts the thread if the form is closed while the thread is running
            thr.Abort();
            thr2.Abort();
        }

        string nowcode, nowtitle;
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nowcode = lv.SelectedItems[0].SubItems[1].Text;
                nowtitle = lv.SelectedItems[0].SubItems[0].Text;
                //MessageBox.Show(nowcode);
                thr2 = new Thread(new ThreadStart(url_goear));

                thr2.IsBackground = true;
                thr2.Start();
            }
            catch
            {
            }
        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                search();
            }
        }

        private void t_buscar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Up(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pictureBox1.Image = nob.Properties.Resources.play;
        }
        private void pictureBox1_Down(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pictureBox1.Image = nob.Properties.Resources.play2;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
