using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using agsXMPP;
using System.Diagnostics;

namespace ApiTuenti
{
    public enum ConexionEstado
    {
        Incorrecto,
        Correcto,
        Cargando,
        Error
    }
    public class API
    {
        public static string Version()
        {
            string mLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return System.Diagnostics.FileVersionInfo.GetVersionInfo(mLocation).FileVersion;
        }
        public static ConexionEstado Estado { get; set; }

        public API(string Email, string Pass)
        {
            
        }
        public PersonaLista listaAmigos { get; set; }
        public PersonaLista listaChat;
        public Conexion conexion { get; set; }
        public Chat chat;
        public void Conectar(string Email, string Pass)
        {
            conexion.Obtener_Token_Id(Email, Pass);
            if (Estado != ConexionEstado.Correcto) return;

            listaAmigos = conexion.Obtener_Amigos();
            if (Estado != ConexionEstado.Correcto) return;

            chat = new Chat(conexion.MiPersona.Jid, conexion.MiPersona.Detalles.Token, listaAmigos, ref listaChat);


        }

    }
}
