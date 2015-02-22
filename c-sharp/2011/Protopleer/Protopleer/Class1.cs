using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Protopleer
{
    public class Protopleer_Downloader
    {/*
        public string[] GetSongByAnyWord(string Words)
        {
            if(Words=="")return null;

            Words.Replace(" ","+");
            int PageIndex = 1;
            string URL = "http://prostopleer.com/#/search?q=" + Words + "&page=" + PageIndex;
            string[] songs = new string[]; 
                ParseHTMLForSongsURLS(URL);
        }
        */
        public string GetHTMLCode(string URL)
        {
            if (URL == "") return null;
            try
            {
                // Create a request for the URL. 		
                WebRequest request = WebRequest.Create(URL);
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // Display the status.
                Console.WriteLine(response.StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Cleanup the streams and the response.
                reader.Close();
                dataStream.Close();
                response.Close();
                return responseFromServer;
            }
            catch
            {
                return null;
            }
        }
        /*public string ParseHTMLForSongsURLS(string URL)
        {
            if (URL == "") return null;
            
        }*/
        public int GetNumberOfPages(string URL)
        {
            if (URL == "") return 0;
            string CodeHTML = GetHTMLCode(URL);
            if (CodeHTML == null) return 0;
            string PageEnd = Regex.Match(CodeHTML, "<ul class=\"pagination\" end=\"[\\d]+\"").Result("[\\d]*");
            return Convert.ToInt32(PageEnd);
        }
    }
}
