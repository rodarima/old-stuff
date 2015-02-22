namespace WindowsFormsApplication1
{
    partial class Calc
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
            this.TxtX = new System.Windows.Forms.TextBox();
            this.TxtY = new System.Windows.Forms.TextBox();
            this.TxtZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Topbox = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtX
            // 
            this.TxtX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtX.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtX.Location = new System.Drawing.Point(45, 24);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(103, 21);
            this.TxtX.TabIndex = 1;
            this.TxtX.Text = "0";
            this.TxtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtX.TextChanged += new System.EventHandler(this.TxtX_TextChanged);
            // 
            // TxtY
            // 
            this.TxtY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtY.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtY.Location = new System.Drawing.Point(45, 45);
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(103, 21);
            this.TxtY.TabIndex = 2;
            this.TxtY.Text = "0";
            this.TxtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtY.TextChanged += new System.EventHandler(this.TxtY_TextChanged);
            // 
            // TxtZ
            // 
            this.TxtZ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtZ.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtZ.Location = new System.Drawing.Point(2, 71);
            this.TxtZ.Name = "TxtZ";
            this.TxtZ.ReadOnly = true;
            this.TxtZ.Size = new System.Drawing.Size(160, 21);
            this.TxtZ.TabIndex = 3;
            this.TxtZ.Text = "0";
            this.TxtZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtZ.TextChanged += new System.EventHandler(this.TxtZ_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "__________________________";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 7;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 8;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Topbox
            // 
            this.Topbox.AutoSize = true;
            this.Topbox.Location = new System.Drawing.Point(45, 5);
            this.Topbox.Name = "Topbox";
            this.Topbox.Size = new System.Drawing.Size(103, 17);
            this.Topbox.TabIndex = 9;
            this.Topbox.Text = "Mantener visible";
            this.Topbox.UseVisualStyleBackColor = true;
            this.Topbox.CheckedChanged += new System.EventHandler(this.Top_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.TabIndex = 10;
            this.button5.Text = "^";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 20);
            this.button6.TabIndex = 11;
            this.button6.Text = "√";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(149, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(16, 21);
            this.button7.TabIndex = 12;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(149, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(16, 21);
            this.button8.TabIndex = 13;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 97);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Topbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtZ);
            this.Controls.Add(this.TxtY);
            this.Controls.Add(this.TxtX);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calc";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.TextBox TxtY;
        private System.Windows.Forms.TextBox TxtZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox Topbox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

