using ExamenIngreso.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamenIngreso
{
	public partial class Form1 : Form
	{
		Tienda tienda = new Tienda
		{
			IdTienda = 1,
			Nombre = "Quark System",
			Direccion = "Pringles 2311"
		};

		Vendedor vendedor = new Vendedor
		{
			IdVendedor = 1,
			Nombre = "Damian",
			Apellido = "Crespo",
			IdTienda = 1
		};

		List<HistorialCotizaciones> historial = new List<HistorialCotizaciones>();

		List<Pantalon> pantalones = new List<Pantalon>
		{
			AgregarTipoPantalon(true),
			AgregarTipoPantalon(false)
		};

		List<Camisa> camisas = new List<Camisa> {
			AgregarTipoCamisa(true,true),
			AgregarTipoCamisa(true),
			AgregarTipoCamisa(false, true),
			AgregarTipoCamisa()
		};


		public Form1()
		{
			InitializeComponent();
		}

		#region Metodos Privados

		private static Camisa AgregarTipoCamisa(bool mangaCorta = false, bool cuelloMao = false)
		{
			var stock = 0;

			switch (mangaCorta)
			{
				case true when cuelloMao:
					stock = 200;
					break;
				case true when !cuelloMao:
					stock = 300;
					break;
				case false when cuelloMao:
					stock = 150;
					break;
				case false when !cuelloMao:
					stock = 350;
					break;
			}

			return new Camisa
			{
				IdPrenda = 1,
				Manga = mangaCorta ? (int)Manga.Corta : (int)Manga.Larga,
				CuelloMao = cuelloMao,
				Stock = stock
			};
		}

		private static Pantalon AgregarTipoPantalon(bool chupin)
		{
			return new Pantalon
			{
				IdPrenda = 1,
				Stock = chupin ? 1500 : 500,
				Chupin = chupin
			};
		}

		private void bntHistorial_Click(object sender, EventArgs e)
		{
			FormHistorial formHistorial = new FormHistorial(historial, vendedor);

			formHistorial.Show();
		}

		private void btnCotizar_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtPrecio.Text)
				&& !string.IsNullOrWhiteSpace(txtCantidad.Text))
			{
				if (!string.IsNullOrWhiteSpace(lbStock.Text) && int.Parse(lbStock.Text) > 0)
				{
					var resultado = ReglasCotizacion();

					lbResultado.Text = resultado.ToString();

					if (rbPantalon.Checked)
					{
						historial.Add(new HistorialCotizaciones
						{
							IdVendedor = vendedor.IdVendedor,
							FechaHora = DateTime.Now,
							PrecioCotizacion = resultado,
							Cantidad = int.Parse(txtCantidad.Text),
							Pantalon = new Pantalon
							{
								Precio = int.Parse(txtPrecio.Text),
								Calidad = rbPremium.Checked ? (int)Calidad.Premium : (int)Calidad.Standard,
								Chupin = chkChupin.Checked,
								Stock = int.Parse(lbStock.Text)
							}
						});
					}

					if (rbCamisa.Checked)
					{
						historial.Add(new HistorialCotizaciones
						{
							IdVendedor = vendedor.IdVendedor,
							FechaHora = DateTime.Now,
							PrecioCotizacion = resultado,
							Cantidad = int.Parse(txtCantidad.Text),
							Camisa = new Camisa
							{
								Precio = int.Parse(txtPrecio.Text),
								Calidad = rbPremium.Checked ? (int)Calidad.Premium : (int)Calidad.Standard,
								Manga = chkMangaCorta.Checked ? (int)Manga.Corta : (int)Manga.Larga,
								CuelloMao = chkCuelloMao.Checked,
								Stock = int.Parse(lbStock.Text)
							}
						});
					}
				}
				else
				{
					MessageBox.Show(
						"No se puede realizar una cotizacion sobre una cantidad de stock no disponible.",
						"Sin Stock",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show(
					"Precio y cantidad son requeridos para realizar una cotizacion.",
					"Faltan datos",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void chkChupin_CheckedChanged(object sender, EventArgs e)
		{
			lbStock.Text = ObtenerStockPantalones().ToString();
		}

		private void chkCuelloMao_CheckedChanged(object sender, EventArgs e)
		{
			lbStock.Text = ObtenerStockCamisas().ToString();
		}

		private void chkMangaCorta_CheckedChanged(object sender, EventArgs e)
		{
			lbStock.Text = ObtenerStockCamisas().ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbTienda.Text = tienda.Nombre;
			lbDireccion.Text = tienda.Direccion;
			lbNombreCodigoVendedor.Text = $"{vendedor.Nombre} {vendedor.Apellido} - {vendedor.IdVendedor}";
			chkChupin.Enabled = false;
			chkMangaCorta.Enabled = false;
			chkCuelloMao.Enabled = false;
			rbStandard.Enabled = true;
		}

		private void lbTienda_Click(object sender, EventArgs e)
		{

		}

		private int ObtenerStockCamisas(bool totalCamisa = false)
		{
			if (totalCamisa)
			{
				chkMangaCorta.Checked = false;
				chkMangaCorta.Enabled = true;
				chkCuelloMao.Checked = false;
				chkCuelloMao.Enabled = true;
				chkChupin.Enabled = false;
			}

			switch (rbCamisa.Checked)
			{
				case true when chkMangaCorta.Checked && chkCuelloMao.Checked:
					return camisas.FirstOrDefault(p => p.Manga == (int)Manga.Corta && p.CuelloMao)?.Stock ?? 0;
				case true when chkMangaCorta.Checked && !chkCuelloMao.Checked:
					return camisas.FirstOrDefault(p => p.Manga == (int)Manga.Corta && !p.CuelloMao)?.Stock ?? 0;
				case true when !chkMangaCorta.Checked && chkCuelloMao.Checked:
					return camisas.FirstOrDefault(p => p.Manga == (int)Manga.Larga && p.CuelloMao)?.Stock ?? 0;
				case true when !chkMangaCorta.Checked && !chkCuelloMao.Checked:
					return camisas.FirstOrDefault(p => p.Manga == (int)Manga.Larga && !p.CuelloMao)?.Stock ?? 0;
				default:
					return 0;
			}
		}

		private int ObtenerStockPantalones()
		{
			if (rbPantalon.Checked)
			{
				chkMangaCorta.Checked = false;
				chkMangaCorta.Enabled = false;
				chkCuelloMao.Checked = false;
				chkCuelloMao.Enabled = false;
				chkChupin.Enabled = true;

				return pantalones.FirstOrDefault(p => p.Chupin == chkChupin.Checked)?.Stock ?? 0;
			}

			return 0;
		}

		private void rbCamisa_CheckedChanged(object sender, EventArgs e)
		{
			lbStock.Text = ObtenerStockCamisas(true).ToString();
		}

		private void rbPantalon_CheckedChanged(object sender, EventArgs e)
		{
			lbStock.Text = this.ObtenerStockPantalones().ToString();
		}

		private double ReglasCotizacion()
		{
			var precio = double.Parse(txtPrecio.Text);
			var cantidad = int.Parse(txtCantidad.Text);
			double montoPorcentaje;
			double precioCotizacion = precio;

			if (rbCamisa.Checked && chkMangaCorta.Checked)
			{
				montoPorcentaje = (precio * 10) / 100;
				precioCotizacion -= montoPorcentaje;
			}

			if (rbCamisa.Checked && chkCuelloMao.Checked)
			{
				montoPorcentaje = (precio * 3) / 100;
				precioCotizacion += montoPorcentaje;
			}

			if (rbPantalon.Checked && chkChupin.Checked)
			{
				montoPorcentaje = (precio * 12) / 100;
				precioCotizacion -= montoPorcentaje;
			}

			if (rbPremium.Checked)
			{
				montoPorcentaje = (precio * 30) / 100;
				precioCotizacion += montoPorcentaje;
			}

			return precioCotizacion * cantidad;
		}

		private void txtPrecio_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		#endregion

		#region Enumeracion

		public enum Calidad
		{
			Standard = 1,
			Premium = 2
		}

		public enum Manga
		{
			Corta = 1,
			Larga = 2
		}

		#endregion
	}
}
