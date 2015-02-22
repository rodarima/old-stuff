namespace Algoritmo_grafica
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
            this.p = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(12, 12);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(800, 400);
            this.p.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Comenzar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(88, 420);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(78, 20);
            this.d.TabIndex = 2;
            this.d.Text = "10";
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(282, 421);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(29, 20);
            this.f.TabIndex = 3;
            this.f.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dinero inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apostar despues de:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Parar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tie
            // 
            this.tie.Location = new System.Drawing.Point(380, 420);
            this.tie.Name = "tie";
            this.tie.Size = new System.Drawing.Size(47, 20);
            this.tie.TabIndex = 9;
            this.tie.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Relentizar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Guardar tras:";
            // 
            // l
            // 
            this.l.Location = new System.Drawing.Point(507, 420);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(47, 20);
            this.l.TabIndex = 11;
            this.l.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox l;
    }
}

