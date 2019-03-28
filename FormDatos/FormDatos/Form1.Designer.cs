namespace FormDatos
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(100, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Nombre";
			this.textBox1.Click += new System.EventHandler(this.textBox_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(100, 92);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Apellido";
			this.textBox2.Click += new System.EventHandler(this.textBox_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(100, 196);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "NroDNI";
			this.textBox4.Click += new System.EventHandler(this.textBox_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(100, 289);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "Direccion";
			this.textBox5.Click += new System.EventHandler(this.textBox_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(100, 345);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 22);
			this.textBox6.TabIndex = 5;
			this.textBox6.Text = "Cuit / Cuil";
			this.textBox6.Click += new System.EventHandler(this.textBox_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(100, 243);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 6;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateSelected);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(206, 289);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(42, 22);
			this.textBox7.TabIndex = 7;
			this.textBox7.Text = "Nro";
			this.textBox7.Click += new System.EventHandler(this.textBox_Click);
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(254, 289);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(69, 22);
			this.textBox8.TabIndex = 8;
			this.textBox8.Text = "Barrio";
			this.textBox8.Click += new System.EventHandler(this.textBox_Click);
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(329, 289);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 22);
			this.textBox9.TabIndex = 9;
			this.textBox9.Text = "Provincia";
			this.textBox9.Click += new System.EventHandler(this.textBox_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(307, 247);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 10;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(100, 143);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 11;
			this.comboBox1.Text = "TipoDNI";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

