namespace Calc2
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
            this.TxSal = new System.Windows.Forms.TextBox();
            this.TxEnt = new System.Windows.Forms.TextBox();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnRes = new System.Windows.Forms.Button();
            this.BtnIgu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxSal
            // 
            this.TxSal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxSal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSal.Location = new System.Drawing.Point(5, 5);
            this.TxSal.Multiline = true;
            this.TxSal.Name = "TxSal";
            this.TxSal.ReadOnly = true;
            this.TxSal.Size = new System.Drawing.Size(280, 95);
            this.TxSal.TabIndex = 1;
            this.TxSal.TextChanged += new System.EventHandler(this.TxSal_TextChanged);
            // 
            // TxEnt
            // 
            this.TxEnt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxEnt.Location = new System.Drawing.Point(5, 105);
            this.TxEnt.Name = "TxEnt";
            this.TxEnt.Size = new System.Drawing.Size(280, 22);
            this.TxEnt.TabIndex = 0;
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(205, 145);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(20, 20);
            this.BtnSum.TabIndex = 2;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnRes
            // 
            this.BtnRes.Location = new System.Drawing.Point(225, 145);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(20, 20);
            this.BtnRes.TabIndex = 3;
            this.BtnRes.Text = "-";
            this.BtnRes.UseVisualStyleBackColor = true;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // BtnIgu
            // 
            this.BtnIgu.Location = new System.Drawing.Point(265, 130);
            this.BtnIgu.Name = "BtnIgu";
            this.BtnIgu.Size = new System.Drawing.Size(20, 20);
            this.BtnIgu.TabIndex = 4;
            this.BtnIgu.Text = "=";
            this.BtnIgu.UseVisualStyleBackColor = true;
            this.BtnIgu.Click += new System.EventHandler(this.BtnIgu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.BtnIgu);
            this.Controls.Add(this.BtnRes);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.TxEnt);
            this.Controls.Add(this.TxSal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxSal;
        private System.Windows.Forms.TextBox TxEnt;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.Button BtnIgu;
    }
}

