namespace ProductPrecio
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
			this.btAgregar = new System.Windows.Forms.Button();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bt_ordenaAlf = new System.Windows.Forms.Button();
			this.bt_ordenPrecio = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btAgregar
			// 
			this.btAgregar.Location = new System.Drawing.Point(264, 49);
			this.btAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btAgregar.Name = "btAgregar";
			this.btAgregar.Size = new System.Drawing.Size(100, 28);
			this.btAgregar.TabIndex = 2;
			this.btAgregar.TabStop = false;
			this.btAgregar.Text = "&Agregar";
			this.btAgregar.UseVisualStyleBackColor = true;
			this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
			// 
			// txtProducto
			// 
			this.txtProducto.AccessibleDescription = "";
			this.txtProducto.AccessibleName = "";
			this.txtProducto.Location = new System.Drawing.Point(17, 16);
			this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(232, 22);
			this.txtProducto.TabIndex = 0;
			this.txtProducto.Tag = "";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(285, 15);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(76, 22);
			this.txtPrecio.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 49);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 3;
			// 
			// bt_ordenaAlf
			// 
			this.bt_ordenaAlf.Location = new System.Drawing.Point(263, 175);
			this.bt_ordenaAlf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_ordenaAlf.Name = "bt_ordenaAlf";
			this.bt_ordenaAlf.Size = new System.Drawing.Size(100, 28);
			this.bt_ordenaAlf.TabIndex = 4;
			this.bt_ordenaAlf.Text = "&Alfabeticamente";
			this.bt_ordenaAlf.UseVisualStyleBackColor = true;
			this.bt_ordenaAlf.Click += new System.EventHandler(this.button1_Click);
			// 
			// bt_ordenPrecio
			// 
			this.bt_ordenPrecio.Location = new System.Drawing.Point(263, 127);
			this.bt_ordenPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_ordenPrecio.Name = "bt_ordenPrecio";
			this.bt_ordenPrecio.Size = new System.Drawing.Size(100, 28);
			this.bt_ordenPrecio.TabIndex = 3;
			this.bt_ordenPrecio.Text = "&Precio";
			this.bt_ordenPrecio.UseVisualStyleBackColor = true;
			this.bt_ordenPrecio.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(260, 106);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Ordenar por:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(17, 49);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(232, 154);
			this.textBox1.TabIndex = 5;
			this.textBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Precio total: ";
			// 
			// Form1
			// 
			this.AcceptButton = this.btAgregar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 242);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bt_ordenPrecio);
			this.Controls.Add(this.bt_ordenaAlf);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.btAgregar);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bt_ordenaAlf;
		private System.Windows.Forms.Button bt_ordenPrecio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
	}
}

