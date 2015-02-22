using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Files
{
    public class DBase
    {
        private string make;
        private string model;

        public DBase()
        {
        }

        public DBase(string Nombre, string Model)
        {
            make = Nombre;
            model = Model;
        }

        public string Nombre
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        
    }
	
}
