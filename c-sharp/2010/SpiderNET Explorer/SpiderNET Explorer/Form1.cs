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

namespace SpiderNET_Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
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
        const string user = "xxxxxxx";
        const string pass = "xxxxxxx";
        const string url = "ftp://xxxxxxxxxxxxxx/";
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
                return true;
            }
            catch (Exception ex)
            {
                AddDebug(ex.Message);

                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Start();
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
                AddDebug("Pantalla actualizada correctamente.");
            }
            catch (Exception ex)
            {
                AddDebug(ex.Message);
                AddDebug("Ha ocurrido un error al intentar actualizar los datos");
            }

            //dataGridView1.Rows[1].Cells[1].Style.BackColor = System.Drawing.Color.Aqua;
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
    }
}
