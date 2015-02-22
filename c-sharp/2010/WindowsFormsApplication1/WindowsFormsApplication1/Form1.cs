using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private BackgroundWorker backgroundWorker1;
        private XmlDocument document = null;

        public Form1()
        {
            InitializeComponent();

            // Instantiate BackgroundWorker and attach handlers to its
            // DowWork and RunWorkerCompleted events.
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            // Start the download operation in the background.
            this.backgroundWorker1.RunWorkerAsync();

            // Disable the button for the duration of the download.
            this.downloadButton.Enabled = false;

            // Once you have started the background thread you 
            // can exit the handler and the application will 
            // wait until the RunWorkerCompleted event is raised.

            // Or if you want to do something else in the main thread,
            // such as update a progress bar, you can do so in a loop 
            // while checking IsBusy to see if the background task is
            // still running.

            while (this.backgroundWorker1.IsBusy)
            {
                progressBar1.Increment(1);
                // Keep UI messages moving, so the form remains 
                // responsive during the asynchronous operation.
                Application.DoEvents();
            }
        }

        private void backgroundWorker1_DoWork(
            object sender,
            DoWorkEventArgs e)
        {
            document = new XmlDocument();

            // Uncomment the following line to
            // simulate a noticeable latency.
            //Thread.Sleep(5000);

            // Replace this file name with a valid file name.
            document.Load(@"http://www.tailspintoys.com/sample.xml");
        }

        private void backgroundWorker1_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            // Set progress bar to 100% in case it's not already there.
            progressBar1.Value = 100;

            if (e.Error == null)
            {
                MessageBox.Show(document.InnerXml, "Download Complete");
            }
            else
            {
                MessageBox.Show(
                    "Failed to download file",
                    "Download failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Enable the download button and reset the progress bar.
            this.downloadButton.Enabled = true;
            progressBar1.Value = 0;
        }
    }
}
