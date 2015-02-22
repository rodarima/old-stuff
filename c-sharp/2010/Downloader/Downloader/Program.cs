using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Downloader
{
    class Program
    {
        static void Upload(string filename)
        {
            FileInfo fileInf = new FileInfo(filename);
            string uri = "ftp://xxxxxxxxxxxxxxxxxxx/" + fileInf.Name;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create
                     (new Uri("ftp://xxxxxxxxxxxxxxxxx/" + fileInf.Name));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential("xxxxxxxx", "xxxxxxxxxxx");

            // By default KeepAlive is true, where the control connection
            // is not closed after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file
            // to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload
                    // Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                FileStream outputStream = new FileStream(fileName, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://xxxxxxxxxxxxxxxxx/" + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential("xxxxxxx",
                                                           "xxxxxxx");
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        static int Main(string[] args)
        {
            string DownloadNetFile = "redes.txt";

            Upload(DownloadNetFile);
            Console.Write("--> Descargando archivo {0}... ", DownloadNetFile);
            if (Download(DownloadNetFile))
            {
                Console.WriteLine("[OK] \n");
            }
            else
            {
                Console.WriteLine("Descarga fallida, saliendo...");
                Console.ReadLine();
                return -1;
            }
            
              

            try
            {

                System.IO.StreamReader sr = new System.IO.StreamReader(DownloadNetFile);
                string texto = sr.ReadToEnd();
                sr.Close();

                Console.WriteLine(texto);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Se ha producido un error al intentar leer el archivo {0}", DownloadNetFile);
            }
            
            Console.ReadLine();
            return 0;
        }
    }
}
