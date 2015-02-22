using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace Nob2
{
    class Ext
    {
        WebRequest request;
        HttpWebResponse response;
        public string get_response(string url)
        {
            
             request = WebRequest.Create(url);

            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = 100000;
            // Get the response.
            response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            //dbg(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            //dbg(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();


            // Find matches.
            return responseFromServer;
        }
    }

}
