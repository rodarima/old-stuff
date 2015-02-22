using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using agsXMPP;
using agsXMPP.protocol.client;
using agsXMPP.Collections;
using agsXMPP.protocol.iq.roster;
using System.IO;
using System.Net;

namespace webbrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string jid, pass;
        private void button1_Click(object sender, EventArgs e)
        {
            conectar_chat(jid, pass);
        }
        bool obtenido_xmpp = false;
        private const int INTERNET_OPTION_END_BROWSER_SESSION = 42;

        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            if (wb.Url.ToString() == "http://www.tuenti.com/?m=login")
            {
                string code = wb.Document.Body.InnerHtml;
                //textBox1.Text = code;

                if (Regex.Match(code, @"Email o contraseña incorrectos.").Success)
                {
                    testado.Text = "Email o contraseña incorrectos";
                }
                else
                {
                    testado.Text = "Bienvenido a Tuenti";
                }

                if (txEmail.Text != "" && txPass.Text != "")
                {
                    login();
                }
                loading.Visible = false;
                btOk.Enabled = true;
            } 
            if (wb.Url.ToString() == "http://www.tuenti.com/#m=Home&func=view_home")
            {
                
                string code = wb.Document.Body.InnerHtml;
                //textBox1.Text = code;
                pass = code.Substring(34, 43);
                jid = Regex.Match(code, @"(?<user_id>(\d)+)@xmpp(?<xmpp_number>(\d)+).tuenti.com").Value;
                obtenido_xmpp = true;
                wb.Navigate("about:blank");
                al_cargar_chat();
                //MessageBox.Show(jid + " " + pass);
            }
            if (wb.Url.ToString() == "about:blank" && obtenido_xmpp == true)
            {
                guardar_email_jid();
                conectar_chat(jid, pass);
            }

        }
        void al_cargar_chat()
        {
                loading.Visible = false;
                testado.Text = "Sesión iniciada";
                pReg.Visible = false;
                pChat.Visible = true;
        }
        void guardar_email_jid()
        {

            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt"))
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt");
                string lista_xmpp = sr.ReadToEnd();
                sr.Close();
                if (lista_xmpp.Contains(txEmail.Text)) { return; }
                testado.Text = ("Añadiendo datos");
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory +@"\Data\lista_xmpp.txt",true))
                {
                    sw.WriteLine(txEmail.Text + ";" + jid);
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
                    sw.WriteLine(txEmail.Text + ";" + jid);
                    testado.Text = ("Guardado");
                }
            }
        }

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
        [return:MarshalAs(UnmanagedType.Error)] 
        static extern int CoInternetSetFeatureEnabled( 
        int FeatureEntry, 
        [MarshalAs(UnmanagedType.U4)] int dwFlags, 
        bool fEnable); 
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Reflection.PropertyInfo propiedadListView = typeof(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propiedadListView.SetValue(list, true, null);
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
            wb.Navigate("http://www.tuenti.com/");
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
        CookieContainer myCookies = new CookieContainer();
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
            if (File.Exists(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt")) {
                System.IO.StreamReader sr = new System.IO.StreamReader(Environment.CurrentDirectory + @"\Data\lista_xmpp.txt");
                string lista_xmpp = sr.ReadToEnd();
                sr.Close();
                if (lista_xmpp.Contains(txEmail.Text)) {
                    jid = Regex.Match(lista_xmpp, txEmail.Text+@";\S*").Value.Substring(txEmail.Text.Length+1);
                    //MessageBox.Show(jid);
                    return true; }
            
            }
            return false;
        }
        void login()
        {
            loading.Visible = true;
            testado.Text = "Accediendo a tuenti...";


            if (comprobar_datos_guardados_email_xmpp() == true)
            {
                wb.Navigate("about:blank");
                string datos = Enchufar(txEmail.Text, txPass.Text);
                pass = Obtener_pass(datos);
                //MessageBox.Show(jid + " " + pass);
                al_cargar_chat();
                conectar_chat(jid, pass);
                
            }
            else if (wb.Url.ToString() == "http://www.tuenti.com/?m=login")
            {
                wb.Document.GetElementById("email").InnerText = txEmail.Text;
                wb.Document.GetElementById("input_password").InnerText = txPass.Text;
                wb.Document.GetElementById("remember").SetAttribute("checked", "false");
                wb.Document.GetElementById("submit_button").InvokeMember("click");
            } 
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            login();
        }


        /*Chat  ########################################*/


        public static XmppClientConnection xmpp;
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
        public delegate void UpdateTextCallback(string User, string jid);
        private void add(string User, string jid)
        {
            ListViewItem item_remove;
            item_remove = list.FindItemWithText(User);
            if (item_remove == null)
            {
                ListViewItem lvi = list.Items.Add(Convert.ToString(User));
                lvi.UseItemStyleForSubItems = false;
                lvi.SubItems.Add(Convert.ToString(jid)).ForeColor = Color.Gray;
            }
                
        }
        private void remove(string User, string jid)
        {
            ListViewItem item_remove;
            item_remove = list.FindItemWithText(User);
            if (item_remove!=null){
                item_remove.Remove();
            }
        }
        void xmpp_OnPresence(object sender, Presence pres)
        {
            //MessageBox.Show(pres.Type.ToString());
            if (pres.Type.ToString() == "available")
            {
                list.BeginInvoke(new UpdateTextCallback(add), new object[] { pres.From.User, pres.From.User + "@" + pres.From.Server });
            }
            else
            {
                list.BeginInvoke(new UpdateTextCallback(remove), new object[] { pres.From.User, pres.From.User + "@" + pres.From.Server });
            
            }
            testado.Text = pres.From.User + "@" + pres.From.Server + "  " + pres.Type;
        }
        void xmpp_OnLogin(object sender)
        {
            //timer_chat.Enabled = false;
            testado.Text = "Chat conectado (" + xmpp.XmppConnectionState+ ")";

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
        static void MessageCallBack(object sender,agsXMPP.protocol.client.Message msg, object data)
        {
            if (msg.Body != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0}>> {1}", msg.From.User, msg.Body);
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
        private void timer_chat_Tick(object sender, EventArgs e)
        {
            testado.Text = xmpp.XmppConnectionState.ToString();
            if (xmpp.XmppConnectionState.ToString() == "SessionStarted")
            {
                timer_chat.Enabled = false;
            }
        }
        private void txPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txPass.Text!="")
            {
                e.Handled = true;
                login();
            }
        }
        public static string[] jid_to = new string[20];
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            jid_to[0] = list.SelectedItems[0].SubItems[1].Text;
            Form f = new Ventana_chat();
            f.Show();
            //MessageBox.Show(list.SelectedItems[0].SubItems[0].Text);
        }

        //Numero a nombres

        string[] user_name = new string[500];
        string[] user_id = new string[500];
        string[] splited = new string[500];
        int u = 0;
        int pag = 0;
        string pass_id;
        int pages = 1;
        bool work = false;
        void navig()
        {
            if (pag <= pages)
            {
                getusers();
                wb.Navigate("http://www.tuenti.com/#m=Multiitemsearch&func=index&string=&filters={%22user_scope%22%3A1}&category=people&page_no=" + pag.ToString());
                pag++;
            }
            else
            {
                work = false;
            }
        }
        void getusers()
        {
            string code = wb.Document.Body.InnerHtml;
            string[] s_prev = { "return false;\" href=\"http://www.tuenti.com/#m=Profile&amp;func=index&amp;user_id=" };
            splited = code.Split(s_prev, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splited.Length; i++)
            {
                if (splited[i].Substring(8, 12) == "\"><IMG alt=\"")
                {
                    if (!user_id.Contains(splited[i].Substring(0, 8)))
                    {

                        user_id[u] = splited[i].Substring(0, 8);
                        user_name[u] = splited[i].Substring(20);
                        string[] sep1 = { "\" src=\"" };
                        string[] a = user_name[u].Split(sep1, StringSplitOptions.RemoveEmptyEntries);
                        user_name[u] = a[0];
                        u++;
                    }
                }

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            jid_to[0] = "xxxxxxx@xmpp6.tuenti.com";
            jid_to[1] = "xxxxxxx@xmpp1.tuenti.com";
            Form f = new Ventana_chat();
            f.Show();

        }





    }
}
