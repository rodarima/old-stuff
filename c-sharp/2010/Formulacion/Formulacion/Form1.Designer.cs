namespace Formulacion
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
            this.TxForm = new System.Windows.Forms.TextBox();
            this.TxNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxForm
            // 
            this.TxForm.Location = new System.Drawing.Point(5, 5);
            this.TxForm.Name = "TxForm";
            this.TxForm.Size = new System.Drawing.Size(215, 20);
            this.TxForm.TabIndex = 0;
            // 
            // TxNome
            // 
            this.TxNome.Location = new System.Drawing.Point(5, 30);
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(215, 20);
            this.TxNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxNome);
            this.Controls.Add(this.TxForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxForm;
        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.Button button1;
    }
}

