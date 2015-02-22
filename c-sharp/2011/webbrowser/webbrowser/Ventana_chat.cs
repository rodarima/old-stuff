using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using agsXMPP;
using agsXMPP.protocol.client;
using agsXMPP.Collections;


namespace webbrowser
{
    public partial class Ventana_chat : Form
    {
        public Ventana_chat()
        {
            InitializeComponent();
        }
        string[] jid_chat;
        public delegate void UpdateTextCallback(string a);
        private void Ventana_chat_Load(object sender, EventArgs e)
        {
            tmensaje.Focus();
            jid_chat = Form1.jid_to;
            Form1.xmpp.MessageGrabber.Add(new Jid(jid_chat[0]),new BareJidComparer(), new MessageCB(MessageCallBack), null);
            Form1.xmpp.MessageGrabber.Add(new Jid(jid_chat[1]), new BareJidComparer(), new MessageCB(MessageCallBack), null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            enviar();
        }
        void enviar()
        {
            if (tmensaje.Text != "")
            {
                Form1.xmpp.Send(new agsXMPP.protocol.client.Message(new Jid(jid_chat[0]), MessageType.chat, tmensaje.Text));
                Form1.xmpp.Send(new agsXMPP.protocol.client.Message(new Jid(jid_chat[1]), MessageType.chat, tmensaje.Text));
                tChat.Text += Form1.jid.Substring(0, 8) + ": " + tmensaje.Text + Environment.NewLine;
                tmensaje.Text = "";
                tmensaje.Focus();
            }
        }
        void MessageCallBack(object sender,
                                    agsXMPP.protocol.client.Message msg,
                                    object data)
        {
            if (msg.Body != null)
            {
                if (jid_chat[0] == msg.From.User + "@" + msg.From.Server) //iphone
                {
                    Form1.xmpp.Send(new agsXMPP.protocol.client.Message(new Jid(jid_chat[1]), MessageType.chat, "Iphone: " + msg.Body));
                }
                else
                {
                    Form1.xmpp.Send(new agsXMPP.protocol.client.Message(new Jid(jid_chat[0]), MessageType.chat, "Sara: " + msg.Body));
                }
                tChat.BeginInvoke(new UpdateTextCallback(write), new object[] { msg.From.User + ": " + msg.Body + Environment.NewLine });
                
            }
        }
        void write(string text)
        {
            tChat.Text += text;
        }

        private void tmensaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && tmensaje.Text != "")
            {
                e.Handled = true;
                enviar();
            }
        }

    }
}
