namespace TuChat2
{
    partial class MultiChat
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
            this.lista_entera = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_nombre_grupo = new System.Windows.Forms.TextBox();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_entera
            // 
            this.lista_entera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lista_entera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_entera.CheckBoxes = true;
            this.lista_entera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lista_entera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_entera.FullRowSelect = true;
            this.lista_entera.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lista_entera.Location = new System.Drawing.Point(0, 90);
            this.lista_entera.MultiSelect = false;
            this.lista_entera.Name = "lista_entera";
            this.lista_entera.Size = new System.Drawing.Size(206, 235);
            this.lista_entera.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lista_entera.TabIndex = 22;
            this.lista_entera.UseCompatibleStateImageBehavior = false;
            this.lista_entera.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nombre";
            this.columnHeader6.Width = 193;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "Elige los amigos que quieras que formen parte de la conversación en grupo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(136, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Crear grupo";
            this.button1.UseVisualStyleBackColor = true;
   //         this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_nombre_grupo
            // 
            this.t_nombre_grupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.t_nombre_grupo.Location = new System.Drawing.Point(5, 330);
            this.t_nombre_grupo.Name = "t_nombre_grupo";
            this.t_nombre_grupo.Size = new System.Drawing.Size(126, 20);
            this.t_nombre_grupo.TabIndex = 27;
            this.t_nombre_grupo.Text = "Nombre del grupo...";
  //          this.t_nombre_grupo.Click += new System.EventHandler(this.t_nombre_grupo_Click);
            // 
            // t_buscar
            // 
            this.t_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.t_buscar.Location = new System.Drawing.Point(5, 50);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(196, 20);
            this.t_buscar.TabIndex = 28;
            this.t_buscar.Text = "Buscar...";
   //         this.t_buscar.Click += new System.EventHandler(this.t_buscar_Click);
  //          this.t_buscar.TextChanged += new System.EventHandler(this.t_buscar_TextChanged);
  //          this.t_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_buscar_KeyPress);
   //         this.t_buscar.Leave += new System.EventHandler(this.t_buscar_LostFocus);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 20);
            this.button2.TabIndex = 29;
            this.button2.Text = "Seleccionar todo";
            this.button2.UseVisualStyleBackColor = true;
  //          this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 20);
            this.button3.TabIndex = 30;
            this.button3.Text = "Deseleccionar todo";
            this.button3.UseVisualStyleBackColor = true;
 //           this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MultiChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 356);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.t_buscar);
            this.Controls.Add(this.t_nombre_grupo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_entera);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "MultiChat";
            this.Text = "MultiChat";
 //           this.Load += new System.EventHandler(this.MultiChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lista_entera;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_nombre_grupo;
        private System.Windows.Forms.TextBox t_buscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}