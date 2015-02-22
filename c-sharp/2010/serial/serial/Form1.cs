using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort port = null;
        void move(char mov)
        {
            try
            {
                port.Write(new byte[] { (byte)mov }, 0, 1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /*private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }*/

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    move('0');
                    break;
                case Keys.NumPad1:
                    move('1');
                    break;
                case Keys.NumPad2:
                    move('2');
                    break;
                case Keys.NumPad3:
                    move('3');
                    break;
                case Keys.NumPad4:
                    move('4');
                    break;
                case Keys.NumPad5:
                    move('5');
                    break;
                case Keys.NumPad6:
                    move('6');
                    break;
                case Keys.NumPad7:
                    move('7');
                    break;
                case Keys.NumPad8:
                    move('8');
                    break;
                case Keys.NumPad9:
                    move('9');
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (port == null)
            {
                port = new SerialPort(
                 com.Text, 9600, Parity.None, 8, StopBits.One);
                try
                {
                    port.Open();
                    button1.Text = "Desconectar";
                    com.Enabled = false;
                    MessageBox.Show("Conexion establecida correctamente");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                if (port.IsOpen)
                {
                    port.Close();
                    button1.Text = "Conectar";
                    com.Enabled = true;
                }
                else
                {
                    port = new SerialPort(
                    com.Text, 9600, Parity.None, 8, StopBits.One);
                    button1.Text = "Conectar";
                    com.Enabled = true;
                    try { port.Open();
            button1.Text = "Desconectar";
            com.Enabled = false;
            MessageBox.Show("Conexion establecida correctamente");
            }
            catch(Exception ex){MessageBox.Show(ex.Message);}
                }
                
            }
            

            
             


        }



    }
}
