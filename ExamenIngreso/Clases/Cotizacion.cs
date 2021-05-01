using System;

namespace ExamenIngreso.Clases
{
	public class Cotizacion
	{
		public int IdCotizacion { get; set; } //Numero Identificacion
		public DateTime FechaHora { get; set; }
		public int IdVendedor { get; set; }
		public int IdPrenda { get; set; }
		public int Cantidad { get; set; }
		public double ResultadoCotizacion { get; set; }
	}
}
