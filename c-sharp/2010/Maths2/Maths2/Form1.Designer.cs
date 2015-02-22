namespace Maths2
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
            this.text_z = new System.Windows.Forms.TextBox();
            this.text_x = new System.Windows.Forms.Label();
            this.text_y = new System.Windows.Forms.Label();
            this.text_op = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_z
            // 
            this.text_z.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_z.Location = new System.Drawing.Point(240, 11);
            this.text_z.Name = "text_z";
            this.text_z.Size = new System.Drawing.Size(105, 44);
            this.text_z.TabIndex = 0;
            this.text_z.Text = "12";
            this.text_z.TextChanged += new System.EventHandler(this.z_TextChanged);
            // 
            // text_x
            // 
            this.text_x.AutoSize = true;
            this.text_x.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_x.Location = new System.Drawing.Point(10, 15);
            this.text_x.Name = "text_x";
            this.text_x.Size = new System.Drawing.Size(83, 37);
            this.text_x.TabIndex = 1;
            this.text_x.Text = "102";
            // 
            // text_y
            // 
            this.text_y.AutoSize = true;
            this.text_y.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_y.Location = new System.Drawing.Point(125, 15);
            this.text_y.Name = "text_y";
            this.text_y.Size = new System.Drawing.Size(83, 37);
            this.text_y.TabIndex = 1;
            this.text_y.Text = "105";
            // 
            // text_op
            // 
            this.text_op.AutoSize = true;
            this.text_op.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_op.Location = new System.Drawing.Point(85, 15);
            this.text_op.Name = "text_op";
            this.text_op.Size = new System.Drawing.Size(39, 37);
            this.text_op.TabIndex = 2;
            this.text_op.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 325);
            this.Controls.Add(this.text_op);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.text_x);
            this.Controls.Add(this.text_z);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_z;
        private System.Windows.Forms.Label text_x;
        private System.Windows.Forms.Label text_y;
        private System.Windows.Forms.Label text_op;
        private System.Windows.Forms.Label label1;
    }
}

