using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjDataGridView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DgvHorario.MultiSelect = false;
			
		}

		private void SetRowName(int i, int rownum)
		{
			DgvHorario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			DgvHorario.Rows.Add();
			DgvHorario.Rows[rownum].HeaderCell.Value = i+":00";

		}

		private void SetColName(string day)
		{
			DgvHorario.Columns.Add(day, day);
		}


		private void BtChargeDgv_Click(object sender, EventArgs e)
		{
			if (DgvHorario.Rows.Count == 0)
			{
				SetColName("Lunes");
				SetColName("Martes");
				SetColName("Miercoles");
				SetColName("Jueves");
				SetColName("Viernes");
				SetColName("Sabado");
				SetColName("Domingo");
				int j = 0;
				for (int i = 8; i < 15; i++)
				{
					SetRowName(i, j);
					j++;
				}
			}
		}

		private void BtInsertarMateria_Click(object sender, EventArgs e)
		{
			try
			{
				DgvHorario.SelectedCells[0].Value = TxBMateria.Text;
			}
			catch (System.ArgumentOutOfRangeException) {
				MessageBox.Show("la tabla no fue cargada");
			}



		}
	}
}
