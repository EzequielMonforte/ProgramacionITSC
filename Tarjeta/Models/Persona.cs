using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Person
	{
		public Person() {
		
		}
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Dni { get; set; }
		public string Genre { get; set; }
		public DateTime Born { get; set; }
		public string Cuit { get; set; }
		public string Tipo { get; set; }
		public override string ToString()
		{
			return $"{Name}-{Dni}-{Age()}";
		}
		public string Age() {
			/*if (Born == null) return "edad indefinida";
					 else
						 return (DateTime.Now - Born).ToString();
							 */
		int edad = DateTime.Today.AddTicks(-Born.Ticks).Year - 1;
			return edad.ToString();
		}


	}
}
