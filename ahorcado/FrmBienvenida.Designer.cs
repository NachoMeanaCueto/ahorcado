namespace ahorcado
{
    partial class FrmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienvenida));
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labPrueba = new System.Windows.Forms.Label();
            this.labSiguenos = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcbGo = new System.Windows.Forms.PictureBox();
            this.pcbTuit = new System.Windows.Forms.PictureBox();
            this.pcbFace = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(122, 146);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(152, 47);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "&Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(122, 208);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 47);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labPrueba
            // 
            this.labPrueba.AutoSize = true;
            this.labPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrueba.Location = new System.Drawing.Point(107, 268);
            this.labPrueba.Name = "labPrueba";
            this.labPrueba.Size = new System.Drawing.Size(186, 32);
            this.labPrueba.TabIndex = 4;
            this.labPrueba.Text = "Pon a prueba tus habilidades \r\ncon mas de 80.000 palabras ";
            // 
            // labSiguenos
            // 
            this.labSiguenos.AutoSize = true;
            this.labSiguenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSiguenos.Location = new System.Drawing.Point(321, 357);
            this.labSiguenos.Name = "labSiguenos";
            this.labSiguenos.Size = new System.Drawing.Size(86, 16);
            this.labSiguenos.TabIndex = 6;
            this.labSiguenos.Text = "Siguenos en:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ahorcado.Properties.Resources.bienvenido;
            this.pictureBox3.Location = new System.Drawing.Point(47, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(308, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pcbGo
            // 
            this.pcbGo.Image = global::ahorcado.Properties.Resources.g_;
            this.pcbGo.Location = new System.Drawing.Point(392, 385);
            this.pcbGo.Name = "pcbGo";
            this.pcbGo.Size = new System.Drawing.Size(40, 38);
            this.pcbGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGo.TabIndex = 9;
            this.pcbGo.TabStop = false;
            this.pcbGo.Click += new System.EventHandler(this.pcbGo_Click);
            // 
            // pcbTuit
            // 
            this.pcbTuit.Image = global::ahorcado.Properties.Resources.tuiter;
            this.pcbTuit.Location = new System.Drawing.Point(345, 385);
            this.pcbTuit.Name = "pcbTuit";
            this.pcbTuit.Size = new System.Drawing.Size(40, 38);
            this.pcbTuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTuit.TabIndex = 8;
            this.pcbTuit.TabStop = false;
            this.pcbTuit.Click += new System.EventHandler(this.pcbTuit_Click);
            // 
            // pcbFace
            // 
            this.pcbFace.Image = global::ahorcado.Properties.Resources.face;
            this.pcbFace.Location = new System.Drawing.Point(299, 385);
            this.pcbFace.Name = "pcbFace";
            this.pcbFace.Size = new System.Drawing.Size(40, 38);
            this.pcbFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFace.TabIndex = 7;
            this.pcbFace.TabStop = false;
            this.pcbFace.Click += new System.EventHandler(this.pcbFace_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ahorcado.Properties.Resources.DamGames1;
            this.pictureBox2.Location = new System.Drawing.Point(2, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ahorcado.Properties.Resources.ahorc;
            this.pictureBox1.Location = new System.Drawing.Point(345, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(437, 448);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pcbGo);
            this.Controls.Add(this.pcbTuit);
            this.Controls.Add(this.pcbFace);
            this.Controls.Add(this.labSiguenos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labPrueba);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labPrueba;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labSiguenos;
        private System.Windows.Forms.PictureBox pcbFace;
        private System.Windows.Forms.PictureBox pcbTuit;
        private System.Windows.Forms.PictureBox pcbGo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}