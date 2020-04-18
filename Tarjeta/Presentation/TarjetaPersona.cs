using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Presentation
{
	public partial class TarjetaPersona : Form
	{
		Business.DBServices DBServices;
		Models.Tarjeta tarjeta;
		public TarjetaPersona(Models.Tarjeta p)
		{
			InitializeComponent();
			tarjeta = p;
			RellenarForm(p);
			DBServices = new Business.DBServices();
		}

		private void RellenarForm(Tarjeta t)
		{
			labelDNI.Text = t.persona.Dni;
			labelName.Text = t.persona.Name;
			labelTipo.Text = t.persona.Tipo +":";
			labelEdad.Text = "Edad: " + t.persona.Age();
			labelSaldo.Text = "Saldo: $"+t.Saldo.ToString();
		}

		private void Cargar_Click(object sender, EventArgs e)
		{
			try
			{
				var t= DBServices.CargarTarjeta(tarjeta, double.Parse(textBox1.Text));
				tarjeta.Saldo = t.Saldo;
				RellenarForm(tarjeta);
			}
			catch (Exception)
			{

				throw;
			}
			
		}
	}
}
