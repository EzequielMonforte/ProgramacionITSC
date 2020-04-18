using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Presentation
{
	public partial class NuevoUser : Form
	{
		DBServices DBServices;
		public NuevoUser(string text)
		{
			
			InitializeComponent();
			textBoxDNI.Text = text;


		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
			DBServices = new DBServices();
			Models.Person p = new Models.Person();
			p.Born = fborn.Value;
			p.Cuit = textBoxCuit.Text;
			p.Dni = textBoxDNI.Text;
			p.Genre = genre.Text;
			p.Name = textBoxNombre.Text;
			p.Tipo = ype.Text;
			DBServices.AddPersona(p);
			this.Close();
		}
	}
}
