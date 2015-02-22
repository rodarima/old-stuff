namespace Funciones
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
            this.Graph = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MultiX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TerIndX = new System.Windows.Forms.TextBox();
            this.ExpX = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OperX = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Zoom = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.vert = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.White;
            this.Graph.Location = new System.Drawing.Point(5, 5);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(300, 300);
            this.Graph.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y=";
            // 
            // MultiX
            // 
            this.MultiX.BackColor = System.Drawing.Color.White;
            this.MultiX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiX.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiX.Location = new System.Drawing.Point(30, 10);
            this.MultiX.Name = "MultiX";
            this.MultiX.Size = new System.Drawing.Size(51, 25);
            this.MultiX.TabIndex = 4;
            this.MultiX.Text = "2";
            this.MultiX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // TerIndX
            // 
            this.TerIndX.BackColor = System.Drawing.Color.White;
            this.TerIndX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TerIndX.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerIndX.Location = new System.Drawing.Point(105, 10);
            this.TerIndX.Name = "TerIndX";
            this.TerIndX.Size = new System.Drawing.Size(60, 25);
            this.TerIndX.TabIndex = 4;
            this.TerIndX.Text = "3";
            // 
            // ExpX
            // 
            this.ExpX.BackColor = System.Drawing.Color.White;
            this.ExpX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpX.Font = new System.Drawing.Font("Lucida Sans Unicode", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpX.Location = new System.Drawing.Point(90, 0);
            this.ExpX.Name = "ExpX";
            this.ExpX.Size = new System.Drawing.Size(31, 14);
            this.ExpX.TabIndex = 4;
            this.ExpX.Text = "2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.MultiX);
            this.panel1.Controls.Add(this.ExpX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OperX);
            this.panel1.Controls.Add(this.TerIndX);
            this.panel1.Location = new System.Drawing.Point(310, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 40);
            this.panel1.TabIndex = 6;
            // 
            // OperX
            // 
            this.OperX.BackColor = System.Drawing.Color.White;
            this.OperX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperX.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperX.Location = new System.Drawing.Point(94, 9);
            this.OperX.Name = "OperX";
            this.OperX.Size = new System.Drawing.Size(13, 25);
            this.OperX.TabIndex = 4;
            this.OperX.Text = "+";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Zoom
            // 
            this.Zoom.BackColor = System.Drawing.SystemColors.Control;
            this.Zoom.Location = new System.Drawing.Point(5, 15);
            this.Zoom.Maximum = 20;
            this.Zoom.Minimum = 1;
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(160, 45);
            this.Zoom.TabIndex = 9;
            this.Zoom.TickFrequency = 0;
            this.Zoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Zoom.Value = 1;
            this.Zoom.Scroll += new System.EventHandler(this.Zoom_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vértice en Y";
            // 
            // vert
            // 
            this.vert.BackColor = System.Drawing.Color.White;
            this.vert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vert.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vert.Location = new System.Drawing.Point(85, 5);
            this.vert.Name = "vert";
            this.vert.Size = new System.Drawing.Size(55, 19);
            this.vert.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.vert);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(310, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 30);
            this.panel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Zoom);
            this.groupBox1.Location = new System.Drawing.Point(310, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Funciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MultiX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TerIndX;
        private System.Windows.Forms.TextBox ExpX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OperX;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar Zoom;
        private System.Windows.Forms.TextBox vert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

