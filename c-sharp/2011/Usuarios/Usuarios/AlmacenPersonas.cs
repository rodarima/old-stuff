using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Usuarios
{
    class AlmacenPersonas
    {
        private List<Estructura_Persona> Personas;
        /// <summary>
        /// Crea un almacén para guardar datos de personas. Debe iniciarse con el número de personas que va a alojar.
        /// </summary>
        /// <param name="N_Personas">Número de personas que tendra el almacen como aforo</param>
        public AlmacenPersonas()
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
                MessageBox.Show("Persona repetida: " + Id + " " + Nombre);
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

        public AlmacenPersonas.Estructura_Persona this[int index]
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
        private int Aforo=0;
        public int Personas_Aforo
        {
            get { return Aforo; }
            set { Aforo = value; }
        }

    }
}
