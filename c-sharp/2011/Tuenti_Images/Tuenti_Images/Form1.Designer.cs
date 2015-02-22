namespace Tuenti_Images
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
            this.temail = new System.Windows.Forms.TextBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.blogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // temail
            // 
            this.temail.Location = new System.Drawing.Point(12, 12);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(122, 20);
            this.temail.TabIndex = 0;
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(140, 12);
            this.tpass.Name = "tpass";
            this.tpass.PasswordChar = '*';
            this.tpass.Size = new System.Drawing.Size(78, 20);
            this.tpass.TabIndex = 1;
            // 
            // blogin
            // 
            this.blogin.Location = new System.Drawing.Point(224, 10);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(75, 23);
            this.blogin.TabIndex = 2;
            this.blogin.Text = "button1";
            this.blogin.UseVisualStyleBackColor = true;
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.blogin);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.temail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Button blogin;
    }
}

