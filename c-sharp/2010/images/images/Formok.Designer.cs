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
            this.sob_x_pat = new System.Windows.Forms.PictureBox();
            this.sob_x_img = new System.Windows.Forms.PictureBox();
            this.sob_y_pat = new System.Windows.Forms.PictureBox();
            this.sob_y_img = new System.Windows.Forms.PictureBox();
            this.img_pt = new System.Windows.Forms.Label();
            this.cmp_img_patron = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.l = new System.Windows.Forms.TextBox();
            this.sx = new System.Windows.Forms.Label();
            this.sy = new System.Windows.Forms.Label();
            this.cmp_sobel_x = new System.Windows.Forms.PictureBox();
            this.cmp_sobel_y = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.Label();
            this.an = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sob_x_pat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sob_x_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sob_y_pat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sob_y_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmp_img_patron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmp_sobel_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmp_sobel_y)).BeginInit();
            this.an.SuspendLayout();
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
            this.linkLabel1.Location = new System.Drawing.Point(20, 51);
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
            this.linkLabel2.Location = new System.Drawing.Point(92, 9);
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
            this.original.Size = new System.Drawing.Size(85, 61);
            this.original.TabIndex = 5;
            this.original.TabStop = false;
            // 
            // rec
            // 
            this.rec.Location = new System.Drawing.Point(91, 0);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(58, 61);
            this.rec.TabIndex = 6;
            this.rec.TabStop = false;
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.White;
            this.mod.Location = new System.Drawing.Point(13, 38);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(33, 30);
            this.mod.TabIndex = 7;
            this.mod.TabStop = false;
            // 
            // pat
            // 
            this.pat.BackColor = System.Drawing.Color.White;
            this.pat.Location = new System.Drawing.Point(77, 38);
            this.pat.Name = "pat";
            this.pat.Size = new System.Drawing.Size(33, 30);
            this.pat.TabIndex = 8;
            this.pat.TabStop = false;
            // 
            // sob_x_pat
            // 
            this.sob_x_pat.BackColor = System.Drawing.Color.White;
            this.sob_x_pat.Location = new System.Drawing.Point(77, 87);
            this.sob_x_pat.Name = "sob_x_pat";
            this.sob_x_pat.Size = new System.Drawing.Size(33, 30);
            this.sob_x_pat.TabIndex = 10;
            this.sob_x_pat.TabStop = false;
            // 
            // sob_x_img
            // 
            this.sob_x_img.BackColor = System.Drawing.Color.White;
            this.sob_x_img.Location = new System.Drawing.Point(13, 87);
            this.sob_x_img.Name = "sob_x_img";
            this.sob_x_img.Size = new System.Drawing.Size(33, 30);
            this.sob_x_img.TabIndex = 9;
            this.sob_x_img.TabStop = false;
            // 
            // sob_y_pat
            // 
            this.sob_y_pat.BackColor = System.Drawing.Color.White;
            this.sob_y_pat.Location = new System.Drawing.Point(77, 135);
            this.sob_y_pat.Name = "sob_y_pat";
            this.sob_y_pat.Size = new System.Drawing.Size(33, 30);
            this.sob_y_pat.TabIndex = 12;
            this.sob_y_pat.TabStop = false;
            // 
            // sob_y_img
            // 
            this.sob_y_img.BackColor = System.Drawing.Color.White;
            this.sob_y_img.Location = new System.Drawing.Point(13, 135);
            this.sob_y_img.Name = "sob_y_img";
            this.sob_y_img.Size = new System.Drawing.Size(33, 30);
            this.sob_y_img.TabIndex = 11;
            this.sob_y_img.TabStop = false;
            // 
            // img_pt
            // 
            this.img_pt.AutoSize = true;
            this.img_pt.Location = new System.Drawing.Point(9, 22);
            this.img_pt.Name = "img_pt";
            this.img_pt.Size = new System.Drawing.Size(69, 13);
            this.img_pt.TabIndex = 13;
            this.img_pt.Text = "Orig + Patron";
            // 
            // cmp_img_patron
            // 
            this.cmp_img_patron.BackColor = System.Drawing.Color.White;
            this.cmp_img_patron.Location = new System.Drawing.Point(45, 38);
            this.cmp_img_patron.Name = "cmp_img_patron";
            this.cmp_img_patron.Size = new System.Drawing.Size(33, 30);
            this.cmp_img_patron.TabIndex = 15;
            this.cmp_img_patron.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(-1, 264);
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
            this.l.Location = new System.Drawing.Point(155, -1);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(77, 62);
            this.l.TabIndex = 18;
            // 
            // sx
            // 
            this.sx.AutoSize = true;
            this.sx.Location = new System.Drawing.Point(9, 71);
            this.sx.Name = "sx";
            this.sx.Size = new System.Drawing.Size(147, 13);
            this.sx.TabIndex = 19;
            this.sx.Text = "Sobel X Org + Sobel X Patron";
            // 
            // sy
            // 
            this.sy.AutoSize = true;
            this.sy.Location = new System.Drawing.Point(9, 119);
            this.sy.Name = "sy";
            this.sy.Size = new System.Drawing.Size(147, 13);
            this.sy.TabIndex = 20;
            this.sy.Text = "Sobel Y Org + Sobel Y Patron";
            // 
            // cmp_sobel_x
            // 
            this.cmp_sobel_x.BackColor = System.Drawing.Color.White;
            this.cmp_sobel_x.Location = new System.Drawing.Point(45, 87);
            this.cmp_sobel_x.Name = "cmp_sobel_x";
            this.cmp_sobel_x.Size = new System.Drawing.Size(33, 30);
            this.cmp_sobel_x.TabIndex = 21;
            this.cmp_sobel_x.TabStop = false;
            // 
            // cmp_sobel_y
            // 
            this.cmp_sobel_y.BackColor = System.Drawing.Color.White;
            this.cmp_sobel_y.Location = new System.Drawing.Point(45, 135);
            this.cmp_sobel_y.Name = "cmp_sobel_y";
            this.cmp_sobel_y.Size = new System.Drawing.Size(33, 30);
            this.cmp_sobel_y.TabIndex = 25;
            this.cmp_sobel_y.TabStop = false;
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Location = new System.Drawing.Point(10, 168);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(31, 13);
            this.tt.TabIndex = 26;
            this.tt.Text = "Total";
            // 
            // an
            // 
            this.an.Controls.Add(this.mod);
            this.an.Controls.Add(this.tt);
            this.an.Controls.Add(this.pat);
            this.an.Controls.Add(this.cmp_sobel_y);
            this.an.Controls.Add(this.sob_x_img);
            this.an.Controls.Add(this.linkLabel2);
            this.an.Controls.Add(this.sob_x_pat);
            this.an.Controls.Add(this.sob_y_img);
            this.an.Controls.Add(this.sob_y_pat);
            this.an.Controls.Add(this.cmp_sobel_x);
            this.an.Controls.Add(this.img_pt);
            this.an.Controls.Add(this.sy);
            this.an.Controls.Add(this.cmp_img_patron);
            this.an.Controls.Add(this.sx);
            this.an.Location = new System.Drawing.Point(0, 67);
            this.an.Name = "an";
            this.an.Size = new System.Drawing.Size(171, 194);
            this.an.TabIndex = 27;
            this.an.TabStop = false;
            this.an.Text = "Analisis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(256, 277);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.an);
            this.Controls.Add(this.l);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.original);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sob_x_pat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sob_x_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sob_y_pat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sob_y_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmp_img_patron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmp_sobel_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmp_sobel_y)).EndInit();
            this.an.ResumeLayout(false);
            this.an.PerformLayout();
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
        private System.Windows.Forms.PictureBox sob_x_pat;
        private System.Windows.Forms.PictureBox sob_x_img;
        private System.Windows.Forms.PictureBox sob_y_pat;
        private System.Windows.Forms.PictureBox sob_y_img;
        private System.Windows.Forms.Label img_pt;
        private System.Windows.Forms.PictureBox cmp_img_patron;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox l;
        private System.Windows.Forms.Label sx;
        private System.Windows.Forms.Label sy;
        private System.Windows.Forms.PictureBox cmp_sobel_x;
        private System.Windows.Forms.PictureBox cmp_sobel_y;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.GroupBox an;
    }
}

