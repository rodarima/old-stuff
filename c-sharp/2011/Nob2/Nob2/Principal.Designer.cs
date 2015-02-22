namespace Nob2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.iconos = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.list = new System.Windows.Forms.ListView();
            this.col_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_com = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.next_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lupa = new System.Windows.Forms.PictureBox();
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.play_picture = new System.Windows.Forms.PictureBox();
            this.title_container = new System.Windows.Forms.Panel();
            this.down_image = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.stream_track = new EConTech.Windows.MACUI.MACTrackBar();
            this.status_wplayer = new System.Windows.Forms.Label();
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.search_text = new System.Windows.Forms.TextBox();
            this.volume_track = new EConTech.Windows.MACUI.MACTrackBar();
            this.fondo_search = new System.Windows.Forms.PictureBox();
            this.stop_search = new System.Windows.Forms.Button();
            this.exclude = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_picture)).BeginInit();
            this.title_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.down_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo_search)).BeginInit();
            this.SuspendLayout();
            // 
            // iconos
            // 
            this.iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconos.ImageStream")));
            this.iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconos.Images.SetKeyName(0, "document-music.png");
            this.iconos.Images.SetKeyName(1, "music.png");
            this.iconos.Images.SetKeyName(2, "drive-download.png");
            this.iconos.Images.SetKeyName(3, "plus-circle.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 436);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.list);
            this.tabPage1.Controls.Add(this.next_button);
            this.tabPage1.Controls.Add(this.previous_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar";
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_title,
            this.col_com,
            this.columnHeader3});
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(780, 410);
            this.list.SmallImageList = this.iconos;
            this.list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list.TabIndex = 1;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged_1);
            this.list.DoubleClick += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // col_title
            // 
            this.col_title.Text = "Título";
            this.col_title.Width = 238;
            // 
            // col_com
            // 
            this.col_com.Text = "Artista, comentarios";
            this.col_com.Width = 303;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ref";
            this.columnHeader3.Width = 0;
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.next_button.BackgroundImage = global::Nob2.Properties.Resources.control_double;
            this.next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next_button.Location = new System.Drawing.Point(757, 71);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(38, 37);
            this.next_button.TabIndex = 4;
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Visible = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.BackColor = System.Drawing.Color.DarkGray;
            this.previous_button.BackgroundImage = global::Nob2.Properties.Resources.control_double_180;
            this.previous_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous_button.FlatAppearance.BorderSize = 0;
            this.previous_button.Location = new System.Drawing.Point(738, 80);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(38, 38);
            this.previous_button.TabIndex = 2;
            this.previous_button.UseVisualStyleBackColor = false;
            this.previous_button.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de reproducción";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lupa
            // 
            this.lupa.BackColor = System.Drawing.Color.Transparent;
            this.lupa.Image = global::Nob2.Properties.Resources.lupa;
            this.lupa.Location = new System.Drawing.Point(164, 17);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(20, 20);
            this.lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lupa.TabIndex = 5;
            this.lupa.TabStop = false;
            // 
            // timer_status
            // 
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Nob2.Properties.Resources.degradado;
            this.panel1.Controls.Add(this.lupa);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.play_picture);
            this.panel1.Controls.Add(this.title_container);
            this.panel1.Controls.Add(this.pic_loading);
            this.panel1.Controls.Add(this.search_text);
            this.panel1.Controls.Add(this.volume_track);
            this.panel1.Controls.Add(this.fondo_search);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 52);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Nob2.Properties.Resources.next30;
            this.pictureBox3.Location = new System.Drawing.Point(270, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Nob2.Properties.Resources.prev30;
            this.pictureBox2.Location = new System.Drawing.Point(200, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // play_picture
            // 
            this.play_picture.BackColor = System.Drawing.Color.Transparent;
            this.play_picture.Image = global::Nob2.Properties.Resources.play;
            this.play_picture.Location = new System.Drawing.Point(230, 6);
            this.play_picture.Name = "play_picture";
            this.play_picture.Size = new System.Drawing.Size(40, 40);
            this.play_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.play_picture.TabIndex = 12;
            this.play_picture.TabStop = false;
            this.play_picture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // title_container
            // 
            this.title_container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.title_container.BackColor = System.Drawing.Color.LemonChiffon;
            this.title_container.Controls.Add(this.down_image);
            this.title_container.Controls.Add(this.pictureBox1);
            this.title_container.Controls.Add(this.title_label);
            this.title_container.Controls.Add(this.info_label);
            this.title_container.Controls.Add(this.stream_track);
            this.title_container.Controls.Add(this.status_wplayer);
            this.title_container.Location = new System.Drawing.Point(418, 0);
            this.title_container.Name = "title_container";
            this.title_container.Size = new System.Drawing.Size(367, 52);
            this.title_container.TabIndex = 7;
            // 
            // down_image
            // 
            this.down_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.down_image.Image = global::Nob2.Properties.Resources.drive_download;
            this.down_image.Location = new System.Drawing.Point(343, 21);
            this.down_image.Name = "down_image";
            this.down_image.Size = new System.Drawing.Size(16, 16);
            this.down_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.down_image.TabIndex = 11;
            this.down_image.TabStop = false;
            this.down_image.Visible = false;
            this.down_image.Click += new System.EventHandler(this.down_image_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Nob2.Properties.Resources.separator;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.title_label.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title_label.Location = new System.Drawing.Point(5, 6);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(359, 13);
            this.title_label.TabIndex = 6;
            this.title_label.Text = "Nob 2, encuentra tu música";
            // 
            // info_label
            // 
            this.info_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.info_label.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.ForeColor = System.Drawing.Color.Gray;
            this.info_label.Location = new System.Drawing.Point(5, 20);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(332, 13);
            this.info_label.TabIndex = 7;
            this.info_label.Text = "Busca una canción o un grupo.";
            this.info_label.Click += new System.EventHandler(this.info_label_Click);
            // 
            // stream_track
            // 
            this.stream_track.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stream_track.BackColor = System.Drawing.Color.Transparent;
            this.stream_track.BorderColor = System.Drawing.Color.Transparent;
            this.stream_track.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stream_track.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.stream_track.IndentHeight = 6;
            this.stream_track.LargeChange = 1;
            this.stream_track.Location = new System.Drawing.Point(-1, 35);
            this.stream_track.Maximum = 1000;
            this.stream_track.Minimum = 0;
            this.stream_track.Name = "stream_track";
            this.stream_track.Size = new System.Drawing.Size(368, 17);
            this.stream_track.TabIndex = 2;
            this.stream_track.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.stream_track.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.stream_track.TickHeight = 1;
            this.stream_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.stream_track.TrackerColor = System.Drawing.Color.DimGray;
            this.stream_track.TrackerSize = new System.Drawing.Size(5, 5);
            this.stream_track.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.stream_track.TrackLineHeight = 1;
            this.stream_track.Value = 0;
            this.stream_track.Scroll += new System.EventHandler(this.macTrackBar1_ValueChanged);
            // 
            // status_wplayer
            // 
            this.status_wplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_wplayer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.status_wplayer.ForeColor = System.Drawing.Color.Gray;
            this.status_wplayer.Location = new System.Drawing.Point(229, 2);
            this.status_wplayer.Name = "status_wplayer";
            this.status_wplayer.Size = new System.Drawing.Size(138, 14);
            this.status_wplayer.TabIndex = 10;
            this.status_wplayer.Text = "status";
            this.status_wplayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.status_wplayer.Visible = false;
            // 
            // pic_loading
            // 
            this.pic_loading.BackColor = System.Drawing.Color.Transparent;
            this.pic_loading.Image = global::Nob2.Properties.Resources.loading;
            this.pic_loading.Location = new System.Drawing.Point(163, 16);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(24, 23);
            this.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_loading.TabIndex = 8;
            this.pic_loading.TabStop = false;
            this.pic_loading.Visible = false;
            this.pic_loading.Click += new System.EventHandler(this.pic_loading_Click);
            // 
            // search_text
            // 
            this.search_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_text.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.Location = new System.Drawing.Point(17, 20);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(147, 15);
            this.search_text.TabIndex = 0;
            this.search_text.GotFocus += new System.EventHandler(this.search_text_Down);
            this.search_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_text_KeyPress);
            this.search_text.LostFocus += new System.EventHandler(this.search_text_Leave);
            // 
            // volume_track
            // 
            this.volume_track.BackColor = System.Drawing.Color.Transparent;
            this.volume_track.BorderColor = System.Drawing.Color.Transparent;
            this.volume_track.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume_track.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.volume_track.IndentHeight = 6;
            this.volume_track.LargeChange = 1;
            this.volume_track.Location = new System.Drawing.Point(310, 16);
            this.volume_track.Maximum = 100;
            this.volume_track.Minimum = 0;
            this.volume_track.Name = "volume_track";
            this.volume_track.Size = new System.Drawing.Size(102, 20);
            this.volume_track.TabIndex = 11;
            this.volume_track.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_track.TickColor = System.Drawing.Color.Black;
            this.volume_track.TickHeight = 1;
            this.volume_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_track.TrackerColor = System.Drawing.Color.White;
            this.volume_track.TrackerSize = new System.Drawing.Size(8, 8);
            this.volume_track.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.volume_track.TrackLineHeight = 8;
            this.volume_track.Value = 70;
            this.volume_track.Scroll += new System.EventHandler(this.volume_track_ValueChanged);
            // 
            // fondo_search
            // 
            this.fondo_search.Image = global::Nob2.Properties.Resources.search1;
            this.fondo_search.Location = new System.Drawing.Point(-1, -1);
            this.fondo_search.Name = "fondo_search";
            this.fondo_search.Size = new System.Drawing.Size(199, 54);
            this.fondo_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fondo_search.TabIndex = 15;
            this.fondo_search.TabStop = false;
            // 
            // stop_search
            // 
            this.stop_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_search.BackgroundImage = global::Nob2.Properties.Resources.control_stop_square;
            this.stop_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop_search.Location = new System.Drawing.Point(761, 464);
            this.stop_search.Name = "stop_search";
            this.stop_search.Size = new System.Drawing.Size(24, 24);
            this.stop_search.TabIndex = 8;
            this.stop_search.UseVisualStyleBackColor = true;
            this.stop_search.Visible = false;
            this.stop_search.Click += new System.EventHandler(this.stop_search_Click);
            // 
            // exclude
            // 
            this.exclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exclude.AutoSize = true;
            this.exclude.Location = new System.Drawing.Point(163, 470);
            this.exclude.Name = "exclude";
            this.exclude.Size = new System.Drawing.Size(103, 17);
            this.exclude.TabIndex = 5;
            this.exclude.Text = "Excluir repetidas";
            this.exclude.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 487);
            this.Controls.Add(this.exclude);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stop_search);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(801, 400);
            this.Name = "Principal";
            this.Text = "Nob 2";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lupa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_picture)).EndInit();
            this.title_container.ResumeLayout(false);
            this.title_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.down_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel title_container;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.ColumnHeader col_title;
        private System.Windows.Forms.ColumnHeader col_com;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pic_loading;
        private System.Windows.Forms.Button stop_search;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label status_wplayer;
        private System.Windows.Forms.Timer timer_status;
        private System.Windows.Forms.ImageList iconos;
        private EConTech.Windows.MACUI.MACTrackBar stream_track;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EConTech.Windows.MACUI.MACTrackBar volume_track;
        private System.Windows.Forms.PictureBox down_image;
        private System.Windows.Forms.PictureBox play_picture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox exclude;
        private System.Windows.Forms.PictureBox fondo_search;
        private System.Windows.Forms.PictureBox lupa;
    }
}

