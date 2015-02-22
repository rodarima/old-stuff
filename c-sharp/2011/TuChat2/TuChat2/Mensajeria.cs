using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using agsXMPP;
using System.Diagnostics;

namespace ApiTuenti
{
    //public class Mensajeria
    //{
    //    //private ApiTuenti.ChatGrupo _chats;
    //    agsXMPP.XmppClientConnection _XmppClientConnection;
    //    //public Mensajeria(agsXMPP.XmppClientConnection XmppClientConnection)
    //    //{
    //    //    _chats = new ChatGrupo();
    //    //    _XmppClientConnection = XmppClientConnection;
    //    //}
    //    //public ChatGrupo Chats
    //    //{
    //    //    get { return _chats; }
    //    //}
    //    Persona p = new Persona(new Jid("pepe@gmail.com"), new Persona.NombrePersona("Pepe", "Lopez"));
    //    public void EnviarMensaje(Jid _Destino, string _Mensaje)
    //    {
            
    //        agsXMPP.protocol.client.Message _mensaje = new agsXMPP.protocol.client.Message(_Destino, _Mensaje);
    //        _XmppClientConnection.Send(_mensaje);
    //    }
    //    public void EnviarMensaje(ChatGrupo.ChatEstructura _Chat, string _Mensaje)
    //    {
    //        int NumeroPersonas = _Chat.ChatLista.Personas_Actuales;
    //        //agsXMPP.Jid MiJid = _XmppClientConnection.MyJID;
    //        for (int i = 0; i < NumeroPersonas; i++)
    //        {
    //            _XmppClientConnection.Send(new agsXMPP.protocol.client.Message(_Chat.ChatLista[i].Jid, _Mensaje));
    //        }
            
    //    }
    //    public void EnviarMensaje(ChatGrupo.ChatEstructura _Chat, string _Mensaje, Persona Excepto)
    //    {
    //        int NumeroPersonas = _Chat.ChatLista.Personas_Actuales;
    //        //agsXMPP.Jid MiJid = _XmppClientConnection.MyJID;
    //        for (int i = 0; i < NumeroPersonas; i++)
    //        {
    //            if (_Chat.ChatLista[i].Jid.User != Excepto.Jid.User)
    //            {
    //                string _encabezado = Excepto.Nombre.NombreAbreviado + ": ";
    //                _XmppClientConnection.Send(new agsXMPP.protocol.client.Message(_Chat.ChatLista[i].Jid,_encabezado + _Mensaje));
    //            }
    //        }

    //    }

    //    public void RecibirMensaje(agsXMPP.protocol.client.Message _Mensaje)
    //    {
    //        Persona Desde = _chats.ObtenerPersona(_Mensaje.From);
    //        ChatGrupo.ChatEstructura _chat = _chats.ObtenerChat(_Mensaje.From);
    //        if (_chat.TipoChat == ChatGrupo.TipoChat.Simple)
    //        {
    //            //Mensaje simple recibido (pasar por pantalla solo)
    //            if (OnMensaje != null)
    //            {
    //                OnMensaje(_Mensaje);
    //            }
    //        }
    //        else if (_chat.TipoChat == ChatGrupo.TipoChat.Grupo)
    //        {
    //            EnviarMensaje(_chat, _Mensaje.Body, Desde);
    //            //Mensaje grupo recibido (tambien pasar por pantalla)
    //            if (OnMensaje != null)
    //            {
    //                OnMensaje(_Mensaje);
    //            }
    //        }
    //    }
    //    public delegate void MensajeRecibido(agsXMPP.protocol.client.Message _Mensaje);
    //    public event MensajeRecibido OnMensaje;
    //}


}
