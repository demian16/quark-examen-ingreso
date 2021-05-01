using ExamenIngreso.Clases;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExamenIngreso
{
	public partial class FormHistorial : Form
	{
		public FormHistorial()
		{
			InitializeComponent();
		}

		public FormHistorial(List<HistorialCotizaciones> historial, Vendedor vendedor)
		{
			InitializeComponent();

			var historialList = new List<Historial>();

			foreach (var row in historial)
			{
				var calidad = row.Pantalon != null
					? row.Pantalon.Calidad == (int)Form1.Calidad.Premium ? Form1.Calidad.Premium.ToString() : Form1.Calidad.Standard.ToString()
					: row.Camisa.Calidad == (int)Form1.Calidad.Premium ? Form1.Calidad.Premium.ToString() : Form1.Calidad.Standard.ToString();

				historialList.Add(new Historial
				{
					Vendedor = $"{vendedor.Nombre} {vendedor.Apellido}",
					Prenda = row.Pantalon != null ? "Pantalon" : "Camisa",
					Manga = row.Camisa != null ? (row.Camisa.Manga == (int)Form1.Manga.Corta ? Form1.Manga.Corta.ToString() : Form1.Manga.Larga.ToString()) : "-",
					Cuello = row.Camisa != null ? (row.Camisa.CuelloMao ? "Cuello Mao" : "Cuello Normal") : "-",
					Chupin = row.Pantalon != null ? (row.Pantalon.Chupin ? "Si" : "No") : "-",
					Cotizacion = row.PrecioCotizacion,
					Calidad = calidad,
					Cantidad = row.Cantidad,
					FechaHora = row.FechaHora
				});
			}

			dgvHistorial.DataSource = historialList;
		}

		private void btnCerrarHistorial_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
