using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace ApiTuenti
{
    public class TextBoxTraceListener : TraceListener
    {
        private ToolStripLabel _target;
        private ToolStripLabel _tool;
        private StringSendDelegate _invokeWrite;

        public TextBoxTraceListener(ToolStripLabel target)
        {
            _target = target;
            _invokeWrite = new StringSendDelegate(SendStringTool);
        }
        public override void Write(string message)
        {
            _target.Text=message;
        }

        public override void WriteLine(string message)
        {
            _target.Text = DateTime.Now.ToLongTimeString() + "," + DateTime.Now.Millisecond.ToString("000") + ": " + message ;
        }

        private delegate void StringSendDelegate(string message);
        private void SendStringTextBox(string message)
        {
            // No need to lock text box as this function will only 

            // ever be executed from the UI thread

            _target.Text += message;

        }
        private void SendStringTool(string message)
        {
            // No need to lock text box as this function will only 

            // ever be executed from the UI thread

            _target.Text = message;

        }
    }
}
