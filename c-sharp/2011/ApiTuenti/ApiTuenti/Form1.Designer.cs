namespace ApiTuenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 289);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nombre";
            this.columnHeader6.Width = 207;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "normal_conectado.png");
            this.imageList1.Images.SetKeyName(1, "normal_desconectado.png");
            this.imageList1.Images.SetKeyName(2, "normal_ausente.png");
            this.imageList1.Images.SetKeyName(3, "webcam_conectado.png");
            this.imageList1.Images.SetKeyName(4, "webcam_desconectado.png");
            this.imageList1.Images.SetKeyName(5, "webcam_ausente.png");
            this.imageList1.Images.SetKeyName(6, "blackberry_conectado.png");
            this.imageList1.Images.SetKeyName(7, "blackberry_desconectado.png");
            this.imageList1.Images.SetKeyName(8, "blackberry_ausente.png");
            this.imageList1.Images.SetKeyName(9, "iphone_conectado.png");
            this.imageList1.Images.SetKeyName(10, "iphone_desconectado.png");
            this.imageList1.Images.SetKeyName(11, "iphone_ausente.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "conetado.png");
            this.imageList2.Images.SetKeyName(1, "desconetado.png");
            this.imageList2.Images.SetKeyName(2, "ausente.png");
            this.imageList2.Images.SetKeyName(3, "conectado_webcam.png");
            this.imageList2.Images.SetKeyName(4, "desconectado_webcam.png");
            this.imageList2.Images.SetKeyName(5, "ausente_webcam.png");
            this.imageList2.Images.SetKeyName(6, "conectado_blackberry.png");
            this.imageList2.Images.SetKeyName(7, "desconectado_blackberry.png");
            this.imageList2.Images.SetKeyName(8, "ausente_blackberry.png");
            this.imageList2.Images.SetKeyName(9, "conectado_movil.png");
            this.imageList2.Images.SetKeyName(10, "desconectado_movil.png");
            this.imageList2.Images.SetKeyName(11, "ausente_movil.png");
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 292);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(324, 94);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 386);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

