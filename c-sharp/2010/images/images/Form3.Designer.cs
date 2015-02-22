namespace images
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.original = new System.Windows.Forms.PictureBox();
            this.rec = new System.Windows.Forms.PictureBox();
            this.mod = new System.Windows.Forms.PictureBox();
            this.pat = new System.Windows.Forms.PictureBox();
            this.pat1 = new System.Windows.Forms.PictureBox();
            this.mod1 = new System.Windows.Forms.PictureBox();
            this.pat2 = new System.Windows.Forms.PictureBox();
            this.mod2 = new System.Windows.Forms.PictureBox();
            this.coinc = new System.Windows.Forms.Label();
            this.pat_f = new System.Windows.Forms.PictureBox();
            this.pat_ok = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.l = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat_ok)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 278);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Leer imagen";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(209, 278);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(73, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Buscar patron";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // original
            // 
            this.original.Location = new System.Drawing.Point(0, 0);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(133, 112);
            this.original.TabIndex = 5;
            this.original.TabStop = false;
            // 
            // rec
            // 
            this.rec.Location = new System.Drawing.Point(139, 0);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(58, 61);
            this.rec.TabIndex = 6;
            this.rec.TabStop = false;
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(203, 0);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(39, 30);
            this.mod.TabIndex = 7;
            this.mod.TabStop = false;
            // 
            // pat
            // 
            this.pat.Location = new System.Drawing.Point(248, 0);
            this.pat.Name = "pat";
            this.pat.Size = new System.Drawing.Size(43, 30);
            this.pat.TabIndex = 8;
            this.pat.TabStop = false;
            // 
            // pat1
            // 
            this.pat1.Location = new System.Drawing.Point(248, 97);
            this.pat1.Name = "pat1";
            this.pat1.Size = new System.Drawing.Size(43, 30);
            this.pat1.TabIndex = 10;
            this.pat1.TabStop = false;
            // 
            // mod1
            // 
            this.mod1.Location = new System.Drawing.Point(203, 97);
            this.mod1.Name = "mod1";
            this.mod1.Size = new System.Drawing.Size(39, 30);
            this.mod1.TabIndex = 9;
            this.mod1.TabStop = false;
            // 
            // pat2
            // 
            this.pat2.Location = new System.Drawing.Point(248, 133);
            this.pat2.Name = "pat2";
            this.pat2.Size = new System.Drawing.Size(43, 30);
            this.pat2.TabIndex = 12;
            this.pat2.TabStop = false;
            // 
            // mod2
            // 
            this.mod2.Location = new System.Drawing.Point(203, 133);
            this.mod2.Name = "mod2";
            this.mod2.Size = new System.Drawing.Size(39, 30);
            this.mod2.TabIndex = 11;
            this.mod2.TabStop = false;
            // 
            // coinc
            // 
            this.coinc.AutoSize = true;
            this.coinc.Location = new System.Drawing.Point(185, 69);
            this.coinc.Name = "coinc";
            this.coinc.Size = new System.Drawing.Size(68, 13);
            this.coinc.TabIndex = 13;
            this.coinc.Text = "Coincidencia";
            // 
            // pat_f
            // 
            this.pat_f.Location = new System.Drawing.Point(248, 36);
            this.pat_f.Name = "pat_f";
            this.pat_f.Size = new System.Drawing.Size(43, 30);
            this.pat_f.TabIndex = 14;
            this.pat_f.TabStop = false;
            // 
            // pat_ok
            // 
            this.pat_ok.Location = new System.Drawing.Point(203, 36);
            this.pat_ok.Name = "pat_ok";
            this.pat_ok.Size = new System.Drawing.Size(39, 30);
            this.pat_ok.TabIndex = 15;
            this.pat_ok.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 16;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(110, 278);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(42, 13);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Manual";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // l
            // 
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(6, 118);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(127, 62);
            this.l.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 300);
            this.Controls.Add(this.l);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pat_ok);
            this.Controls.Add(this.pat_f);
            this.Controls.Add(this.coinc);
            this.Controls.Add(this.pat2);
            this.Controls.Add(this.mod2);
            this.Controls.Add(this.pat1);
            this.Controls.Add(this.mod1);
            this.Controls.Add(this.pat);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.original);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat_ok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox original;
        private System.Windows.Forms.PictureBox rec;
        private System.Windows.Forms.PictureBox mod;
        private System.Windows.Forms.PictureBox pat;
        private System.Windows.Forms.PictureBox pat1;
        private System.Windows.Forms.PictureBox mod1;
        private System.Windows.Forms.PictureBox pat2;
        private System.Windows.Forms.PictureBox mod2;
        private System.Windows.Forms.Label coinc;
        private System.Windows.Forms.PictureBox pat_f;
        private System.Windows.Forms.PictureBox pat_ok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox l;
    }
}

