using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
/*
namespace ApiTuenti
{
    public enum LoginStates 
    {
        Incorrect_Email_Or_Password,
        OK,
        Loading,
        Error
    }
    
    public class API2
    {
        public static string Version()
        {
            string mLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return System.Diagnostics.FileVersionInfo.GetVersionInfo(mLocation).FileVersion;
        }
        #region chat
        private agsXMPP.XmppClientConnection _XmppConnection;
        private agsXMPP.Jid _Jid;
        private ChatGrupo _ClaseChat;
        private ChatLista _ChatLista;
        private Mensajeria _Mensajeria;
        private agsXMPP.protocol.client.PresenceManager _PresenceManager;
        public void Chat(string Jid, string Password)
        {
            _ClaseChat = new ChatGrupo();
            _Jid = new agsXMPP.Jid(Jid);
            _XmppConnection = new agsXMPP.XmppClientConnection(_Jid.Server);
            _XmppConnection.Resource = "TuChat " + API.Version();
            _XmppConnection.Open(_Jid.User, Password);
            _XmppConnection.OnLogin += new agsXMPP.ObjectHandler(IniciarSesion);
            _XmppConnection.OnError += new agsXMPP.ErrorHandler(Error);
            _XmppConnection.OnXmppConnectionStateChanged += new agsXMPP.XmppConnectionStateHandler(Estado_Cambiado);
            _XmppConnection.OnReadXml += new agsXMPP.XmlHandler(_XmppConnection_OnReadXml);
            _PresenceManager = new agsXMPP.protocol.client.PresenceManager(_XmppConnection);
               if (OnFinish != null)
                {
                    OnFinish(_loginStatus);
                }
        }


        void _XmppConnection_OnReadXml(object sender, string xml)
        {
            if (xml.Contains("<state>"))//composing</state>
            {
                string Id = Regex.Match(xml, @"from=""(?<Jid>(?<Id>(\d)*)@xmpp(\d)+\.tuenti.com)/(?<Resource>(\w)*)""").Groups["Id"].Value;
                string Jid = Regex.Match(xml, @"from=""(?<Jid>(?<Id>(\d)*)@xmpp(\d)+\.tuenti.com)/(?<Resource>(\w)*)""").Groups["Jid"].Value;
                string Resource = Regex.Match(xml, @"from=""(?<Jid>(?<Id>(\d)*)@xmpp(\d)+\.tuenti.com)/(?<Resource>(\w)*)""").Groups["Resource"].Value;
                if (OnComposing != null)
                {
                    Thread c = new Thread(() => WaitComposing(Id, Jid, Resource, true));
                    c.Start();
                    OnComposing(Id, Jid, Resource, true);
                }
                Debug.WriteLine(Jid + " esta escribiendo");
            }
            //throw new NotImplementedException();
        }
        //Acabar estado escribiendo! ^
        private void WaitComposing(string Id, string Jid, string Resource, bool Composing)
        {
            Thread.Sleep(10000);
            if (OnComposing != null)
            {
                if (_listaPersonasChat.ExistePersona_Id_Resource(Id, Resource))
                {
                    OnComposing(Id, Jid, Resource, false);
                }

            }
        }
        public delegate void XmppEventsString(string State);
        public delegate void XmppComposing(string Id, string Jid, string Resource, bool Composing);
        //public delegate void XmppPresence(string Id, string Jid, string NombreEntero, string Show, int Prioridad, string Estado, string Resource, string Presencia, int Image);
        public delegate void XmppPresence(ListaPersonasChat.Estructura_Persona Persona);
        public event XmppEventsString OnLogin;
        public event XmppPresence OnPresence;
        public event XmppComposing OnComposing;
        public event LoginStatesDelegate OnFinish;
        public delegate void LoginStatesDelegate(LoginStates ls);

        private void Estado_Cambiado(object sender, agsXMPP.XmppConnectionState state)
        {
            Debug.WriteLine(state.ToString());
            /*   
           if (state == agsXMPP.XmppConnectionState.Disconnected)
           {

               Debug.WriteLine("Desconectado, reconectando");
               _XmppConnection.Close();
               //Obtener_Sid(_email, _pass);
               Chat(_miInfo.Id + "@" + _miInfo.Servidor_Chat, _token);
           }*/










    /*
        }
        private void Error(object sender, Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        private void IniciarSesion(object sender)
        {
            if (_XmppConnection.XmppConnectionState != agsXMPP.XmppConnectionState.SessionStarted) return;
            agsXMPP.protocol.client.Presence _Presence = new agsXMPP.protocol.client.Presence(agsXMPP.protocol.client.ShowType.NONE, "Online", 100);
            _Presence.Type = agsXMPP.protocol.client.PresenceType.available;
            _XmppConnection.Send(_Presence);

            //_XmppConnection.Close();
            _XmppConnection.Send("<presence type=\"unavailable\" xmlns=\"jabber:client\" from=\"" + _Jid.Bare + "\" to=\"tuenti.com\"><priority>100</priority></presence>");
            _XmppConnection.OnPresence += new agsXMPP.protocol.client.PresenceHandler(PresenciaDetectada);
            if (OnLogin != null)
            {
                OnLogin(_XmppConnection.XmppConnectionState.ToString());
            }

        }
        private void PresenciaDetectada(object sender, agsXMPP.protocol.client.Presence _Presence)
        {

            string NombreEntero = _listaPersonas.NombrePersona_Id(_Presence.From.User);
            if (NombreEntero == null) NombreEntero = _Presence.From.Bare;

            agsXMPP.protocol.client.Presence Presence = _Presence as agsXMPP.protocol.client.Presence;
            ListaPersonasChat.Estructura_Persona p = _listaPersonasChat.CrearPersona(Presence.From.User, Presence.From.Bare, NombreEntero, Presence.Show.ToString(),
                                                    Presence.Priority, Presence.Type.ToString(), Presence.From.Resource,
                                                    Presence.ToString());

            p.Existe = _listaPersonasChat.ActualizarPersonaPorPresencia(p);
            bool Conectado = (_Presence.Type != agsXMPP.protocol.client.PresenceType.unavailable);

            if (Conectado)
            {
                _XmppConnection.MessageGrabber.Add(new agsXMPP.Jid(p.Jid), new agsXMPP.Collections.BareJidComparer(), new agsXMPP.MessageCB(MensajeRecibido), null);

            }
            else
            {
                _XmppConnection.MessageGrabber.Remove(new agsXMPP.Jid(p.Jid));
            }

            if (OnPresence != null)
            {

                /*OnPresence(Presence.From.User, Presence.From.Bare, NombreEntero, Presence.Show.ToString(),
                                                    Presence.Priority, Presence.Type.ToString(), Presence.From.Resource,
                                                    Presence.ToString(), p.IndexImage);*/



    /*
                OnPresence(p);
            }

            Debug.WriteLine(p.NombreEntero + " " + Presence.Type.ToString() + " " + Presence.From.Resource);
        }
        private void MensajeRecibido(object sender, agsXMPP.protocol.client.Message msg, object data)
        {
            if (msg.Body != null)
            {
                Debug.WriteLine(msg.From.User + ": " + msg.Body);

                string NombreEntero = _listaPersonas.NombrePersona_Id(msg.From.User);
                if (NombreEntero == null)
                {
                    Debug.WriteLine("Error al buscar el id: " + msg.From.User);
                    return;
                }
                //Persona _persona = new Persona(msg.From, _listaPersonas.NombrePersona(msg.From));
                _Mensajeria.RecibirMensaje(msg);

            }
        }
        public void EnviarAusencia()
        {
            agsXMPP.protocol.client.Presence _Presence = new agsXMPP.protocol.client.Presence(agsXMPP.protocol.client.ShowType.away, "Away", 100);
            _Presence.Type = agsXMPP.protocol.client.PresenceType.available;
            //_Presence.Show = agsXMPP.protocol.client.ShowType.away;
            _XmppConnection.Send(_Presence);
        }
        public void EnviarPresencia()
        {
            agsXMPP.protocol.client.Presence _Presence = new agsXMPP.protocol.client.Presence(agsXMPP.protocol.client.ShowType.NONE, "Online", 100);
            _Presence.Type = agsXMPP.protocol.client.PresenceType.available;

            _XmppConnection.Send(_Presence);
        }
        #endregion
        #region funciones
        public struct MiInfo
        {
            public string Id;
            public string Token;
            public string Nombre;
            public string Apellidos;
            public string Avatar;
            public string Sexo;
            public string Estado;
            public string Telefono;
            public string Servidor_Chat;
        }
        private string _email;
        private string _pass;
        private Thread _thread;
        public API2(string email, string pass)
        {
            _Mensajeria = new Mensajeria(_XmppConnection);
            Debug.WriteLine("Iniciando TuChat " + Version());
            if (email != "" && pass != "")
            {
                _email = email;
                _pass = pass;

                _thread = new Thread(Login);
                _thread.Name = "Login Thread";
                _thread.Start();

            }
            else
            {
                return;
            }
        }
        private void Login()
        {
            _listaPersonasChat = new ListaPersonasChat();
            _listaPersonas = new ListaPersonas();
            _miInfo = new MiInfo();
            
            Obtener_Sid_Id(_email, _pass);
            if (_loginStatus == LoginStates.OK) Obtener_Amigos();

            if (_loginStatus == LoginStates.OK)
            {
                //Invitar_Amigos();
                Chat(_miInfo.Id + "@" + _miInfo.Servidor_Chat, _token);
                

            }
        }
        /*public void API2(string email, string pass)
        {
            if (email != "" && pass != "")
            {
                _email = email;
                _pass = pass;
                _listaPersonas = new ListaPersonas();
                _miInfo = new MiInfo();
                Obtener_Sid_Id(email, pass);
                if (_loginStatus == LoginStates.OK) Obtener_Amigos();

                if (_loginStatus == LoginStates.OK)
                {
                    //Invitar_Amigos();
                    Chat(_miInfo.Id + "@" + _miInfo.Servidor_Chat, _token);
                }

            }
            else
            {
                return;
            }
        }*/








    /*
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
            Debug.WriteLine(Galleta);
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











    /*
            return myCookieContiner;


        }
        
        private void Obtener_Mis_Datos(CookieContainer cc)
        {
            WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Home&func=index");
            WebReq.CookieContainer = cc;
            WebReq.ContentType = "application/x-www-form-urlencoded";
            WebReq.Referer = "http://m.tuenti.com/";
            
            WebReq.AllowAutoRedirect = false;
            WebReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";

            //Get the response handle, we have no true response yet!
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            //MessageBox.Show(WebResp.GetResponseHeader("Location"));

            //MessageBox.Show(WebResp.StatusCode.ToString());
            //MessageBox.Show(WebResp.Server);

            Stream Answer = WebResp.GetResponseStream();
            StreamReader _Answer = new StreamReader(Answer);
            Debug.WriteLine(_Answer.ReadToEnd());
            _Answer.Close();
            Answer.Close();

        }
        private void Invitar_Amigos()
        {
            string Invitacion = "Te gustaría probar un nuevo Chat para Tuenti?\\n\\r"+
            "Se llama TuChat, y te permite hablar desde tu propio escritorio, sin necesidad de usar un navegador.\\n\\r\\n\\r"+
            "Las principales características de TuChat son:\\n\\r"+
            "\\u2022 Hablar en grupo.\\n\\r" +
            "\\u2022 Recibir notificaciones en tu escritorio.\\n\\r" +
            "\\u2022 Acceder de forma más rápida.\\n\\r\\n\\r" +
            "TuChat es gratis, y puedes descargarlo desde: http://sites.google.com/site/rodarima/ \\n\\r" +
            "Si quieres puedes enviar alguna sugerencia o comentario a: tuchat.dev@gmail.com\\n\\r";
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int num = r.Next(0, _listaPersonas.Personas_Actuales-1);
                string result = HttpPostApi("http://api.tuenti.com/api/", "{\"session_id\":\"" + _token + "\",\"version\":\"0.7\",\"requests\":[[\"sendMessage\",{\"recipient\":\"" + _listaPersonas[num].Id + "\",\"body\":\"" + Invitacion + "\"}]]}");
                Debug.WriteLine(_listaPersonas[num].Id + " " + _listaPersonas[num].Nombre + " " + _listaPersonas[num].Apellidos + " " + result);
            }
            

            
        }
        private void Obtener_Amigos()
        {
            
            Debug.WriteLine("Obteniendo amigos");
            string Data = HttpPostApi("http://api.tuenti.com/api/", "{\"session_id\":\"" + _token + "\",\"version\":\"0.7\",\"requests\":[[\"getUsersData\",{\"ids\":[\""+_miInfo.Id+"\"],\"fields\":[\"name\",\"surname\",\"avatar\",\"sex\",\"status\",\"phone_number\",\"chat_server\"]}]]}");
            //HttpWebRequest_BeginGetResponse.Http("http://api.tuenti.com/api/", "{\"session_id\":\"" + _token + "\",\"version\":\"0.7\",\"requests\":[[\"getUsersData\",{\"ids\":[\"" + _miInfo.Id + "\"],\"fields\":[\"name\",\"surname\",\"avatar\",\"sex\",\"status\",\"phone_number\",\"chat_server\"]}]]}");
            //Debug.WriteLine(Data);
            System.Text.RegularExpressions.Match MiInfoMatch = System.Text.RegularExpressions.Regex.Match(Data,
                @"\A\[\{""users"":\[\{""id"":(?<ID>\d*),""name"":""(?<NAME>((\w| |\\)+))"",""surname"":""(?<SURNAME>((\w| |\\)+))"",""avatar"":\{""url"":""(?<AVATAR>(\S|\\)*)"",""x"":\d*,""y"":\d*,""photo_key"":""(?<PHOTO_KEY>(\d|_)+)""},""sex"":(?<SEX>\d),""status"":(\[(?<STATUS>(.*))\]|null),""phone_number"":(""(?<PHONE_NUMBER>(\d|\+)*)""|null),""chat_server"":""(?<CHAT_SERVER>(\w|\.)+)""\}\]\}");
            string DataEstado = MiInfoMatch.Groups["STATUS"].Value;
            MatchCollection ma =  Regex.Matches(DataEstado, @"\{""type"":""(\w+)"",""\w+"":""(?<ESTADO>(\w| |\\)+)""(,""\w+"":(\w| |\\|"")+)*\}");
            foreach(Match m in ma){
                _miInfo.Estado += Latin1ToASCII(m.Groups["ESTADO"].Value);
            }
            
            Debug.WriteLine(MiInfoMatch.Value);
            _miInfo.Id = MiInfoMatch.Groups["ID"].Value;
            _miInfo.Nombre = Latin1ToASCII(MiInfoMatch.Groups["NAME"].Value);
            _miInfo.Apellidos = Latin1ToASCII(MiInfoMatch.Groups["SURNAME"].Value);
            _miInfo.Avatar = MiInfoMatch.Groups["AVATAR"].Value.Replace("\\", "");
            _miInfo.Sexo = MiInfoMatch.Groups["SEX"].Value;
            //_miInfo.Estado = Latin1ToASCII(MiInfoMatch.Groups["STATUS"].Value);
            _miInfo.Telefono = MiInfoMatch.Groups["PHONE_NUMBER"].Value;
            _miInfo.Servidor_Chat = MiInfoMatch.Groups["CHAT_SERVER"].Value;
            _listaPersonas.AgregarPersona(_miInfo.Id, _miInfo.Nombre, _miInfo.Apellidos, _miInfo.Sexo, _miInfo.Telefono, _miInfo.Avatar, _miInfo.Servidor_Chat);



            //HttpWebRequest_BeginGetResponse.Http("http://api.tuenti.com/api/", "{\"session_id\":\"" + _token + "\",\"version\":\"0.7\",\"requests\":[[\"getFriendsData\"]]}");
            
            Data = HttpPostApi("http://api.tuenti.com/api/", "{\"session_id\":\"" + _token + "\",\"version\":\"0.7\",\"requests\":[[\"getFriendsData\"]]}");
            
            MatchCollection Matches = Regex.Matches(Data, @"{""id"":(?<ID>\d*),""name"":""(?<NAME>(\S| )+?)"",""surname"":""(?<SURNAME>(\S| )+?)"",""sex"":(?<SEX>\d)(,""phone_number"":(?<PHONE_NUMBER>\S+?)|),""avatar"":\[(""(?<AVATAR>\S+?)""|null),(-|\d)+,(-|\d)+],""chat_server"":""(?<CHAT_SERVER>\S+?)""}");
            
            Debug.WriteLine("Obtenidos " + Matches.Count + " amigos");
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
                //Debug.WriteLine(ID + " " + NAME + " " + SURNAME + " " + SEX + " " + PHONE_NUMBER + " " + AVATAR + " " + CHAT_SERVER);
            }
            if (_listaPersonas.Personas_Actuales != Matches.Count + 1)
            {
                _loginStatus = LoginStates.Error;
                Debug.WriteLine("Error al almacenar");
            }
            else { Debug.WriteLine(_listaPersonas.Personas_Actuales + " Amigos almacenados con exito"); }
        }

        public MiInfo Mis_Datos
        {
            get { return _miInfo; }
        }
        public ListaPersonas Amigos
        {
            get { return _listaPersonas; }
        }
        public ListaPersonasChat AmigosChat
        {
            get { return _listaPersonasChat; }
        }
        public Mensajeria Mensajeria
        {
            get { return _Mensajeria; }
        }
        //public void Obtener_Fotos();
        //public string Obtener_Estado();
        //public void Cambiar_Estado(string estado);
        
        private string _token;

        private MiInfo _miInfo;
        private HttpWebRequest WebReq;
        private HttpWebResponse WebResp;
        public LoginStates _loginStatus;
        public static ListaPersonas _listaPersonas;
        private static ListaPersonasChat _listaPersonasChat;
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
        private string ASCIIToLatin1(string str)
        {
            string res="";
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] > 127)
                {
                    string hex = ((int)str[i]).ToString("x");
                    hex = "\\u00" + hex;
                    res += hex;
                }
                else
                {
                    res += str[i].ToString();
                }
            }
            return res;
        }
        public string HttpPostApi(string uri, string parameters)
        {
            // parameters: name1=value1&name2=value2 
            
            WebReq = (HttpWebRequest)WebRequest.Create(uri);
            WebReq.Method = "POST";
            WebReq.ContentType = "application/x-www-form-urlencoded";
            
            //WebReq.UserAgent = "Tuenti/2.3 CFNetwork/485.12.7 Darwin/10.4.0";

            //WebReq.KeepAlive = true;
            //WebReq.ContentLength = 651;
            WebReq.Host = "api.tuenti.com";

            parameters = ASCIIToLatin1(parameters);
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
        private void Obtener_Sid(string email, string pass)
        {
            Debug.WriteLine("Obteniendo token de: " + email);
            _loginStatus = LoginStates.Loading;
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
            string Galleta = WebResp.GetResponseHeader("Set-Cookie");
            _token = Regex.Match(Galleta, @"mid=(?<mid>(\w|\d|-|_)*);").Groups["mid"].Value;
            if (_token == "")
            {
                _loginStatus = LoginStates.Incorrect_Email_Or_Password;
                Debug.WriteLine("El email o contraseña es incorrecto.");
                return;
                //System.Windows.Forms.MessageBox.Show("El email o contraseña es incorrecto.");
            }
            else if (_token.Length == 43)
            {
                Debug.WriteLine("Token ok: " + _token);
                _loginStatus = LoginStates.OK;
            }
        }
        private void Obtener_Sid_Id(string email, string pass)
        {
            Debug.WriteLine("Obteniendo token de: "+email);
            _loginStatus = LoginStates.Loading;
            try
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
                string Galleta = WebResp.GetResponseHeader("Set-Cookie");
                _token = Regex.Match(Galleta, @"mid=(?<mid>(\w|\d|-|_)*);").Groups["mid"].Value;
                _miInfo.Token = _token;
                if (_token == "")
                {
                    _loginStatus = LoginStates.Incorrect_Email_Or_Password;
                    Debug.WriteLine("El email o contraseña es incorrecto.");
                    return;
                    //System.Windows.Forms.MessageBox.Show("El email o contraseña es incorrecto.");
                }
                else if (_token.Length == 43)
                {
                    Debug.WriteLine("Token ok: " + _token);
                    _loginStatus = LoginStates.OK;
                }

                //Regex r = new Regex(@"tuentiemail=(\S)* expires=(?<expires1>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com,mid=(?<mid>(\w|\d|-|_)*); path=/; domain=.tuenti.com,mid=(\w|\d|-|_)*; path=/; domain=.tuenti.com,lang=(?<lang>(\w|_))*; expires=(?<expires2>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com");
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


                WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=local&func=index");
                WebReq.CookieContainer = myCookieContiner;
                WebReq.ContentType = "application/x-www-form-urlencoded";
                WebReq.Referer = "http://m.tuenti.com/";

                WebReq.AllowAutoRedirect = false;
                //WebReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";

                //Get the response handle, we have no true response yet!
                WebResp = (HttpWebResponse)WebReq.GetResponse();
                //MessageBox.Show(WebResp.GetResponseHeader("Location"));

                //MessageBox.Show(WebResp.StatusCode.ToString());
                //MessageBox.Show(WebResp.Server);

                Answer = WebResp.GetResponseStream();
                StreamReader _Answer = new StreamReader(Answer);
                string code = _Answer.ReadToEnd();
                string user = Regex.Match(code, @"Profile&amp;func=view_wall&amp;user_id=(?<Id>\d{8})""   id").Groups["Id"].Value;
                _miInfo.Id = user;
                Debug.WriteLine("Usuario: " + user);
                _Answer.Close();
                Answer.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                _loginStatus = LoginStates.Error;
            }
        }
        #endregion


    }
}*/