namespace apispruebas2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtNombrePoke = new System.Windows.Forms.TextBox();
            this.lblNombrePoke = new System.Windows.Forms.Label();
            this.lblPesoPoke = new System.Windows.Forms.Label();
            this.lblAlturaPoke = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ApiPokemon";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(50, 79);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 33);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtNombrePoke
            // 
            this.txtNombrePoke.Location = new System.Drawing.Point(23, 38);
            this.txtNombrePoke.Name = "txtNombrePoke";
            this.txtNombrePoke.Size = new System.Drawing.Size(163, 26);
            this.txtNombrePoke.TabIndex = 2;
            // 
            // lblNombrePoke
            // 
            this.lblNombrePoke.AutoSize = true;
            this.lblNombrePoke.Location = new System.Drawing.Point(3, 128);
            this.lblNombrePoke.Name = "lblNombrePoke";
            this.lblNombrePoke.Size = new System.Drawing.Size(69, 20);
            this.lblNombrePoke.TabIndex = 3;
            this.lblNombrePoke.Text = "Nombre:";
            // 
            // lblPesoPoke
            // 
            this.lblPesoPoke.AutoSize = true;
            this.lblPesoPoke.Location = new System.Drawing.Point(7, 166);
            this.lblPesoPoke.Name = "lblPesoPoke";
            this.lblPesoPoke.Size = new System.Drawing.Size(49, 20);
            this.lblPesoPoke.TabIndex = 4;
            this.lblPesoPoke.Text = "Peso:";
            // 
            // lblAlturaPoke
            // 
            this.lblAlturaPoke.AutoSize = true;
            this.lblAlturaPoke.Location = new System.Drawing.Point(3, 206);
            this.lblAlturaPoke.Name = "lblAlturaPoke";
            this.lblAlturaPoke.Size = new System.Drawing.Size(55, 20);
            this.lblAlturaPoke.TabIndex = 5;
            this.lblAlturaPoke.Text = "Altura:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(243, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 362);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(755, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(577, 413);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 41);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(648, 474);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(183, 66);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar resultados del Pokemon";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Red;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrar.Location = new System.Drawing.Point(689, 546);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(119, 48);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "Api Extra ";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 631);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAlturaPoke);
            this.Controls.Add(this.lblPesoPoke);
            this.Controls.Add(this.lblNombrePoke);
            this.Controls.Add(this.txtNombrePoke);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtNombrePoke;
        private System.Windows.Forms.Label lblNombrePoke;
        private System.Windows.Forms.Label lblPesoPoke;
        private System.Windows.Forms.Label lblAlturaPoke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnEntrar;
    }
}

