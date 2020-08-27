using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class Ejercicio3 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Unnamed_Click(object sender, EventArgs e)
		{
			if (login.Text == WebApplication1.User.Login && password.Text == WebApplication1.User.Password)
				result.Text = "Bienvenido/a " + WebApplication1.User.NombreUsuario;
			else 
			{
				result.Text = "Datos incorrectos";
				login.Text = "";
				password.Text = "";
			}
		}
	}
}