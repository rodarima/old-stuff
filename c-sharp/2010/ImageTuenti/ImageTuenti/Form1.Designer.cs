namespace ImageTuenti
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pLoad = new System.Windows.Forms.PictureBox();
            this.pTuenti = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTuenti)).BeginInit();
            this.SuspendLayout();
            // 
            // tUrl
            // 
            this.tUrl.AllowDrop = true;
            this.tUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUrl.Location = new System.Drawing.Point(10, 5);
            this.tUrl.Name = "tUrl";
            this.tUrl.Size = new System.Drawing.Size(315, 18);
            this.tUrl.TabIndex = 0;
            this.tUrl.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(330, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zoom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(383, 147);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pLoad);
            this.panel1.Controls.Add(this.tUrl);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 45);
            this.panel1.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(248, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Automático";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(328, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Visible";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pLoad
            // 
            this.pLoad.Image = global::ZoomIt.Properties.Resources.ajax_loader;
            this.pLoad.Location = new System.Drawing.Point(10, 25);
            this.pLoad.Name = "pLoad";
            this.pLoad.Size = new System.Drawing.Size(220, 19);
            this.pLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pLoad.TabIndex = 5;
            this.pLoad.TabStop = false;
            this.pLoad.Visible = false;
            // 
            // pTuenti
            // 
            this.pTuenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pTuenti.BackColor = System.Drawing.Color.White;
            this.pTuenti.Image = global::ZoomIt.Properties.Resources.imagetuenti;
            this.pTuenti.Location = new System.Drawing.Point(0, 0);
            this.pTuenti.Name = "pTuenti";
            this.pTuenti.Size = new System.Drawing.Size(385, 147);
            this.pTuenti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pTuenti.TabIndex = 3;
            this.pTuenti.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 192);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pTuenti);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZoomIt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTuenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pTuenti;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

