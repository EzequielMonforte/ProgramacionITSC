using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class Ejercicio1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) label.Text = "“Hola Mundo - Es la primera vez que se ha cargado la página";
			else label.Text = "Esta página ya ha sido visitada";

		}

		protected void button_Click(object sender, EventArgs e)
		{
			Page_Load(sender, e);
		}
	}
}