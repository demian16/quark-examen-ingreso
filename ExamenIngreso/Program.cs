using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenIngreso.Clases;

namespace ExamenIngreso
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//var tienda = new Tienda {IdTienda = 1, Nombre = "Quark System", Direccion = "Pringles 2311"};
			//var vendedor = new Vendedor {Nombre = "Damian", Apellido = "Crespo", IdTienda = 1};
			//var pantalones = new List<Pantalon> {ObtenerPantalones(true), ObtenerPantalones(false)};

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new Form1());
		}

		//private static Pantalon ObtenerPantalones(bool chupin)
		//{
		//	return new Pantalon
		//	{
		//		IdPrenda = 1,
		//		Calidad = 1,
		//		Precio = 600,
		//		Stock = chupin ? 1500 : 500,
		//		Chupin = chupin
		//	};
		//}
	}
}
