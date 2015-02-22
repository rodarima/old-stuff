using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApiTuenti;
using System.Diagnostics;

namespace TuChat2
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            toolStripNombre.Width = this.Width - 47;
            toolStripLabel1.Width = this.Width - 37;
            lista.Columns[0].Width = this.Width - 32;
        }


    }
}



        /*private void _XmppTuenti_OnPresence(string Id, string Jid, string NombreEntero, string Show, int Prioridad, string Estado, string Resource, string Presencia, int Index)
        {
            /*MethodInvoker method = delegate
            {
                textBox1.Text += Presencia + Environment.NewLine + Environment.NewLine;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            };
            textBox1.Invoke(method);
            
            if (Estado == "available")
            {

                AgregarPersonaListView(NombreEntero, Index, Resource, Id);
            }
            else
            {
                QuitarPersonaListView(NombreEntero, Resource);
            }
        }*/
        /*
        void _api_OnPresence(ListaPersonasChat.Estructura_Persona Nueva_Persona)
        {
            bool _Existe = ExistePersonaListView(Nueva_Persona);
            if (Nueva_Persona.Estado == EstadoPersona.Conectado)
            {
                if (_Existe)
                {
                    QuitarPersonaListView(Nueva_Persona);
                }
                AgregarPersonaListView(Nueva_Persona);
                Debug.WriteLine("Añadiendo " + Nueva_Persona.NombreEntero + " " + Nueva_Persona.Dispositivo.ToString());

            }
            else if (Nueva_Persona.Estado == EstadoPersona.Ausente)
            {
                if (_Existe)
                {
                    QuitarPersonaListView(Nueva_Persona);

                }
                AgregarPersonaListView(Nueva_Persona);
                Debug.WriteLine("Actualizando " + Nueva_Persona.NombreEntero + " " + Nueva_Persona.Dispositivo.ToString());
            }
            else if (Nueva_Persona.Estado == EstadoPersona.Desconectado)
            {
                if (_Existe)
                {
                    QuitarPersonaListView(Nueva_Persona);
                }
                Debug.WriteLine("Quitando " + Nueva_Persona.NombreEntero + " " + Nueva_Persona.Dispositivo.ToString());
            }
        }
        void _XmppTuenti_OnLogin(string Estado)
        {
            Debug.WriteLine("Limpiando");
            MethodInvoker method = delegate
            {
                int n = lista.Items.Count;
                for (int i = 0; i < n; i++)
                {
                    lista.Items[0].Remove();
                }

            };

            lista.Invoke(method);
            MethodInvoker method2 = delegate
            {
                toolStripNombre.Text = _api.Mis_Datos.Nombre + " " + _api.Mis_Datos.Apellidos;
                pictureBox1.ImageLocation = _api.Mis_Datos.Avatar;
                label1.Text = _api.Mis_Datos.Estado;

            };

            this.Invoke(method2);
        }
        /*private void AgregarPersonaListView(string Nombre, int Index, string Resource, string Id)
        {
            ListViewItem _Item = new ListViewItem(Nombre);
            _Item.SubItems.Add(Resource);
            _Item.SubItems.Add(Id);
            _Item.StateImageIndex = Index;
            MethodInvoker method = delegate
            {
                lista.Items.Add(_Item);
            };
            lista.Invoke(method);

        }*//*
        private void AgregarPersonaListView(ListaPersonasChat.Estructura_Persona Persona)
        {
            ListViewItem _Item = new ListViewItem(Persona.NombreEntero);
            //_Item.SubItems.Add(Persona.Resource);
            _Item.SubItems.Add(Persona.Id);
            _Item.SubItems.Add(Persona.Resource);
            _Item.StateImageIndex = Persona.IndexImage;
            MethodInvoker method = delegate
            {
                lista.Items.Add(_Item);
            };
            lista.Invoke(method);

        }
        private bool ExistePersonaListView(ListaPersonasChat.Estructura_Persona Persona)
        {
            bool _Existe = false;
            MethodInvoker method = delegate
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    ListViewItem l = lista.Items[i];
                    if (l.SubItems[1].Text == Persona.Id &&
                        l.SubItems[2].Text == Persona.Resource)
                    {
                        _Existe = true;
                    }

                }
            };
            lista.Invoke(method);
            return _Existe;
        }
        /*private void QuitarPersonaListView(string Nombre, string Resource)
        {
            MethodInvoker method = delegate
            {

                ListViewItem _Item = lista.FindItemWithText(Resource);
                lista.Items.Remove(_Item);

            };

            lista.Invoke(method);


        }*//*
        struct Dispositivos
        {
            public const string Normal = "Normal";
            public const string Webcam = "Webcam";
            public const string BlackBerry = "BlackBerry";
            public const string iPhone = "iPhone";
        }
        private void QuitarPersonaListView(ListaPersonasChat.Estructura_Persona Persona)
        {
            MethodInvoker method = delegate
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    ListViewItem l = lista.Items[i];
                    if (l.SubItems[1].Text == Persona.Id &&
                        l.SubItems[2].Text == Persona.Resource)
                    {

                        lista.Items.Remove(l);
                    }

                }
            };
            lista.Invoke(method);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxTraceListener _textBoxListener = new TextBoxTraceListener(toolStripLabel1);
            Debug.Listeners.Add(_textBoxListener);

            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            System.Reflection.PropertyInfo propiedadListView = typeof(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propiedadListView.SetValue(lista, true, null);
            lista.Columns[0].Width = this.Width - 32;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButton1.Checked == true) this.TopMost = true;
            else this.TopMost = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount)
                tabControl1.SelectedIndex++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0) tabControl1.SelectedIndex--;
        }
        //Actualizaciones a;


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*if (a == null)
            {
                a = new Actualizaciones();
                
                int x = this.Location.X + this.Width;
                int y = this.Location.Y;
                a.Location = new Point(x, y);
                a.Height = this.Height;
                a.Width = 200;
                a.Show();
            }
            else
            {
                a.Dispose();
                a = null;
            }*/
/*
        }
        public static ApiTuenti.API _api;
        /*public static void NuevoMultichat(MultiChatGrupo _multiChat, Form _form)
        {
            MultiChatLista _lista = _multiChat[0].Lista;
            string _nombreGrupo = _multiChat[0].NombreGrupo;
            for (int i = 0; i < _lista.NumeroPersonas; i++)
            {
                multichat_principal.Text;
                In
            }
            
        }*/
        /*
        private void button2_Click_1(object sender, EventArgs e)
        {
            _api = new ApiTuenti.API(temail.Text, tpass.Text);
            //_api.OnPresence += new API.XmppPresence(_XmppTuenti_OnPresence);
            _api.OnPresence += new API.XmppPresence(_api_OnPresence);
            _api.OnLogin += new API.XmppEventsString(_XmppTuenti_OnLogin);
            _api.OnFinish += new API.LoginStatesDelegate(_api_OnFinish);
            _api.OnComposing += new API.XmppComposing(_api_OnComposing);
            _api.Mensajeria.OnMensaje += new Mensajeria.MensajeRecibido(Mensajeria_OnMensaje);
        }

        private void Mensajeria_OnMensaje(agsXMPP.protocol.client.Message _Mensaje)
        {
            NombrePersona _nombre = _api.Amigos.NombrePersona(_Mensaje.From);


            multichat_principal.AppendText(_nombre.NombreAbreviado + ": " + _Mensaje.Body+Environment.NewLine);
        }


        void _api_OnComposing(string Id, string Jid, string Resource, bool Composing)
        {
            MethodInvoker method = delegate
            {

                for (int i = 0; i < lista.Items.Count; i++)
                {
                    ListViewItem lv = lista.Items[i];
                    if (lv.SubItems[1].Text == Id && lv.SubItems[2].Text == Resource)
                    {
                        if (Composing)
                        {
                            lv.StateImageIndex = 3;
                            Debug.WriteLine(lv.SubItems[2].Text + " escribiendo");
                            break;
                        }
                        else
                        {
                            int ind = _api.AmigosChat.ObtenerPersona_Id_Resource(Id, Resource).IndexImage;
                            lv.StateImageIndex = ind;
                            break;
                        }

                    }
                }

            };
            try
            {
                lista.Invoke(method);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            /*
            if ( ind != -1)
            {
                int img = lista.Items[ind].StateImageIndex;
                img = img % 4;
                MethodInvoker method = delegate
                {
                    lista.Items[ind].StateImageIndex = 4;
                };
                
            }*/
      /*  }
    
        private void _api_OnFinish(LoginStates ls)
        {
            if (ls == LoginStates.OK)
            {
                Debug.WriteLine("Login correcto, comenzando el chat");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            apisend.Text = "Token: " + _api.Mis_Datos.Token + Environment.NewLine;
            apisend.Text += "Id: " + _api.Mis_Datos.Id + Environment.NewLine;
            apisend.Text += "Server: " + _api.Mis_Datos.Servidor_Chat + Environment.NewLine;

        }

        private void apienviar_Click(object sender, EventArgs e)
        {
            apirec.Text = _api.HttpPostApi("http://api.tuenti.com/api/", apisend.Text);
        }



        private void pepeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _api.EnviarAusencia();
        }

        private void b_Multichat_Click(object sender, EventArgs e)
        {
            MultiChat m = new MultiChat();
            m.MostrarLista(_api.AmigosChat);
            m.Show();
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            _multichat = new ClaseChat();
            MultiChatLista _lista = _api.MultiChatGrupoLista[0].Lista;
            string _nombreGrupo = _api.MultiChatGrupoLista[0].NombreGrupo;
            _multichat.AgregarChat(_nombreGrupo, _lista);
            multichat_principal.Text = "Conversacion en grupo: " + _nombreGrupo;
            multichat_principal.Text += Environment.NewLine;
            multichat_principal.Text += "Participantes: ";
            multichat_principal.Text += Environment.NewLine;
            for (int i = 0; i < _lista.NumeroPersonas; i++)
            {
                //multichat_principal.Text += _lista[i].Nombre + " " + _lista[i].Apellidos;
                multichat_principal.Text += _lista[i].Nombre_Abreviado;
                multichat_principal.Text += Environment.NewLine;
                //Debug.WriteLine("Agregando " + _lista[i].Nombre_Abreviado + " al grupo \"" + _nombreGrupo + "\"");
                
            }

/*
        }

        private void multichat_enviar_Click(object sender, EventArgs e)
        {
         /*   _api.EnviarMensajeMultichat(_multichat[0].NombreGrupo, _multichat[0].Lista, multichat_mensaje.Text);
            multichat_mensaje.Text = "";
            multichat_mensaje.Focus();*//*
        }
    }


}

    */