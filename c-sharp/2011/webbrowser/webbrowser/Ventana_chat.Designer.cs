namespace webbrowser
{
    partial class Ventana_chat
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
            this.tChat = new System.Windows.Forms.TextBox();
            this.tmensaje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tChat
            // 
            this.tChat.Location = new System.Drawing.Point(12, 12);
            this.tChat.Multiline = true;
            this.tChat.Name = "tChat";
            this.tChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tChat.Size = new System.Drawing.Size(264, 214);
            this.tChat.TabIndex = 1;
            // 
            // tmensaje
            // 
            this.tmensaje.Location = new System.Drawing.Point(12, 234);
            this.tmensaje.Name = "tmensaje";
            this.tmensaje.Size = new System.Drawing.Size(186, 20);
            this.tmensaje.TabIndex = 0;
            this.tmensaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tmensaje_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ventana_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tmensaje);
            this.Controls.Add(this.tChat);
            this.Name = "Ventana_chat";
            this.Text = "Ventana_chat";
            this.Load += new System.EventHandler(this.Ventana_chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tChat;
        private System.Windows.Forms.TextBox tmensaje;
        private System.Windows.Forms.Button button1;
    }
}