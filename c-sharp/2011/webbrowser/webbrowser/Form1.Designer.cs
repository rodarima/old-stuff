namespace webbrowser
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
            this.pReg = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.txPass = new System.Windows.Forms.TextBox();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.testado = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_chat = new System.Windows.Forms.Timer(this.components);
            this.list = new System.Windows.Forms.ListView();
            this.col_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_com = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pChat = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pReg
            // 
            this.pReg.Controls.Add(this.loading);
            this.pReg.Controls.Add(this.checkBox1);
            this.pReg.Controls.Add(this.txEmail);
            this.pReg.Controls.Add(this.btOk);
            this.pReg.Controls.Add(this.txPass);
            this.pReg.Location = new System.Drawing.Point(31, 52);
            this.pReg.Name = "pReg";
            this.pReg.Size = new System.Drawing.Size(187, 181);
            this.pReg.TabIndex = 6;
            // 
            // loading
            // 
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(160, 44);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(20, 20);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loading.TabIndex = 14;
            this.loading.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(5, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Recordar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(4, 4);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(178, 20);
            this.txEmail.TabIndex = 2;
            this.txEmail.Text = "xxxxxxxxxx@gmail.com";
            // 
            // btOk
            // 
            this.btOk.Enabled = false;
            this.btOk.Location = new System.Drawing.Point(49, 68);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(83, 27);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Iniciar sesión";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(4, 24);
            this.txPass.Name = "txPass";
            this.txPass.Size = new System.Drawing.Size(178, 20);
            this.txPass.TabIndex = 3;
            this.txPass.Text = "xxxxxxxx";
            this.txPass.UseSystemPasswordChar = true;
            this.txPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPass_KeyPress);
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(8, 317);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(189, 39);
            this.wb.TabIndex = 0;
            this.wb.Url = new System.Uri("", System.UriKind.Relative);
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(253, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // testado
            // 
            this.testado.Name = "testado";
            this.testado.Size = new System.Drawing.Size(22, 17);
            this.testado.Text = "     ";
            this.testado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer_chat
            // 
            this.timer_chat.Tick += new System.EventHandler(this.timer_chat_Tick);
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_title,
            this.col_com});
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(229, 298);
            this.list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list.TabIndex = 11;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.DoubleClick += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // col_title
            // 
            this.col_title.Text = "user";
            this.col_title.Width = 100;
            // 
            // col_com
            // 
            this.col_com.Text = "jid";
            this.col_com.Width = 303;
            // 
            // pChat
            // 
            this.pChat.Controls.Add(this.list);
            this.pChat.Location = new System.Drawing.Point(12, 7);
            this.pChat.Name = "pChat";
            this.pChat.Size = new System.Drawing.Size(229, 298);
            this.pChat.TabIndex = 12;
            this.pChat.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Multichat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.pReg);
            this.Controls.Add(this.pChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TuChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pReg.ResumeLayout(false);
            this.pReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pChat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pReg;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel testado;
        private System.Windows.Forms.Timer timer_chat;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader col_title;
        private System.Windows.Forms.ColumnHeader col_com;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Panel pChat;
        private System.Windows.Forms.Button button1;
    }
}

