using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class Ejercicio2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int n = int.Parse(Session["recharge"].ToString());
			if (IsPostBack) Session["recharge"] = n+1;
			ReloadCount.Text = Session["recharge"].ToString();
			UsersCount.Text = UserCounter.UsersAccessed.ToString();
		}
	}
}