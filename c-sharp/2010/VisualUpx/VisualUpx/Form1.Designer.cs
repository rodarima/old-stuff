namespace VisualUpx
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
            this.BtnUrl = new System.Windows.Forms.Button();
            this.txURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txCompInfo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDescomprimir = new System.Windows.Forms.CheckBox();
            this.cbForzar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUrl
            // 
            this.BtnUrl.Location = new System.Drawing.Point(270, 15);
            this.BtnUrl.Name = "BtnUrl";
            this.BtnUrl.Size = new System.Drawing.Size(25, 20);
            this.BtnUrl.TabIndex = 0;
            this.BtnUrl.Text = "...";
            this.BtnUrl.UseVisualStyleBackColor = true;
            this.BtnUrl.Click += new System.EventHandler(this.BtnUrl_Click);
            // 
            // txURL
            // 
            this.txURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txURL.Location = new System.Drawing.Point(5, 15);
            this.txURL.Name = "txURL";
            this.txURL.Size = new System.Drawing.Size(260, 18);
            this.txURL.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pack!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(5, 15);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 70);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txCompInfo
            // 
            this.txCompInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txCompInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txCompInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCompInfo.ForeColor = System.Drawing.Color.Black;
            this.txCompInfo.Location = new System.Drawing.Point(50, 20);
            this.txCompInfo.Multiline = true;
            this.txCompInfo.Name = "txCompInfo";
            this.txCompInfo.Size = new System.Drawing.Size(120, 50);
            this.txCompInfo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txCompInfo);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(5, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de compresión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "+";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnUrl);
            this.groupBox2.Controls.Add(this.txURL);
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 40);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archivo a comprimir";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDescomprimir);
            this.groupBox3.Controls.Add(this.cbForzar);
            this.groupBox3.Location = new System.Drawing.Point(185, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // cbDescomprimir
            // 
            this.cbDescomprimir.AutoSize = true;
            this.cbDescomprimir.Location = new System.Drawing.Point(5, 30);
            this.cbDescomprimir.Name = "cbDescomprimir";
            this.cbDescomprimir.Size = new System.Drawing.Size(89, 17);
            this.cbDescomprimir.TabIndex = 1;
            this.cbDescomprimir.Text = "Descomprimir";
            this.cbDescomprimir.UseVisualStyleBackColor = true;
            // 
            // cbForzar
            // 
            this.cbForzar.AutoSize = true;
            this.cbForzar.Location = new System.Drawing.Point(5, 15);
            this.cbForzar.Name = "cbForzar";
            this.cbForzar.Size = new System.Drawing.Size(112, 17);
            this.cbForzar.TabIndex = 0;
            this.cbForzar.Text = "Forzar compresion";
            this.cbForzar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 135);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upx Packer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUrl;
        private System.Windows.Forms.TextBox txURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txCompInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbForzar;
        private System.Windows.Forms.CheckBox cbDescomprimir;
    }
}

