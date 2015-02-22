using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace ApiTuenti
{
    public class Chat
    {
        #region chat
        private agsXMPP.XmppClientConnection _XmppConnection;
        private agsXMPP.Jid _Jid;
        //private ChatGrupo _ClaseChat;
        
        //private Mensajeria _Mensajeria;
        private agsXMPP.protocol.client.PresenceManager _PresenceManager;
        public PersonaLista _ListaChat;
        private PersonaLista _ListaAmigos;
        //public Mensajeria _Mensajeria { get; set; }

        public Chat(agsXMPP.Jid Jid, string Password, PersonaLista ListaAmigos, ref PersonaLista ListaChat)
        {
            _ListaChat = ListaChat;
            _ListaChat = new PersonaLista();

            _ListaAmigos = ListaAmigos;
            _Jid = Jid;
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
                OnFinish(API.Estado);
            }
        }


        void _XmppConnection_OnReadXml(object sender, string xml)
        {
            if (xml.Contains("<state>"))//composing</state>
            {
                string Id = Regex.Match(xml, @"from=""(?<Jid>(?<Id>(\d)*)@xmpp(\d)+\.tuenti.com)/(?<Resource>(\w)*)""").Groups["Id"].Value;
                string sJid = Regex.Match(xml, @"from=""(?<Jid>(?<Id>(\d)*)@xmpp(\d)+\.tuenti.com)/(?<Resource>(\w)*)""").Groups["Jid"].Value;
                string Resource = Regex.Match(xml, @"from=""(?<Jid>(?<Id>(\d)*)@xmpp(\d)+\.tuenti.com)/(?<Resource>(\w)*)""").Groups["Resource"].Value;
                agsXMPP.Jid Jid = new agsXMPP.Jid(Id,sJid,Resource);
                if (OnComposing != null)
                {
                    Thread c = new Thread(() => WaitComposing(Jid, true));
                    c.Start();
                    OnComposing(Jid, true);
                }
                Debug.WriteLine(Jid.Bare + " esta escribiendo");
            }
            //throw new NotImplementedException();
        }
        //Acabar estado escribiendo! ^
        private void WaitComposing(agsXMPP.Jid Jid, bool Composing)
        {
            Thread.Sleep(10000);
            if (OnComposing != null)
            {
                if (_ListaAmigos.Existe(Jid))
                {
                    OnComposing(Jid, false);
                }

            }
        }
        public delegate void XmppEventsString(string State);
        public delegate void XmppComposing(agsXMPP.Jid Jid, bool Composing);
        public delegate void XmppPresence(Persona Persona);
        public delegate void LoginStatesDelegate(ConexionEstado EstadoConexion);

        public event XmppEventsString OnLogin;
        public event XmppComposing OnComposing;
        public event XmppPresence OnPresence;
        public event LoginStatesDelegate OnFinish;
        
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
            Persona Nueva_Persona = _ListaAmigos.Encontrar(_Presence.From);

            agsXMPP.protocol.client.Presence Presence = _Presence as agsXMPP.protocol.client.Presence;

            Nueva_Persona.Jid = Presence.From;



            int Index = 0;
            if (Presence.Type == agsXMPP.protocol.client.PresenceType.available)
            {
                Nueva_Persona.EstadoChat = Persona.EstadoPersona.Conectado;
                if (Presence.Show == agsXMPP.protocol.client.ShowType.away) {
                    Nueva_Persona.EstadoChat = Persona.EstadoPersona.Ausente; Index += 2; 
                }
            }
            else { Nueva_Persona.EstadoChat = Persona.EstadoPersona.Desconectado; }

            Nueva_Persona.Dispositivo = Persona.DispositivoPersona.Normal;

            if (Presence.ToString().Contains("<mobile")) { Nueva_Persona.Detalles.Movil = true; Nueva_Persona.Dispositivo = Persona.DispositivoPersona.BlackBerry; Index += 8; }
            else { Nueva_Persona.Detalles.Movil = false; }

            if (Presence.ToString().Contains("<push")) { Nueva_Persona.Detalles.Push = true; Nueva_Persona.Dispositivo = Persona.DispositivoPersona.iPhone; Index += 4; }
            else { Nueva_Persona.Detalles.Push = false; }

            if (Presence.ToString().Contains("video_chat\":true")) { Nueva_Persona.Detalles.WebCam = true; Nueva_Persona.Dispositivo = Persona.DispositivoPersona.Webcam; Index += 4; }
            else { Nueva_Persona.Detalles.WebCam = false; }

            if (Presence.ToString().Contains("games\":true")) { Nueva_Persona.Detalles.Juegos = true; }
            else { Nueva_Persona.Detalles.Juegos = false; }


            Nueva_Persona.Detalles.IndexImage = Index;
            Nueva_Persona.Detalles.Prioridad = Presence.Priority;
            
            if(!_ListaChat.Existe(Presence.From))
            {
                _ListaChat.AgregarPresencia(Nueva_Persona);
            }

            bool Conectado = (_Presence.Type != agsXMPP.protocol.client.PresenceType.unavailable);

            if (Conectado)
            {
                _XmppConnection.MessageGrabber.Add(Nueva_Persona.Jid, new agsXMPP.Collections.BareJidComparer(), new agsXMPP.MessageCB(MensajeRecibido), null);

            }
            else
            {
                _XmppConnection.MessageGrabber.Remove(Nueva_Persona.Jid);
            }

            if (OnPresence != null)
            {

                /*OnPresence(Presence.From.User, Presence.From.Bare, NombreEntero, Presence.Show.ToString(),
                                                    Presence.Priority, Presence.Type.ToString(), Presence.From.Resource,
                                                    Presence.ToString(), p.IndexImage);*/
                OnPresence(Nueva_Persona);
            }

            Debug.WriteLine(Nueva_Persona.Nombre.NombreEntero + " " + Presence.Type.ToString() + " " + Presence.From.Resource);
        }
        private void MensajeRecibido(object sender, agsXMPP.protocol.client.Message msg, object data)
        {
            if (msg.Body != null)
            {
                Debug.WriteLine(msg.From.User + ": " + msg.Body);

                Persona persoa = _ListaAmigos.Encontrar(msg.From);
                if (persoa == null)
                {
                    Debug.WriteLine("Error al buscar el id: " + msg.From.User);
                    return;
                }
                //Persona _persona = new Persona(msg.From, _listaPersonas.NombrePersona(msg.From));
                
       //         _Mensajeria.RecibirMensaje(msg);

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
       
    }
}
