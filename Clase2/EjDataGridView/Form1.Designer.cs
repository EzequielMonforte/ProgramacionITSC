namespace EjDataGridView
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
			this.DgvHorario = new System.Windows.Forms.DataGridView();
			this.BtChargeDgv = new System.Windows.Forms.Button();
			this.TxBMateria = new System.Windows.Forms.TextBox();
			this.BtInsertarMateria = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgvHorario)).BeginInit();
			this.SuspendLayout();
			// 
			// DgvHorario
			// 
			this.DgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvHorario.Location = new System.Drawing.Point(29, 53);
			this.DgvHorario.Name = "DgvHorario";
			this.DgvHorario.RowTemplate.Height = 24;
			this.DgvHorario.Size = new System.Drawing.Size(725, 288);
			this.DgvHorario.TabIndex = 0;
			// 
			// BtChargeDgv
			// 
			this.BtChargeDgv.Location = new System.Drawing.Point(597, 393);
			this.BtChargeDgv.Name = "BtChargeDgv";
			this.BtChargeDgv.Size = new System.Drawing.Size(75, 23);
			this.BtChargeDgv.TabIndex = 1;
			this.BtChargeDgv.Text = "Cargar";
			this.BtChargeDgv.UseVisualStyleBackColor = true;
			this.BtChargeDgv.Click += new System.EventHandler(this.BtChargeDgv_Click);
			// 
			// TxBMateria
			// 
			this.TxBMateria.Location = new System.Drawing.Point(29, 393);
			this.TxBMateria.Name = "TxBMateria";
			this.TxBMateria.Size = new System.Drawing.Size(219, 22);
			this.TxBMateria.TabIndex = 2;
			// 
			// BtInsertarMateria
			// 
			this.BtInsertarMateria.Location = new System.Drawing.Point(255, 393);
			this.BtInsertarMateria.Name = "BtInsertarMateria";
			this.BtInsertarMateria.Size = new System.Drawing.Size(75, 23);
			this.BtInsertarMateria.TabIndex = 3;
			this.BtInsertarMateria.Text = "Insertar";
			this.BtInsertarMateria.UseVisualStyleBackColor = true;
			this.BtInsertarMateria.Click += new System.EventHandler(this.BtInsertarMateria_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtInsertarMateria);
			this.Controls.Add(this.TxBMateria);
			this.Controls.Add(this.BtChargeDgv);
			this.Controls.Add(this.DgvHorario);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.DgvHorario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DgvHorario;
		private System.Windows.Forms.Button BtChargeDgv;
		private System.Windows.Forms.TextBox TxBMateria;
		private System.Windows.Forms.Button BtInsertarMateria;
	}
}

