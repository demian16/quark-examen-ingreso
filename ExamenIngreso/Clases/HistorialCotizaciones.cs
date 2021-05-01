using System;

namespace ExamenIngreso.Clases
{
	public class HistorialCotizaciones
	{
		public int IdHistorialCotizacion { get; set; }
		public int IdVendedor { get; set; }
		public double PrecioCotizacion { get; set; }
		public DateTime FechaHora { get; set; }
		public int Cantidad { get; set; }
		public Pantalon Pantalon { get; set; }
		public Camisa Camisa { get; set; }
	}
}
