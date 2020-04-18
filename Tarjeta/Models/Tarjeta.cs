using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Tarjeta
	{
		[Key]

		public int NroTarjeta { get; set; }
		public string TipoTarjeta { get; set; }

		public double Saldo { get; set; }
		public Person persona { get; set; }

		public override string ToString()
		{
			return $"{persona.Name}-{NroTarjeta.ToString()}-${Saldo}";
		}
		public void CargarTarjeta(double charge) {
			this.Saldo += charge;
		}
	}
}