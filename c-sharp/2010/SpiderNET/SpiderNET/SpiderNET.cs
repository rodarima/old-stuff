using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using Files;
using System.Media;
using Google_Maps;

namespace SpiderNET
{
    public partial class SpiderNET : Form
    {
        public SpiderNET()
        {
            InitializeComponent();
        }
        void AddDebug(string texto)
        {
            debug.Text += Environment.NewLine;
            debug.Text += DateTime.Now.ToString("[hh:mm:ss]: ");
            debug.Text += texto;
            debug.SelectionStart = debug.Text.Length;
            debug.ScrollToCaret();
            debug.Refresh();
            //Linfo.Text = texto;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DataRefresh();
            //dataGridView1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //Start();
        }
        const string DownloadNetFile = "redes.txt";
        const string user = "xxxxxxxx";
        const string pass = "xxxxxxxx";
        const string url = "ftp://xxxxxxxxxxxxxxx/";
        void Start()
        {


            //Upload(DownloadNetFile);

            if (Download(DownloadNetFile))
            {

                AddDebug("Descarga realizada con éxito.");

            }
            else
            {
                AddDebug("Descarga fallida, abortando...");
                return;
            }

            DataRefresh();

            /*try
            {
                AddDebug(".....................Inicio BD..........................");
                System.IO.StreamReader sr = new System.IO.StreamReader(DownloadNetFile);
                string texto = sr.ReadToEnd();
                sr.Close();
                AddDebug(texto);
                AddDebug(".......................Fin BD...........................");
                Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                AddDebug("Se ha producido un error al intentar leer el archivo " + DownloadNetFile);
            }*/

        }
        bool Upload(string filename)
        {
            try
            {
            AddDebug("Intentando subir el archivo " + DownloadNetFile);
            ProgBarAdd(10);
            FileInfo fileInf = new FileInfo(filename);
            string uri = url + fileInf.Name;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create
                     (new Uri(url + fileInf.Name));
            AddDebug("Conectando con el servidor...");
            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(user, pass);
            ProgBarAdd(20);
            // By default KeepAlive is true, where the control connection
            // is not closed after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            ProgBarAdd(30);
            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;
            ProgBarAdd(40);
            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file
            // to be uploaded
            FileStream fs = fileInf.OpenRead();
            ProgBarAdd(50);
            
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);
                ProgBarAdd(60);
                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload
                    // Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                ProgBarAdd(70);
                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
                ProgBarAdd(100);
                AddDebug("Subida realizada correctamente");
                SystemSounds.Asterisk.Play();
                return true;
            }
            catch (Exception ex)
            {
                AddDebug("Error al intentar subir el archivo");
                AddDebug(ex.Message);
                SystemSounds.Hand.Play();
                return false;
            }
        }
        bool Download(string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                //filePath: The full path where the file is to be created.
                //fileName: Name of the file to be createdNeed not name on
                //          the FTP server. name name()
                FileStream outputStream = new FileStream(fileName, FileMode.Create);
                ProgBarAdd(10);
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(url + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(user, pass);
                AddDebug("Intentando conectar con el servidor ...");
                ProgBarAdd(20);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                ProgBarAdd(50);
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                ProgBarAdd(70);
                AddDebug("Descargando archivo " + DownloadNetFile + " ...");
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ProgBarAdd(100);
                ftpStream.Close();
                outputStream.Close();
                response.Close();
                SystemSounds.Asterisk.Play();

                return true;
            }
            catch (Exception ex)
            {
                AddDebug(ex.Message);
                SystemSounds.Hand.Play();
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }
        string CheckFields()
        {
            AddDebug("Intentando añadir datos al fichero: " + DownloadNetFile);
            if (TxtName.Text != "" && TxtPass.Text != "" /*&& TxtLocation.Text != ""*/)
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
                //ShowMap();


                return newline;
            }
            else
            {
                AddDebug("#### Hay campos vacios ####");
                return "";

            }
        }
        
        void ShowMap()
        {
            Maps m = new Maps();
            m.Show();
        }
        private void BntAdd_Click(object sender, EventArgs e)
        {
            
            CheckFields();

        }
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            Upload(DownloadNetFile);
        }
        string[] Array2;
        void DataRefresh()
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
        }
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
        private void button1_Click_1(object sender, EventArgs e)
        {

            DataRefresh();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", DownloadNetFile);
                AddDebug("Edicion manual del archivo: " + DownloadNetFile);
            }
            catch (Exception ex)
            {
                AddDebug(ex.Message);
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        void Search()
        {
            DataRefresh();
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
        }
        void ProgBarAdd(int progress)
        {
            if (progress <= 100)
            {
                pbar.Value = progress;
            }
            
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (AutoSearch.Checked == true)
            {
                Search();
            }
        }
        private void tArranque_Tick(object sender, EventArgs e)
        {
            tArranque.Enabled = false;
            Start();
        }
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

        private void BtnMaps_Click(object sender, EventArgs e)
        {
            ShowMap();
        }

    }
}
