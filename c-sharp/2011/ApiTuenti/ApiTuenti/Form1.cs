using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ApiTuenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _XmppTuenti_OnPresence(string Id, string Jid, string NombreEntero, string Show, int Prioridad, string Estado, string Resource, string Presencia)
        {
            /*MethodInvoker method = delegate
            {
                textBox1.Text += Presencia + Environment.NewLine + Environment.NewLine;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            };
            textBox1.Invoke(method);*/
            int Index = 0;
            if (Show == "away") { Index += 2; }
            if (Presencia.Contains("<push")) { Index += 3; }
            if (Presencia.Contains("<mobile")) { Index += 6; }
            if (Presencia.Contains("video_chat\":true")) { Index += 3; }

            if (Estado == "available")
            {
                AgregarPersonaListView(NombreEntero, Index, Resource);
            }
            else
            {
                QuitarPersonaListView(NombreEntero, Resource);
            }
        }
        void _XmppTuenti_OnLogin(string Estado)
        {
            //if (Estado == "Disconnected")
            {
                Debug.WriteLine("Limpiando");
                MethodInvoker method = delegate
                {
                    int n = listView1.Items.Count;
                    for (int i = 0; i < n; i++)
                    {
                        listView1.Items[0].Remove();
                    }

                };

                listView1.Invoke(method);
            }
            //MessageBox.Show("Login " + Estado);
        }
        private void AgregarPersonaListView(string Nombre, int Index, string Resource)
        {
            ListViewItem _Item = new ListViewItem(Nombre);
            _Item.SubItems.Add(Resource);
            _Item.StateImageIndex = Index;
            MethodInvoker method = delegate
            {
            listView1.Items.Add(_Item);
            };
            listView1.Invoke(method);
            
        }
        void QuitarPersonaListView(string Nombre, string Resource)
        {
            MethodInvoker method = delegate
            {

                ListViewItem _Item = listView1.FindItemWithText(Resource);
                listView1.Items.Remove(_Item);

            };

            listView1.Invoke(method);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            TextBoxTraceListener _textBoxListener = new TextBoxTraceListener(textBox1);
            Debug.Listeners.Add(_textBoxListener);

            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            System.Reflection.PropertyInfo propiedadListView = typeof(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propiedadListView.SetValue(listView1, true, null);

            //agsXMPP.Jid _Jid = new agsXMPP.Jid("xxxxxxxx@xmpp1.tuenti.com");
            //_XmppConnection = new agsXMPP.XmppClientConnection(_Jid.Server);
            /*_XmppTuenti = new XmppTuenti("xxxxxxx@xmpp1.tuenti.com", "xxxxxxxxxxxxxxxxxxxxxxxxx");

            _XmppTuenti.OnLogin += new XmppTuenti.XmppEventsString(_XmppTuenti_OnLogin);
            _XmppTuenti.OnPresence += new XmppTuenti.XmppPresence(_XmppTuenti_OnPresence);
            */
            _api = new API("xxxxxxxxxxxxx@gmail.com", "xxxxxxxxx");
            _api.OnPresence += new API.XmppPresence(_XmppTuenti_OnPresence);
            _api.OnLogin += new API.XmppEventsString(_XmppTuenti_OnLogin);
        }


        
        API _api;
        

    }
   


}
