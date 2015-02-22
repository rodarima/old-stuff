namespace TuentiLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.wBro = new System.Windows.Forms.WebBrowser();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.pReg = new System.Windows.Forms.Panel();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Lvisitas = new System.Windows.Forms.Label();
            this.pReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wBro
            // 
            this.wBro.IsWebBrowserContextMenuEnabled = false;
            this.wBro.Location = new System.Drawing.Point(5, 325);
            this.wBro.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBro.Name = "wBro";
            this.wBro.ScrollBarsEnabled = false;
            this.wBro.Size = new System.Drawing.Size(695, 200);
            this.wBro.TabIndex = 1;
            this.wBro.Visible = false;
            this.wBro.WebBrowserShortcutsEnabled = false;
            this.wBro.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wBro_DocumentCompleted);
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(0, 0);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(135, 20);
            this.txEmail.TabIndex = 2;
            this.txEmail.Text = "Email";
            this.txEmail.TextChanged += new System.EventHandler(this.txEmail_TextChanged);
            this.txEmail.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(140, 0);
            this.txPass.Name = "txPass";
            this.txPass.Size = new System.Drawing.Size(135, 20);
            this.txPass.TabIndex = 3;
            this.txPass.Text = "Contraseña";
            this.txPass.TextChanged += new System.EventHandler(this.txPass_TextChanged_1);
            this.txPass.Click += new System.EventHandler(this.txPass_TextChanged);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(280, 0);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(30, 20);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.button2_Click);
            // 
            // pReg
            // 
            this.pReg.Controls.Add(this.txEmail);
            this.pReg.Controls.Add(this.btOk);
            this.pReg.Controls.Add(this.txPass);
            this.pReg.Location = new System.Drawing.Point(0, 0);
            this.pReg.Name = "pReg";
            this.pReg.Size = new System.Drawing.Size(310, 20);
            this.pReg.TabIndex = 5;
            // 
            // tx1
            // 
            this.tx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx1.Location = new System.Drawing.Point(5, 25);
            this.tx1.Multiline = true;
            this.tx1.Name = "tx1";
            this.tx1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tx1.Size = new System.Drawing.Size(695, 150);
            this.tx1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tx2
            // 
            this.tx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx2.Location = new System.Drawing.Point(5, 175);
            this.tx2.Multiline = true;
            this.tx2.Name = "tx2";
            this.tx2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tx2.Size = new System.Drawing.Size(695, 150);
            this.tx2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox1.Image = global::TuentiLogin.Properties.Resources.loading_bar2;
            this.pictureBox1.Location = new System.Drawing.Point(372, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 3);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(715, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lvisitas
            // 
            this.Lvisitas.AutoSize = true;
            this.Lvisitas.Location = new System.Drawing.Point(760, 508);
            this.Lvisitas.Name = "Lvisitas";
            this.Lvisitas.Size = new System.Drawing.Size(37, 13);
            this.Lvisitas.TabIndex = 10;
            this.Lvisitas.Text = "Visitas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 530);
            this.Controls.Add(this.Lvisitas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tx1);
            this.Controls.Add(this.pReg);
            this.Controls.Add(this.wBro);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pReg.ResumeLayout(false);
            this.pReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.WebBrowser wBro;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Panel pReg;
        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Lvisitas;
    }
}

