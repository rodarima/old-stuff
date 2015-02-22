using System;
using System.Collections.Generic;
using System.Text;

namespace Files
{
    public class DBase
    {
        private string date;
        private string name;
        private string pass;
        private string location;

        public DBase()
        {
        }

        public DBase(string Fecha, string Nombre, string Contraseña, string Localizacion)
        {
            date = Fecha;
            name = Nombre;
            pass = Contraseña;
            location = Localizacion;
        }
        public string Fecha
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public string Nombre
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
        }
        public string Localizacion
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }


    }

}
