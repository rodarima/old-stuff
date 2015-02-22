using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Nob_3;

namespace SourceSites
{
    public class Sites
    {
        /*public string[] GetSongByAnyWord(string Words)
        {
            if(Words=="")return null;

            Words.Replace(" ","+");
            int PageIndex = 1;
            string URL = "http://prostopleer.com/#/search?q=" + Words + "&page=" + PageIndex;
            string[] songs = new string[]; 
                ParseHTMLForSongsURLS(URL);
        }
        */
        public struct _ListOfSongs
        {
            public string[] Artist;
            public string[] Song;
            public string[] Lenght;
            public string[] Size;
            public string[] URL;
            public string[] Comments;
        }
        public _ListOfSongs ListOfSongs = new _ListOfSongs();
        public void NewListByResults(int NumberOfResults)
        {
            ListOfSongs.Artist = new string[NumberOfResults];
            ListOfSongs.Comments = new string[NumberOfResults];
            ListOfSongs.Lenght = new string[NumberOfResults];
            ListOfSongs.Size = new string[NumberOfResults];
            ListOfSongs.Song = new string[NumberOfResults];
            ListOfSongs.URL = new string[NumberOfResults];

        }
        public void _4sharedGetSongsByAnyWord(){
            if (Words == "") return;
            Words.Replace(" ","+");
            int PageIndex = 0;

            string URL = "http://search.4shared.com/q/BBQD/" + PageIndex + "0/music/" + Words;
            int NumberOfResults = GetNumberOfMaxResultsByURL(URL);
            NewListByResults(NumberOfResults);
            int Songs = 0;
            bool ContinueSearching=true;
            while (ContinueSearching == true)
            {
                URL ="http://search.4shared.com/q/BBQD/" + PageIndex + "0/music/" + Words ;
                int ParsedSongs = ParseHTMLForSongsURLS(URL);
                if (ParsedSongs == 0) ContinueSearching = false;
                PageIndex++;
                Songs += ParsedSongs;
            }
        }
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
        public int IndexAdding = 0;
        public string Words;
        public int ParseHTMLForSongsURLS(string URL)
        {
            if (URL == "") return 0;
            string CodeHTML = GetHTMLCode(URL);

            //CodeHTML = "<tr valign=\"top\" > <td width=\"102\">     <div class=\"imgbox\" align=\"center\">         <a href=\"http://www.4shared.com/audio/VB89hkxE/Dire_Straits_Mark_Knopfler__Er.htm\" target=\"_blank\"                ><img src=\"http://static.4shared.com/icons/32x32/mp3.gif\" width=\"32\" height=\"32\" vspace=\"27\" class=\"absmid\" alt=\"Dire Straits' Mark Knopfler & Eric Clapton, Sting, Phil Collins - Money For Nothing.mp3\" title=\"Dire Straits' Mark Knopfler & Eric Clapton, Sting, Phil Collins - Money For Nothing.mp3\" /></a>     </div>     <div class=\"fsize\">8,886 KB</div> </td> <td width=\"10\">&nbsp;</td> <td> ";

            Regex SongParser = new Regex("<a href=\"(?<SONG_URL>http://www.4shared.com/audio/[^.]*.htm)[^>]*><img src=\"http://static.4shared.com/icons/32x32/mp3.gif\" width=\"32\" height=\"32\" vspace=\"27\" class=\"absmid\" alt=\"(?<ARTIST>[^-]*) - (?<TITLE>[^.]*).mp3\"[^>]*></a>[^<]+</div>[^<]*<div class=\"fsize\">(?<SIZE>[^<]*)</div>");//
            MatchCollection matches = SongParser.Matches(CodeHTML);
            int SongsResult = matches.Count;
            if (SongsResult == 0) return 0;
            int i = 0;
            foreach (Match match in matches)
            {
                if (match.Groups["SONG_URL"] != null && match.Groups["SIZE"] != null && match.Groups["TITLE"] != null && match.Groups["ARTIST"] != null)
                {
                    ListOfSongs.Artist[IndexAdding] = match.Groups["ARTIST"].ToString();
                    ListOfSongs.Song[IndexAdding] = match.Groups["TITLE"].ToString();
                    ListOfSongs.URL[IndexAdding] = match.Groups["SONG_URL"].ToString();
                    ListOfSongs.Size[IndexAdding] = match.Groups["SIZE"].ToString();
                    //MessageBox.Show(match.Value);
                    IndexAdding++;
                }
            }
            return SongsResult;
        }
        public int GetNumberOfMaxResultsByURL(string URL)
        {
            int Results = 0;
            if (URL == "") return 0;
            string CodeHTML = GetHTMLCode(URL);
            if (CodeHTML == null) return 0;
            string PageEnd="";
            if(URL.StartsWith("http://es.dilandau.eu/")){
            PageEnd = Regex.Match(CodeHTML, "<ul class=\"pagination\" end=\"[^\"]*\"").Value;
            Results = Convert.ToInt32(PageEnd);
            Results = Results * 10;
            }
            if(URL.StartsWith("http://search.4shared.com/")){
                PageEnd = Regex.Match(CodeHTML, "<td class=\"pager\">&nbsp;([^)]*)").Value;
                PageEnd = PageEnd.Substring(25,PageEnd.Length-(9+25));
                Results = Convert.ToInt32(PageEnd);
            }
            return Results;
        }
    }
}
