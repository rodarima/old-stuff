namespace Roulette
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
            this.max = new System.Windows.Forms.NumericUpDown();
            this.apostar = new System.Windows.Forms.TextBox();
            this.tiradas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.presupuesto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.m = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(182, 29);
            this.max.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(50, 20);
            this.max.TabIndex = 1;
            this.max.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // apostar
            // 
            this.apostar.Location = new System.Drawing.Point(339, 29);
            this.apostar.Name = "apostar";
            this.apostar.Size = new System.Drawing.Size(63, 20);
            this.apostar.TabIndex = 2;
            // 
            // tiradas
            // 
            this.tiradas.Location = new System.Drawing.Point(257, 29);
            this.tiradas.Name = "tiradas";
            this.tiradas.Size = new System.Drawing.Size(46, 20);
            this.tiradas.TabIndex = 3;
            this.tiradas.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apuesta Máx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doblajes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apostar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Presupuesto";
            // 
            // presupuesto
            // 
            this.presupuesto.Location = new System.Drawing.Point(23, 29);
            this.presupuesto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.presupuesto.Name = "presupuesto";
            this.presupuesto.Size = new System.Drawing.Size(50, 20);
            this.presupuesto.TabIndex = 9;
            this.presupuesto.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apuesta Mín";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(113, 29);
            this.min.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(50, 20);
            this.min.TabIndex = 10;
            this.min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Checked = true;
            this.m.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m.Location = new System.Drawing.Point(23, 71);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(97, 17);
            this.m.TabIndex = 12;
            this.m.Text = "Método seguro";
            this.m.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 110);
            this.Controls.Add(this.m);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.min);
            this.Controls.Add(this.presupuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiradas);
            this.Controls.Add(this.apostar);
            this.Controls.Add(this.max);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown max;
        private System.Windows.Forms.TextBox apostar;
        private System.Windows.Forms.NumericUpDown tiradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown presupuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.CheckBox m;
    }
}

