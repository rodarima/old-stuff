using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace pass
{
    class Program
    {
        
        static string get_response(string url)
        {
            try
            {
                WebRequest request;
                HttpWebResponse response;
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
            catch
            {
                return null;
            }
            
        }
        static public void OrdenarBurbuja(int[] b)
        {
            for (int pasadas = 1; pasadas < b.Length; pasadas++) // pasadas
                for (int i = 0; i < b.Length - 1; i++)
                    if (b[i] > b[i + 1])      // comparar
                        intercambio(b, i);         // intercambiar
        }
        static public void intercambio(int[] c, int primero)
        {
            int temp;      // variable temporal para el intercambio
            temp = c[primero];
            c[primero] = c[primero + 1];
            c[primero + 1] = temp;
        }
        static void Main(string[] args)
        {
            char[] let = { 'e', 'r', 't', 'u', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'l', 'm' };
            double best = 0;
            string best_name="";
            int index = 0;
            StreamWriter sw = new StreamWriter("pass2.txt");
            for (char pri = 'g'; pri <= 'z'; )
            {
                for (char seg = 'a'; seg <= 'z'; seg++)
                {
                    for (char ter = 'a'; ter <= 'z'; ter++)
                    {
                        for (char cua = 'a'; cua <= 'z'; cua++)
                        {
                            for (char qui = 'a'; qui <= 'z'; qui++)
                            {
                                //Console.Write(pri.ToString() + seg.ToString() + ter.ToString() + cua.ToString() + qui.ToString() + Environment.NewLine);
                                if (Regex.IsMatch(pri.ToString(), "[ertuopasdfglm]") == false) continue;
                                if (Regex.IsMatch(seg.ToString(), "[ertuopasdfglm]") == false) continue;
                                if (Regex.IsMatch(ter.ToString(), "[ertuopasdfglm]") == false) continue;
                                if (Regex.IsMatch(cua.ToString(), "[ertuopasdfglm]") == false) continue;
                                if (Regex.IsMatch(qui.ToString(), "[ertuopasdfglm]") == false) continue;


                                if (pri == seg || seg == ter || ter == cua || cua == qui) continue; //quita las palindromas


                                if (pri != 'g') continue;
                                if (qui == 'f') continue;
                                if (Regex.IsMatch(seg.ToString(), "[aeiou]") == false) continue;
                                if (Regex.IsMatch(qui.ToString(), "[aeiou]") == false) continue; 

                                index++;
                                string url_google = get_response("http://www.google.es/search?q=" + pri.ToString() + seg.ToString() + ter.ToString() + cua.ToString() + qui.ToString());
                                string goog = Regex.Match(url_google, "Aproximadamente [^r]+resultados").ToString();
                                if (goog != "")
                                {
                                    goog = goog.Substring(16, goog.Length - (16 + 11));
                                    goog = goog.Replace(".", "");
                                    if (best == 0) { best = Convert.ToDouble(goog); }
                                    else
                                    {
                                        if (best > Convert.ToDouble(goog))
                                        {
                                            best = Convert.ToDouble(goog);
                                            best_name = pri.ToString() + seg.ToString() + ter.ToString() + cua.ToString() + qui.ToString();
                                        }
                                    }
                                    //MessageBox.Show(goog);


                                }
                                Console.Write(index.ToString() + " " + pri.ToString() + seg.ToString() + ter.ToString() + cua.ToString() + qui.ToString() + " " + goog + " mejor:"+  best +" "+ best_name + Environment.NewLine);

                                sw.WriteLine(index.ToString() + " " + pri.ToString() + seg.ToString() + ter.ToString() + cua.ToString() + qui.ToString() + " " + goog + " mejor:" + best + " " + best_name);
                            }
                        }
                    }
                }

                    pri = (char)(pri + 2); //empieza por impar
                }
            
            sw.Close();
                Console.ReadKey();

        }
    }
}
