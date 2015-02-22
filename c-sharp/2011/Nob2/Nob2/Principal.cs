using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Nob2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        Ext ext = new Ext();
        struct lista
        {
            
            
            public string[] song;
            public string[] comment;
            public string[] code;
            public string[] rec;
        }
        lista list_songs;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
            
            // Aborts the thread if the form is closed while the thread is running
        }
        private void search_text_Down(object sender, EventArgs e)
        {
            if (search_text.Text == "Buscar...")
            {
                search_text.Text = "";
                search_text.ForeColor = Color.Black;
            }
        }
        private void search_text_Leave(object sender, EventArgs e)
        {
            if (search_text.Text == "")
            {
                search_text.Text = "Buscar...";
                search_text.ForeColor = Color.Gray;
            }
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            wplayer.controls.play();
            wplayer.network.maxBandwidth = 99999999;
            
            
            System.Reflection.PropertyInfo propiedadListView = typeof(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propiedadListView.SetValue(list, true, null);
            System.Reflection.PropertyInfo propiedadPictureBox = typeof(PictureBox).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propiedadListView.SetValue(list, true, null);
             search_text.Focus();
             search_text.Select();
             pic_loading.Parent = fondo_search;
             lupa.Parent = fondo_search;
             //num_can.Parent = search_text;
             list_songs.code = new string[1000];
             list_songs.comment = new string[1000];
             list_songs.song = new string[1000];
             list_songs.rec = new string[1000];
             timer_status.Start();
        }
        private void search_text_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 )
            {
                e.Handled = true;
                if (search_text.Text != "")
                {
                    search();
                }
            }
        }
        void Reset_title_com()
        {
            info_label.Text = "Busca una canción o un grupo.";
            title_label.Text = "Nob 2, encuentra tu música";
        }
        public delegate void UpdateTextCallback(string titulo, string com, string re, int num);
        public delegate void URL(string url);
        public delegate void Upd();
        string sugerencia;
        bool playing = false;
        void play()
        {
            title_label.Text =  nowtitle ;
            info_label.Text = nowcoment;
            //MessageBox.Show(wplayer.status);
            wplayer.URL = now_playing_url;
            wplayer.controls.play();
            play_picture.Image = Nob2.Properties.Resources.pause40;
            //play_button.BackgroundImage = Nob2.Properties.Resources.control_pause;
            down_image.Visible = true;
            //MessageBox.Show(wplayer.status);
            
        }
        string now_playing_url;
        bool cont;
        private void goear()
        {
            
                real_songs = 0;
                int canciones = 0;
                int ind = 0;
                cont = true;
                int res = 0;
                sugerencia = "";

            try
            {
                string url_google = ext.get_response("http://www.google.es/search?q=" + search_text.Text);
                //goog = "<a href=\"/search?hl=es&amp;&amp;sa=X&amp;ei=RdZeTabmIYan8QPjpcxZ&amp;ved=0CBYQBSgA&amp;q=dire+straits&amp;spell=1\" class=\"spell\">dire <b><i>straits</i></b></a>&nbsp;&nbsp;<br></div><!--a-->";
                string goog = Regex.Match(url_google, "q=[^&]+&amp;spell=1").ToString();
                if (goog != "")
                {
                    goog = goog.Substring(2, goog.Length - (2 + 12));
                    goog = goog.Replace("+", " ");
                    //MessageBox.Show(goog);
                    sugerencia = goog;

                }
                info_label.BeginInvoke(new Upd(upd_sug));
                if (list.InvokeRequired)
                {
                    list.Invoke(new EventHandler(
                        delegate
                        {
                            col_title.Text = "Título";
                            //num_can.Text = res.ToString();
                        }));
                }
                while (cont == true)
                {//                                        [^\"]+ class=\"spell\">[^/]+/"

                    Regex rx = new Regex("href=\"listen/[\\S]+ class=\"b1\">[^<]+</a>");
                    //Regex rx = new Regex("</div><div>");
                    // Find matches.
                    Regex com = new Regex("font-size:11px;padding-left:13px;\">[^<]+</div>");
                    string url = "http://www.goear.com/search/" + search_text.Text + "/" + ind;
                    //MessageBox.Show(ext.get_response(url));
                    //color:#978080;font-size:11px;padding-left:13px;">
                    string c = ext.get_response(url);
                    MatchCollection matches = rx.Matches(c);
                    MatchCollection commatch = com.Matches(c);
                    //MessageBox.Show(matches.Count + " matches found.");
                    res += matches.Count;
                    int i = 0;
                    foreach (Match match in matches)
                    {

                        string comment = commatch[i].ToString();
                        if (comment.Length > 35 + 6)
                        {
                            comment = comment.Substring(35, comment.Length - (6 + 35));
                            comment = comment.ToLower();
                            comment = comment.Replace(comment.Substring(0, 1), comment.Substring(0, 1).ToUpper());
                        }
                        else
                        {
                            comment = "";
                        }
                        string word = match.Value; //MessageBox.Show(word);
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
                            title = title.Substring(1, title.Length - 2);
                            title = title.ToLower();
                            title = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title);

                            if (title.Length > 1)
                            {
                                string t = title.Substring(0, 1);
                                string tit_orig = title;
                                while (!Regex.IsMatch(t, "[A-Z]"))
                                {
                                    
                                    title = title.Remove(0, 1);
                                    if (title.Length > 1)
                                    {
                                        t = title.Substring(0, 1);
                                    }
                                    else break;
                                }
                                if (title.Length > 1)
                                {
                                    list.BeginInvoke(new UpdateTextCallback(add), new object[] { title, comment, cod, canciones });
                                    canciones++;
                                }
                                else
                                {
                                    list.BeginInvoke(new UpdateTextCallback(add), new object[] { tit_orig, comment, cod, canciones });
                                    canciones++;
                                    
                                }



                            }
                        }

                        if (list.InvokeRequired)
                        {
                            list.Invoke(new EventHandler(
                                delegate
                                {
                                    col_title.Text = "Título (" + real_songs + "/" + res + " )";
                                    
                                    //num_can.Text = res.ToString();
                                }));
                        }


                        i++;
                    }
                    //if (res >= 50) { cont = false; }
                    if (matches.Count == 0) { cont = false; }
                    ind++;
                    

                }
            }
            catch (Exception ex)
            {
                cont = false;
                MessageBox.Show(ex.Message);
            }
                

             searching = false;
            this.BeginInvoke(new Upd(close));
        }
        void upd_sug() {
            if (sugerencia != "")
            {
                info_label.Text = "Quizás buscas: " + sugerencia;
                info_label.Cursor = Cursors.Hand;
                info_label.ForeColor = Color.DarkRed;
            }
            else if(info_label.Text.StartsWith("Quizás buscas:"))
            {
                info_label.Text = "";
                info_label.Cursor = Cursors.Default;
                info_label.ForeColor = Color.Gray;
            }
        }
        void close()
        {
            pic_loading.Visible = false;
            stop_search.Visible = false;
            
        }
        public void url_goear()
        {
            
            try
            {
                this.BeginInvoke(new Upd(upd_sug));
                /*
                if (num_can.InvokeRequired)
                {
                    num_can.Invoke(new EventHandler(
                        delegate
                        {
                            lurl.Text = "Descargando " + nowtitle;
                        }));
                }*/
                //MessageBox.Show("Obteniendo url de: " + nowcode);

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
                    /*
                  if (num_can.InvokeRequired)
                  {
                      num_can.Invoke(new EventHandler(
                          delegate
                          {
                              lurl.Text = "Descarga completa";
                          }));
                  }*/
                    //System.Diagnostics.Process.Start("mms://" + mp3_path);
                    now_playing_url = "http://" + mp3_path;
                    //MessageBox.Show(now_playing_url);
                    //this.BeginInvoke(new URL(PlayMp3FromUrl), new object[] { "http://" + mp3_path });
                    this.BeginInvoke(new Upd(play));
                    
                    //System.Diagnostics.Process.Start("http://" + mp3_path);
                    /*Process p = new Process();
                    p.StartInfo.FileName = mp3_path;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();*/
                    //dbg(mp3_path);
                    //li.Text = mp3_path;
                    //lv.BeginInvoke(new UpdateTextCallback(add), new object[] { word, mp3_path });


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        bool searching = false;
        Thread thr, thr2, player;
        void clear_list()
        {
            list_songs.code = new string[1000];
            list_songs.comment = new string[1000];
            list_songs.song = new string[1000];
            list_songs.rec = new string[1000];
        }
        void search()
        {
            Reset_title_com();
            list.Items.Clear();
            list.Focus();
            info_label.Cursor = Cursors.Default;
            clear_list();
            if (searching == false)
            {
                pic_loading.Visible = true;
                stop_search.Visible = true;
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
        string nowcode, nowtitle, nowcoment;
        int real_songs = 0;
        private void add(string title,string comment, string code,int n_canc)
        {
            string rec_tit = title;
            if (title.Length > 6)
            {
                rec_tit = title.Substring(0, 6);
            }
            if (exclude.Checked == false)
            {

                    real_songs++;
                    ListViewItem lvi = list.Items.Add(title);
                    lvi.UseItemStyleForSubItems = false;
                    lvi.SubItems.Add(comment).ForeColor = Color.Gray;
                    lvi.SubItems.Add(code).ForeColor = Color.Wheat;
                    lvi.ImageIndex = 0;

            }
            else
            {
                if (!list_songs.rec.Contains(rec_tit))
                {
                    real_songs++;
                    ListViewItem lvi = list.Items.Add(title);
                    lvi.UseItemStyleForSubItems = false;
                    lvi.SubItems.Add(comment).ForeColor = Color.Gray;
                    lvi.SubItems.Add(code).ForeColor = Color.Wheat;
                    lvi.ImageIndex = 0;
                }

            }
            list_songs.song[n_canc] = title;
            list_songs.comment[n_canc] = comment;
            list_songs.code[n_canc] = code;
            if (title.Length > 6)
            {
                list_songs.rec[n_canc] = title.Substring(0, 6);
            }
            else
            {
                list_songs.rec[n_canc] = title;
            }
            //lvi.SubItems[0].ForeColor = Color.Gray;
        }
        void status_change()
        {
            status_wplayer.Text = wplayer.status;
        }
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                nowcode = list.SelectedItems[0].SubItems[2].Text;
                nowcoment = list.SelectedItems[0].SubItems[1].Text;
                nowtitle = list.SelectedItems[0].SubItems[0].Text;
                //MessageBox.Show(nowcode);
                thr2 = new Thread(new ThreadStart(url_goear));

                thr2.IsBackground = true;
                thr2.Start();
            }
            catch
            {
            }
        }
        private void pic_loading_Click(object sender, EventArgs e)
        {
            search_text.Focus();
            search_text.Select();
        }
        private void info_label_Click(object sender, EventArgs e)
        {
            if (sugerencia != "")
            {
                thr.Abort();
                thr.Join();

                search_text.Text = sugerencia;
                //sugerencia = "";
                info_label.Text = nowcoment;
                info_label.ForeColor = Color.Gray;
                search_text.Select(search_text.Text.Length, 0);
                search();
            }
        }
        private void list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /*try
            {

                nowcode = list.SelectedItems[0].SubItems[2].Text;
                nowtitle = list.SelectedItems[0].SubItems[0].Text;
                title_label.Text = list.SelectedItems[0].SubItems[0].Text;
                info_label.Text = list.SelectedItems[0].SubItems[1].Text;
            }
            catch
            {
            }*/
        }

        private void volume_track_Scroll(object sender, EventArgs e)
        {
            wplayer.settings.volume = volume_track.Value;
            
        }
        private void next_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wplayer.status);
        }
        private void stop_search_Click(object sender, EventArgs e)
        {
            cont = false;
        }
        private void timer_status_Tick(object sender, EventArgs e)
        {
            
        }
        private void timer_status_Tick_1(object sender, EventArgs e)
        {
status_wplayer.Text = wplayer.status;
if (wplayer.status != "")
{
    if (wplayer.status != "En pausa")
    {
        double l = wplayer.currentMedia.duration;
        //MessageBox.Show(wplayer.currentMedia.duration.ToString());
        //MessageBox.Show(wplayer.controls.currentPositionString);
        if (wplayer.currentMedia.duration != 0)
        {
            stream_track.Value = Convert.ToInt32((wplayer.controls.currentPosition * 1000) / wplayer.currentMedia.duration);
        }
        //MessageBox.Show(wplayer.controls.currentPositionString);
        //play_button.BackgroundImage = Nob2.Properties.Resources.control;
    }
    else
    {
        //wplayer.controls.play();
        //play_button.BackgroundImage = Nob2.Properties.Resources.control_pause;
    }
}
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            thr = new Thread(new ThreadStart(downloader));
            thr.IsBackground = true;
            thr.Start();
        }
        void downloader()
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(now_playing_url, nowtitle + ".mp3");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (wplayer.status != "")
            {
                if (wplayer.status != "En pausa")
                {
                    double l =wplayer.currentMedia.duration;
                    //MessageBox.Show(wplayer.currentMedia.duration.ToString());
                    //MessageBox.Show(wplayer.controls.currentPositionString);
                    wplayer.controls.currentPosition = (double)(stream_track.Value*l)/1000;
                    //MessageBox.Show(wplayer.controls.currentPositionString);
                    //play_button.BackgroundImage = Nob2.Properties.Resources.control;
                }
                else
                {
                    //wplayer.controls.play();
                    //play_button.BackgroundImage = Nob2.Properties.Resources.control_pause;
                }
            }
        }

        private void macTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (wplayer.status != "")
            {
                if (wplayer.status != "En pausa")
                {
                    double l = wplayer.currentMedia.duration;
                    //MessageBox.Show(wplayer.currentMedia.duration.ToString());
                    //MessageBox.Show(wplayer.controls.currentPositionString);
                    wplayer.controls.currentPosition = (double)(stream_track.Value * l) / 1000;
                    //MessageBox.Show(wplayer.controls.currentPositionString);
                    //play_button.BackgroundImage = Nob2.Properties.Resources.control;
                }
                else
                {
                    //wplayer.controls.play();
                    //play_button.BackgroundImage = Nob2.Properties.Resources.control_pause;
                }
            }
        }

        private void volume_track_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = volume_track.Value;
        }

        private void volume_track_ValueChanged(object sender, decimal value)
        {

        }

        private void down_image_Click(object sender, EventArgs e)
        {
            thr = new Thread(new ThreadStart(downloader));
            thr.IsBackground = true;
            thr.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (wplayer.status != "")
            {
                if (wplayer.status != "En pausa")
                {
                    wplayer.controls.pause();
                    play_picture.Image = Nob2.Properties.Resources.play;
                }
                else
                {
                    wplayer.controls.play();
                    play_picture.Image = Nob2.Properties.Resources.pause40;
                }
            }
        }

    }


}
