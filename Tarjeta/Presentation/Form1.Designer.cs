namespace Presentation
{
	partial class Form1
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
			this.ListaPersonas = new System.Windows.Forms.ListBox();
			this.BTAddPerson = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ListaPersonas
			// 
			this.ListaPersonas.FormattingEnabled = true;
			this.ListaPersonas.ItemHeight = 16;
			this.ListaPersonas.Location = new System.Drawing.Point(12, 12);
			this.ListaPersonas.Name = "ListaPersonas";
			this.ListaPersonas.Size = new System.Drawing.Size(267, 356);
			this.ListaPersonas.TabIndex = 0;
			this.ListaPersonas.SelectedIndexChanged += new System.EventHandler(this.ListaPersonas_SelectedIndexChanged);
			this.ListaPersonas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListaPersonas_MouseDoubleClick);
			// 
			// BTAddPerson
			// 
			this.BTAddPerson.Location = new System.Drawing.Point(204, 374);
			this.BTAddPerson.Name = "BTAddPerson";
			this.BTAddPerson.Size = new System.Drawing.Size(75, 28);
			this.BTAddPerson.TabIndex = 1;
			this.BTAddPerson.Text = "Agregar";
			this.BTAddPerson.UseVisualStyleBackColor = true;
			this.BTAddPerson.Click += new System.EventHandler(this.BTAddPerson_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 431);
			this.Controls.Add(this.BTAddPerson);
			this.Controls.Add(this.ListaPersonas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox ListaPersonas;
		private System.Windows.Forms.Button BTAddPerson;
	}
}

