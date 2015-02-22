namespace Engranajes
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.E1 = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.E2 = new System.Windows.Forms.TextBox();
            this.L2 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.N2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mec = new System.Windows.Forms.ComboBox();
            this.E3 = new System.Windows.Forms.TextBox();
            this.N3 = new System.Windows.Forms.TextBox();
            this.N4 = new System.Windows.Forms.TextBox();
            this.E4 = new System.Windows.Forms.TextBox();
            this.L3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.NumEng = new System.Windows.Forms.ComboBox();
            this.Eng1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.Grafic = new Engranajes.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(648, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 11);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reproducir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // E1
            // 
            this.E1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.E1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E1.Location = new System.Drawing.Point(30, 405);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(31, 24);
            this.E1.TabIndex = 2;
            this.E1.Text = "10";
            // 
            // L1
            // 
            this.L1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(5, 410);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(25, 16);
            this.L1.TabIndex = 3;
            this.L1.Text = "D1";
            // 
            // E2
            // 
            this.E2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.E2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E2.Location = new System.Drawing.Point(30, 430);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(31, 24);
            this.E2.TabIndex = 2;
            this.E2.Text = "10";
            // 
            // L2
            // 
            this.L2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(5, 435);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(25, 16);
            this.L2.TabIndex = 3;
            this.L2.Text = "D2";
            // 
            // N1
            // 
            this.N1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.N1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N1.Location = new System.Drawing.Point(95, 405);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(31, 24);
            this.N1.TabIndex = 2;
            this.N1.Text = "100";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "N1";
            // 
            // N2
            // 
            this.N2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.N2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2.Location = new System.Drawing.Point(95, 430);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(31, 24);
            this.N2.TabIndex = 2;
            this.N2.Text = "100";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N2";
            // 
            // Mec
            // 
            this.Mec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Mec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mec.FormattingEnabled = true;
            this.Mec.Items.AddRange(new object[] {
            "Ruedas dentadas",
            "Poleas y ruedas de friccion"});
            this.Mec.Location = new System.Drawing.Point(275, 405);
            this.Mec.Name = "Mec";
            this.Mec.Size = new System.Drawing.Size(155, 21);
            this.Mec.TabIndex = 4;
            this.Mec.Text = "Ruedas dentadas";
            this.Mec.SelectedIndexChanged += new System.EventHandler(this.Mec_SelectedIndexChanged);
            // 
            // E3
            // 
            this.E3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.E3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E3.Location = new System.Drawing.Point(170, 405);
            this.E3.Name = "E3";
            this.E3.Size = new System.Drawing.Size(31, 24);
            this.E3.TabIndex = 2;
            this.E3.Text = "10";
            // 
            // N3
            // 
            this.N3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.N3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N3.Location = new System.Drawing.Point(235, 405);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(31, 24);
            this.N3.TabIndex = 2;
            // 
            // N4
            // 
            this.N4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.N4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N4.Location = new System.Drawing.Point(235, 430);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(31, 24);
            this.N4.TabIndex = 2;
            // 
            // E4
            // 
            this.E4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.E4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E4.Location = new System.Drawing.Point(170, 430);
            this.E4.Name = "E4";
            this.E4.Size = new System.Drawing.Size(31, 24);
            this.E4.TabIndex = 2;
            this.E4.Text = "10";
            // 
            // L3
            // 
            this.L3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3.Location = new System.Drawing.Point(145, 410);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(25, 16);
            this.L3.TabIndex = 3;
            this.L3.Text = "D3";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "N3";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "N4";
            // 
            // L4
            // 
            this.L4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L4.Location = new System.Drawing.Point(145, 435);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(25, 16);
            this.L4.TabIndex = 3;
            this.L4.Text = "D4";
            // 
            // NumEng
            // 
            this.NumEng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumEng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumEng.FormattingEnabled = true;
            this.NumEng.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.NumEng.Location = new System.Drawing.Point(275, 430);
            this.NumEng.Name = "NumEng";
            this.NumEng.Size = new System.Drawing.Size(35, 21);
            this.NumEng.TabIndex = 4;
            this.NumEng.Text = "2";
            this.NumEng.SelectedIndexChanged += new System.EventHandler(this.Mec_SelectedIndexChanged);
            // 
            // Eng1
            // 
            this.Eng1.Interval = 10;
            this.Eng1.Tick += new System.EventHandler(this.Eng1_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(588, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dibujar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grafic
            // 
            this.Grafic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Grafic.BackColor = System.Drawing.Color.White;
            this.Grafic.Location = new System.Drawing.Point(5, 5);
            this.Grafic.Name = "Grafic";
            this.Grafic.Size = new System.Drawing.Size(653, 390);
            this.Grafic.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumEng);
            this.Controls.Add(this.Mec);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.E4);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.N4);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.E3);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.Grafic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferPanel Grafic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox E1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox E2;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.TextBox N1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Mec;
        private System.Windows.Forms.TextBox E3;
        private System.Windows.Forms.TextBox N3;
        private System.Windows.Forms.TextBox N4;
        private System.Windows.Forms.TextBox E4;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.ComboBox NumEng;
        private System.Windows.Forms.Timer Eng1;
        private System.Windows.Forms.Button button2;
    }
}

