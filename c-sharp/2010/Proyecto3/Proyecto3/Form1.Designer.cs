namespace Proyecto2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto2.Properties.Resources.ajax_loader3;
            this.pictureBox1.Location = new System.Drawing.Point(7, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tEmail
            // 
            this.tEmail.ForeColor = System.Drawing.Color.Gray;
            this.tEmail.Location = new System.Drawing.Point(12, 19);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(162, 20);
            this.tEmail.TabIndex = 1;
            this.tEmail.Text = "E-mail";
            this.tEmail.TextChanged += new System.EventHandler(this.tEmail_Refresh);
            this.tEmail.Click += new System.EventHandler(this.tEmail_Refresh);
            this.tEmail.LostFocus += new System.EventHandler(this.tEmail_Check);
            // 
            // tPass
            // 
            this.tPass.ForeColor = System.Drawing.Color.Gray;
            this.tPass.Location = new System.Drawing.Point(12, 39);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(162, 20);
            this.tPass.TabIndex = 2;
            this.tPass.Text = "Contraseña";
            this.tPass.TextChanged += new System.EventHandler(this.tPass_Refresh);
            this.tPass.Click += new System.EventHandler(this.tPass_Refresh);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(13, 4);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(34, 13);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 96);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tPass);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lEmail;
    }
}

