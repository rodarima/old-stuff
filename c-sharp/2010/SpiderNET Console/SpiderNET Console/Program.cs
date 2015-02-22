using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace SpiderNET_Console
{
    class Program
    {
        const string DownloadNetFile = "redes.txt";
        const string user = "xxxxxxxxx";
        const string pass = "xxxxxxxxx";
        const string url = "ftp://xxxxxxxxxxxxx/";
        const string cabecera = "[d]Descargar  [s]Subir  [m]Mostrar";

        static void Main(string[] args)
        {
            while (true)
            {
                //PrintHeader();
                string key = Console.ReadKey().Key.ToString();
                switch (key)
                {
                    case "D":
                        Download(DownloadNetFile);
                        break;
                    case "S":
                        Upload(DownloadNetFile);
                        break;
                    case "M":
                        ShowFile();
                        break;
                    default:
                        Console.WriteLine("-FAIL");
                        break;
                }
            }
            

        }
        static void Debug(string texto, int tipo)
        {
            ConsoleColor cc = Console.ForegroundColor;
            if (tipo == 1) { Console.ForegroundColor = ConsoleColor.Green; } //ok
            if (tipo == 2) { Console.ForegroundColor = ConsoleColor.Gray; } //atencion
            if (tipo == 3) { Console.ForegroundColor = ConsoleColor.Red; } //error
            int ancho = Console.WindowWidth;
            if (texto.Length >= ancho - 17) {//la hora ocupa 12 + el ok o error 5 + espacio = 17
                texto = texto.Substring(0, ancho - 21) + "... ";//17 de los bordes + "... " = 21
            }
            
            Console.Write(DateTime.Now.ToString("[HH:mm:ss]: ")+texto);
            Console.ForegroundColor = cc;
        }
        static void DebSta(string texto, int tipo)
        {
            ConsoleColor cc = Console.ForegroundColor;
            if (tipo == 1) { Console.ForegroundColor = ConsoleColor.Green; } //ok
            if (tipo == 2) { Console.ForegroundColor = ConsoleColor.White; } //atencion
            if (tipo == 3) { Console.ForegroundColor = ConsoleColor.Red; } //error
            int ancho = Console.WindowWidth;
            Console.CursorLeft = ancho - texto.Length;
            Console.Write(texto);
            Console.ForegroundColor = cc;
        }
        static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(cabecera);
        }
        static bool Upload(string filename)
        {
            try
            {
                Debug("Comenzando parametros de la transferencia...", 2);
                FileInfo fileInf = new FileInfo(filename);
                string uri = url + fileInf.Name;
                FtpWebRequest reqFTP;
                DebSta("OK\n", 1);
                // Create FtpWebRequest object from the Uri provided
                Debug("Creando peticion web FTP...", 2);
                reqFTP = (FtpWebRequest)FtpWebRequest.Create
                         (new Uri(url + fileInf.Name));
                DebSta("OK\n", 1);
                // Provide the WebPermission Credintials
                Debug("Comprobando usuario...", 2);
                reqFTP.Credentials = new NetworkCredential(user, pass); DebSta("OK\n", 1);
                // By default KeepAlive is true, where the control connection
                // is not closed after a command is executed.
                reqFTP.KeepAlive = false;

                // Specify the command to be executed.
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
                // Specify the data transfer type.
                reqFTP.UseBinary = true;

                // Notify the server about the size of the uploaded file
                Debug("Creando informe del tamaño del archivo...", 2);
                reqFTP.ContentLength = fileInf.Length; DebSta("OK\n", 1);
                // The buffer size is set to 2kb
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;
                Debug("Abriendo nuevo flujo para la lectura del archivo...", 2);
                // Opens a file stream (System.IO.FileStream) to read the file
                // to be uploaded
                FileStream fs = fileInf.OpenRead();
                DebSta("OK\n", 1);
                Debug("Inicializando flujo para la subida...", 2);
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();
                DebSta("OK\n", 1);
                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength); ;
                // Till Stream content ends
                Debug("Iniciando la subida del archivo al servidor...", 2);
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload
                    // Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                DebSta("OK\n", 1);
                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
                Debug("Archivo subido al servidor correctamente\n", 2);
                return true;
            }
            catch (Exception ex)
            {
                DebSta("ERROR\n", 3);
                Debug(ex.Message, 3);
                return false;
            }
        }
        static bool Download(string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                //filePath: The full path where the file is to be created.
                //fileName: Name of the file to be createdNeed not name on
                //          the FTP server. name name()
                Debug("Creando flujo FTP...", 2);
                FileStream outputStream = new FileStream(fileName, FileMode.Create); DebSta("OK\n", 1);
                Debug("Creando peticion web FTP...", 2);
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(url + fileName)); DebSta("OK\n", 1);
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(user, pass);
                Debug("Conectando con el servidor...", 2);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse(); DebSta("OK\n", 1);
                Debug("Respuesta obtenida, abriendo un nuevo flujo de datos...", 2);
                Stream ftpStream = response.GetResponseStream();
                DebSta("OK\n", 1);
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                Debug("Descargando archivo " + DownloadNetFile + " ...", 2);
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                DebSta("OK\n", 1);
                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                DebSta("ERROR\n", 3);
                Debug(ex.Message, 3);

                return false;
            }
        }
        static bool ShowFile()
        {
            try
            {
                string database;
                Debug("Comenzando la lectura del fichero  " + DownloadNetFile + " ...", 2);
                System.IO.StreamReader sr = new System.IO.StreamReader(DownloadNetFile);
                database = sr.ReadToEnd(); DebSta("OK\n", 1);
                sr.Close();
                sr.Dispose();
                Debug("Analizando y distribuyendo los datos ...", 2);
                string[] Array, Array2;
                string[] Separ = { "\r\n" };
                Array = database.Split((Separ), StringSplitOptions.RemoveEmptyEntries);
                int LenArr = Array.Length;
                string[] Sep1 = { ";" };
                DebSta("OK\n", 1);
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < LenArr; i++)
                {
                    Array2 = Array[i].Split((Sep1), StringSplitOptions.None);
                    try
                    {

                        Console.Write(Array2[1]);
                        Console.CursorLeft = 15;
                        Console.Write(Array2[2]);
                        Console.CursorLeft = 30;
                        Console.Write(Array2[3] + "\n");
                    }
                    catch (Exception ex) { DebSta("ERROR\n", 3); Debug(ex.Message, 3); }

                }
                
                return true;
            }
            catch(Exception ex)
            {
                DebSta("ERROR\n", 3);
                Debug(ex.Message, 3);

                return false;
            }
            

        }
        /*string CheckFields()
        {
            AddDebug("Intentando añadir datos al fichero: " + DownloadNetFile);
            if (TxtName.Text != "" && TxtPass.Text != "" )
            {
                string newline = DateTime.Now.ToString("[dd/MM/yyyy HH:mm:ss];") + TxtName.Text + ";" + TxtPass.Text + ";" + TxtLocation.Text;
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(DownloadNetFile, true))
                    {
                        file.WriteLine(newline);
                        file.Close();
                        AddDebug("Se ha añadido correctamente: " + newline);
                    }
                }
                catch (Exception ex)
                {
                    AddDebug(ex.Message);
                    AddDebug("Error al añadir la linea: " + newline);
                }
                
                DataRefresh();
                Upload(DownloadNetFile);


                return newline;
            }
            else
            {
                AddDebug("#### Hay campos vacios ####");
                return "";

            }
        }*/
        string[] Array2;
        /*void DataRefresh()
        {
            AddDebug("Actualizando la pantalla...");
            try
            {
                string database;
                ProgBarAdd(10);
                System.IO.StreamReader sr = new System.IO.StreamReader(DownloadNetFile);
                database = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                string[] Array;
                string[] Separ = { "\r\n" };
                Array = database.Split((Separ), StringSplitOptions.RemoveEmptyEntries);
                ProgBarAdd(10);
                int LenArr = Array.Length;

                DBase[] arr = new DBase[LenArr];
                string[] Sep1 = { ";" };
                ProgBarAdd(30);
                for (int i = 0; i < LenArr; i++)
                {
                    Array2 = Array[i].Split((Sep1), StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        arr[i] = new DBase(Array2[0], Array2[1], Array2[2], Array2[3]);
                    }
                    catch
                    {
                        try
                        {
                            AddDebug("Se ha encontrado una red con datos incompletos: " + Array2[1]);
                            arr[i] = new DBase(Array2[0], Array2[1], Array2[2], "<No hay datos>");
                        }
                        catch
                        {
                            try
                            {
                                AddDebug("Se ha encontrado una red con datos incompletos: " + Array2[1]);
                                arr[i] = new DBase(Array2[0], Array2[1], "<No hay datos>", "<No hay datos>");
                            }
                            catch
                            {
                                try
                                {
                                    AddDebug("Se ha encontrado una red con datos incompletos: " + Array2[1]);
                                    arr[i] = new DBase(Array2[0], "<No hay datos>", "<No hay datos>", "<No hay datos>");
                                }
                                catch
                                {
                                    AddDebug("Se ha encontrado una linea vacia");
                                    arr[i] = new DBase("<No hay datos>", "<No hay datos>", "<No hay datos>","<No hay datos>");

                                }
                            }

                        }

                    }
                }
                ProgBarAdd(100);
                dataGridView1.DataSource = arr;
                int leng = arr.Length;
                InfoClaves.Text = "Claves: " + leng.ToString() + " (" + (Convert.ToDouble(leng) / ElapsedTime()).ToString("0.0000") + " claves/día)";
                AddDebug("Pantalla actualizada correctamente.");
            }
            catch (Exception ex)
            {
                AddDebug(ex.Message);
                AddDebug("Ha ocurrido un error al intentar actualizar los datos");
            }

            //dataGridView1.Rows[1].Cells[1].Style.BackColor = System.Drawing.Color.Aqua;
        }*/
        double ElapsedTime()
        {
            double dias = 0;

            Intervalo edad = new Intervalo();
            edad.Fecha1 = DateTime.Now;
            edad.Fecha2 = Convert.ToDateTime("16/08/2010");
            // Edad en años
            dias = (double)(edad.Diferencia.Days);
            return dias;
        }
        /*void Search()
        {
            //DataRefresh();
            if (TxtSearch.Text != "")
            {
                try
                {
                    string database;

                    System.IO.StreamReader sr = new System.IO.StreamReader(DownloadNetFile);
                    database = sr.ReadToEnd();
                    sr.Close();
                    string[] ArrayPrinc;
                    string[] Separ = { "\r\n" };
                    ArrayPrinc = database.Split((Separ), StringSplitOptions.RemoveEmptyEntries);
                    int LenArr = ArrayPrinc.Length;
                    DBase[] arr = new DBase[LenArr];
                    string[] Sep1 = { ";" };
                    int ind = 0;
                    AddDebug("Buscando la cadena: " + TxtSearch.Text);
                    for (int i = 0; i < LenArr; i++)
                    {
                        if (ArrayPrinc[i].ToLower().Contains(TxtSearch.Text.ToLower()))
                        {
                            Array2 = ArrayPrinc[i].Split((Sep1), StringSplitOptions.None);

                            try
                            {
                                arr[ind] = new DBase(Array2[0], Array2[1], Array2[2], Array2[3]);
                            }
                            catch
                            {
                                try
                                {
                                    arr[ind] = new DBase(Array2[0], Array2[1], Array2[2], "<No hay datos>");
                                }
                                catch
                                {
                                    try
                                    {
                                        arr[ind] = new DBase(Array2[0], Array2[1], "<No hay datos>", "<No hay datos>");
                                    }
                                    catch 
                                    {
                                        try
                                        {
                                            arr[ind] = new DBase(Array2[0], "<No hay datos>", "<No hay datos>", "<No hay datos>");
                                        }
                                        catch (Exception ex)
                                        {
                                            AddDebug(ex.Message);

                                        }

                                    }
                                }
                            }
                            ind++;
                        }
                    }
                    AddDebug("Se han encontrado  " + Convert.ToString(ind) + " coincidencia(s)");
                    dataGridView1.DataSource = arr;

                }

                catch (Exception ex)
                {
                    AddDebug(ex.Message);
                    AddDebug("Ha ocurrido un error al intentar actualizar los datos");
                }
            }
        }*/
        public class Intervalo
        {
            DateTime fecha1;
            DateTime fecha2;

            public Intervalo()
            {
            }

            public DateTime Fecha1
            {
                set
                {
                    fecha1 = value;
                }
            }

            public DateTime Fecha2
            {
                set
                {
                    fecha2 = value;
                }
            }
            // Retorna la diferencia entre las dos fechas
            public TimeSpan Diferencia
            {
                get
                {
                    return fecha1 - fecha2;
                }
            }
        }
        
    }
}
