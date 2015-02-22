namespace TuChat
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.T_principal = new System.Windows.Forms.TabControl();
            this.T_chat = new System.Windows.Forms.TabPage();
            this.T_buscar = new System.Windows.Forms.TextBox();
            this.P_informacion = new System.Windows.Forms.Panel();
            this.I_opciones = new System.Windows.Forms.PictureBox();
            this.I_multichat = new System.Windows.Forms.PictureBox();
            this.L_estado = new System.Windows.Forms.Label();
            this.L_nombre = new System.Windows.Forms.Label();
            this.I_usuario = new System.Windows.Forms.PictureBox();
            this.P_login = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.C_recordar = new System.Windows.Forms.CheckBox();
            this.B_conectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.T_pass = new System.Windows.Forms.TextBox();
            this.T_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testado = new System.Windows.Forms.Label();
            this.timer_chat = new System.Windows.Forms.Timer(this.components);
            this.wb = new System.Windows.Forms.WebBrowser();
            this.timer_testado = new System.Windows.Forms.Timer(this.components);
            this.timer_lista = new System.Windows.Forms.Timer(this.components);
            this.timer_list = new System.Windows.Forms.Timer(this.components);
            this.timer_lista1 = new System.Windows.Forms.Timer(this.components);
            this.T_principal.SuspendLayout();
            this.T_chat.SuspendLayout();
            this.P_informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.I_opciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.I_multichat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.I_usuario)).BeginInit();
            this.P_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lista.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.ForeColor = System.Drawing.Color.Black;
            this.lista.FullRowSelect = true;
            this.lista.GridLines = true;
            this.lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lista.Location = new System.Drawing.Point(-4, 53);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(192, 240);
            this.lista.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lista.TabIndex = 1;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            this.lista.DoubleClick += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 175;
            // 
            // T_principal
            // 
            this.T_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.T_principal.Controls.Add(this.T_chat);
            this.T_principal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_principal.ItemSize = new System.Drawing.Size(20, 16);
            this.T_principal.Location = new System.Drawing.Point(-4, -1);
            this.T_principal.Name = "T_principal";
            this.T_principal.Padding = new System.Drawing.Point(0, 0);
            this.T_principal.SelectedIndex = 0;
            this.T_principal.Size = new System.Drawing.Size(196, 320);
            this.T_principal.TabIndex = 4;
            // 
            // T_chat
            // 
            this.T_chat.Controls.Add(this.T_buscar);
            this.T_chat.Controls.Add(this.P_informacion);
            this.T_chat.Controls.Add(this.lista);
            this.T_chat.Location = new System.Drawing.Point(4, 20);
            this.T_chat.Name = "T_chat";
            this.T_chat.Padding = new System.Windows.Forms.Padding(3);
            this.T_chat.Size = new System.Drawing.Size(188, 296);
            this.T_chat.TabIndex = 0;
            this.T_chat.Text = "Chat";
            this.T_chat.UseVisualStyleBackColor = true;
            // 
            // T_buscar
            // 
            this.T_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.T_buscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_buscar.Location = new System.Drawing.Point(2, 33);
            this.T_buscar.Name = "T_buscar";
            this.T_buscar.Size = new System.Drawing.Size(186, 20);
            this.T_buscar.TabIndex = 5;
            this.T_buscar.Text = "Buscar...";
            this.T_buscar.Visible = false;
            this.T_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_buscar_KeyPress);
            // 
            // P_informacion
            // 
            this.P_informacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.P_informacion.Controls.Add(this.I_opciones);
            this.P_informacion.Controls.Add(this.I_multichat);
            this.P_informacion.Controls.Add(this.L_estado);
            this.P_informacion.Controls.Add(this.L_nombre);
            this.P_informacion.Controls.Add(this.I_usuario);
            this.P_informacion.Location = new System.Drawing.Point(0, 0);
            this.P_informacion.Name = "P_informacion";
            this.P_informacion.Size = new System.Drawing.Size(188, 32);
            this.P_informacion.TabIndex = 4;
            // 
            // I_opciones
            // 
            this.I_opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.I_opciones.Image = ((System.Drawing.Image)(resources.GetObject("I_opciones.Image")));
            this.I_opciones.Location = new System.Drawing.Point(141, 4);
            this.I_opciones.Name = "I_opciones";
            this.I_opciones.Size = new System.Drawing.Size(24, 24);
            this.I_opciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.I_opciones.TabIndex = 6;
            this.I_opciones.TabStop = false;
            // 
            // I_multichat
            // 
            this.I_multichat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.I_multichat.Image = ((System.Drawing.Image)(resources.GetObject("I_multichat.Image")));
            this.I_multichat.Location = new System.Drawing.Point(164, 4);
            this.I_multichat.Name = "I_multichat";
            this.I_multichat.Size = new System.Drawing.Size(24, 24);
            this.I_multichat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.I_multichat.TabIndex = 5;
            this.I_multichat.TabStop = false;
            // 
            // L_estado
            // 
            this.L_estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.L_estado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_estado.ForeColor = System.Drawing.Color.Gray;
            this.L_estado.Location = new System.Drawing.Point(32, 16);
            this.L_estado.Name = "L_estado";
            this.L_estado.Size = new System.Drawing.Size(109, 15);
            this.L_estado.TabIndex = 4;
            this.L_estado.Text = "Estado";
            // 
            // L_nombre
            // 
            this.L_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.L_nombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_nombre.Location = new System.Drawing.Point(32, 2);
            this.L_nombre.Name = "L_nombre";
            this.L_nombre.Size = new System.Drawing.Size(109, 14);
            this.L_nombre.TabIndex = 3;
            this.L_nombre.Text = "Usuario";
            // 
            // I_usuario
            // 
            this.I_usuario.Image = global::TuChat.Properties.Resources.user;
            this.I_usuario.Location = new System.Drawing.Point(0, 0);
            this.I_usuario.Name = "I_usuario";
            this.I_usuario.Size = new System.Drawing.Size(32, 32);
            this.I_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.I_usuario.TabIndex = 2;
            this.I_usuario.TabStop = false;
            // 
            // P_login
            // 
            this.P_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.P_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(140)))), ((int)(((byte)(184)))));
            this.P_login.Controls.Add(this.loading);
            this.P_login.Controls.Add(this.pictureBox1);
            this.P_login.Controls.Add(this.C_recordar);
            this.P_login.Controls.Add(this.B_conectar);
            this.P_login.Controls.Add(this.label3);
            this.P_login.Controls.Add(this.T_pass);
            this.P_login.Controls.Add(this.T_usuario);
            this.P_login.Controls.Add(this.label1);
            this.P_login.Controls.Add(this.label2);
            this.P_login.Location = new System.Drawing.Point(0, -1);
            this.P_login.Name = "P_login";
            this.P_login.Size = new System.Drawing.Size(188, 320);
            this.P_login.TabIndex = 5;
            // 
            // loading
            // 
            this.loading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(86, 174);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(20, 20);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loading.TabIndex = 15;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // C_recordar
            // 
            this.C_recordar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.C_recordar.AutoSize = true;
            this.C_recordar.Checked = true;
            this.C_recordar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.C_recordar.ForeColor = System.Drawing.Color.White;
            this.C_recordar.Location = new System.Drawing.Point(99, 104);
            this.C_recordar.Name = "C_recordar";
            this.C_recordar.Size = new System.Drawing.Size(70, 17);
            this.C_recordar.TabIndex = 6;
            this.C_recordar.Text = "Recordar";
            this.C_recordar.UseVisualStyleBackColor = true;
            // 
            // B_conectar
            // 
            this.B_conectar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_conectar.Location = new System.Drawing.Point(57, 145);
            this.B_conectar.Name = "B_conectar";
            this.B_conectar.Size = new System.Drawing.Size(75, 23);
            this.B_conectar.TabIndex = 5;
            this.B_conectar.Text = "Conectar";
            this.B_conectar.UseVisualStyleBackColor = true;
            this.B_conectar.Click += new System.EventHandler(this.B_conectar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(6, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Accede al chat de tuenti con un sólo clic, y ten a todos tus contactos en línea e" +
                "stés donde estés.";
            // 
            // T_pass
            // 
            this.T_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.T_pass.Location = new System.Drawing.Point(20, 80);
            this.T_pass.Name = "T_pass";
            this.T_pass.Size = new System.Drawing.Size(147, 20);
            this.T_pass.TabIndex = 1;
            this.T_pass.UseSystemPasswordChar = true;
            this.T_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_pass_KeyPress);
            // 
            // T_usuario
            // 
            this.T_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.T_usuario.Location = new System.Drawing.Point(20, 45);
            this.T_usuario.Name = "T_usuario";
            this.T_usuario.Size = new System.Drawing.Size(147, 20);
            this.T_usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // testado
            // 
            this.testado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.testado.BackColor = System.Drawing.Color.Gold;
            this.testado.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testado.Location = new System.Drawing.Point(14, 303);
            this.testado.Name = "testado";
            this.testado.Size = new System.Drawing.Size(155, 14);
            this.testado.TabIndex = 6;
            this.testado.Visible = false;
            // 
            // timer_chat
            // 
            this.timer_chat.Tick += new System.EventHandler(this.timer_chat_Tick);
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(168, -1);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(20, 20);
            this.wb.TabIndex = 7;
            this.wb.Visible = false;
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            this.wb.GotFocus += new System.EventHandler(this.wb_GotFocus);
            // 
            // timer_testado
            // 
            this.timer_testado.Interval = 3000;
            this.timer_testado.Tick += new System.EventHandler(this.timer_testado_Tick);
            // 
            // timer_lista
            // 
            this.timer_lista.Interval = 2000;
            this.timer_lista.Tick += new System.EventHandler(this.timer_lista_Tick);
            // 
            // timer_list
            // 
            this.timer_list.Interval = 1000;
            this.timer_list.Tick += new System.EventHandler(this.timer_list_Tick);
            // 
            // timer_lista1
            // 
            this.timer_lista1.Interval = 6000;
            this.timer_lista1.Tick += new System.EventHandler(this.timer_lista1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 316);
            this.Controls.Add(this.testado);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.P_login);
            this.Controls.Add(this.T_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 350);
            this.Name = "Principal";
            this.Text = "TuChat";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.SizeChanged += new System.EventHandler(this.Principal_SizeChanged);
            this.T_principal.ResumeLayout(false);
            this.T_chat.ResumeLayout(false);
            this.T_chat.PerformLayout();
            this.P_informacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.I_opciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.I_multichat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.I_usuario)).EndInit();
            this.P_login.ResumeLayout(false);
            this.P_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.PictureBox I_usuario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabControl T_principal;
        private System.Windows.Forms.TabPage T_chat;
        private System.Windows.Forms.Panel P_informacion;
        private System.Windows.Forms.Label L_nombre;
        private System.Windows.Forms.Label L_estado;
        private System.Windows.Forms.PictureBox I_opciones;
        private System.Windows.Forms.PictureBox I_multichat;
        private System.Windows.Forms.TextBox T_buscar;
        private System.Windows.Forms.Panel P_login;
        private System.Windows.Forms.CheckBox C_recordar;
        private System.Windows.Forms.Button B_conectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox T_pass;
        private System.Windows.Forms.TextBox T_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label testado;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Timer timer_chat;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Timer timer_testado;
        private System.Windows.Forms.Timer timer_lista;
        private System.Windows.Forms.Timer timer_list;
        private System.Windows.Forms.Timer timer_lista1;

    }
}

