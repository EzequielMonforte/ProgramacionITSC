using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Models;

namespace Business
{
    public class DBServices
    {
		private Context context;

		public DBServices()
		{
			context = new Context();
			context.Configuration.LazyLoadingEnabled = true;
		}
		public void AddPersona(Person x) {
			context.Personas.Add(x);
			context.SaveChanges();
		}
		public List<Person> GetPersonas() {
			return context.Personas.ToList();
		}

		public List<Tarjeta> GetTarjetas() {
			return context.Tarjetas.Include("persona").ToList();
		}

		public void AddTarjeta(Tarjeta x)
		{
			context.Tarjetas.Add(x);
			context.SaveChanges();
		}
		public Tarjeta CargarTarjeta(Tarjeta x, double d)
		{
			var t = context.Tarjetas.First<Tarjeta>(a => a.NroTarjeta == x.NroTarjeta);
			t.Saldo += d;
			context.SaveChanges();
			return t;
		}

		public Person GetPersona(string text)
		{
			var p= context.Personas.Single<Person>(x => x.Dni == text);
			return p;
		}
	}
}
