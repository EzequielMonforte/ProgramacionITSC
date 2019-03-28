using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDatos
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}



		private void textBox_Click(object sender, EventArgs e)
		{
			TextBox a = sender as TextBox;
			a.Text = "";
		}

		private void DateSelected(object sender, EventArgs e)
		{
			DateTimePicker a = sender as DateTimePicker;
			DateTime date = a.Value;
			int days=date.Subtract(DateTime.Now).Days;

			label1.Text = Math.Abs(days / 365).ToString()+ " años";
		}
	}
}
