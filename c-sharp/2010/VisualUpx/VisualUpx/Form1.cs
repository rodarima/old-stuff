using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;


namespace VisualUpx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public string folder = null;

        private Assembly _assembly = Assembly.GetExecutingAssembly();

        private string GetResourceName(string resourceName)
        {
            string _name = null;
            foreach (string str in this._assembly.GetManifestResourceNames())
            {
                if (str.EndsWith(resourceName))
                {
                    _name = str;
                    break;
                }
                Console.WriteLine(str);
            }
            return _name;
        }




        public void ExtractToFile(string resourceFileName, string outFilename)
        {
            string fullName = this.GetResourceName(resourceFileName);
            if (fullName == null)
                throw new Exception(String.Format("No existe {0} en la lista de recursos", resourceFileName));

            try
            {
                Stream file = this._assembly.GetManifestResourceStream(fullName);
                FileStream outFile = new FileStream(outFilename, FileMode.Create);
                int bufferLen = 1024;
                byte[] buffer = new byte[bufferLen];
                int bytesRead;
                do
                {
                    bytesRead = file.Read(buffer, 0, bufferLen);
                    outFile.Write(buffer, 0, bytesRead);
                } while (bytesRead != 0);
                outFile.Close();
            }
            catch (Exception ex)
            {
                string msg = "Existió un error al intentar correr el compresor UPX\n{0}";
                MessageBox.Show(String.Format(msg, ex.Message));
            }
        } 

























        public string compname = null;
        public string Ratio = null;
        private void BtnUrl_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Ejecutables (.exe)|*.exe|Bibliotecas (.dll)|*.dll";

            DialogResult r = dialogo.ShowDialog();
            if (r == DialogResult.OK)
            {
                //folder = System.IO.Path.GetDirectoryName(dialogo.FileName);
                compname = System.IO.Path.GetFullPath(dialogo.FileName);
                txURL.Text = dialogo.FileName;
            }
        }

        void BarValue()
        {
            switch (trackBar1.Value)
            {
                case 0: txCompInfo.Text = "Nivel de compresión: 1" + Environment.NewLine + "Compresión ultra rápida pero menor rendimiento"; Ratio = "1"; break;
                case 1: txCompInfo.Text = "Nivel de compresión: 2" + Environment.NewLine + "Compresión ultra rápida pero menor rendimiento"; Ratio = "2"; break;
                case 2: txCompInfo.Text = "Nivel de compresión: 3" + Environment.NewLine + "Compresión ultra rápida pero menor rendimiento"; Ratio = "3"; break;
                case 3: txCompInfo.Text = "Nivel de compresión: 4" + Environment.NewLine + "Buen promedio entre rendimiento y tiempo"; Ratio = "4"; break;
                case 4: txCompInfo.Text = "Nivel de compresión: 5" + Environment.NewLine + "Buen promedio entre rendimiento y tiempo"; Ratio = "5"; break;
                case 5: txCompInfo.Text = "Nivel de compresión: 6" + Environment.NewLine + "Buen promedio entre rendimiento y tiempo"; Ratio = "6"; break;
                case 6: txCompInfo.Text = "Nivel de compresión: 7" + Environment.NewLine + "Mejor compresión pero mayor tiempo requerido"; Ratio = "7"; break;
                case 7: txCompInfo.Text = "Nivel de compresión: 8" + Environment.NewLine + "Mejor compresión pero mayor tiempo requerido"; Ratio = "8"; break;
                case 8: txCompInfo.Text = "Nivel de compresión: 9" + Environment.NewLine + "Mejor compresión pero mayor tiempo requerido"; Ratio = "9"; break;
                case 9: txCompInfo.Text = "Nivel de compresión: 10" + Environment.NewLine + "La máxima compresión posible"; Ratio = "-best"; break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            BarValue();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BarValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txURL.Text != "")
            {
                string desc = "";
                if ( cbDescomprimir.CheckState == System.Windows.Forms.CheckState.Checked)
                {
                    desc = " -d";
                }
                string force = "";
                if (cbForzar.CheckState == System.Windows.Forms.CheckState.Checked)
                {
                    force = " -f";
                }
                string upx = Application.StartupPath + @"\" + "UpxPacker.exe";

                string filename = "upx.exe";
                string outfilename = Path.Combine(Path.GetTempPath(), filename);
                ExtractToFile(filename, outfilename); 
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = outfilename;
                //p.EnableRaisingEvents = false;
                p.StartInfo.Arguments = desc + force + " -" + Ratio + " " + "\"" + compname + "\"";
                p.Start();
                p.WaitForExit();
            }
        }






    }
}
