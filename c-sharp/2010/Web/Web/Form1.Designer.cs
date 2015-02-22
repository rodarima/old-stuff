namespace Web
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.button1 = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(0, 20);
            this.debug.Multiline = true;
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(240, 245);
            this.debug.TabIndex = 1;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(0, 0);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(215, 21);
            this.n.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.n);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.button1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox debug;
        private System.Windows.Forms.TextBox n;
    }
}

