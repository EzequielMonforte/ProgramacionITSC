using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
	public class Global : HttpApplication
	{
		void Application_Start(object sender, EventArgs e)
		{
			// Code that runs on application startup
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			WebApplication1.User.Login = "ITSC";
			WebApplication1.User.Password = "ProgramacionIII";
			WebApplication1.User.NombreUsuario= "Alumno/a";
		}
		void Session_Start(object sender, EventArgs e)
		{
			UserCounter.UsersAccessed += 1;
			Session["recharge"] = 0;
		}
	}
}