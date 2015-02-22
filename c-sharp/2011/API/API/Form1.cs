using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = @"\u00f1";
            char a = '\u0080';
            string s1 = s.Substring(2);
            int n = Convert.ToInt32(s1, 16);
            MessageBox.Show(((char)(n)).ToString());
            
            label1.Text = "Cargando datos. Este proceso dura unos 5 segundos.";
            this.Update();
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            ApiTuenti ap = new ApiTuenti("xxxxxxxxxxx@gmail.com", "xxxxxxxxx");
            for (int i = 0; i < ap._listaPersonas.Personas_Actuales; i++)
            {
                textBox1.Text += ap._listaPersonas[i].Nombre + " " + ap._listaPersonas[i].Apellidos;
                textBox1.Text += Environment.NewLine;
            }
            /*
            Token t = new Token();
            t.UpdateToken("xxxxxxxx@gmail.com", "xxxxxxxxxx");
            textBox1.Text = t.r;*/
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            label1.Text = ts.TotalMilliseconds.ToString();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }

    public class Token
    {
        string _Token;
        HttpWebRequest WebReq;
        HttpWebResponse WebResp;
        public Token()
        {
            return;
        }
        public string r;
        public string UpdateToken(string email, string pass)
        {
            if (email == "" && pass == "") return null;

            CookieContainer cc = Obtener_CookieContainer_movil(email, pass);
            //r = (HttpPost("http://api.pl.tuenti.com/api/", "{\"session_id\":\"" + _Token + "\",\"version\":\"0.7\",\"requests\":[[\"getUserNotifications\",{\"max_notifications\":8,\"types\":[\"unread_friend_messages\",\"unread_spam_messages\",\"new_profile_wall_posts\",\"new_friend_requests\",\"accepted_friend_requests\",\"new_photo_wall_posts\",\"new_tagged_photos\",\"new_event_invitations\",\"new_group_page_invitations\",\"group_admin_promotions\",\"group_member_promotions\",\"mentions_bare\"]}],[\"getUserNotifications\",{\"max_notifications\":20,\"types\":[\"new_profile_wall_comments\"]}],[\"getFriendsNotifications\",{\"page\":0,\"page_size\":10}],[\"getUpcomingEvents\",{\"desired_number\":20,\"include_friend_birthdays\":true}]]}"));
            //r = (HttpPost("http://api.tuenti.com/api/", "{\"session_id\":\"" + _Token + "\",\"version\":\"0.7\",\"requests\":[[\"getFriends\"]]}"));
            //r = r.Replace(",", Environment.NewLine);

            r = (HttpPost("http://api.tuenti.com/api/", "{\"session_id\":\"" + _Token + "\",\"version\":\"0.7\",\"requests\":[[\"getFriendsNotifications\"]]}"));
            return _Token;
        }
        public string TokenString
        {
            get { return _Token; }
        }
        private int ConvertToTimestamp(DateTime value)
        {
            //create Timespan by subtracting the value provided from
            //the Unix Epoch
            TimeSpan span = (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());

            //return the total seconds (which is a UNIX timestamp)
            return (int)span.TotalSeconds;
        }
        CookieContainer Obtener_CookieContainer(string email, string pass)
        {
            int timestamp = ConvertToTimestamp(DateTime.Now);
            byte[] buffer = Encoding.ASCII.GetBytes("email=" + email + "&input_password=" + pass + "&timezone=1&timestamp=" + timestamp);

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("https://secure.tuenti.com/?m=Login&func=do_login");
            WebReq.Method = "POST";
            WebReq.AllowAutoRedirect = false;/*
            Cookie cookiename = new Cookie();
            cookiename.Name = "cookiename";
            cookiename.Value = "1";
            cookiename.Path = "/";
            cookiename.Domain = "m.tuenti.com";
            CookieContainer cc = new CookieContainer();
            cc.Add(cookiename);
            WebReq.CookieContainer = cc;*/
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
            //MessageBox.Show(Galleta);
            //Regex r = new Regex(@"tuentiemail=(\S)* expires=(?<expires1>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com,mid=(?<mid>(\w|\d|-|_)*); path=/; domain=.tuenti.com,mid=(\w|\d|-|_)*; path=/; domain=.tuenti.com,lang=(?<lang>(\w|_))*; expires=(?<expires2>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com");
            CookieContainer myCookieContiner = new CookieContainer();
            Cookie cok = new Cookie();
            cok.Name = "SignatureToken";
            cok.Value = Regex.Match(Galleta, @"SignatureToken=(?<sig>(\S)*);").Groups["sig"].Value;

            cok.Domain = ".tuenti.com";
            cok.HttpOnly = true;
            cok.Secure = true;
            cok.Path = "/";
            myCookieContiner.Add(cok);


            cok = new Cookie();
            cok.Name = "sid";
            cok.Value = Regex.Match(Galleta, @"sid=(?<sid>(\S)*);").Groups["sid"].Value;
            _Token = cok.Value;
            cok.Path = "/";
            cok.Domain = ".tuenti.com";
            myCookieContiner.Add(cok);


            cok = new Cookie();
            cok.Name = "lang";
            cok.Value = Regex.Match(Galleta, @"lang=(?<lang>(\S)*); ").Groups["lang"].Value;
            cok.Expires = DateTime.UtcNow.AddYears(1).AddDays(-6);
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

        CookieContainer Obtener_CookieContainer_movil(string email, string pass)
        {

            byte[] buffer = Encoding.ASCII.GetBytes("tuentiemail=" + email + "&password=" + pass + "&remember=1");

            WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Login&func=process_login");
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
            WebResp = (HttpWebResponse)WebReq.GetResponse();
            CookieCollection co = new CookieCollection();
            WebResp.Cookies = co;
            //Let's show some information about the response
            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            //Now, we read the response (the string), and output it.
            Stream Answer = WebResp.GetResponseStream();
            string Galleta;
            Galleta = WebResp.GetResponseHeader("Set-Cookie");
            _Token = Regex.Match(Galleta, @"mid=(?<mid>(\w|\d|-|_)*);").Groups["mid"].Value;
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
        /*private string Obtener_Jid_y_Token(string email, string pass)
        {

        }*/
        string HttpPost(string uri, string parameters)
        {
            // parameters: name1=value1&name2=value2 

            WebReq = (HttpWebRequest)WebRequest.Create(uri);
            WebReq.Method = "POST";
            WebReq.ContentType = "application/x-www-form-urlencoded";
            //WebReq.UserAgent = "Tuenti/2.3 CFNetwork/485.12.7 Darwin/10.4.0";
            //WebReq.Accept = "*/*";
            //WebReq.KeepAlive = true;
            //WebReq.ContentLength = 651;
            WebReq.Host = "api.tuenti.com";


            byte[] bytes = Encoding.ASCII.GetBytes(parameters);
            Stream os = null;
            try
            {
                WebReq.ContentLength = bytes.Length;   //Count bytes to send
                os = WebReq.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);         //Send it
            }
            catch (WebException ex)
            {

            }
            finally
            {
                if (os != null)
                {
                    os.Close();
                }
            }

            try
            {
                WebResponse webResponse = WebReq.GetResponse();
                if (webResponse == null)
                {
                    return null;
                }
                StreamReader sr = new StreamReader(webResponse.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {

            }
            return null;
        }
    }

    public class ApiTuenti
    {
        private string _token;
        HttpWebRequest WebReq;
        HttpWebResponse WebResp;
        public enum LoginStates { Incorrect_Email_Or_Password, OK, Loading };
        LoginStates _loginStatus;
        public ListaPersonas _listaPersonas;
        
        public ApiTuenti(string email, string pass)
        {
            _loginStatus = LoginStates.Loading;
            _listaPersonas = new ListaPersonas();
            GetToken(email, pass);
            if (_loginStatus == LoginStates.OK)
            {
                GetFriendsData();
            }
        }
        public void GetFriendsData()
        {
            string Data = HttpPostApi("http://api.tuenti.com/api/", "{\"session_id\":\"" + _token + "\",\"version\":\"0.7\",\"requests\":[[\"getFriendsData\"]]}");
            System.Text.RegularExpressions.MatchCollection Matches = System.Text.RegularExpressions.Regex.Matches(Data, @"{""id"":(?<ID>\d*),""name"":""(?<NAME>(\S| )+?)"",""surname"":""(?<SURNAME>(\S| )+?)"",""sex"":(?<SEX>\d),""phone_number"":(?<PHONE_NUMBER>\S+?),""avatar"":\[(""(?<AVATAR>\S+?)""|null),(-|\d)+,(-|\d)+],""chat_server"":""(?<CHAT_SERVER>\S+?)""}");
            for (int i = 0; i < Matches.Count; i++)
            {
                string ID = Matches[i].Groups["ID"].Value;
                string NAME = Matches[i].Groups["NAME"].Value;
                string SURNAME = Matches[i].Groups["SURNAME"].Value;
                string SEX = Matches[i].Groups["SEX"].Value;
                string PHONE_NUMBER = Matches[i].Groups["PHONE_NUMBER"].Value;
                string AVATAR = Matches[i].Groups["AVATAR"].Value;
                AVATAR = AVATAR.Replace("\\", "");
                string CHAT_SERVER = Matches[i].Groups["CHAT_SERVER"].Value;

                if (AVATAR == "") AVATAR = null;
                NAME = Latin1ToASCII(NAME);
                SURNAME = Latin1ToASCII(SURNAME);

                _listaPersonas.AgregarPersona(ID, NAME, SURNAME, SEX, PHONE_NUMBER, AVATAR, CHAT_SERVER);
            }
        }
        public LoginStates LoginStatus
        {
            get { return _loginStatus; }
        }


        private string Latin1ToASCII(string str)
        {
            
            MatchCollection m = Regex.Matches(str, @"\\(u|U)00(?<hex>(\w){2})");
            for (int i = 0; i < m.Count; i++)
            {
                string s1 = m[i].Groups["hex"].Value;
                int n = Convert.ToInt32(s1, 16);
                str = Regex.Replace(str, @"\\(u|U)00(?<hex>(\w){2})", ((char)(n)).ToString());

            }
            return str;
        }
        private void GetToken(string email, string pass)
        {
            byte[] buffer = Encoding.ASCII.GetBytes("tuentiemail=" + email + "&password=" + pass + "&remember=1");

            WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Login&func=process_login");
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
            WebResp = (HttpWebResponse)WebReq.GetResponse();
            CookieCollection co = new CookieCollection();
            WebResp.Cookies = co;
            //Let's show some information about the response
            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            //Now, we read the response (the string), and output it.
            Stream Answer = WebResp.GetResponseStream();
            string Galleta;
            Galleta = WebResp.GetResponseHeader("Set-Cookie");
            _token = Regex.Match(Galleta, @"mid=(?<mid>(\w|\d|-|_)*);").Groups["mid"].Value;
            if (_token == "")
            {
                _loginStatus = LoginStates.Incorrect_Email_Or_Password;
                MessageBox.Show("El email o contraseña es incorrecto.");
            }
            else if(_token.Length == 43)
            {
                _loginStatus = LoginStates.OK;
            }
        }
        private string HttpPostApi(string uri, string parameters)
        {
            // parameters: name1=value1&name2=value2 

            WebReq = (HttpWebRequest)WebRequest.Create(uri);
            WebReq.Method = "POST";
            WebReq.ContentType = "application/x-www-form-urlencoded";
            
            //WebReq.UserAgent = "Tuenti/2.3 CFNetwork/485.12.7 Darwin/10.4.0";
            //WebReq.Accept = "*/*";
            //WebReq.KeepAlive = true;
            //WebReq.ContentLength = 651;
            WebReq.Host = "api.tuenti.com";


            byte[] bytes = Encoding.ASCII.GetBytes(parameters);
            Stream os = null;
            try
            {
                WebReq.ContentLength = bytes.Length;   //Count bytes to send
                os = WebReq.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);         //Send it
            }
            catch (WebException ex)
            {

            }
            finally
            {
                if (os != null)
                {
                    os.Close();
                }
            }

            try
            {
                WebResponse WebRes = (HttpWebResponse)WebReq.GetResponse();
                
                if (WebRes == null)
                {
                    return null;
                }
                Encoding encode = System.Text.Encoding.ASCII;
                StreamReader sr = new StreamReader(WebRes.GetResponseStream(),encode);
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {

            }
            return null;
        }
    }

    public class XmppTuenti
    {
        agsXMPP.XmppClientConnection _XmppConnection;
        agsXMPP.Jid _Jid;
        public ListaPersonasChat _ListaXmpp;
        public ListaPersonas _ListaPersonas;
        public agsXMPP.XmppClientConnection Xmpp
        {
            get { return _XmppConnection; }
        }
        public XmppTuenti(string Jid, string Password)
        {
            _ListaXmpp = new ListaPersonasChat();
            _ListaPersonas = new ListaPersonas();
            LeerPersonas();
            _Jid = new agsXMPP.Jid(Jid);
            _XmppConnection = new agsXMPP.XmppClientConnection(_Jid.Server);
            _XmppConnection.Resource = "TuChat";
            _XmppConnection.Open(_Jid.User, Password);
            _XmppConnection.OnLogin += new agsXMPP.ObjectHandler(IniciarSesion);
            _XmppConnection.OnError += new agsXMPP.ErrorHandler(Error);
            _XmppConnection.OnXmppConnectionStateChanged += new agsXMPP.XmppConnectionStateHandler(Estado_Cambiado);
            _XmppConnection.OnReadXml += new agsXMPP.XmlHandler(_XmppConnection_OnReadXml);

        }

        void _XmppConnection_OnReadXml(object sender, string xml)
        {
            if (xml.Contains("<state>"))//composing</state>
            {
                string Id = Regex.Match(xml, @"from=""(?<Jid>(?<Id>(\d)*)@xmpp(\d)+\.tuenti.com)/(?<Resource>(\w)*)""").Groups["Id"].Value;
                string Jid = Regex.Match(xml, @"from=""(?<Jid>(?<Id>(\d)*)@xmpp(\d)+\.tuenti.com)/(?<Resource>(\w)*)""").Groups["Jid"].Value;
                MessageBox.Show(Jid + " esta escribiendo");
            }
            //throw new NotImplementedException();
        }
        //Acabar estoo!!
        public void LeerPersonas()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(Environment.CurrentDirectory + @"\lista.txt");
            string lista = sr.ReadToEnd();
            int lineas = Regex.Matches(lista, @"(\d)*;(\S| )*;(?<foto>(\S)*);(\S| )*;(\S| )*;").Count;
            MatchCollection users = Regex.Matches(lista, @"(?<user_id>(\d)*);(?<user_nombre>(\S)*) (?<user_apellidos>(\S| )*);(?<user_foto>(\S)*);(?<user_ciudad>(\w| |,|-|_)*);(?<user_provincia>(\w| )*);");

            for (int i = 0; i < lineas; i++)
            {
                string users_id = users[i].Groups["user_id"].Value;
                string users_nombre = users[i].Groups["user_nombre"].Value;
                string users_apellidos = users[i].Groups["user_apellidos"].Value;
                string users_foto = users[i].Groups["user_foto"].Value;
                string users_ciudad = users[i].Groups["user_ciudad"].Value;
                string users_provincia = users[i].Groups["user_provincia"].Value;

                _ListaPersonas.AgregarPersona(users_id, users_nombre, users_apellidos, "", users_ciudad, users_provincia, users_foto);
            }
            sr.Close();

        }
        public string Usuario
        {
            get { return _Jid.User; }
        }
        public delegate void XmppEventsString(string State);
        public delegate void XmppPresence(string Id, string Jid, string NombreEntero, string Show, int Prioridad, string Estado, string Resource, string Presencia);
        public event XmppEventsString OnLogin;
        public event XmppPresence OnPresence;

        public void Estado_Cambiado(object sender, agsXMPP.XmppConnectionState state)
        {
            if (state == agsXMPP.XmppConnectionState.Disconnected)
            {
                MessageBox.Show("Desconectado");
            }

        }
        public void Error(object sender, Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        public void IniciarSesion(object sender)
        {
            if (_XmppConnection.XmppConnectionState != agsXMPP.XmppConnectionState.SessionStarted) return;
            agsXMPP.protocol.client.Presence _Presence = new agsXMPP.protocol.client.Presence(agsXMPP.protocol.client.ShowType.NONE, "Online", 100);
            _Presence.Type = agsXMPP.protocol.client.PresenceType.available;
            _XmppConnection.Send(_Presence);

            _XmppConnection.OnPresence += new agsXMPP.protocol.client.PresenceHandler(PresenciaDetectada);

            OnLogin(_XmppConnection.XmppConnectionState.ToString());

        }
        public void PresenciaDetectada(object sender, agsXMPP.protocol.client.Presence _Presence)
        {

            string NombreEntero = _ListaPersonas.NombrePersona_Id(_Presence.From.User);
            if (NombreEntero == null) NombreEntero = _Presence.From.Bare;

            agsXMPP.protocol.client.Presence Presence = _Presence as agsXMPP.protocol.client.Presence;
            _ListaXmpp.ActualizarPersonaPorPresencia(Presence.From.User, Presence.From.Bare, NombreEntero, Presence.Show.ToString(),
                                                  Presence.Priority, Presence.Type.ToString(), Presence.From.Resource,
                                                  Presence.ToString());
            /*
            string Presence_Code = Presence.ToString();
            if (Presence_Code.Contains("<mobile />")) MessageBox.Show("Movil");
            MessageBox.Show(Presence.ToString() + " -------------------- " + Presence.From.Bare + " " + Presence.Show);
             */


            if (OnPresence != null)
            {
                OnPresence(Presence.From.User, Presence.From.Bare, NombreEntero, Presence.Show.ToString(),
                                                  Presence.Priority, Presence.Type.ToString(), Presence.From.Resource,
                                                  Presence.ToString());
            }
        }


    }

    public class ListaPersonasChat
    {
        private System.Collections.Generic.List<Estructura_Persona> Personas;
        /// <summary>
        /// Crea un almacén para guardar datos de personas. Debe iniciarse con el número de personas que va a alojar.
        /// </summary>
        /// <param name="N_Personas">Número de personas que tendra el almacen como aforo</param>
        public ListaPersonasChat()
        {
            Personas = new System.Collections.Generic.List<Estructura_Persona>();
        }
        public Estructura_Persona ObtenerPersona(string Id)
        {
            Estructura_Persona PersonaExistente = Personas.Find(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Id == Id;
            }
            );
            return PersonaExistente;
        }
        public void ActualizarPersonaPorPresencia(string Id, string Jid, string NombreEntero, string Show, int Prioridad, string Estado, string Resource, string Presencia)
        {

            if (Estado == "available")
            {
                Estructura_Persona Nueva_Persona = new Estructura_Persona();



                if (Show == "away") { Nueva_Persona.Ausente = true; }
                else if (Show == "NONE") { Nueva_Persona.Ausente = false; }

                if (Presencia.Contains("<push")) { Nueva_Persona.Push = true; }
                else { Nueva_Persona.Push = false; }

                if (Presencia.Contains("<mobile")) { Nueva_Persona.Movil = true; }
                else { Nueva_Persona.Movil = false; }

                if (Presencia.Contains("video_chat\":true")) { Nueva_Persona.WebCam = true; }
                else { Nueva_Persona.WebCam = false; }

                if (Presencia.Contains("games\":true")) { Nueva_Persona.Juegos = true; }
                else { Nueva_Persona.Juegos = false; }

                Nueva_Persona.Jid = Jid;
                Nueva_Persona.Id = Id;
                Nueva_Persona.Prioridad = Prioridad;
                Nueva_Persona.Resource = Resource;
                Nueva_Persona.Presencia = Presencia;
                Nueva_Persona.NombreEntero = NombreEntero;

                Personas.Add(Nueva_Persona);
            }
            else
            {
                //MessageBox.Show(Estado);
                QuitarPersona_Id(Resource);
            }
        }


        public bool ExistePersona_Id(string Id)
        {
            bool Existe = Personas.Exists(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Id == Id;
            }
            );
            return Existe;
        }
        public bool ExistePersona_Presencia(string Presencia)
        {
            bool Existe = Personas.Exists(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Presencia == Presencia;
            }
            );
            return Existe;
        }
        public void QuitarPersona_Id(string Resource)
        {
            List<Estructura_Persona> PersonasEliminadas = Personas.FindAll(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Resource == Resource;
            }
            );
            for (int i = 0; i < PersonasEliminadas.Count; i++)
            {
                Personas.Remove(PersonasEliminadas[i]);
            }

        }

        public ListaPersonasChat.Estructura_Persona this[int index]
        {
            get { return Personas[index]; }

        }
        public struct Estructura_Persona
        {
            public string NombreEntero;
            public string Jid;
            public string Id;
            public string Resource;
            public bool Movil;
            public bool Ausente;
            public bool WebCam;
            public bool Juegos;
            public bool Push;
            public int Prioridad;
            public string Presencia;

        }

        public int Personas_Actuales
        {
            get { return Personas.Count; }
        }
        private int Aforo = 0;
        public int Personas_Aforo
        {
            get { return Aforo; }
            set { Aforo = value; }
        }

    }

    public class ListaPersonas
    {
        private List<Estructura_Persona> Personas;
        /// <summary>
        /// Crea un almacén para guardar datos de personas. Debe iniciarse con el número de personas que va a alojar.
        /// </summary>
        /// <param name="N_Personas">Número de personas que tendra el almacen como aforo</param>
        public ListaPersonas()
        {
            Personas = new List<Estructura_Persona>();
        }
        private string toUTF8(string s)
        {

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
        public void AgregarPersona(string Id, string Nombre, string Apellidos, string Sexo, string Telefono, string Avatar, string ServidorXMPP)
        {
            if (!ExistePersona_Id(Id))
            {
                Estructura_Persona Nueva_Persona = new Estructura_Persona();
                Nueva_Persona.Id = Id;
                Nueva_Persona.Nombre = Nombre;
                Nueva_Persona.Apellidos = Apellidos;
                Nueva_Persona.Sexo = Sexo;
                Nueva_Persona.Telefono = Telefono;
                Nueva_Persona.Avatar = Avatar;
                Nueva_Persona.ServidorXMPP = ServidorXMPP;

                Personas.Add(Nueva_Persona);
            }
            else
            {
                MessageBox.Show("Persona repetida: ID:" + Id + " Nombre: " + Nombre + " " + Apellidos);
            }
        }
        public string NombrePersona_Id(string Id)
        {
            Estructura_Persona Persona = Personas.Find(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Id == Id;
            }
            );
            if (Persona.Nombre == null) return null;
            return Persona.Nombre + " " + Persona.Apellidos;
        }
        public bool ExistePersona_Id(string Id)
        {
            bool Existe = Personas.Exists(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Id == Id;
            }
            );
            return Existe;
        }
        public void QuitarPersona_Id(string Id)
        {
            Estructura_Persona PersonaEliminada = Personas.Find(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Id == Id;
            }
            );
            Personas.Remove(PersonaEliminada);

        }

        public ListaPersonas.Estructura_Persona this[int index]
        {
            get { return Personas[index]; }

        }
        public struct Estructura_Persona
        {
            public string Id;
            public string Nombre;
            public string Apellidos;
            public string Sexo;
            public string Telefono;
            public string Avatar;
            public string ServidorXMPP;

            public string Estado;
            public string Ciudad;
            public string Provincia;
        }

        public int Personas_Actuales
        {
            get { return Personas.Count; }
        }
        private int Aforo = 0;
        public int Personas_Aforo
        {
            get { return Aforo; }
            set { Aforo = value; }
        }

    }

}
