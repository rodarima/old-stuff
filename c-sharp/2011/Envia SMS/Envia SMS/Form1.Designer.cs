namespace Envia_SMS
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
            this.cuerpo = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.wBro = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cuerpo
            // 
            this.cuerpo.Location = new System.Drawing.Point(19, 38);
            this.cuerpo.Multiline = true;
            this.cuerpo.Name = "cuerpo";
            this.cuerpo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cuerpo.Size = new System.Drawing.Size(298, 417);
            this.cuerpo.TabIndex = 0;
            this.cuerpo.Text = "12345";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(41, 12);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(195, 20);
            this.number.TabIndex = 1;
            this.number.Text = "xxxxxxxxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(242, 9);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 3;
            this.send.Text = "Enviar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // wBro
            // 
            this.wBro.Location = new System.Drawing.Point(329, 13);
            this.wBro.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBro.Name = "wBro";
            this.wBro.Size = new System.Drawing.Size(549, 454);
            this.wBro.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 479);
            this.Controls.Add(this.wBro);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.cuerpo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cuerpo;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.WebBrowser wBro;

    }
}

