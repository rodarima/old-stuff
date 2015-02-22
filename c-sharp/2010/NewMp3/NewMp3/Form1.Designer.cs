namespace NewMp3
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
            this.BtnSound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSound)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSound
            // 
            this.BtnSound.BackgroundImage = global::NewMp3.Properties.Resources.Mute;
            this.BtnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSound.Location = new System.Drawing.Point(20, 20);
            this.BtnSound.Name = "BtnSound";
            this.BtnSound.Size = new System.Drawing.Size(30, 30);
            this.BtnSound.TabIndex = 1;
            this.BtnSound.TabStop = false;
            this.BtnSound.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 74);
            this.Controls.Add(this.BtnSound);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BtnSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnSound;
    }
}

