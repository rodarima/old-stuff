using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using agsXMPP;
using agsXMPP.protocol.client;
using agsXMPP.Collections;
using agsXMPP.protocol.iq.roster;
using System.Text.RegularExpressions;
using System.IO;

namespace TuChat
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        #region Variables

        public static string jid, pass;
        bool obtenido_xmpp = false;
        private const int INTERNET_OPTION_END_BROWSER_SESSION = 42;
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);
        private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
        private const int SET_FEATURE_ON_THREAD = 0x00000001;
        private const int SET_FEATURE_ON_PROCESS = 0x00000002;
        private const int SET_FEATURE_IN_REGISTRY = 0x00000004;
        private const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;
        private const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;
        private const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;
        private const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;
        private const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;
        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        static extern int CoInternetSetFeatureEnabled(
        int FeatureEntry,
        [MarshalAs(UnmanagedType.U4)] int dwFlags,
        bool fEnable);
        CookieContainer myCookies = new CookieContainer();
        public static XmppClientConnection xmpp;
        string[] users_id;
        string[] users_nombre;
        string[] users_estado;
        string[] users_ciudad;
        string[] users_provincia;
        string[] users_foto;
        int user_num = 0;
        int page = 0;
        bool first_timer_lista_1 = true;
        bool btimer1 = false;
        bool btimerlist = false;

        #endregion

        #region Eventos
        private void Principal_Load(object sender, EventArgs e)
        {
            int desktopHeight = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

            this.Location = new Point(0, (desktopHeight - 380));
            System.Reflection.PropertyInfo propiedadListView = typeof(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propiedadListView.SetValue(lista, true, null);
            wb.ScriptErrorsSuppressed = true;
            loading.Visible = true;
            string[] theCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            foreach (string currentFile in theCookies)
            {
                try
                {
                    System.IO.File.Delete(currentFile);
                }
                catch (Exception ex)
                {
                }
            }
            int feature = FEATURE_DISABLE_NAVIGATION_SOUNDS;
            CoInternetSetFeatureEnabled(feature, SET_FEATURE_ON_PROCESS, true);
            obtener_email_pass();
            wb.Navigate("http://www.tuenti.com/");
            T_usuario.Focus();
        }
        private void Principal_SizeChanged(object sender, EventArgs e)
        {
            lista.Columns[0].Width = Principal.ActiveForm.Width-25;
        }
        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (wb.IsBusy == false)
            {
                if (wb.Url.ToString() == "http://www.tuenti.com/?m=login")
                {
                    string code = wb.Document.Body.InnerHtml;
                    //textBox1.Text = code;

                    if (Regex.Match(code, @" incorrectos.").Success)
                    {
                        Update_testado("Email o contraseña incorrectos");
                        T_pass.Text = "";
                        T_usuario.Focus();
                    }
                    else
                    {
                        Update_testado("Bienvenido a Tuenti");

                        T_usuario.Focus();
                    }

                    /*if (T_usuario.Text != "" && T_pass.Text != "")
                    {
                        login();
                    }*/
                    loading.Visible = false;
                    B_conectar.Enabled = true;
                }
                else if (wb.Url.ToString() == "http://www.tuenti.com/#m=Home&func=view_home" && jid == null)
                {

                    string code = wb.Document.Body.InnerHtml;
                    //textBox1.Text = code;
                    jid = Regex.Match(code, @"(?<user_id>(\d)+)@xmpp(?<xmpp_number>(\d)+).tuenti.com").Value;
                    obtener_mis_datos();
                    
                    pass = code.Substring(34, 43);
                    
                    obtenido_xmpp = true;
                    //wb.Navigate("about:blank");
                    al_cargar_chat();
                    wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=0");
                    //MessageBox.Show(jid + " " + pass);
                }
                else if (wb.Url.ToString() == "about:blank" && obtenido_xmpp == true)
                {
                    guardar_email_jid();
                    conectar_chat(jid, pass);
                }

                else if (wb.Url.ToString().Contains("category=people"))
                {
                    string code = wb.Document.Body.InnerHtml;
                    int t = Regex.Matches(code, @"user_item_(?<user_id>(\d)*) class=").Count;
                    if (t != 0)
                    {

                        if (first_timer_lista_1 == true)
                        {
                            if (btimer1 == false)
                            {
                                first_timer_lista_1 = false;
                                timer_lista1.Enabled = true;
                            }
                        }
                        else
                        {
                            if (btimerlist == false)
                            {
                                timer_list.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=0");
                    
                    }
                }
            }
        }
        string mi_nombre;
        void obtener_mis_datos()
        {
            string code = wb.Document.Body.InnerHtml;
            string username = Regex.Match(code, @"href=""http://www\.tuenti\.com/#m=Profile&amp;func=index"">(?<user_name>(\S| )*)</A></H1>").Groups["user_name"].Value;
            L_nombre.Text = username;
            mi_nombre = username;
            string estado = Regex.Match(code, @"<SPAN id=contentUpdateStatus class=_updateStatus template=""shared\.RichStringPlainLinks"" control=""true"">(?<user_status>(\S| )*)</SPAN></SPAN> <SPAN id=current_status_date class=date>").Groups["user_status"].Value;
            int links = Regex.Matches(estado, "(<A[^>]*>|</A>)").Count;
            for (int i = 0; i < links; i++)
            {
                int index = Regex.Matches(estado, "(<A[^>]*>|</A>)")[0].Index;
                int lenght = Regex.Matches(estado, "(<A[^>]*>|</A>)")[0].Length;
                string estado_temp1 = estado.Substring(0, index);
                string estado_temp2 = estado.Substring(index + lenght, estado.Length - (index + lenght));
                estado = estado_temp1 + estado_temp2;
                
            }
            //MessageBox.Show(estado);
            L_estado.Text = estado;

            
        }
        private void wb_GotFocus(object sender, EventArgs e)
        {
            T_usuario.Focus();
        }
        private void B_conectar_Click(object sender, EventArgs e)
        {
            login();
        }
        private void timer_chat_Tick(object sender, EventArgs e)
        {
            Update_testado(xmpp.XmppConnectionState.ToString());
            if (xmpp.XmppConnectionState.ToString() == "SessionStarted")
            {
                timer_chat.Enabled = false;
            }
        }
        private void T_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && T_pass.Text != "")
            {
                e.Handled = true;
                login();
            }
        }
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //jid_to[0] = lista.SelectedItems[0].SubItems[1].Text;
            string num_lista = lista.SelectedItems[0].SubItems[1].Text;
            abrir_pestaña(num_lista);

        }
        void abrir_pestaña(string num_lista)
        {
            int ancho = Principal.ActiveForm.Width;
            int alto = Principal.ActiveForm.Height;
            
            int num_lista_int = Convert.ToInt32(num_lista);
            string titulo = Regex.Match(users_nombre[num_lista_int], @"(?<tit>(\w)+) (\w| )*").Groups["tit"].Value;
            if (T_principal.TabPages["T_" + num_lista] != null)
            {
                T_principal.SelectedTab = T_principal.TabPages["T_" + num_lista];
                //Controls["R_chat_enviar_" + user_to[0]].Focus();
                //R_chat_enviar_.Focus();
                return;
            }
            T_principal.TabPages.Add("T_" + num_lista, titulo);
            T_principal.TabPages["T_" + num_lista].BackColor = System.Drawing.Color.White;
            // 
            // R_chat_enviar
            // 
            RichTextBox R_chat_enviar_ = new RichTextBox();
            R_chat_enviar_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
            R_chat_enviar_.BackColor = System.Drawing.Color.White;
            R_chat_enviar_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            R_chat_enviar_.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            R_chat_enviar_.Location = new System.Drawing.Point(0, 0);
            R_chat_enviar_.Name = "R_chat_enviar_" + num_lista;
            R_chat_enviar_.Size = new System.Drawing.Size(ancho - (200 - 187), alto - (350 - 46));
            R_chat_enviar_.TabIndex = 0;
            R_chat_enviar_.Text = "";
            R_chat_enviar_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Enviar_mensaje);
            //T_principal.TabPages[user_to[0]].Controls.Add(R_chat_enviar_);
            // 
            // R_chat_conversacion
            // 
            RichTextBox R_chat_conversacion_ = new RichTextBox();
            R_chat_conversacion_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            R_chat_conversacion_.BackColor = System.Drawing.Color.White;
            R_chat_conversacion_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            R_chat_conversacion_.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            R_chat_conversacion_.Location = new System.Drawing.Point(0, 0);
            R_chat_conversacion_.Name = "R_chat_conversacion_" + num_lista; ;
            R_chat_conversacion_.ReadOnly = true;
            R_chat_conversacion_.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            R_chat_conversacion_.Size = new System.Drawing.Size(ancho - (200 - 187), alto - (350 - 212));
            R_chat_conversacion_.TabIndex = 1;
            R_chat_conversacion_.Text = "";
            //T_principal.TabPages[user_to[0]].Controls.Add(R_chat_conversacion_);
            // 
            // I_chat_usuario
            // 
            PictureBox I_chat_usuario_ = new PictureBox();
            I_chat_usuario_.InitialImage = (Image)Properties.Resources.user;
            I_chat_usuario_.ImageLocation = users_foto[num_lista_int];
            I_chat_usuario_.Location = new System.Drawing.Point(0, 0);
            I_chat_usuario_.Name = "I_chat_usuario_" + num_lista;
            I_chat_usuario_.Size = new System.Drawing.Size(32, 32);
            I_chat_usuario_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            I_chat_usuario_.TabIndex = 2;
            I_chat_usuario_.TabStop = false;
            T_principal.TabPages["T_" + num_lista].Controls.Add(I_chat_usuario_);
            // 
            // L_chat_usuario
            // 
            Label L_chat_usuario_ = new Label();
            L_chat_usuario_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            L_chat_usuario_.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            L_chat_usuario_.ForeColor = System.Drawing.Color.SteelBlue;
            L_chat_usuario_.Location = new System.Drawing.Point(32, 2);
            L_chat_usuario_.Name = "L_chat_usuario_" + num_lista;
            L_chat_usuario_.Size = new System.Drawing.Size(ancho - (200 - 139), 17);
            L_chat_usuario_.TabIndex = 3;
            L_chat_usuario_.Text = users_nombre[num_lista_int];
            T_principal.TabPages["T_" + num_lista].Controls.Add(L_chat_usuario_);
            // 
            // L_chat_estado
            // 
            Label L_chat_estado_ = new Label();
            L_chat_estado_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            L_chat_estado_.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            L_chat_estado_.ForeColor = System.Drawing.Color.Gray;
            L_chat_estado_.Location = new System.Drawing.Point(32, 16);
            L_chat_estado_.Name = "L_chat_estado_" + num_lista;
            L_chat_estado_.Size = new System.Drawing.Size(ancho - (200 - 155), 14);
            L_chat_estado_.TabIndex = 4;
            L_chat_estado_.Text = users_ciudad[num_lista_int] + ", " + users_provincia[num_lista_int];
            T_principal.TabPages["T_" + num_lista].Controls.Add(L_chat_estado_);
            // 
            // T_chat_panel_enviar
            // 
            /*Panel T_chat_panel_enviar_ = new Panel();
            T_chat_panel_enviar_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            T_chat_panel_enviar_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            T_chat_panel_enviar_.Controls.Add(R_chat_enviar_);
            T_chat_panel_enviar_.Location = new System.Drawing.Point(3, 3);
            T_chat_panel_enviar_.Name = "T_chat_panel_enviar_" + user_to[0];
            T_chat_panel_enviar_.Size = new System.Drawing.Size(182, 38);
            T_chat_panel_enviar_.TabIndex = 5;
            */
            //T_principal.TabPages[user_to[0]].Controls.Add(T_chat_panel_enviar_);
            // 
            // S_chat_divisor
            // 
            SplitContainer S_chat_divisor_ = new SplitContainer();
            S_chat_divisor_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            S_chat_divisor_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            S_chat_divisor_.Location = new System.Drawing.Point(1, 35);
            S_chat_divisor_.Name = ("S_chat_divisor_" + num_lista);
            S_chat_divisor_.Orientation = System.Windows.Forms.Orientation.Horizontal;
            S_chat_divisor_.Size = new System.Drawing.Size(ancho - (200 - 187), alto - (200 - 262));
            S_chat_divisor_.SplitterDistance = (int)((210.0 / 350.0) * alto);
            S_chat_divisor_.IsSplitterFixed = false;
            S_chat_divisor_.TabIndex = 6;
            S_chat_divisor_.BackColor = System.Drawing.Color.LightGray;
            // 
            // S_chat_divisor.Panel1
            // 
            S_chat_divisor_.Panel1.Controls.Add(R_chat_conversacion_);
            // 
            // S_chat_divisor.Panel2
            // 
            S_chat_divisor_.Panel2.Controls.Add(R_chat_enviar_);



            T_principal.TabPages["T_" + num_lista].Controls.Add(S_chat_divisor_);
            // 
            // I_chat_cerrar
            // 
            PictureBox I_chat_cerrar_ = new PictureBox();

            I_chat_cerrar_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

            I_chat_cerrar_.Image = (Image)Properties.Resources.members_close;
            I_chat_cerrar_.Location = new System.Drawing.Point(ancho - (200 - 173), 3);
            I_chat_cerrar_.Name = "I_chat_cerrar_" + num_lista;
            I_chat_cerrar_.Size = new System.Drawing.Size(12, 12);
            I_chat_cerrar_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            I_chat_cerrar_.TabIndex = 7;
            I_chat_cerrar_.TabStop = false;
            I_chat_cerrar_.Click += new System.EventHandler(I_chat_cerrar_Click);
            T_principal.TabPages["T_" + num_lista].Controls.Add(I_chat_cerrar_);
            T_principal.TabPages["T_" + num_lista].Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            T_principal.TabPages["T_" + num_lista].Click += new System.EventHandler(T_pestaña_Click);
            //T_principal.SelectedTab = T_principal.TabPages["T_" + num_lista];
            //R_chat_enviar_.Focus();
        }
        private void T_pestaña_Click(object sender, EventArgs e)
        {
            TabPage t = sender as TabPage;
            t.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void Enviar_mensaje(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter )
            {
                e.Handled = true;
                RichTextBox r = sender as RichTextBox;
                string msg = r.Text;
                msg = msg.Substring(0,msg.Length-1);
                r.Text = "";
                string num = r.Name.Substring("R_chat_enviar_".Length);
                Control[] d = Controls.Find("R_chat_conversacion_" + num, true); 
                d[0].Invoke(new UpdateTextControl(añadir_msg), new object[] { d[0], msg + Environment.NewLine , Color.Black });
                string jid_a = lista.FindItemWithText(users_id[Convert.ToInt32(num)], true ,0).SubItems[2].Text;
                xmpp.Send(new agsXMPP.protocol.client.Message(new Jid(jid_a), MessageType.chat, msg));
            }
            
        }


        private void T_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                
            
                filtrar_lista();
            }
            
            
        }
        string[] nueva_lista_usuario;
        string[] nueva_lista_num;
        string[] nueva_lista_jid;
        bool buscando = false;
        int num_nuevos=0;
        void filtrar_lista()
        {
            
            
            if (buscando == false)
            {
                num_nuevos = lista.Items.Count;
                nueva_lista_usuario = new string[num_nuevos];
                nueva_lista_num = new string[num_nuevos];
                nueva_lista_jid = new string[num_nuevos];



                for (int i = 0; i < num_nuevos; i++)
                {
                    nueva_lista_usuario[i] = lista.Items[i].SubItems[0].Text;
                    nueva_lista_num[i] = lista.Items[i].SubItems[1].Text;
                    nueva_lista_jid[i] = lista.Items[i].SubItems[2].Text;
                    
                }

            }
            for (int i = 0; i < lista.Items.Count; i++)
            {
                lista.Items.Remove(lista.Items[0]);
            }
            buscando = true;
            if (T_buscar.Text != "")
            {
                for (int i = 0; i < num_nuevos; i++)
                {
                    if (nueva_lista_usuario[i].ToLower().Contains(T_buscar.Text.ToLower()))
                    {
                        ListViewItem lvi = lista.Items.Add(nueva_lista_usuario[i]);
                        lvi.UseItemStyleForSubItems = false;
                        lvi.SubItems.Add(nueva_lista_num[i]).ForeColor = Color.Gray;
                        lvi.SubItems.Add(nueva_lista_jid[i]);
                    }

                }
            }
            else
            {
                for (int i = 0; i < num_nuevos; i++)
                {
                    
                        ListViewItem lvi = lista.Items.Add(nueva_lista_usuario[i]);
                        lvi.UseItemStyleForSubItems = false;
                        lvi.SubItems.Add(nueva_lista_num[i]).ForeColor = Color.Gray;
                        lvi.SubItems.Add(nueva_lista_jid[i]);
                    

                }
                buscando = false;
            }
        }
        bool timer_testado_ = false;
        private void timer_testado_Tick(object sender, EventArgs e)
        {
            testado.Visible = true;
            if (timer_testado_ == true)
            {
                testado.Visible = false;
                timer_testado.Enabled = false;
                timer_testado_ = false;
            }
            else
            {
                timer_testado_ = true;
            }
            

        }
        private void send_message(object sender, EventArgs e)
        {
            RichTextBox r = sender as RichTextBox;
            r.SelectionFont = new Font("Arial", (float)9.75, FontStyle.Bold);
            r.SelectedText += DateTime.Now.ToString() + Environment.NewLine; 
        }
        bool timer_lista_ = false;
        private void timer_lista_Tick(object sender, EventArgs e)
        {
            if (timer_lista_ == true)
            {
                int lista_items = lista.Items.Count;
                for (int i = 0; i < lista_items; i++)
                {
                    lista.Items[i].BackColor = Color.White;
                    
                }
                timer_lista_ = false;
                timer_lista.Enabled = false;
            }
            else
            {
                timer_lista_ = true;
            }
        }

        private void I_chat_cerrar_Click(object sender, EventArgs e)
        {
            PictureBox I_cerrar = sender as PictureBox;
            string name = I_cerrar.Name;
            name = name.Substring("I_chat_cerrar_".Length);
            T_principal.TabPages.Remove(T_principal.TabPages["T_"+name]);
            
        }
        private void I_chat_cerrar_tabprueba_Click(object sender, EventArgs e)
        {
            T_principal.TabPages.Remove(T_principal.TabPages["tabPage2"]);

        }
        private void timer_lista1_Tick(object sender, EventArgs e)
        {
            if (btimer1 == true)
            {
                //btimer1 = false;
                timer_lista1.Enabled = false;
                string code = wb.Document.Body.InnerHtml;

                //MessageBox.Show(get_num_pages().ToString());
                get_users();
                //wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={\"user_scope\":1}&category=people&page_no=1");
                if (btimerlist == false)
                {
                    timer_list.Enabled = true;
                }

            }
            else
            {
                btimer1 = true;
            }
        }
        private void timer_list_Tick(object sender, EventArgs e)
        {
            if (btimerlist == true)
            {
                get_users();
            }
            else
            {
                btimerlist = true;
            }
        }


        #endregion

        #region Funciones

        void al_cargar_chat()
        {
            loading.Visible = false;
            Update_testado("Sesión iniciada");
            P_login.Visible = false;
            T_chat.Visible = true;
        }
        void guardar_email_jid()
        {

            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt"))
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt");
                string lista_xmpp = sr.ReadToEnd();
                sr.Close();
                if (lista_xmpp.Contains(T_usuario.Text)) { return; }
                testado.Text = ("Añadiendo datos");
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt", true))
                {
                    sw.WriteLine(T_usuario.Text + ";" + jid + ";" + mi_nombre);
                    testado.Text = ("Guardado");
                }
            }
            else
            {
                testado.Text = ("Creando nuevos datos");
                DirectoryInfo DIR = new DirectoryInfo(Environment.CurrentDirectory + @"\Data");
                if (!DIR.Exists)
                {
                    DIR.Create();
                }
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt"))
                {
                    sw.WriteLine(T_usuario.Text + ";" + jid + ";" + mi_nombre);
                    testado.Text = ("Guardado");
                }
            }
        }
        public string Enchufar(string Correo, string pass)
        {
            HttpWebRequest Red = (HttpWebRequest)WebRequest.Create("http://www.tuenti.com/?");
            Red.Method = "GET";
            //Red.UserAgent = "Mozilla/6.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko/2008072820 Firefox/3.0.1";
            Red.ContentType = "application/x-www-form-urlencoded";

            try
            {
                Stream Flujo = Red.GetResponse().GetResponseStream();
                StreamReader LectorDeFlujo = new StreamReader(Flujo);

                String sLine = "";
                String cad = "";

                while (sLine != null)
                {
                    sLine = LectorDeFlujo.ReadLine();
                    if (sLine != null)
                        cad += sLine + Environment.NewLine;
                }
                string Argumentos = "email=" + Correo + "&input_password=" + pass + "&timezone=1";
                return Argumentos;
            }
            catch
            {
                return null;
            }// datos es lo que devuelve la funcion anterior
        }
        public string Obtener_pass(string Argumentos)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            System.Uri Lugar = new System.Uri("https://www.tuenti.com/?m=Login&func=do_login");
            HttpWebRequest Red = (HttpWebRequest)HttpWebRequest.Create(Lugar);
            Red.AllowAutoRedirect = false;
            Red.ProtocolVersion = HttpVersion.Version11;
            Red.Method = "POST";
            //Red.UserAgent = "Mozilla/6.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko/2008072820 Firefox/3.0.1";
            Red.ContentType = "application/x-www-form-urlencoded";
            byte[] ContenidoBytes = UTF8Encoding.UTF8.GetBytes(Argumentos);
            Red.ContentLength = ContenidoBytes.Length;



            try
            {
                Stream FlujoPosterior = Red.GetRequestStream();
                FlujoPosterior.Write(ContenidoBytes, 0, ContenidoBytes.Length);
                FlujoPosterior.Close();
            }
            catch { }
            string Galleta;

            HttpWebResponse Respuesta = (HttpWebResponse)Red.GetResponse();
            Galleta = Respuesta.GetResponseHeader("Set-Cookie");
            Galleta = Regex.Match(Galleta, @"sid=(\S).{42}").Value.Substring(4);
            //MessageBox.Show(Regex.Match(Galleta, @"sid=(\S).{42}").Value.Substring(4));
            /*Cookie c = new Cookie();

            c.Value = Regex.Match(Galleta, @"sid=(\S).{42}").Value.Substring(4);
            c.Domain = ".tuenti.com";
            c.Name = "sid";
            c.Path = "/";
            myCookies.Add(c);
            c.Value = "m=Home&func=view_home";
            c.Domain = "www.tuenti.com";
            c.Name = "tempHash";
            c.Path = "/";
            myCookies.Add(c);*/
            return Galleta;



        }
        bool comprobar_datos_guardados_email_xmpp()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt") ||
                File.Exists(Environment.CurrentDirectory + @"\Data\" + T_usuario.Text + ".txt")
                )
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt");
                string lista_xmpp = sr.ReadToEnd();
                sr.Close();
                if (lista_xmpp.Contains(T_usuario.Text))
                {
                    jid = Regex.Match(lista_xmpp, T_usuario.Text +@";(?<jid>(\d){8}@xmpp(\d)+\.tuenti\.com);(?<nombre>(.)*)").Groups["jid"].Value;
                    mi_nombre = Regex.Match(lista_xmpp, T_usuario.Text +@";(?<jid>(\d){8}@xmpp(\d)+\.tuenti\.com);(?<nombre>(\S| )*)").Groups["nombre"].Value;
                    L_nombre.Text = mi_nombre;
                    
                    //MessageBox.Show(jid);
                    return true;
                }

            }
            return false;
        }
        void leer_lista_usuarios()
        {
            string[] lineas = File.ReadAllLines(Environment.CurrentDirectory + @"\Data\" + T_usuario.Text + ".txt");
            int n = lineas.Length;
            users_id = new string[n];
            users_nombre = new string[n];
            users_estado = new string[n];
            users_ciudad = new string[n];
            users_provincia = new string[n];
            users_foto = new string[n];
            for (int i = 0; i < lineas.Length; i++)
            {
                users_id[i] = Regex.Match(lineas[i], @"(?<user_id>(\d)*);(?<user_nombre>(\S| )*);(?<user_foto>(\S)*);(?<user_ciudad>(\w| |,|-|_)*);(?<user_provincia>(\w| )*);").Groups["user_id"].Value;
                users_nombre[i] = Regex.Match(lineas[i], @"(?<user_id>(\d)*);(?<user_nombre>(\S| )*);(?<user_foto>(\S)*);(?<user_ciudad>(\w| |,|-|_)*);(?<user_provincia>(\w| )*);").Groups["user_nombre"].Value;
                users_foto[i] = Regex.Match(lineas[i], @"(?<user_id>(\d)*);(?<user_nombre>(\S| )*);(?<user_foto>(\S)*);(?<user_ciudad>(\w| |,|-|_)*);(?<user_provincia>(\w| )*);").Groups["user_foto"].Value;
                users_ciudad[i] = Regex.Match(lineas[i], @"(?<user_id>(\d)*);(?<user_nombre>(\S| )*);(?<user_foto>(\S)*);(?<user_ciudad>(\w| |,|-|_)*);(?<user_provincia>(\w| )*);").Groups["user_ciudad"].Value;
                users_provincia[i] = Regex.Match(lineas[i], @"(?<user_id>(\d)*);(?<user_nombre>(\S| )*);(?<user_foto>(\S)*);(?<user_ciudad>(\w| |,|-|_)*);(?<user_provincia>(\w| )*);").Groups["user_provincia"].Value;
            }

        }
        public string Encode64(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }
        public string Decode64(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
        void borrar_email_pass()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\Data\recordar.txt"))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.

                System.IO.File.Delete(Environment.CurrentDirectory + @"\Data\recordar.txt");

            }
        }
        void obtener_email_pass()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\Data\recordar.txt"))
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(Environment.CurrentDirectory + @"\Data\recordar.txt");
                string user_pass = sr.ReadToEnd();
                sr.Close();
                if(user_pass!=""){
                    string user_pass_decoded = Decode64(user_pass);
                    string u = user_pass_decoded.Split(';')[0];
                    string p = user_pass_decoded.Split(';')[1];
                    T_usuario.Text = u;
                    T_pass.Text = p;
                }

            }
        }
        void guardar_email_pass()
        {
            DirectoryInfo DIR = new DirectoryInfo(Environment.CurrentDirectory + @"\Data");
            if (!DIR.Exists)
            {
                DIR.Create();
            }
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\Data\recordar.txt"))
            {
                string str = T_usuario.Text + ";" + T_pass.Text;
                str = Encode64(str);
                sw.Write(str);
            }
        }
        CookieContainer Obtener_CookieContainer_movil(string email, string pass)
        {

            byte[] buffer = Encoding.ASCII.GetBytes("tuentiemail=" + email + "&password=" + pass + "&remember=1");

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Login&func=process_login");
            WebReq.Method = "POST";
            WebReq.AllowAutoRedirect = false;
            Cookie cookiename = new Cookie();
            cookiename.Name = "cookiename";
            cookiename.Value = "1";
            cookiename.Path = "/";
            cookiename.Domain = "m.tuenti.com";
            CookieContainer cc = new CookieContainer();
            cc.Add(cookiename);
            WebReq.CookieContainer = cc;
            WebReq.ContentType = "application/x-www-form-urlencoded";
            WebReq.KeepAlive = true;
            WebReq.ContentLength = buffer.Length;


            Stream PostData = WebReq.GetRequestStream();
            //Now we write, and afterwards, we close. Closing is always important!
            PostData.Write(buffer, 0, buffer.Length);
            PostData.Close();
            //Get the response handle, we have no true response yet!
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            CookieCollection co = new CookieCollection();
            WebResp.Cookies = co;
            //Let's show some information about the response
            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            //Now, we read the response (the string), and output it.
            Stream Answer = WebResp.GetResponseStream();
            string Galleta;
            Galleta = WebResp.GetResponseHeader("Set-Cookie");
            Regex r = new Regex(@"tuentiemail=(\S)* expires=(?<expires1>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com,mid=(?<mid>(\w|\d|-|_)*); path=/; domain=.tuenti.com,mid=(\w|\d|-|_)*; path=/; domain=.tuenti.com,lang=(?<lang>(\w|_))*; expires=(?<expires2>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com");
            CookieContainer myCookieContiner = new CookieContainer();
            Cookie cok = new Cookie();
            cok.Name = "tuentiemail";
            cok.Value = email;
            cok.Domain = ".tuenti.com";
            cok.Expires = DateTime.Now.AddYears(1).AddDays(-1);
            cok.Path = "/";
            myCookieContiner.Add(cok);
            cok.Name = "mid";
            cok.Value = Regex.Match(Galleta, @"mid=(?<mid>(\w|\d|-|_)*);").Groups["mid"].Value;
            cok.Path = "/";
            cok.Domain = ".tuenti.com";
            myCookieContiner.Add(cok);
            cok.Name = "lang";
            cok.Value = Regex.Match(Galleta, @"lang=(?<lang>(\S)*); ").Groups["lang"].Value;
            cok.Expires = DateTime.Now.AddYears(1).AddDays(-6);
            cok.Path = "/";
            cok.Domain = ".tuenti.com";
            myCookieContiner.Add(cok);
            /*
            myCookieContiner.Add(WebResp.Cookies);
            
            
            StreamReader _Answer = new StreamReader(Answer);
            MessageBox.Show("response html:" + _Answer.ReadToEnd());
            for(int i =0; i< myCookieContiner.Count;i++){
                MessageBox.Show(WebResp.Cookies[i].Name + " " + WebResp.Cookies[i].Value);
            }
            */
            return myCookieContiner;


        }
        string toUTF8(string s){

            s = s.Replace("&aacute;", "á");
            s = s.Replace("&eacute;", "é");
            s = s.Replace("&iacute;", "í");
            s = s.Replace("&oacute;", "ó");
            s = s.Replace("&uacute;", "ú");

            s = s.Replace("&Aacute;", "Á");
            s = s.Replace("&Eacute;", "É");
            s = s.Replace("&Iacute;", "Í");
            s = s.Replace("&Oacute;", "Ó");
            s = s.Replace("&Uacute;", "Ú");

            s = s.Replace("&not;", "¬");
            s = s.Replace("&#039;", "'");


            return s;
        }
        void obtener_nombre_estado_movil(CookieContainer cc)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Profile&func=my_profile");
            WebReq.CookieContainer = cc;
            WebReq.ContentType = "application/x-www-form-urlencoded";
            WebReq.Referer = "http://m.tuenti.com/?m=login";
            WebReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            WebReq.AllowAutoRedirect = false;
            WebReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";

            //Get the response handle, we have no true response yet!
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            //MessageBox.Show(WebResp.GetResponseHeader("Location"));

            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            Stream Answer = WebResp.GetResponseStream();
            StreamReader _Answer = new StreamReader(Answer, Encoding.UTF8, false);
            string code = _Answer.ReadToEnd();
            string img = Regex.Match(code, @"<img id=""profile_img"" src=""(?<img_perfil>(\S)*)"" width=""75""/>").Groups["img_perfil"].Value;
            I_usuario.ImageLocation = img;
            string estado = Regex.Match(code, @"<div id=""status"" class=""box""><div class=""h"">[^<]*</div><div class=""body""><div><small>(?<user_status>(\S| )*)</small></div></div><form action=""\?m=profile&amp;func=process_set_status").Groups["user_status"].Value;
            int links = Regex.Matches(estado, "(  <a[^>]*>|</a>  )").Count;
            for (int i = 0; i < links; i++)
            {
                int index = Regex.Matches(estado, "(  <a[^>]*>|</a>  )")[0].Index;
                int lenght = Regex.Matches(estado, "(  <a[^>]*>|</a>  )")[0].Length;
                string estado_temp1 = estado.Substring(0, index);
                string estado_temp2 = estado.Substring(index + lenght, estado.Length - (index + lenght));
                estado = estado_temp1 + estado_temp2;


            }
            estado = toUTF8(estado);
            L_estado.Text = estado;
            _Answer.Close();
            Answer.Close();
        }
        void login()
        {
            if (T_usuario.Text != "" && T_pass.Text != "")
            {
                loading.Visible = true;
                testado.Text = "Accediendo a tuenti...";

                if (C_recordar.Checked == true)
                {

                    guardar_email_pass();
                }
                else
                {
                    if (File.Exists(Environment.CurrentDirectory + @"\Data\recordar.txt"))
                    {
                        File.Delete(Environment.CurrentDirectory + @"\Data\recordar.txt");
                    }
                }

                if (comprobar_datos_guardados_email_xmpp() == true)
                {
                    wb.Navigate("about:blank");
                    string datos = Enchufar(T_usuario.Text, T_pass.Text);
                    pass = Obtener_pass(datos);
                    
                    //MessageBox.Show(jid + " " + pass);

                    CookieContainer cc = Obtener_CookieContainer_movil(T_usuario.Text, T_pass.Text);
                    obtener_nombre_estado_movil(cc);
                    leer_lista_usuarios();
                    al_cargar_chat();
                    conectar_chat(jid, pass);

                }
                else if (wb.Url.ToString() == "http://www.tuenti.com/?m=login")
                {

                    wb.Document.GetElementById("email").InnerText = T_usuario.Text;
                    wb.Document.GetElementById("input_password").InnerText = T_pass.Text;
                    wb.Document.GetElementById("remember").SetAttribute("checked", "false");
                    wb.Document.GetElementById("submit_button").InvokeMember("click");
                }
            }
        }
        void conectar_chat(string jid, string pass)
        {
            Jid jidSender = new Jid(jid);
            xmpp = new XmppClientConnection(jidSender.Server);

            /*
             * Open the connection
             * and register the OnLogin event handler
             */
            try
            {
                xmpp.Open(jidSender.User, pass);
                xmpp.OnLogin += new ObjectHandler(xmpp_OnLogin);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            /*
             * workaround, jus waiting till the login 
             * and authentication is finished
             * 
             */
            timer_chat.Enabled = true;
        }
        public delegate void llamar_void();
        public delegate void UpdateInfo(string a);
        public delegate void UpdateTextCallback(string User,string num, string jid);
        private void add(string User, string num, string m_jid)
        {
            ListViewItem item_remove;
            item_remove = lista.FindItemWithText(User);
            if (item_remove == null)
            {
                ListViewItem lvi = lista.Items.Add(Convert.ToString(User));
                lvi.UseItemStyleForSubItems = false;
                lvi.BackColor = Color.LightGreen;
                lvi.SubItems.Add(Convert.ToString(num)).ForeColor = Color.Gray;
                lvi.SubItems.Add(m_jid);
                timer_lista.Enabled = true;
                timer_lista_ = false;
            }

        }
        private void remove(string jid)
        {
            ListViewItem item_remove;
            item_remove = lista.FindItemWithText(jid);
            if (item_remove != null)
            {
                item_remove.Remove();
            }
        }
        void xmpp_OnPresence(object sender, Presence pres)
        {
            string user = pres.From.User;
            int num = -1;
            for(int i = 0;i<users_id.Length; i++){
                if (users_id[i] == user)
                {
                    num = i;
                    user = users_nombre[i];
                    break;
                }
                if (user == jid.Substring(0, 8))
                {
                    num = -2;
                    user = "Tu mismo";
                }
                
            }
            if (user == pres.From.User)
            {
                MessageBox.Show("error con " + user);

            }
                
            //MessageBox.Show(pres.Type.ToString());
            if(num>=0){
            if (pres.Type.ToString() == "available")
            {
                xmpp.MessageGrabber.Add(new Jid(pres.From.User + "@" + pres.From.Server), new BareJidComparer(), new MessageCB(MessageCallBack), null);
                Update_testado(user+ " se ha conectado");
                lista.BeginInvoke(new UpdateTextCallback(add), new object[] { user, num.ToString(), pres.From.User + "@" + pres.From.Server });
                
            }
            else
            {
                xmpp.MessageGrabber.Remove(new Jid(pres.From.User + "@" + pres.From.Server));
                Update_testado(user + " se ha desconectado");
                lista.BeginInvoke(new UpdateInfo(remove), new object[] {  num.ToString()});

            }
            }
            
        }
        void Update_testado(string message)
        {
            testado.BeginInvoke(new UpdateInfo(Update_testado_), new object[] { message });
        }
        void Update_testado_(string message)
        {
            testado.Visible = true;
            testado.Text = message;
            timer_testado.Enabled = true;
        }
        void xmpp_OnLogin(object sender)
        {

            //timer_chat.Enabled = false;
            Update_testado( "Chat conectado (" + xmpp.XmppConnectionState + ")");

            Presence p = new Presence(ShowType.chat, "Online");
            p.Type = PresenceType.available;
            xmpp.Send(p);


            /*
             * 
             * get the roster (see who's online)
             */
            xmpp.OnPresence += new PresenceHandler(xmpp_OnPresence);

            //wait until we received the list of available contacts            


            /*
            xmpp.MessageGrabber.Add(new Jid(JID_Receiver),
                                     new BareJidComparer(),
                                     new MessageCB(MessageCallBack),
                                     null);

            
            string outMessage;
            bool halt = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                outMessage = Console.ReadLine();
                if (outMessage == "q!")
                {
                    halt = true;
                }
                else
                {
                    xmpp.Send(new Message(new Jid(JID_Receiver),
                                  MessageType.chat,
                                  outMessage));
                }

            } while (!halt);
            Console.ForegroundColor = ConsoleColor.White;

     
            xmpp.Close();*/

        }
        public delegate void UpdateTextControl( RichTextBox c, string text, Color color);
        void MessageCallBack(object sender, agsXMPP.protocol.client.Message msg, object data)
        {
            //MessageBox.Show(msg.From.User + ": " + msg.Body);
            string user = msg.From.User;
            int num = -1;
            for(int i=0; i<users_id.Length;i++){
                if(users_id[i]==user){
                    num=i;
                    user = users_nombre[i];
                }
            }
            if (num > 0)
            {
                if (msg.Body != null)
                {
                    if (T_principal.TabPages["T_" + num.ToString()] == null)
                    {
                        T_principal.Invoke(new UpdateInfo(abrir_pestaña), new object[] { num.ToString() });
                        
                        
                    }
                    Control[] r = Controls.Find("R_chat_conversacion_" + num.ToString(), true); 
                    r[0].Invoke(new UpdateTextControl(añadir_msg), new object[] { (RichTextBox)r[0], msg.Body + Environment.NewLine , Color.Blue });
                    //T_principal.Invoke(new UpdateTextCallback(añadir_msg),new object[] {num.ToString(), msg.Body});
                    //T_principal.TabPages["T_"+num.ToString()].Controls["R_chat_conversacion_" + num.ToString()].Text += msg.Body + Environment.NewLine;
                    Update_testado(user + ": " + msg.Body);
                }
            }
        }
        void añadir_msg(RichTextBox c, string msg, Color color)
        {
            c.SelectionColor = color;
            c.SelectedText += msg;
            c.SelectionStart = c.TextLength;
            c.ScrollToCaret();
        }
        public static string[] jid_to = new string[20];
        public static string[] user_to = new string[20];

        int get_num_users(string code)
        {
            string num = Regex.Match(code, @"<SPAN class=result>\((?<num_amigos>(\d)*) resultados\) </SPAN>").Groups["num_amigos"].Value;
            if (num != "")
            {
                int n = Convert.ToInt32(num);
                users_id = new string[n];
                users_nombre = new string[n];
                users_estado = new string[n];
                users_ciudad = new string[n];
                users_provincia = new string[n];
                users_foto = new string[n];
                return n;
            }
            return 0;
        }
        int get_num_pages(int num_amigos)
        {
            double pages = (double)num_amigos / 10;
            int intpages = num_amigos / 10;

            if (pages - intpages != 0.0) { return intpages + 1; }
            return intpages;
        }

        
        void get_users()
        {
            
            string code = wb.Document.Body.InnerHtml;
            if (wb.Url.ToString() != "about:blank")
            {
                if (users_id == null)
                {
                    get_num_users(code);
                }
                else
                {
                    Update_testado("Obteniendo amigos " + page * 10 + "/" + users_id.Length);
                }

                int t = Regex.Matches(code, @"user_item_(?<user_id>(\d)*) class=").Count;
                //textBox1.Text += t.ToString();

                if (t != 0 && user_num <= users_id.Length)
                {

                    bool repetido = false;
                    for (int i = 0; i < t; i++)
                    {
                        try
                        {

                            users_id[user_num] = Regex.Matches(code, @"user_item_(?<user_id>(\d)*) class=")[i].Groups["user_id"].Value;
                            users_nombre[user_num] = Regex.Matches(code, @"<IMG( class="" outsideNetwork"")* alt=""(?<user_nombre>(\S| )*)"" src")[i].Groups["user_nombre"].Value;
                            users_foto[user_num] = Regex.Matches(code, @"src=""(?<user_foto>(\S)*)"" width=100 height=100")[i].Groups["user_foto"].Value;
                            users_ciudad[user_num] = Regex.Matches(code, @"<SPAN class=definition>Ubicación</SPAN>(\s)*(?<user_ciudad>(\w| |,|-|_)*),(\s)*<A title=""*(?<user_provincia>(\w|\s)*)""* onclick")[i].Groups["user_ciudad"].Value;
                            users_provincia[user_num] = Regex.Matches(code, @"<SPAN class=definition>Ubicación</SPAN>(\s)*(?<user_ciudad>(\w| |,|-|_)*),(\s)*<A title=""*(?<user_provincia>(\w|\s)*)""* onclick")[i].Groups["user_provincia"].Value;

                            repetido = false;
                            for (int j = 0; j < user_num; j++)
                            {
                                if (users_id[j] == users_id[user_num])
                                {
                                    repetido = true;
                                }

                            }

                            if (repetido == false)
                            {
                                user_num++;
                            }

                        }
                        catch
                        {
                            Update_testado("Problema con el usuario " + user_num);
                            //MessageBox.Show("Problema con el usuario " + user_num);

                        }

                    }

                    if (repetido == true) { page--; }
                    if (user_num <= users_id.Length)
                    {
                        page++;
                        nav(page);
                    }

                }
                else /*if (page != 0)*/
                {
                    wb.Navigate("about:blank");
                    timer_list.Enabled = false;
                    DirectoryInfo DIR = new DirectoryInfo(Environment.CurrentDirectory + @"\Data");
                    if (!DIR.Exists)
                    {
                        DIR.Create();
                    }
                    using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\Data\" + T_usuario.Text + ".txt"))
                    {
                        for (int i = 0; i < users_id.Length; i++)
                        {
                            sw.WriteLine(users_id[i] + ";" + users_nombre[i] + ";" + users_foto[i] + ";" + users_ciudad[i] + ";" + users_provincia[i] + ";");
                            //Update_testado(users_nombre[i]);
                            //textBox1.Text += i.ToString() + ": " + users_id[i] + " - " + users_nombre[i] + " - " + users_ciudad[i] + " - " + users_provincia[i] + Environment.NewLine;
                        }
                    }

                }
            }
        }
        void nav(int page)
        {
            wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=" + page.ToString());
        }
        #endregion







       
        
        





    }
}
