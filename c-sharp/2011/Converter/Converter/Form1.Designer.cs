namespace Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.texto_insertar = new System.Windows.Forms.TextBox();
            this.entero_hex_dec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.entero_oct_dec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entero_dec_oct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entero_dec_hex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.texto_ascii_hex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texto_hex_ascii = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.texto_base64_ascii = new System.Windows.Forms.TextBox();
            this.texto_ascii_base64 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.texto_sha1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.texto_md5 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.texto_ignorar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.texto_tamaño = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // texto_insertar
            // 
            this.texto_insertar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.texto_insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_insertar.Location = new System.Drawing.Point(10, 10);
            this.texto_insertar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_insertar.Multiline = true;
            this.texto_insertar.Name = "texto_insertar";
            this.texto_insertar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texto_insertar.Size = new System.Drawing.Size(331, 40);
            this.texto_insertar.TabIndex = 0;
            this.texto_insertar.TextChanged += new System.EventHandler(this.texto_insertar_TextChanged);
            // 
            // entero_hex_dec
            // 
            this.entero_hex_dec.Location = new System.Drawing.Point(56, 11);
            this.entero_hex_dec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.entero_hex_dec.Name = "entero_hex_dec";
            this.entero_hex_dec.Size = new System.Drawing.Size(126, 18);
            this.entero_hex_dec.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.entero_oct_dec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.entero_dec_oct);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.entero_dec_hex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.entero_hex_dec);
            this.groupBox1.Location = new System.Drawing.Point(10, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(188, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 11);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oct->Dec";
            // 
            // entero_oct_dec
            // 
            this.entero_oct_dec.Location = new System.Drawing.Point(56, 69);
            this.entero_oct_dec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.entero_oct_dec.Name = "entero_oct_dec";
            this.entero_oct_dec.Size = new System.Drawing.Size(126, 18);
            this.entero_oct_dec.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 11);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dec->Oct";
            // 
            // entero_dec_oct
            // 
            this.entero_dec_oct.Location = new System.Drawing.Point(56, 51);
            this.entero_dec_oct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.entero_dec_oct.Name = "entero_dec_oct";
            this.entero_dec_oct.Size = new System.Drawing.Size(126, 18);
            this.entero_dec_oct.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 11);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dec->Hex";
            // 
            // entero_dec_hex
            // 
            this.entero_dec_hex.Location = new System.Drawing.Point(56, 29);
            this.entero_dec_hex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.entero_dec_hex.Name = "entero_dec_hex";
            this.entero_dec_hex.Size = new System.Drawing.Size(126, 18);
            this.entero_dec_hex.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 11);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hex->Dec";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.texto_ascii_hex);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.texto_hex_ascii);
            this.groupBox2.Location = new System.Drawing.Point(203, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(137, 147);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto";
            // 
            // texto_ascii_hex
            // 
            this.texto_ascii_hex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.texto_ascii_hex.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_ascii_hex.Location = new System.Drawing.Point(5, 84);
            this.texto_ascii_hex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_ascii_hex.Multiline = true;
            this.texto_ascii_hex.Name = "texto_ascii_hex";
            this.texto_ascii_hex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texto_ascii_hex.Size = new System.Drawing.Size(127, 59);
            this.texto_ascii_hex.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 11);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ascii->Hex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 11);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hex->Ascii";
            // 
            // texto_hex_ascii
            // 
            this.texto_hex_ascii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.texto_hex_ascii.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_hex_ascii.Location = new System.Drawing.Point(5, 27);
            this.texto_hex_ascii.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_hex_ascii.Multiline = true;
            this.texto_hex_ascii.Name = "texto_hex_ascii";
            this.texto_hex_ascii.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texto_hex_ascii.Size = new System.Drawing.Size(127, 41);
            this.texto_hex_ascii.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.texto_base64_ascii);
            this.groupBox3.Controls.Add(this.texto_ascii_base64);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(10, 206);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(330, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Base64";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(242, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 11);
            this.label12.TabIndex = 15;
            this.label12.Text = "Backgateway 2011";
            // 
            // texto_base64_ascii
            // 
            this.texto_base64_ascii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.texto_base64_ascii.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_base64_ascii.Location = new System.Drawing.Point(7, 93);
            this.texto_base64_ascii.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_base64_ascii.Multiline = true;
            this.texto_base64_ascii.Name = "texto_base64_ascii";
            this.texto_base64_ascii.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texto_base64_ascii.Size = new System.Drawing.Size(318, 49);
            this.texto_base64_ascii.TabIndex = 14;
            // 
            // texto_ascii_base64
            // 
            this.texto_ascii_base64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.texto_ascii_base64.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_ascii_base64.Location = new System.Drawing.Point(7, 27);
            this.texto_ascii_base64.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_ascii_base64.Multiline = true;
            this.texto_ascii_base64.Name = "texto_ascii_base64";
            this.texto_ascii_base64.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texto_ascii_base64.Size = new System.Drawing.Size(318, 51);
            this.texto_ascii_base64.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 11);
            this.label8.TabIndex = 2;
            this.label8.Text = "Base64->Ascii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 11);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ascii->Base64";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.texto_sha1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.texto_md5);
            this.groupBox4.Location = new System.Drawing.Point(10, 366);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(330, 58);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hashes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 11);
            this.label10.TabIndex = 12;
            this.label10.Text = "SHA1";
            // 
            // texto_sha1
            // 
            this.texto_sha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.texto_sha1.Location = new System.Drawing.Point(35, 34);
            this.texto_sha1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_sha1.Name = "texto_sha1";
            this.texto_sha1.Size = new System.Drawing.Size(291, 18);
            this.texto_sha1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 11);
            this.label9.TabIndex = 10;
            this.label9.Text = "MD5";
            // 
            // texto_md5
            // 
            this.texto_md5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.texto_md5.Location = new System.Drawing.Point(35, 16);
            this.texto_md5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_md5.Name = "texto_md5";
            this.texto_md5.Size = new System.Drawing.Size(291, 18);
            this.texto_md5.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.texto_ignorar);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.texto_tamaño);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(10, 151);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(188, 50);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Información";
            // 
            // texto_ignorar
            // 
            this.texto_ignorar.Location = new System.Drawing.Point(56, 28);
            this.texto_ignorar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_ignorar.Name = "texto_ignorar";
            this.texto_ignorar.Size = new System.Drawing.Size(126, 18);
            this.texto_ignorar.TabIndex = 4;
            this.texto_ignorar.Text = ":";
            this.texto_ignorar.TextChanged += new System.EventHandler(this.texto_insertar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 11);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ignorar";
            // 
            // texto_tamaño
            // 
            this.texto_tamaño.Location = new System.Drawing.Point(56, 10);
            this.texto_tamaño.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.texto_tamaño.Name = "texto_tamaño";
            this.texto_tamaño.Size = new System.Drawing.Size(126, 18);
            this.texto_tamaño.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 11);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tamaño";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 434);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.texto_insertar);
            this.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(360, 428);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto_insertar;
        private System.Windows.Forms.TextBox entero_hex_dec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entero_dec_oct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entero_dec_hex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entero_oct_dec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox texto_ascii_hex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texto_hex_ascii;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox texto_base64_ascii;
        private System.Windows.Forms.TextBox texto_ascii_base64;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox texto_sha1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox texto_md5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox texto_tamaño;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox texto_ignorar;
        private System.Windows.Forms.Label label13;
    }
}

