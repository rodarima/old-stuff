using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using agsXMPP;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ApiTuenti
{
    public class Persona
    {
        //public Persona() { }
        /*public Persona(string _Nombre, string _Apellidos, Jid _Jid)
        {
            Nombre._Nombre = _Nombre;
            Nombre.Apellidos = _Apellidos;
            Nombre.NombreAbreviado = _Nombre + " " + _Apellidos.Substring(0, 1) + ".";
            Nombre.NombreApellido = _Nombre + " " + _Apellidos;
            Jid = _Jid;
        }
        public Persona(string _Id)
        {
            Jid.User = _Id;
        }*/
        public Persona(Jid _Jid, NombrePersona _Nombre)
        {

            Nombre = _Nombre;
            Jid = _Jid;
        }
        public agsXMPP.Jid Jid { get; set; }
        public NombrePersona Nombre { get; set; }
        public DetallesPersona Detalles { get; set; }
        public InformacionPersona Informacion { get; set; }
        public EstadoPersona EstadoChat { get; set; }
        public DispositivoPersona Dispositivo { get; set; }
        public bool Existe { get; set; }
        public enum DispositivoPersona
        {
            Normal,
            Webcam,
            BlackBerry,
            iPhone
        }
        public class DetallesPersona
        {
            public bool Movil { get; set; }
            public bool WebCam { get; set; }
            public bool Juegos { get; set; }
            public bool Push { get; set; }

            public string Token { get; set; }
            public int Prioridad { get; set; }
            public int IndexImage { get; set; }
            public string Presencia { get; set; }
        }
        public class InformacionPersona
        {
            public string Estado { get; set; }
            public string Ciudad { get; set; }
            public string Provincia { get; set; }
            public string Avatar { get; set; }
            public string Telefono { get; set; }
            public string Sexo { get; set; }

        }
        public enum EstadoPersona
        {
            Conectado,
            Ausente,
            Desconectado
        }
        public class NombrePersona
        {
            public NombrePersona(string _Nombre, string _Apellidos)
            {
                Nombre = _Nombre;
                Apellidos = _Apellidos;
            }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string NombreAbreviado
            {
                get { return Nombre + " " + Apellidos.Substring(0, 1) + "."; }
            }
            public string NombreApellido
            {
                get
                {
                    string pApellido = Regex.Match(Apellidos, @"(\w|\\)").Value;
                    return Nombre + " " + pApellido;
                }
            }
            public string NombreEntero
            {
                get { return Nombre + " " + Apellidos; }
            }
        }
    }
    public class PersonaLista
    {
        public PersonaLista()
        {
            ListaPersonas = new List<Persona>();
        }
        private List<Persona> ListaPersonas;

        public Persona this[int Index]
        {
            get { return ListaPersonas[Index]; }
        }
        public Persona this[Persona.NombrePersona Nombre]
        {
            get
            {
                Persona PersonaBuscada = ListaPersonas.Find(delegate(Persona persona)
                {
                    return persona.Nombre == Nombre;
                });
                return PersonaBuscada;
            }
        }
        public Persona this[string Id]
        {
            get
            {
                Persona PersonaBuscada = ListaPersonas.Find(delegate(Persona persona)
                {
                    return persona.Jid.User == Id;
                });
                return PersonaBuscada;
            }
        }
        public Persona this[agsXMPP.Jid Jid]
        {
            get
            {
                Persona PersonaBuscada = ListaPersonas.Find(delegate(Persona persona)
                {
                    return persona.Jid.User == Jid.User;
                });
                return PersonaBuscada;
            }
        }

        public bool Existe(Persona persona)
        {
            return ListaPersonas.Exists(delegate(Persona personadelegado)
            {
                return personadelegado == persona;
            });
        }
        public bool Existe(Jid Jid)
        {
            return ListaPersonas.Exists(delegate(Persona persona)
            {
                return persona.Jid == Jid;
            });

        }
        public bool Existe(string Id)
        {
            return ListaPersonas.Exists(delegate(Persona persona)
            {
                return persona.Jid.User == Id;
            });

        }

        public int Count
        {
            get { return ListaPersonas.Count; }
        }
        public void Agregar(Persona persona)
        {
            if (!Existe(persona))
            {
                ListaPersonas.Add(persona);
            }
        }
        public bool AgregarPresencia(Persona Nueva_Persona)
        {
            bool _Existe = Existe(Nueva_Persona.Jid);
            if (Nueva_Persona.EstadoChat == Persona.EstadoPersona.Conectado)
            {
                if (!_Existe)
                {
                    ListaPersonas.Add(Nueva_Persona);
                    Debug.WriteLine("Añadiendo " + Nueva_Persona.Nombre.Nombre + " " + Nueva_Persona.Jid.Resource);
                }
            }
            else if (Nueva_Persona.EstadoChat == Persona.EstadoPersona.Ausente)
            {
                if (_Existe)
                {
                    Quitar(Nueva_Persona);
                }
                ListaPersonas.Add(Nueva_Persona);
                Debug.WriteLine("Actualizando " + Nueva_Persona.Nombre.NombreEntero + " " + Nueva_Persona.Jid.Resource);
            }
            else if (Nueva_Persona.EstadoChat == Persona.EstadoPersona.Desconectado)
            {
                Quitar(Nueva_Persona);
                Debug.WriteLine("Quitando " + Nueva_Persona.Nombre.NombreEntero + " " + Nueva_Persona.Jid.Resource);
            }
            return _Existe;
        }
        public Persona Encontrar(Jid Jid)
        {
            return ListaPersonas.Find(delegate(Persona persona)
            {
                return persona.Jid == Jid;
            });
           
        }
        public Persona Encontrar(string Id)
        {
            return ListaPersonas.Find(delegate(Persona persona)
            {
                return persona.Jid.User == Id;
            });

        }
        public void Quitar(Persona Persona)
        {
            List<Persona> PersonasEliminadas = ListaPersonas.FindAll(
            delegate(Persona _persona)
            {
                return _persona.Jid == Persona.Jid;
            }
            );
            for (int i = 0; i < PersonasEliminadas.Count; i++)
            {
                ListaPersonas.Remove(PersonasEliminadas[i]);
            }

        }
    }
    
    public class Pruebas
    {
        public void main()
        {
            PersonaLista p = new PersonaLista();
            p.Encontrar(new Jid("v")).EstadoChat = Persona.EstadoPersona.Conectado;
        }
    }

}
