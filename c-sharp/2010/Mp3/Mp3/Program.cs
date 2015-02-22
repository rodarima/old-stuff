using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;


namespace ReproductorMp3
{
    public class Rep
    {
        public Reproductor Sonido = new Reproductor();
        static void Main(string[] args)
        {
            Console.ReadKey();
            
            //IniciarReproduccion ini = new IniciarReproduccion();
            

        }

        public void IniciarReproduccion()
        {
            // Sí hay un elemento seleccionado en la lista


                Sonido.NombreDeArchivo = "F:\\musica\\Beyonce - Single Ladies.mp3";
                // Iniciamos la reproducción,
                Sonido.Reproducir();
                

        }
    }
}
