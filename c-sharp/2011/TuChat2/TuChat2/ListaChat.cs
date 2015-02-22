using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApiTuenti;
using agsXMPP;
using System.Diagnostics;

//namespace ApiTuenti
//{
//    public class ChatGrupo
//    {
//        private List<ChatEstructura> Grupo;
//        public ChatGrupo()
//        {
//            Grupo = new List<ChatEstructura>();
//        }
//        public void AgregarChat(TipoChat TipoChat, ChatLista ChatLista, string NombreLista)
//        {
//            ChatEstructura _lista = new ChatEstructura();
//            _lista.ChatLista = ChatLista;
//            _lista.NombreLista = NombreLista;
//            Grupo.Add(_lista);
//        }
//        public void QuitarChat(TipoChat TipoChat, string NombreLista)
//        {
//            Grupo.RemoveAll(
//            delegate(ChatEstructura ListaQuitar)
//            {
//                return ListaQuitar.TipoChat == TipoChat &&
//                    ListaQuitar.NombreLista == NombreLista;
//            }
//            );
//        }
//        public ChatEstructura ObtenerChat(Jid Desde)
//        {
//            for (int i = 0; i < Grupo.Count; i++)
//            {
//                for (int j = 0; j < Grupo[i].ChatLista.Personas_Actuales; j++)
//                {
//                    if (Desde.User == Grupo[i].ChatLista[j].Jid.User)
//                    {
//                        return Grupo[i];
//                    }
//                }
//            }
//            ChatEstructura _ChatEstructura = new ChatEstructura();
            
//            NombrePersona _nombre =  ApiTuenti.API._listaPersonas.NombrePersona(Desde);
//            Persona _persona = new Persona(Desde, _nombre);
//            _ChatEstructura.ChatLista.AgregarPersona(_persona);
//            _ChatEstructura.TipoChat = TipoChat.Simple;
//            return _ChatEstructura;
//        }
//        public Persona ObtenerPersona(Jid Desde)
//        {
//            for (int i = 0; i < Grupo.Count; i++)
//            {
//                for (int j = 0; j < Grupo[i].ChatLista.Personas_Actuales; j++)
//                {
//                    if (Desde.User == Grupo[i].ChatLista[j].Jid.User)
//                    {
//                        return Grupo[i].ChatLista[j];
//                    }
//                }
//            }
//            return null;
//        }
//        public struct ChatEstructura
//        {
//            public TipoChat TipoChat;
//            public ChatLista ChatLista;
//            public string NombreLista;
//        }
//        public enum TipoChat
//        {
//            Simple,
//            Grupo,
//            Nuevo
//        }
//        public ChatGrupo.ChatEstructura this[int index]
//        {
//            get { return Grupo[index]; }

//        }
//    }
//    public class ChatLista
//    {
//        private System.Collections.Generic.List<Persona> Personas;
//        /// <summary>
//        /// Crea un almacén para guardar datos de personas. Debe iniciarse con el número de personas que va a alojar.
//        /// </summary>
//        /// <param name="N_Personas">Número de personas que tendra el almacen como aforo</param>
//        public ChatLista()
//        {
//            Personas = new System.Collections.Generic.List<Persona>();
//        }
//        public Persona ObtenerPersona_Id(string Id)
//        {
//            Persona PersonaExistente = Personas.Find(
//            delegate(Persona _persona)
//            {
//                return _persona.Jid.User == Id;
//            }
//            );
//            return PersonaExistente;
//        }
//        public Persona ObtenerPersona_Id_Resource(string Id, string Resource)
//        {
//            Persona PersonaExistente = Personas.Find(
//            delegate(Persona _persona)
//            {
//                return _persona.Jid.User == Id &&
//                    _persona.Jid.Resource == Resource
//                    ;
//            }
//            );
//            return PersonaExistente;
//        }
//        public Persona CrearPersona(Jid Jid, NombrePersona Nombre, string Show, int Prioridad, string Estado, string Resource, string Presencia)
//        {
//            Persona Nueva_Persona = new Persona(Presencia);
//            int Index = 0;
//            if (Estado == "available")
//            {
//                Nueva_Persona.EstadoChat = Persona.EstadoPersona.Conectado;
//                if (Show == "away") { Nueva_Persona.EstadoChat = Persona.EstadoPersona.Ausente; Index += 2; }
//            }
//            else { Nueva_Persona.EstadoChat = Persona.EstadoPersona.Desconectado; }

//            Nueva_Persona.Dispositivo = Persona.DispositivoPersona.Normal;

//            if (Presencia.Contains("<mobile")) { Nueva_Persona.Detalles.Movil = true; Nueva_Persona.Dispositivo = Persona.DispositivoPersona.BlackBerry; Index += 8; }
//            else { Nueva_Persona.Detalles.Movil = false; }

//            if (Presencia.Contains("<push")) { Nueva_Persona.Detalles.Push = true; Nueva_Persona.Dispositivo = Persona.DispositivoPersona.iPhone; Index += 4; }
//            else { Nueva_Persona.Detalles.Push = false; }

//            if (Presencia.Contains("video_chat\":true")) { Nueva_Persona.Detalles.WebCam = true; Nueva_Persona.Dispositivo = Persona.DispositivoPersona.Webcam; Index += 4; }
//            else { Nueva_Persona.Detalles.WebCam = false; }

//            if (Presencia.Contains("games\":true")) { Nueva_Persona.Detalles.Juegos = true; }
//            else { Nueva_Persona.Detalles.Juegos = false; }

//            Nueva_Persona.Jid = Jid;
//            Nueva_Persona.Prioridad = Prioridad;
//            Nueva_Persona.Presencia = Presencia;
//            Nueva_Persona.Nombre = Nombre;
//            Nueva_Persona.IndexImage = Index;


//            return Nueva_Persona;
//        }
//        public bool ActualizarPersonaPorPresencia(Persona Nueva_Persona)
//        {
//            bool _Existe = ExistePersona(Nueva_Persona);
//            if (Nueva_Persona.EstadoChat == EstadoPersona.Conectado)
//            {
//                if (!_Existe)
//                {
//                    Personas.Add(Nueva_Persona);
//                    Debug.WriteLine("Añadiendo " + Nueva_Persona.Nombre.Nombre + " " + Nueva_Persona.Jid.Resource);
//                }
//            }
//            else if (Nueva_Persona.EstadoChat == EstadoPersona.Ausente)
//            {
//                if (_Existe)
//                {
//                    QuitarPersona(Nueva_Persona);

//                }
//                Personas.Add(Nueva_Persona);
//                Debug.WriteLine("Actualizando " + Nueva_Persona.Nombre.NombreEntero + " " + Nueva_Persona.Jid.Resource);
//            }
//            else if (Nueva_Persona.EstadoChat == EstadoPersona.Desconectado)
//            {
//                QuitarPersona_Id_Resource(Nueva_Persona.Jid.User, Nueva_Persona.Jid.Resource);
//                Debug.WriteLine("Quitando " + Nueva_Persona.Nombre.NombreEntero + " " + Nueva_Persona.Jid.Resource);
//            }
//            return _Existe;
//        }
//        public bool ExistePersona_Id(string Id)
//        {
//            bool Existe = Personas.Exists(
//            delegate(Persona _persona)
//            {
//                return _persona.Jid.User == Id;
//            }
//            );
//            return Existe;
//        }
//        public void AgregarPersona(Persona Nueva_Persona)
//        {
//            Personas.Add(Nueva_Persona);
//        }
//        public bool ExistePersona_Id_Resource(string Id, string Resource)
//        {
//            bool Existe = Personas.Exists(
//            delegate(Persona _persona)
//            {
//                return _persona.Jid.User == Id &&
//                    _persona.Jid.Resource == Resource;
//            }
//            );
//            return Existe;
//        }
//        public bool ExistePersona(Persona Persona)
//        {
//            bool Existe = Personas.Exists(
//            delegate(Persona _persona)
//            {
//                return //_persona.Ausente == Persona.Ausente &&
//                    _persona.Jid.Bare == Persona.Jid.Bare &&
//                    _persona.Detalles.Juegos == Persona.Detalles.Juegos &&
//                    _persona.Detalles.Movil == Persona.Detalles.Movil &&
//                    //_persona.Prioridad == Persona.Prioridad &&
//                    _persona.Detalles.Push == Persona.Detalles.Push &&
//                    //_persona.Resource == Persona.Resource &&
//                    _persona.Detalles.WebCam == Persona.Detalles.WebCam;
//            }
//            );
//            return Existe;
//        }
//        public bool ExistePersona_Presencia(string Presencia)
//        {
//            bool Existe = Personas.Exists(
//            delegate(Persona _persona)
//            {
//                return _persona.Presencia == Presencia;
//            }
//            );
//            return Existe;
//        }
//        public void QuitarPersona_Id_Resource(string Id, string Resource)
//        {
//            List<Persona> PersonasEliminadas = Personas.FindAll(
//            delegate(Persona _persona)
//            {
//                return _persona.Jid.Resource == Resource &&
//                    _persona.Jid.Resource == Resource;
//            }
//            );
//            for (int i = 0; i < PersonasEliminadas.Count; i++)
//            {
//                Personas.Remove(PersonasEliminadas[i]);
//            }

//        }
//        public void QuitarPersona(Persona Persona)
//        {
//            List<Persona> PersonasEliminadas = Personas.FindAll(
//            delegate(Persona _persona)
//            {
//                return _persona.Jid == Persona.Jid;
//            }
//            );
//            for (int i = 0; i < PersonasEliminadas.Count; i++)
//            {
//                Personas.Remove(PersonasEliminadas[i]);
//            }

//        }
//        public Persona this[int index]
//        {
//            get { return Personas[index]; }

//        }

//        public enum DispositivoPersonaChat
//        {
//            Normal,
//            Webcam,
//            BlackBerry,
//            iPhone
//        }
//        public int Personas_Actuales
//        {
//            get { return Personas.Count; }
//        }
//        private int Aforo = 0;
//        public int Personas_Aforo
//        {
//            get { return Aforo; }
//            set { Aforo = value; }
//        }
//    }
    
//}
