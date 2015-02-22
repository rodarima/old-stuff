using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TuChat2
{
    public partial class MultiChat : Form
    {
        public MultiChat()
        {
            InitializeComponent();
        }
        //ApiTuenti.ListaPersonasChat _listachat;
//        public void MostrarLista(ApiTuenti.ListaPersonasChat Lista)
//        {
//            _listachat = new ApiTuenti.ListaPersonasChat();
//            for (int i = 0; i < Lista.Personas_Actuales; i++)
//            {
                
//                ListViewItem l = new ListViewItem(Lista[i].NombreEntero);
//                l.SubItems.Add(Lista[i].Id);
                
//                l.SubItems.Add(Lista[i].Jid);
//                int a = lista_entera.Items.Count;
//                bool Existe = false; ;
//                for (int j = 0; j < lista_entera.Items.Count; j++)
//                {
//                    Existe = (lista_entera.Items[j].Text == Lista[i].NombreEntero);
//                    if (Existe) break;
//                }
//                if (!Existe)
//                {
//                    lista_entera.Items.Add(l);
//                    _listachat.AgregarPersona(Lista[i]);
//                }
//                else { }
//            }
//        }
//        private void t_buscar_KeyPress(object sender, KeyPressEventArgs e)
//        {
            
//            if (e.KeyChar == (char)Keys.Enter && t_buscar.Text != "")
//            {
//                borrar = true;
//                e.Handled = true;
//                buscar();
//            }

//        }
//        private void buscar()
//        {
//            if ((t_buscar.Text != "Buscar..." || t_buscar.Text != ""))
//            {
//                borrar = false;
//                //ApiTuenti.ListaPersonasChat _listabuscar = new ApiTuenti.ListaPersonasChat();
//                int items = lista_entera.Items.Count;
//                for (int i = 0; i < items; i++)
//                {
//                    lista_entera.Items.Remove(lista_entera.Items[0]);
//                }
//                borrar = true;
//                for (int i = 0; i < _listachat.Personas_Actuales; i++)
//                {
//                    if (_listachat[i].NombreEntero.ToLower().Contains(t_buscar.Text.ToLower()) ||
//                        _listachat[i].Id.Contains(t_buscar.Text))
//                    {
//                        ListViewItem l = new ListViewItem(_listachat[i].NombreEntero);
//                        l.SubItems.Add(_listachat[i].Id);
//                        l.SubItems.Add(_listachat[i].Jid);
//                        lista_entera.Items.Add(l);
                        
//                    }
//                }
//            }

//        }
//        private bool borrar = false;
//        private void t_buscar_TextChanged(object sender, EventArgs e)
//        {
//            if (t_buscar.Text == "" && borrar)
//            {
//                int items = lista_entera.Items.Count;
//                for (int i = 0; i < items; i++)
//                {
//                    lista_entera.Items.Remove(lista_entera.Items[0]);
//                }
//                for (int i = 0; i < _listachat.Personas_Actuales; i++)
//                {
//                    ListViewItem l = new ListViewItem(_listachat[i].NombreEntero);
//                    l.SubItems.Add(_listachat[i].Id);
//                    l.SubItems.Add(_listachat[i].Jid);
//                    lista_entera.Items.Add(l);
//                }
//                borrar = false;
//            }
//        }
//        private void t_buscar_Click(object sender, EventArgs e)
//        {
//            if (t_buscar.Text == "Buscar...")
//            {
//                borrar = false;
//                t_buscar.Text = "";
//            }
//        }
//        private void t_buscar_LostFocus(object sender, EventArgs e)
//        {
//            if (t_buscar.Text == "")
//            {
//                t_buscar.Text = "Buscar...";
//            }
//        }
//        private void MultiChat_Load(object sender, EventArgs e)
//        {
//            System.Reflection.PropertyInfo propiedadListView = typeof(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
//            propiedadListView.SetValue(lista_entera, true, null);
//        }

//        private void t_nombre_grupo_Click(object sender, EventArgs e)
//        {
//            if (t_nombre_grupo.Text == "Nombre del grupo...")
//            {
//                t_nombre_grupo.Text = "";
//            }
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//           /* int n = lista_entera.CheckedItems.Count;
//            string _nombregrupo;
//            if (t_nombre_grupo.Text == "Nombre del grupo...")
//            {
//                _nombregrupo = "Grupo sin nombre";
//            }
//            else
//            {
//                _nombregrupo = t_nombre_grupo.Text;
//            }
//            for (int i = 0; i < n; i++)
//            {
//                ListViewItem l = lista_entera.CheckedItems[i];
//                ApiTuenti.MultiChatLista.Estructura_MultiChatPersona p = _multichatlista.CrearPersona(l.SubItems[1].Text, l.SubItems[2].Text, l.Text);
//                _multichatlista.AgregarPersona(p);

//                Debug.WriteLine("Agregando " + p.Nombre_Abreviado + " al grupo \"" + _nombregrupo + "\"");
//            }
//            Principal._api.AgregarMultichat(_nombregrupo, _multichatlista);
//            this.Close();
//            this.Dispose();*/
            



///*
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            int _count = lista_entera.Items.Count;
//            for (int i = 0; i < _count; i++)
//            {
//                lista_entera.Items[i].Checked = true;
//            }
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            int _count = lista_entera.Items.Count;
//            for (int i = 0; i < _count; i++)
//            {
//                lista_entera.Items[i].Checked = false;
//            }
//        }
    }
}
