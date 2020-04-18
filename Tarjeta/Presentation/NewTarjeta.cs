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
	public partial class NewTarjeta : Form
	{
		Business.DBServices DBServices;
		public NewTarjeta()
		{
			InitializeComponent();
			DBServices = new Business.DBServices();
			cmTipoTarjeta.Items.AddRange(Enum.GetNames(typeof(Business.CONTSANTS.TipoTarjeta)));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var tarjeta = new Models.Tarjeta();
			try
			{
				tarjeta.persona = DBServices.GetPersona(textBoxDni.Text);
				tarjeta.NroTarjeta = int.Parse(textBoxNro.Text);
			}
			catch (FormatException)
			{
				MostrarError("El Nro de tarjeta debe ser un Numero");
				return;
			}
			catch (Exception){
				MostrarError("La persona no esta registrada");
				buttonPer.Visible = true;
				return;
			}
			
			tarjeta.TipoTarjeta = cmTipoTarjeta.SelectedItem.ToString();
			if (tarjeta.TipoTarjeta != "")
			try
			{
				DBServices.AddTarjeta(tarjeta);
			}
			catch (Exception)
			{
				MostrarError("Error en la base de datos");
				return;
			}
			this.Close();

		}

		private void MostrarError(string err) {
			label1.Text = err;
		}

		private void buttonPer_Click(object sender, EventArgs e)
		{
			Form a = new NuevoUser(textBoxDni.Text);
			a.ShowDialog();
			label1.Text = "";
		}
	}
}
