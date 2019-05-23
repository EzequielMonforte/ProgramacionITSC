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
			SetColName("");
			SetColName("Lunes");
			SetColName("Martes");
			SetColName("Miercoles");
			SetColName("Jueves");
			SetColName("Viernes");
			SetColName("Sabado");
			SetColName("Domingo");

			for (int i = 8; i < 15; i++)
			{
				SetRowName(i);
			}
			
		}

		private void SetRowName(int i)
		{
			
			DgvHorario.Rows.Add(i+":00");
		}

		private void SetColName(string day)
		{
			DgvHorario.Columns.Add(day, day);
		}
	}
}
