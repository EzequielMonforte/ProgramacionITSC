using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
	public partial class Form1 : Form
	{
		private readonly DBServices dBServices;
		public Form1()
		{
			InitializeComponent();
			dBServices = new DBServices();
			CargarListaTarjetas();
			
		}

		private void CargarListaTarjetas()
		{
			var tarjetas= dBServices.GetTarjetas();
			foreach (var tarjeta in tarjetas)
			{
				ListaPersonas.Items.Add(tarjeta);
			}
		}

		private void BTAddPerson_Click(object sender, EventArgs e)
		{
			Form n = new NewTarjeta();
			n.ShowDialog();
			ListaPersonas.Items.Clear();
			CargarListaTarjetas();
		}

		private void ListaPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			TarjetaPersona form = new TarjetaPersona(ListaPersonas.SelectedItem as Models.Tarjeta);
			form.ShowDialog();
			ListaPersonas.Items.Clear();
			CargarListaTarjetas();
		}

		private void ListaPersonas_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
