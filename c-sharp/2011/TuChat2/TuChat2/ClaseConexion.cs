using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace ApiTuenti
{
    public class Conexion
    {
        public class ConexionDetalles
        {
            public string Email { get; set; }
            public string Pass { get; set; }
            public string Token { get; set; }
            public string Id { get; set; }

        }
        public Persona MiPersona { get; set; }
        public ConexionDetalles Detalles { get; set; }

        
        private HttpWebRequest WebReq;
        private HttpWebResponse WebResp;
        public void Obtener_Token_Id(string email, string pass)
        {
            Debug.WriteLine("Obteniendo token de: " + email);
            API.Estado = ConexionEstado.Cargando;
            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes("tuentiemail=" + email + "&password=" + pass + "&remember=1");

                WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=Login&func=process_login");
                WebReq.Method = "POST";
                WebReq.AllowAutoRedirect = false;
                Cookie cookiename = new Cookie();
                cookiename.Name = "cookiename";
                cookiename.Value = "1";
                cookiename.Path = "/";
                cookiename.Domain = "m.tuenti.com";
                CookieContainer cc = new CookieContainer();
                cc.Add(cookiename);
                WebReq.CookieContainer = cc;
                WebReq.ContentType = "application/x-www-form-urlencoded";
                WebReq.KeepAlive = true;
                WebReq.ContentLength = buffer.Length;

                Stream PostData = WebReq.GetRequestStream();
                //Now we write, and afterwards, we close. Closing is always important!
                PostData.Write(buffer, 0, buffer.Length);
                PostData.Close();
                //Get the response handle, we have no true response yet!
                WebResp = (HttpWebResponse)WebReq.GetResponse();

                CookieCollection co = new CookieCollection();
                WebResp.Cookies = co;
                //Let's show some information about the response
                //MessageBox.Show(WebResp.StatusCode.ToString());
                //MessageBox.Show(WebResp.Server);

                //Now, we read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();
                string Galleta = WebResp.GetResponseHeader("Set-Cookie");
                Detalles.Token = Regex.Match(Galleta, @"mid=(?<mid>(\w|\d|-|_)*);").Groups["mid"].Value;
                if (Detalles.Token == "")
                {
                API.Estado = ConexionEstado.Incorrecto;
                    Debug.WriteLine("El email o contraseña es incorrecto.");
                    return;
                    //System.Windows.Forms.MessageBox.Show("El email o contraseña es incorrecto.");
                }
                else if (Detalles.Token.Length == 43)
                {
                    Debug.WriteLine("Token ok: " + Detalles.Token);
                    API.Estado = ConexionEstado.Correcto;
                }

                //Regex r = new Regex(@"tuentiemail=(\S)* expires=(?<expires1>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com,mid=(?<mid>(\w|\d|-|_)*); path=/; domain=.tuenti.com,mid=(\w|\d|-|_)*; path=/; domain=.tuenti.com,lang=(?<lang>(\w|_))*; expires=(?<expires2>(\w)+, (\S)* (\S)* (\w)*); path=/; domain=.tuenti.com");
                CookieContainer myCookieContiner = new CookieContainer();
                Cookie cok = new Cookie();
                cok.Name = "tuentiemail";
                cok.Value = email;
                cok.Domain = ".tuenti.com";
                cok.Expires = DateTime.Now.AddYears(1).AddDays(-1);
                cok.Path = "/";
                myCookieContiner.Add(cok);
                cok.Name = "mid";
                cok.Value = Regex.Match(Galleta, @"mid=(?<mid>(\w|\d|-|_)*);").Groups["mid"].Value;
                cok.Path = "/";
                cok.Domain = ".tuenti.com";
                myCookieContiner.Add(cok);
                cok.Name = "lang";
                cok.Value = Regex.Match(Galleta, @"lang=(?<lang>(\S)*); ").Groups["lang"].Value;
                cok.Expires = DateTime.Now.AddYears(1).AddDays(-6);
                cok.Path = "/";
                cok.Domain = ".tuenti.com";
                myCookieContiner.Add(cok);


                WebReq = (HttpWebRequest)WebRequest.Create("http://m.tuenti.com/?m=local&func=index");
                WebReq.CookieContainer = myCookieContiner;
                WebReq.ContentType = "application/x-www-form-urlencoded";
                WebReq.Referer = "http://m.tuenti.com/";
                WebReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                WebReq.AllowAutoRedirect = false;
                //WebReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";

                //Get the response handle, we have no true response yet!
                WebResp = (HttpWebResponse)WebReq.GetResponse();
                //MessageBox.Show(WebResp.GetResponseHeader("Location"));

                //MessageBox.Show(WebResp.StatusCode.ToString());
                //MessageBox.Show(WebResp.Server);

                Answer = WebResp.GetResponseStream();
                StreamReader _Answer = new StreamReader(Answer);
                string code = _Answer.ReadToEnd();
                string user = Regex.Match(code, @"Profile&amp;func=view_wall&amp;user_id=(?<Id>\d{8})""   id").Groups["Id"].Value;
                Detalles.Id = user;
                Debug.WriteLine("Usuario: " + Detalles.Id);
                _Answer.Close();
                Answer.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                API.Estado = ConexionEstado.Error;
            }
        }
        public PersonaLista Obtener_Amigos()
        {

            Debug.WriteLine("Obteniendo mis datos");
            string MisDatos = HttpPostApi("http://api.tuenti.com/api/", "{\"session_id\":\"" + Detalles.Token + "\",\"version\":\"0.7\",\"requests\":[[\"getUsersData\",{\"ids\":[\"" + Detalles.Id + "\"],\"fields\":[\"name\",\"surname\",\"avatar\",\"sex\",\"status\",\"phone_number\",\"chat_server\"]}]]}");
            
            
            System.Text.RegularExpressions.Match MisDatosRegex = System.Text.RegularExpressions.Regex.Match(MisDatos,
                @"\A\[\{""users"":\[\{""id"":(?<ID>\d*),""name"":""(?<NAME>((\w| |\\)+))"",""surname"":""(?<SURNAME>((\w| |\\)+))"",""avatar"":\{""url"":""(?<AVATAR>(\S|\\)*)"",""x"":\d*,""y"":\d*,""photo_key"":""(?<PHOTO_KEY>(\d|_)+)""},""sex"":(?<SEX>\d),""status"":(\[(?<STATUS>(.*))\]|null),""phone_number"":(""(?<PHONE_NUMBER>(\d|\+)*)""|null),""chat_server"":""(?<CHAT_SERVER>(\w|\.)+)""\}\]\}");
            
            string DataEstado = MisDatosRegex.Groups["STATUS"].Value;
            MatchCollection EstadoRegex = Regex.Matches(DataEstado, @"\{""type"":""(\w+)"",""\w+"":""(?<ESTADO>(\w| |\\)+)""(,""\w+"":(\w| |\\|"")+)*\}");
            foreach (Match EstadoCortes in EstadoRegex)
            {
                MiPersona.Informacion.Estado += Latin1ToASCII(EstadoCortes.Groups["ESTADO"].Value);
            }

            MiPersona.Informacion.Estado = "";
            MiPersona.Nombre.Nombre = Latin1ToASCII(MisDatosRegex.Groups["NAME"].Value);
            MiPersona.Nombre.Apellidos = Latin1ToASCII(MisDatosRegex.Groups["SURNAME"].Value);
            MiPersona.Informacion.Avatar = MisDatosRegex.Groups["AVATAR"].Value.Replace("\\", "");
            MiPersona.Informacion.Sexo = MisDatosRegex.Groups["SEX"].Value;
            MiPersona.Informacion.Telefono = MisDatosRegex.Groups["PHONE_NUMBER"].Value;
            MiPersona.Jid.User = MisDatosRegex.Groups["ID"].Value;
            MiPersona.Jid.Server = MisDatosRegex.Groups["CHAT_SERVER"].Value;

            Debug.WriteLine("Datos personales obtenidos. " + MiPersona.Nombre.NombreEntero);
            
            MisDatos = HttpPostApi("http://api.tuenti.com/api/", "{\"session_id\":\"" + Detalles.Token + "\",\"version\":\"0.7\",\"requests\":[[\"getFriendsData\"]]}");

            MatchCollection Matches = Regex.Matches(MisDatos, @"{""id"":(?<ID>\d*),""name"":""(?<NAME>(\S| )+?)"",""surname"":""(?<SURNAME>(\S| )+?)"",""sex"":(?<SEX>\d)(,""phone_number"":(?<PHONE_NUMBER>\S+?)|),""avatar"":\[(""(?<AVATAR>\S+?)""|null),(-|\d)+,(-|\d)+],""chat_server"":""(?<CHAT_SERVER>\S+?)""}");

            Debug.WriteLine("Obtenidos " + Matches.Count + " amigos");

            PersonaLista Lista = new PersonaLista();
            for (int i = 0; i < Matches.Count; i++)
            {
                try{
                string ID = Matches[i].Groups["ID"].Value;
                string CHAT_SERVER = Matches[i].Groups["CHAT_SERVER"].Value;
                string NAME = Matches[i].Groups["NAME"].Value;
                string SURNAME = Matches[i].Groups["SURNAME"].Value;
                string SEX = Matches[i].Groups["SEX"].Value;
                string PHONE_NUMBER = Matches[i].Groups["PHONE_NUMBER"].Value;
                string AVATAR = Matches[i].Groups["AVATAR"].Value;
                AVATAR = AVATAR.Replace("\\", "");

                if (AVATAR == "") AVATAR = null;
                NAME = Latin1ToASCII(NAME);
                SURNAME = Latin1ToASCII(SURNAME);

                Persona NuevoAmigo = new Persona(new agsXMPP.Jid(ID,CHAT_SERVER,null), new Persona.NombrePersona(NAME,SURNAME));
                NuevoAmigo.Informacion.Sexo = SEX;
                NuevoAmigo.Informacion.Telefono = PHONE_NUMBER;
                NuevoAmigo.Informacion.Avatar = AVATAR;
                
                Lista.Agregar(NuevoAmigo);
                }catch(Exception ex)
                {
                    Debug.WriteLine("Error al almacenar usuario " +i.ToString() + " " + ex.Message);
                    API.Estado = ConexionEstado.Error;
                }
            }
            if (Lista.Count != Matches.Count)
            {
                API.Estado = ConexionEstado.Error;
                Debug.WriteLine("Error al almacenar");
            }
            else { Debug.WriteLine(Lista.Count + " Amigos almacenados con exito"); }
            return Lista;
        }

        public string HttpPostApi(string uri, string parameters)
        {
            // parameters: name1=value1&name2=value2 

            WebReq = (HttpWebRequest)WebRequest.Create(uri);
            WebReq.Method = "POST";
            WebReq.ContentType = "application/x-www-form-urlencoded";

            //WebReq.UserAgent = "Tuenti/2.3 CFNetwork/485.12.7 Darwin/10.4.0";
            //WebReq.Accept = "*/*";
            //WebReq.KeepAlive = true;
            //WebReq.ContentLength = 651;
            WebReq.Host = "api.tuenti.com";

            parameters = ASCIIToLatin1(parameters);
            byte[] bytes = Encoding.ASCII.GetBytes(parameters);
            Stream os = null;
            try
            {
                WebReq.ContentLength = bytes.Length;   //Count bytes to send
                os = WebReq.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);         //Send it
            }
            catch (WebException ex)
            {

            }
            finally
            {
                if (os != null)
                {
                    os.Close();
                }
            }

            try
            {
                WebResponse WebRes = (HttpWebResponse)WebReq.GetResponse();

                if (WebRes == null)
                {
                    return null;
                }
                Encoding encode = System.Text.Encoding.ASCII;
                StreamReader sr = new StreamReader(WebRes.GetResponseStream(), encode);
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {

            }
            return null;
        }
        public string Latin1ToASCII(string str)
        {

            MatchCollection m = Regex.Matches(str, @"\\(u|U)00(?<hex>(\w){2})");
            for (int i = 0; i < m.Count; i++)
            {
                string s1 = m[i].Groups["hex"].Value;
                int n = Convert.ToInt32(s1, 16);
                str = Regex.Replace(str, @"\\(u|U)00(?<hex>(\w){2})", ((char)(n)).ToString());

            }
            return str;
        }
        public string ASCIIToLatin1(string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] > 127)
                {
                    string hex = ((int)str[i]).ToString("x");
                    hex = "\\u00" + hex;
                    res += hex;
                }
                else
                {
                    res += str[i].ToString();
                }
            }
            return res;
        }
    }
    
}

