namespace ahorcado
{
    partial class FrmPerder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerder));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labPalabra = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbPerder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 292);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(148, 49);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "&Volver a jugar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(207, 292);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 49);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labPalabra
            // 
            this.labPalabra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labPalabra.AutoEllipsis = true;
            this.labPalabra.AutoSize = true;
            this.labPalabra.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.labPalabra.Location = new System.Drawing.Point(74, 241);
            this.labPalabra.Name = "labPalabra";
            this.labPalabra.Size = new System.Drawing.Size(221, 36);
            this.labPalabra.TabIndex = 2;
            this.labPalabra.Text = "democratacristiano";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.labTitulo.Location = new System.Drawing.Point(117, 210);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(132, 28);
            this.labTitulo.TabIndex = 3;
            this.labTitulo.Text = "La palabra era:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ahorcado.Properties.Resources.Perder;
            this.pictureBox1.Location = new System.Drawing.Point(28, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pcbPerder
            // 
            this.pcbPerder.Image = global::ahorcado.Properties.Resources.ahorc;
            this.pcbPerder.Location = new System.Drawing.Point(288, 1);
            this.pcbPerder.Name = "pcbPerder";
            this.pcbPerder.Size = new System.Drawing.Size(80, 237);
            this.pcbPerder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPerder.TabIndex = 4;
            this.pcbPerder.TabStop = false;
            // 
            // FrmPerder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(367, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbPerder);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.labPalabra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "has perdido";
            this.Load += new System.EventHandler(this.FrmPerder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labPalabra;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.PictureBox pcbPerder;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}