namespace nob
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.b_buscar = new System.Windows.Forms.ToolStripButton();
            this.t_buscar = new System.Windows.Forms.ToolStripTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num_can = new System.Windows.Forms.Label();
            this.lurl = new System.Windows.Forms.Label();
            this.pg = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_buscar,
            this.t_buscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // b_buscar
            // 
            this.b_buscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.b_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.b_buscar.Image = ((System.Drawing.Image)(resources.GetObject("b_buscar.Image")));
            this.b_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_buscar.Name = "b_buscar";
            this.b_buscar.Size = new System.Drawing.Size(27, 22);
            this.b_buscar.Text = "OK";
            this.b_buscar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // t_buscar
            // 
            this.t_buscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.t_buscar.MergeIndex = 0;
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(250, 25);
            this.t_buscar.Text = "Buscar...";
            this.t_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeys);
            this.t_buscar.Click += new System.EventHandler(this.t_buscar_Click);
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.url});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.LabelEdit = true;
            this.lv.Location = new System.Drawing.Point(0, 28);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(558, 276);
            this.lv.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv.TabIndex = 4;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Título";
            this.id.Width = 450;
            // 
            // url
            // 
            this.url.Text = "Ref";
            this.url.Width = 69;
            // 
            // num_can
            // 
            this.num_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.num_can.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_can.Location = new System.Drawing.Point(518, 353);
            this.num_can.Name = "num_can";
            this.num_can.Size = new System.Drawing.Size(41, 13);
            this.num_can.TabIndex = 6;
            this.num_can.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lurl
            // 
            this.lurl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lurl.AutoSize = true;
            this.lurl.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lurl.Location = new System.Drawing.Point(-1, 353);
            this.lurl.Name = "lurl";
            this.lurl.Size = new System.Drawing.Size(44, 11);
            this.lurl.TabIndex = 7;
            this.lurl.Text = "             ";
            // 
            // pg
            // 
            this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pg.Location = new System.Drawing.Point(0, 24);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(557, 10);
            this.pg.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pg.TabIndex = 8;
            this.pg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::nob.Properties.Resources.play;
            this.pictureBox1.Location = new System.Drawing.Point(26, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Down);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Up);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::nob.Properties.Resources.play;
            this.pictureBox2.Location = new System.Drawing.Point(1, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::nob.Properties.Resources.play;
            this.pictureBox3.Location = new System.Drawing.Point(66, 318);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 365);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pg);
            this.Controls.Add(this.lurl);
            this.Controls.Add(this.num_can);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Nob";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton b_buscar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader url;
        private System.Windows.Forms.Label num_can;
        private System.Windows.Forms.Label lurl;
        private System.Windows.Forms.ToolStripTextBox t_buscar;
        private System.Windows.Forms.ProgressBar pg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

