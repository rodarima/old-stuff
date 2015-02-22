namespace SpiderNET
{
    partial class SpiderNET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpiderNET));
            this.BtnDownload = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.BntAdd = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AutoSearch = new System.Windows.Forms.CheckBox();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.tArranque = new System.Windows.Forms.Timer(this.components);
            this.InfoClaves = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnMaps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDownload
            // 
            this.BtnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDownload.BackgroundImage")));
            this.BtnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDownload.Location = new System.Drawing.Point(783, 5);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(50, 50);
            this.BtnDownload.TabIndex = 1;
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // debug
            // 
            this.debug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.debug.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.ForeColor = System.Drawing.SystemColors.WindowText;
            this.debug.Location = new System.Drawing.Point(5, 470);
            this.debug.Multiline = true;
            this.debug.Name = "debug";
            this.debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debug.Size = new System.Drawing.Size(828, 100);
            this.debug.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(5, 25);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(105, 20);
            this.TxtName.TabIndex = 3;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(116, 25);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(100, 20);
            this.TxtPass.TabIndex = 4;
            // 
            // TxtLocation
            // 
            this.TxtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLocation.Location = new System.Drawing.Point(222, 25);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(203, 20);
            this.TxtLocation.TabIndex = 5;
            // 
            // BntAdd
            // 
            this.BntAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BntAdd.BackgroundImage")));
            this.BntAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BntAdd.Location = new System.Drawing.Point(425, 5);
            this.BntAdd.Name = "BntAdd";
            this.BntAdd.Size = new System.Drawing.Size(40, 40);
            this.BntAdd.TabIndex = 6;
            this.BntAdd.Tag = "";
            this.BntAdd.UseVisualStyleBackColor = true;
            this.BntAdd.Click += new System.EventHandler(this.BntAdd_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearch.Location = new System.Drawing.Point(623, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 40);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnUpload
            // 
            this.BtnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpload.BackgroundImage")));
            this.BtnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpload.Location = new System.Drawing.Point(663, 5);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(40, 40);
            this.BtnUpload.TabIndex = 8;
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 400);
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(703, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de la red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña de la red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lugar donde se encuentra la red";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(743, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(508, 25);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(110, 20);
            this.TxtSearch.TabIndex = 15;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Buscar";
            // 
            // AutoSearch
            // 
            this.AutoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoSearch.AutoSize = true;
            this.AutoSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoSearch.Checked = true;
            this.AutoSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSearch.Location = new System.Drawing.Point(568, 10);
            this.AutoSearch.Name = "AutoSearch";
            this.AutoSearch.Size = new System.Drawing.Size(48, 17);
            this.AutoSearch.TabIndex = 18;
            this.AutoSearch.Text = "Auto";
            this.AutoSearch.UseVisualStyleBackColor = true;
            // 
            // pbar
            // 
            this.pbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbar.Location = new System.Drawing.Point(5, 45);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(778, 10);
            this.pbar.TabIndex = 19;
            // 
            // tArranque
            // 
            this.tArranque.Enabled = true;
            this.tArranque.Tick += new System.EventHandler(this.tArranque_Tick);
            // 
            // InfoClaves
            // 
            this.InfoClaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoClaves.AutoSize = true;
            this.InfoClaves.Location = new System.Drawing.Point(5, 455);
            this.InfoClaves.Name = "InfoClaves";
            this.InfoClaves.Size = new System.Drawing.Size(42, 13);
            this.InfoClaves.TabIndex = 21;
            this.InfoClaves.Text = "Claves:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "SpiderNET creada el 16/08/2010";
            // 
            // BtnMaps
            // 
            this.BtnMaps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMaps.BackgroundImage")));
            this.BtnMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMaps.Location = new System.Drawing.Point(465, 5);
            this.BtnMaps.Name = "BtnMaps";
            this.BtnMaps.Size = new System.Drawing.Size(40, 40);
            this.BtnMaps.TabIndex = 22;
            this.BtnMaps.UseVisualStyleBackColor = true;
            this.BtnMaps.Click += new System.EventHandler(this.BtnMaps_Click);
            // 
            // SpiderNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 577);
            this.Controls.Add(this.BtnMaps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InfoClaves);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BntAdd);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AutoSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 250);
            this.Name = "SpiderNET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpiderNET";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.TextBox debug;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.Button BntAdd;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox AutoSearch;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Timer tArranque;
        private System.Windows.Forms.Label InfoClaves;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnMaps;
    }
}

