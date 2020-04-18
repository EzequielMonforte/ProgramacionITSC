namespace Presentation
{
	partial class TarjetaPersona
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
			this.labelName = new System.Windows.Forms.Label();
			this.labelDNI = new System.Windows.Forms.Label();
			this.labelTipo = new System.Windows.Forms.Label();
			this.labelEdad = new System.Windows.Forms.Label();
			this.labelSaldo = new System.Windows.Forms.Label();
			this.Cargar = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 19);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(75, 17);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "labelName";
			// 
			// labelDNI
			// 
			this.labelDNI.AutoSize = true;
			this.labelDNI.Location = new System.Drawing.Point(64, 46);
			this.labelDNI.Name = "labelDNI";
			this.labelDNI.Size = new System.Drawing.Size(61, 17);
			this.labelDNI.TabIndex = 1;
			this.labelDNI.Text = "labelDNI";
			// 
			// labelTipo
			// 
			this.labelTipo.AutoSize = true;
			this.labelTipo.Location = new System.Drawing.Point(12, 46);
			this.labelTipo.Name = "labelTipo";
			this.labelTipo.Size = new System.Drawing.Size(46, 17);
			this.labelTipo.TabIndex = 2;
			this.labelTipo.Text = "label1";
			// 
			// labelEdad
			// 
			this.labelEdad.AutoSize = true;
			this.labelEdad.Location = new System.Drawing.Point(106, 19);
			this.labelEdad.Name = "labelEdad";
			this.labelEdad.Size = new System.Drawing.Size(0, 17);
			this.labelEdad.TabIndex = 3;
			// 
			// labelSaldo
			// 
			this.labelSaldo.AutoSize = true;
			this.labelSaldo.Location = new System.Drawing.Point(15, 99);
			this.labelSaldo.Name = "labelSaldo";
			this.labelSaldo.Size = new System.Drawing.Size(52, 17);
			this.labelSaldo.TabIndex = 4;
			this.labelSaldo.Text = "Saldo: ";
			// 
			// Cargar
			// 
			this.Cargar.Location = new System.Drawing.Point(220, 177);
			this.Cargar.Name = "Cargar";
			this.Cargar.Size = new System.Drawing.Size(75, 23);
			this.Cargar.TabIndex = 5;
			this.Cargar.Text = "Cargar";
			this.Cargar.UseVisualStyleBackColor = true;
			this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(67, 177);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(147, 22);
			this.textBox1.TabIndex = 6;
			// 
			// TarjetaPersona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Cargar);
			this.Controls.Add(this.labelSaldo);
			this.Controls.Add(this.labelEdad);
			this.Controls.Add(this.labelTipo);
			this.Controls.Add(this.labelDNI);
			this.Controls.Add(this.labelName);
			this.Name = "TarjetaPersona";
			this.Text = "TarjetaPersona";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelDNI;
		private System.Windows.Forms.Label labelTipo;
		private System.Windows.Forms.Label labelEdad;
		private System.Windows.Forms.Label labelSaldo;
		private System.Windows.Forms.Button Cargar;
		private System.Windows.Forms.TextBox textBox1;
	}
}