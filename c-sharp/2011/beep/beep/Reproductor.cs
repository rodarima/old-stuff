// ==========================================================
// Clase para reproducir archivos de mp3, utilizando las API´s
// Multimedia de Windows.
// Gonzalo Antonio Sosa M. Julio 2003
// ==========================================================

// importamos los espacios de nombres que necesitaremos.
using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace ReproductorMp3
{
	/// <summary>
	/// Clase para la reproducción de archivos de audio.
	/// </summary>
	public class Reproductor
	{
		#region Declaración de API´s
		// declaramos las funciones Api´s requeridas para la reproducción.

		// Envía cadenas de comando a un dispositivo MCI.
		[DllImport("winmm.dll")]
		public static extern int mciSendString(string lpstrCommand, 
			StringBuilder lpstrReturnString, int uReturnLengh, int hwndCallback);

		// Obtiene el número de dispositivos de salida, audio en este caso.
		[DllImport("winmm.dll")]
		public static extern int waveOutGetNumDevs();

		// Obtiene la cadena de mensaje de error, del valor de retorno de la función
		// mciSendString. 
		[DllImport("winmm.dll")]
		public static extern int mciGetErrorString(int fwdError,
			StringBuilder lpszErrorText, int cchErrorText);

		// Obtiene el nombre corto del archivo especificado en el parámetro
		// lpszLongPath.
		[DllImport("kernel32.dll")]
		public static extern int GetShortPathName(string lpszLongPath,
			StringBuilder lpszShortPath, int cchBuffer);

		// Obtiene el nombre largo del archivo especificado en el parámetro
		// lpszShortName
		[DllImport("kernel32.dll")]
		public static extern int GetLongPathName(string lpszShortPath,
			StringBuilder lpszLongPath, int cchBuffer);
		#endregion
		#region Variables y constantes
		const int MAX_PATH = 260;  // Constante con la longitud máxima de un nombre de archivo.
		const string Tipo = "MPEGVIDEO";  // Constante con el formato de archivo a reproducir.
		const string sAlias = "ArchivoDeSonido";  // Alias asiganado al archivo especificado.
		private string fileName; //Nombre de archivo a reproducir
		#endregion
		#region Declaración del Evento 
		//Especificamos el delegado al que se vá a asociar el evento.
		public delegate void ReproductorMessage(string Msg);  
		//Declaramos nuestro evento.
		public event ReproductorMessage ReproductorEstado;
		#endregion
		#region Contructor
		// Constructor de clase por defecto.
		public Reproductor()
		{
		}
		#endregion
		#region Propiedad de para leer o establecer el archivo a reproducir
		/// <summary>
		/// Propiedad que obtiene o establece el nombre y ruta del archivo
		/// de audio a reproducir
		/// </summary>
		public string NombreDeArchivo
		{
			get
			{
				return fileName;
			}
			set
			{
				fileName = value;
			}
		}
		#endregion
		#region Métodos que efectuan las operaciones básicas
		/// <summary>
		/// Método para convertir un nombre de archivo largo en uno corto,
		/// necesario para usarlo como parámetro de la función MciSendString.
		/// </summary>
		/// <param name="nombreLargo">Nombre y ruta del archivo a convertir.</param>
		/// <returns>Nombre corto del archivo especificado.</returns>
		private string NombreCorto(string NombreLargo)
		{
			// Creamos un buffer usando un constructor de la clase StringBuider.
			StringBuilder sBuffer = new StringBuilder(MAX_PATH);
			// intentamos la conversión del archivo.
			if (GetShortPathName(NombreLargo, sBuffer, MAX_PATH) > 0)
				// si la función ha tenido éxito devolvemos el buffer formateado
				// a tipo string.
				return sBuffer.ToString();
			else // en caso contrario, devolvemos una cadena vacía.
				return "";
		}

		/// <summary>
		/// Método que convierte un nombre de archivo corto, en uno largo.
		/// </summary>
		/// <param name="NombreCorto">Nombre del archivo a convertir.</param>
		/// <returns>Cadena con el nombre de archivo resultante.</returns>
		public string NombreLargo(string NombreCorto)
		{
			StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
			if (GetLongPathName(NombreCorto, sbBuffer, MAX_PATH) > 0)
				return sbBuffer.ToString();
			else 
				return "";

		}

		/// <summary>
		/// Método para convertir los mensajes de error numéricos, generados por la
		/// función mciSendString, en su correspondiente cadena de caracteres.
		/// </summary>
		/// <param name="ErrorCode">Código de error devuelto por la función mciSendString</param>
		/// <returns>Cadena de tipo string, con el mensaje de error</returns>
		private string MciMensajesDeError(int ErrorCode)
		{
			// Creamos un buffer, con suficiente espacio, para almacenar el mensaje
			// devuelto por la función.
			StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
			// Obtenemos la cadena de mensaje.
			if (mciGetErrorString(ErrorCode, sbBuffer, MAX_PATH) != 0)
				// Sí la función ha tenido éxito, valor devuelto diferente de 0,
				// devolvemos el valor del buffer, formateado a string.
				return sbBuffer.ToString();
			else // si no, devolvemos una cadena vacía.
				return "";
		}

		/// <summary>
		/// Devuelve el número de dispositivos de salida, 
		/// instalados en nuestro sistema.
		/// </summary>
		/// <returns>Número de dispositivos.</returns>
		public int DispositivosDeSonido()
		{
			return waveOutGetNumDevs();
		}

		/// <summary>
		/// Abre el archivo específicado.
		/// </summary>
		/// <returns>Verdadero si se tuvo éxito al abrir el archivo
		/// falso en caso contrario.</returns>
		private bool Abrir()
		{
			// verificamos que el archivo existe; si no, regresamos falso.
			if (!File.Exists(fileName)) return false;
			// obtenemos el nombre corto del archivo.
			string nombreCorto = NombreCorto(fileName);
			// intentamos abrir el archivo, utilizando su nombre corto
			// y asignándole un alias para trabajar con él.
			if (mciSendString("open " + nombreCorto + " type " + Tipo + 
				" alias " + sAlias, null, 0, 0) == 0)
				// si el resultado es igual a 0, la función tuvo éxito,
				// devolvemos verdadero.
					return true;
			else
				// en caso contrario, falso.
				return false;
		}

		/// <summary>
		/// Inicia la reproducción del archivo específicado.
		/// </summary>
		public void Reproducir()
		{
			// Nos cersioramos que hay un archivo que reproducir.
			if (fileName != "")
			{
				// intentamos iniciar la reproducción.
				if (Abrir())
				{
					int mciResul = mciSendString("play " + sAlias, null, 0, 0);
					/*if (mciResul == 0)
						// si se ha tenido éxito, devolvemos el mensaje adecuado,
						ReproductorEstado("Ok");
					else // en caso contrario, la cadena de mensaje de error.
						ReproductorEstado(MciMensajesDeError(mciResul));
				*/}
				
			}
			
		}

		/// <summary>
		/// Inicia la reproducción desde una posición específica.
		/// </summary>
		/// <param name="Desde">Nuevo valor de la posición a iniciar</param>
		public void ReproducirDesde(long Desde)
		{
			int mciResul = mciSendString("play " + sAlias + " from " +
				(Desde * 1000).ToString(), null, 0, 0);
			if (mciResul == 0)
				ReproductorEstado("Nueva Posición: " + Desde.ToString());
			else
				ReproductorEstado(MciMensajesDeError(mciResul));
		}

		/// <summary>
		/// Modifica la velocidad actual de reproducción.
		/// </summary>
		/// <param name="Tramas">Nuevo valor de la velocidad.</param>
		public void Velocidad(int Tramas)
		{
			// Establecemos la nueva velocidad pasando como parámetro,
			// la cadena adecuada, incluyendo el nuevo valor de la velocidad,
			// medido en tramas por segundo.
			int mciResul = mciSendString("set " + sAlias + " tempo " +
				Tramas.ToString(), null, 0, 0);
			if (mciResul == 0)
				// informamos el evento de la modificación éxitosa,
				ReproductorEstado("Velocidad modificada.");
			else // de lo contrario, enviamos el mensaje de error correspondiente.
				ReproductorEstado(MciMensajesDeError(mciResul));
		}

		/// <summary>
		/// Mueve el apuntador del archivo a la posición especificada.
		/// </summary>
		/// <param name="NuevaPosicion">Nueva posición</param>
		public void Reposicionar(int NuevaPosicion)
		{
			// Enviamos la cadena de comando adecuada a la función mciSendString,
			// pasando como parte del mismo, la cantidad a mover el apuntador de
			// archivo.
			int mciResul = mciSendString("seek " + sAlias + " to " +
				(NuevaPosicion * 1000).ToString(), null, 0, 0);
			if (mciResul == 0)
				ReproductorEstado("Nueva Posición: " + NuevaPosicion.ToString());
			else 
				ReproductorEstado(MciMensajesDeError(mciResul));
		}

		/// <summary>
		/// Mueve el apuntador de archivo al inicio del mismo.
		/// </summary>
		public void Principio()
		{
			// Establecemos la cadena de comando para mover el apuntador del archivo,
			// al inicio de este.
			int mciResul = mciSendString("seek " + sAlias + " to start", null, 0, 0);
			if (mciResul == 0)
				ReproductorEstado("Inicio de " + Path.GetFileNameWithoutExtension(fileName));
			else 
				ReproductorEstado(MciMensajesDeError(mciResul));
		}

		/// <summary>
		/// Mueve el apuntador de archivo al final del mismo.
		/// </summary>
		public void Final()
		{
			// Establecemos la cadena de comando para mover el apuntador del archivo,
			// al final de este.
			int mciResul = mciSendString("seek " + sAlias + " to end", null, 0, 0);
			if (mciResul == 0)
				ReproductorEstado("Final de " + Path.GetFileNameWithoutExtension(fileName));
			else 
				ReproductorEstado(MciMensajesDeError(mciResul));
		}

		/// <summary>
		/// Pausa la reproducción en proceso.
		/// </summary>
		public void Pausar()
		{
			// Enviamos el comando de pausa mediante la función mciSendString,
			int mciResul = mciSendString("pause " + sAlias, null, 0, 0);

		}

		/// <summary>
		/// Continúa con la reproducción actual.
		/// </summary>
		public void Continuar()
		{
			// Enviamos el comando de pausa mediante la función mciSendString,
			int mciResul = mciSendString("resume " + sAlias, null, 0, 0);
			
		}

		/// <summary>
		/// Detiene la reproducción actual y cierra el archivo de audio.
		/// </summary>
		public void Cerrar()
		{
			// Establecemos los comando detener reproducción y cerrar archivo.
			mciSendString("stop " + sAlias, null, 0, 0);
			mciSendString("close " + sAlias, null, 0, 0);
		}

		/// <summary>
		/// Detiene la reproducción del archivo de audio.
		/// </summary>
		public void Detener()
		{
			// Detenemos la reproducción, mediante el comando adecuado.
			mciSendString("stop " + sAlias, null, 0, 0);
		}

		/// <summary>
		/// Obtiene el estado de la reproducción en proceso.
		/// </summary>
		/// <returns>Cadena con la información requerida.</returns>
		public string Estado()
		{
			StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
			// Obtenemos la información mediante el comando adecuado.
			mciSendString("status " + sAlias + " mode", sbBuffer, MAX_PATH, 0);

			// Devolvemos la información.
			return sbBuffer.ToString();
		}	

		/// <summary>
		/// Obtiene un valor que indica si la reproducción está en marcha.
		/// </summary>
		/// <returns>Verdadero si se encuentra en marcha, falso si no.</returns>
		public bool EstadoReproduciendo()
		{
			return Estado() == "playing" ? true : false;
		}

		/// <summary>
		/// Obtiene un valor que indica si la reproducción está pausada.
		/// </summary>
		/// <returns>Verdadero si se encuentra en marcha, falso si no.</returns>
		public bool EstadoPausado()
		{
			return Estado() == "paused" ? true : false;
		}

		/// <summary>
		/// Obtiene un valor que indica si la reproducción está detenida.
		/// </summary>
		/// <returns>Verdadero si se encuentra en marcha, falso si no.</returns>
		public bool EstadoDetenido()
		{
			return Estado() == "stopped" ? true : false;
		}

		/// <summary>
		/// Obtiene un valor que indica si el archivo se encuentra abierto.
		/// </summary>
		/// <returns>Verdadero si se encuentra en marcha, falso si no.</returns>
		public bool EstadoAbierto()
		{
			return Estado() == "open" ? true : false;
		}

		/// <summary>
		/// Calcula la posición actual del apuntador del archivo.
		/// </summary>
		/// <returns>Posición actual</returns>
		public long CalcularPosicion()
		{
			StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
			// Establecemos el formato de tiempo.
			mciSendString("set " + sAlias + " time format milliseconds", null, 0, 0);
			//  Enviamos el comando para conocer la posición del apuntador.
			mciSendString("status " + sAlias + " position", sbBuffer, MAX_PATH, 0);

			// Sí hay información en el buffer,
			if (sbBuffer.ToString() != "")
				// la devolvemos, eliminando el formato de milisegundos
				// y formateando la salida a entero largo;
				return long.Parse(sbBuffer.ToString()) / 1000;
			else // si no, devolvemos cero.
				return 0L;
		}

		/// <summary>
		/// Devuelve una cadena con la información de posición del apuntador del archivo.
		/// </summary>
		/// <returns>Cadena con la información.</returns>
		public string Posicion()
		{
			// obtenemos los segundos.
			long sec = CalcularPosicion();
			long mins;

			// Si la cantidad de segundos es menor que 60 (1 minuto),
			if (sec < 60)
				// devolvemos la cadena formateada a 0:Segundos.
				return "0:" + String.Format("{0:D2}", sec);
			// Si los segundos son mayores que 59 (60 o más),
			else if (sec > 59)
			{
				// calculamos la cantidad de minutos,
				mins = (int)(sec / 60);
				// restamos los segundos de la cantida de minutos obtenida,
				sec = sec - (mins * 60);
				// devolvemos la cadena formateada a Minustos:Segundos.
				return String.Format("{0:D2}", mins) + ":" + String.Format("{0:D2}", sec);
			}
			else // en caso de obtener un valor menos a 0, devolvemos una cadena vacía.
				return "";
				
		}

		/// <summary>
		/// Cálcula el tamaño del archivo abierto para reproducción.
		/// </summary>
		/// <returns>Tamaño en segundos del archivo.</returns>
		public long CalcularTamaño()
		{
			StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
			mciSendString("set " + sAlias + " time format milliseconds", null, 0, 0);
			// Obtenemos el largo del archivo, en millisegundos.
			mciSendString("status " + sAlias + " length", sbBuffer, MAX_PATH, 0);

			// Sí el buffer contiene información,
			if (sbBuffer.ToString() != "")
				// la devolvemos, formateando la salida a entero largo;
				return long.Parse(sbBuffer.ToString()) / 1000;
			else // si no, devolvemos cero.
				return 0L;
		}

		/// <summary>
		/// Obtiene una cadena con la información sobre el tamaño (largo) del archivo.
		/// </summary>
		/// <returns>Largo del archivo de audio.</returns>
		public string Tamaño()
		{
			long sec = CalcularTamaño();
			long mins;

			// Si la cantidad de segundos es menor que 60 (1 minuto),
			if (sec < 60)
				// devolvemos la cadena formateada a 0:Segundos.
				return "0:" + String.Format("{0:D2}", sec);
				// Si los segundos son mayores que 59 (60 o más),
			else if (sec > 59)
			{
				mins = (int)(sec / 60);
				sec = sec - (mins * 60);
				// devolvemos la cadena formateada a Minustos:Segundos.
				return String.Format("{0:D2}", mins) + ":" + String.Format("{0:D2}", sec);
			}
			else 
				return "";
		}
		#endregion
	}
}
