﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ApiTuenti
{

    public class ListaXmpp
    {
        private System.Collections.Generic.List<Estructura_Persona> Personas;
        /// <summary>
        /// Crea un almacén para guardar datos de personas. Debe iniciarse con el número de personas que va a alojar.
        /// </summary>
        /// <param name="N_Personas">Número de personas que tendra el almacen como aforo</param>
        public ListaXmpp()
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

        public ListaXmpp.Estructura_Persona this[int index]
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

            if (Estado == "available")
            {
                if (!ExistePersona(Nueva_Persona))
                {
                    Personas.Add(Nueva_Persona);
                }
                else
                {
                    QuitarPersona_Id_Resource(Id, Resource);
                }
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
        public bool ExistePersona(Estructura_Persona Persona)
        {
            bool Existe = Personas.Exists(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Ausente == Persona.Ausente &&
                    _persona.Id == Persona.Id &&
                    _persona.Jid == Persona.Jid &&
                    _persona.Juegos == Persona.Juegos &&
                    _persona.Movil == Persona.Movil &&
                    //_persona.Prioridad == Persona.Prioridad &&
                    _persona.Push == Persona.Push &&
                    //_persona.Resource == Persona.Resource &&
                    _persona.WebCam == Persona.WebCam;
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
        public void QuitarPersona_Id_Resource(string Id, string Resource)
        {
            List<Estructura_Persona> PersonasEliminadas = Personas.FindAll(
            delegate(Estructura_Persona _persona)
            {
                return _persona.Resource == Resource &&
                    _persona.Resource == Resource;
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
        
        public void AgregarPersona(string Id, string Nombre, string Apellidos, string Estado, string Ciudad, string Provincia, string Foto)
        {
            if (!ExistePersona_Id(Id))
            {
                Estructura_Persona Nueva_Persona = new Estructura_Persona();
                Nueva_Persona.Id = Id;
                Nueva_Persona.Nombre = Nombre;
                Nueva_Persona.Apellidos = Apellidos;
                Nueva_Persona.Estado = Estado;
                Nueva_Persona.Ciudad = Ciudad;
                Nueva_Persona.Provincia = Provincia;
                Nueva_Persona.Foto = Foto;

                Personas.Add(Nueva_Persona);
            }
            else
            {
                Debug.WriteLine("Persona repetida: " + Id + " " + Nombre);
                //MessageBox.Show("Persona repetida: " + Id + " " + Nombre);
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
            public string Estado;
            public string Ciudad;
            public string Provincia;
            public string Foto;
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
