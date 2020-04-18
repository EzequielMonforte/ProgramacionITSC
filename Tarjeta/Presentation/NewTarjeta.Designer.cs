namespace Presentation
{
	partial class NewTarjeta
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
			this.textBoxNro = new System.Windows.Forms.TextBox();
			this.textBoxDni = new System.Windows.Forms.TextBox();
			this.cmTipoTarjeta = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonPer = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxNro
			// 
			this.textBoxNro.Location = new System.Drawing.Point(100, 29);
			this.textBoxNro.Name = "textBoxNro";
			this.textBoxNro.Size = new System.Drawing.Size(234, 22);
			this.textBoxNro.TabIndex = 0;
			// 
			// textBoxDni
			// 
			this.textBoxDni.Location = new System.Drawing.Point(100, 78);
			this.textBoxDni.Name = "textBoxDni";
			this.textBoxDni.Size = new System.Drawing.Size(234, 22);
			this.textBoxDni.TabIndex = 1;
			// 
			// cmTipoTarjeta
			// 
			this.cmTipoTarjeta.FormattingEnabled = true;
			this.cmTipoTarjeta.Location = new System.Drawing.Point(100, 124);
			this.cmTipoTarjeta.Name = "cmTipoTarjeta";
			this.cmTipoTarjeta.Size = new System.Drawing.Size(234, 24);
			this.cmTipoTarjeta.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(259, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 31);
			this.button1.TabIndex = 3;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 4;
			// 
			// buttonPer
			// 
			this.buttonPer.Location = new System.Drawing.Point(26, 207);
			this.buttonPer.Name = "buttonPer";
			this.buttonPer.Size = new System.Drawing.Size(112, 31);
			this.buttonPer.TabIndex = 5;
			this.buttonPer.Text = "Agregar Pers";
			this.buttonPer.UseVisualStyleBackColor = true;
			this.buttonPer.Visible = false;
			this.buttonPer.Click += new System.EventHandler(this.buttonPer_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nro Tar.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Doc";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Tipo Tar.";
			// 
			// NewTarjeta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 272);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonPer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmTipoTarjeta);
			this.Controls.Add(this.textBoxDni);
			this.Controls.Add(this.textBoxNro);
			this.Name = "NewTarjeta";
			this.Text = "NewTarjeta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxNro;
		private System.Windows.Forms.TextBox textBoxDni;
		private System.Windows.Forms.ComboBox cmTipoTarjeta;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}