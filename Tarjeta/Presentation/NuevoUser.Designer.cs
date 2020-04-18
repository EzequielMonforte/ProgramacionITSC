namespace Presentation
{
	partial class NuevoUser
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
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxDNI = new System.Windows.Forms.TextBox();
			this.textBoxCuit = new System.Windows.Forms.TextBox();
			this.ype = new System.Windows.Forms.ComboBox();
			this.genre = new System.Windows.Forms.ComboBox();
			this.fborn = new System.Windows.Forms.DateTimePicker();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(113, 35);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(201, 22);
			this.textBoxNombre.TabIndex = 0;
			// 
			// textBoxDNI
			// 
			this.textBoxDNI.Location = new System.Drawing.Point(113, 127);
			this.textBoxDNI.Name = "textBoxDNI";
			this.textBoxDNI.Size = new System.Drawing.Size(201, 22);
			this.textBoxDNI.TabIndex = 2;
			// 
			// textBoxCuit
			// 
			this.textBoxCuit.Location = new System.Drawing.Point(113, 272);
			this.textBoxCuit.Name = "textBoxCuit";
			this.textBoxCuit.Size = new System.Drawing.Size(201, 22);
			this.textBoxCuit.TabIndex = 5;
			// 
			// ype
			// 
			this.ype.FormattingEnabled = true;
			this.ype.Items.AddRange(new object[] {
            "Dni",
            "Passport"});
			this.ype.Location = new System.Drawing.Point(113, 82);
			this.ype.Name = "ype";
			this.ype.Size = new System.Drawing.Size(201, 24);
			this.ype.TabIndex = 8;
			// 
			// genre
			// 
			this.genre.FormattingEnabled = true;
			this.genre.Items.AddRange(new object[] {
            "Fem",
            "Masc"});
			this.genre.Location = new System.Drawing.Point(113, 174);
			this.genre.Name = "genre";
			this.genre.Size = new System.Drawing.Size(201, 24);
			this.genre.TabIndex = 9;
			// 
			// fborn
			// 
			this.fborn.Location = new System.Drawing.Point(113, 218);
			this.fborn.Name = "fborn";
			this.fborn.Size = new System.Drawing.Size(201, 22);
			this.fborn.TabIndex = 10;
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Location = new System.Drawing.Point(239, 350);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
			this.buttonGuardar.TabIndex = 11;
			this.buttonGuardar.Text = "Guardar";
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 17);
			this.label1.TabIndex = 12;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "Tipo Doc";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 17);
			this.label3.TabIndex = 14;
			this.label3.Text = "Doc";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 17);
			this.label4.TabIndex = 15;
			this.label4.Text = "Genero";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 17);
			this.label5.TabIndex = 16;
			this.label5.Text = "Nacimiento";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 275);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 17);
			this.label6.TabIndex = 17;
			this.label6.Text = "Cuit";
			// 
			// NuevoUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 399);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.fborn);
			this.Controls.Add(this.genre);
			this.Controls.Add(this.ype);
			this.Controls.Add(this.textBoxCuit);
			this.Controls.Add(this.textBoxDNI);
			this.Controls.Add(this.textBoxNombre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "NuevoUser";
			this.Text = "NuevoUser";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxDNI;
		private System.Windows.Forms.TextBox textBoxCuit;
		private System.Windows.Forms.ComboBox ype;
		private System.Windows.Forms.ComboBox genre;
		private System.Windows.Forms.DateTimePicker fborn;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}