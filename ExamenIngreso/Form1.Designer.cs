namespace ExamenIngreso
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbTienda = new System.Windows.Forms.Label();
			this.lbDireccion = new System.Windows.Forms.Label();
			this.lbVendedor = new System.Windows.Forms.Label();
			this.lbNombreCodigoVendedor = new System.Windows.Forms.Label();
			this.bntHistorial = new System.Windows.Forms.Button();
			this.chkChupin = new System.Windows.Forms.CheckBox();
			this.chkMangaCorta = new System.Windows.Forms.CheckBox();
			this.rbCamisa = new System.Windows.Forms.RadioButton();
			this.rbPantalon = new System.Windows.Forms.RadioButton();
			this.chkCuelloMao = new System.Windows.Forms.CheckBox();
			this.lbUnidadesStockDisponible = new System.Windows.Forms.Label();
			this.lbStock = new System.Windows.Forms.Label();
			this.lbPrecioUnitarioCantidad = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.lbSignoPesos = new System.Windows.Forms.Label();
			this.lbCantidad = new System.Windows.Forms.Label();
			this.btnCotizar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbResultado = new System.Windows.Forms.Label();
			this.rbStandard = new System.Windows.Forms.RadioButton();
			this.rbPremium = new System.Windows.Forms.RadioButton();
			this.gbCalidadPrenda = new System.Windows.Forms.GroupBox();
			this.gbPrenda = new System.Windows.Forms.GroupBox();
			this.gbCalidadPrenda.SuspendLayout();
			this.gbPrenda.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTienda
			// 
			this.lbTienda.AutoSize = true;
			this.lbTienda.Location = new System.Drawing.Point(13, 13);
			this.lbTienda.Name = "lbTienda";
			this.lbTienda.Size = new System.Drawing.Size(106, 17);
			this.lbTienda.TabIndex = 0;
			this.lbTienda.Text = "Nombre Tienda";
			this.lbTienda.Click += new System.EventHandler(this.lbTienda_Click);
			// 
			// lbDireccion
			// 
			this.lbDireccion.AutoSize = true;
			this.lbDireccion.Location = new System.Drawing.Point(505, 9);
			this.lbDireccion.Name = "lbDireccion";
			this.lbDireccion.Size = new System.Drawing.Size(115, 17);
			this.lbDireccion.TabIndex = 1;
			this.lbDireccion.Text = "Direccion Tienda";
			// 
			// lbVendedor
			// 
			this.lbVendedor.AutoSize = true;
			this.lbVendedor.Location = new System.Drawing.Point(13, 53);
			this.lbVendedor.Name = "lbVendedor";
			this.lbVendedor.Size = new System.Drawing.Size(74, 17);
			this.lbVendedor.TabIndex = 2;
			this.lbVendedor.Text = "Vendedor:";
			// 
			// lbNombreCodigoVendedor
			// 
			this.lbNombreCodigoVendedor.AutoSize = true;
			this.lbNombreCodigoVendedor.Location = new System.Drawing.Point(93, 53);
			this.lbNombreCodigoVendedor.Name = "lbNombreCodigoVendedor";
			this.lbNombreCodigoVendedor.Size = new System.Drawing.Size(117, 17);
			this.lbNombreCodigoVendedor.TabIndex = 3;
			this.lbNombreCodigoVendedor.Text = "Nombre y Codigo";
			// 
			// bntHistorial
			// 
			this.bntHistorial.Location = new System.Drawing.Point(508, 44);
			this.bntHistorial.Name = "bntHistorial";
			this.bntHistorial.Size = new System.Drawing.Size(162, 34);
			this.bntHistorial.TabIndex = 5;
			this.bntHistorial.Text = "Historial Cotizaciones";
			this.bntHistorial.UseVisualStyleBackColor = true;
			this.bntHistorial.Click += new System.EventHandler(this.bntHistorial_Click);
			// 
			// chkChupin
			// 
			this.chkChupin.AutoSize = true;
			this.chkChupin.Location = new System.Drawing.Point(175, 118);
			this.chkChupin.Name = "chkChupin";
			this.chkChupin.Size = new System.Drawing.Size(74, 21);
			this.chkChupin.TabIndex = 6;
			this.chkChupin.Text = "Chupin";
			this.chkChupin.UseVisualStyleBackColor = true;
			this.chkChupin.CheckedChanged += new System.EventHandler(this.chkChupin_CheckedChanged);
			// 
			// chkMangaCorta
			// 
			this.chkMangaCorta.AutoSize = true;
			this.chkMangaCorta.Location = new System.Drawing.Point(191, 30);
			this.chkMangaCorta.Name = "chkMangaCorta";
			this.chkMangaCorta.Size = new System.Drawing.Size(111, 21);
			this.chkMangaCorta.TabIndex = 7;
			this.chkMangaCorta.Text = "Manga Corta";
			this.chkMangaCorta.UseVisualStyleBackColor = true;
			this.chkMangaCorta.CheckedChanged += new System.EventHandler(this.chkMangaCorta_CheckedChanged);
			// 
			// rbCamisa
			// 
			this.rbCamisa.AutoSize = true;
			this.rbCamisa.Location = new System.Drawing.Point(18, 30);
			this.rbCamisa.Name = "rbCamisa";
			this.rbCamisa.Size = new System.Drawing.Size(75, 21);
			this.rbCamisa.TabIndex = 9;
			this.rbCamisa.TabStop = true;
			this.rbCamisa.Text = "Camisa";
			this.rbCamisa.UseVisualStyleBackColor = true;
			this.rbCamisa.CheckedChanged += new System.EventHandler(this.rbCamisa_CheckedChanged);
			// 
			// rbPantalon
			// 
			this.rbPantalon.AutoSize = true;
			this.rbPantalon.Location = new System.Drawing.Point(18, 117);
			this.rbPantalon.Name = "rbPantalon";
			this.rbPantalon.Size = new System.Drawing.Size(85, 21);
			this.rbPantalon.TabIndex = 10;
			this.rbPantalon.TabStop = true;
			this.rbPantalon.Text = "Pantalon";
			this.rbPantalon.UseVisualStyleBackColor = true;
			this.rbPantalon.CheckedChanged += new System.EventHandler(this.rbPantalon_CheckedChanged);
			// 
			// chkCuelloMao
			// 
			this.chkCuelloMao.AutoSize = true;
			this.chkCuelloMao.Location = new System.Drawing.Point(348, 31);
			this.chkCuelloMao.Name = "chkCuelloMao";
			this.chkCuelloMao.Size = new System.Drawing.Size(100, 21);
			this.chkCuelloMao.TabIndex = 11;
			this.chkCuelloMao.Text = "Cuello Mao";
			this.chkCuelloMao.UseVisualStyleBackColor = true;
			this.chkCuelloMao.CheckedChanged += new System.EventHandler(this.chkCuelloMao_CheckedChanged);
			// 
			// lbUnidadesStockDisponible
			// 
			this.lbUnidadesStockDisponible.AutoSize = true;
			this.lbUnidadesStockDisponible.Location = new System.Drawing.Point(44, 302);
			this.lbUnidadesStockDisponible.Name = "lbUnidadesStockDisponible";
			this.lbUnidadesStockDisponible.Size = new System.Drawing.Size(177, 17);
			this.lbUnidadesStockDisponible.TabIndex = 13;
			this.lbUnidadesStockDisponible.Text = "Unidades Stock Disponible";
			// 
			// lbStock
			// 
			this.lbStock.AutoSize = true;
			this.lbStock.Location = new System.Drawing.Point(245, 302);
			this.lbStock.Name = "lbStock";
			this.lbStock.Size = new System.Drawing.Size(16, 17);
			this.lbStock.TabIndex = 14;
			this.lbStock.Text = "0";
			// 
			// lbPrecioUnitarioCantidad
			// 
			this.lbPrecioUnitarioCantidad.AutoSize = true;
			this.lbPrecioUnitarioCantidad.Location = new System.Drawing.Point(288, 336);
			this.lbPrecioUnitarioCantidad.Name = "lbPrecioUnitarioCantidad";
			this.lbPrecioUnitarioCantidad.Size = new System.Drawing.Size(172, 17);
			this.lbPrecioUnitarioCantidad.TabIndex = 18;
			this.lbPrecioUnitarioCantidad.Text = "Precio Unitario y Cantidad";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(310, 382);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(150, 22);
			this.txtPrecio.TabIndex = 19;
			this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
			this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(360, 410);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 22);
			this.txtCantidad.TabIndex = 20;
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			// 
			// lbSignoPesos
			// 
			this.lbSignoPesos.AutoSize = true;
			this.lbSignoPesos.Location = new System.Drawing.Point(288, 382);
			this.lbSignoPesos.Name = "lbSignoPesos";
			this.lbSignoPesos.Size = new System.Drawing.Size(16, 17);
			this.lbSignoPesos.TabIndex = 21;
			this.lbSignoPesos.Text = "$";
			// 
			// lbCantidad
			// 
			this.lbCantidad.AutoSize = true;
			this.lbCantidad.Location = new System.Drawing.Point(288, 415);
			this.lbCantidad.Name = "lbCantidad";
			this.lbCantidad.Size = new System.Drawing.Size(64, 17);
			this.lbCantidad.TabIndex = 22;
			this.lbCantidad.Text = "Cantidad";
			// 
			// btnCotizar
			// 
			this.btnCotizar.Location = new System.Drawing.Point(112, 461);
			this.btnCotizar.Name = "btnCotizar";
			this.btnCotizar.Size = new System.Drawing.Size(162, 43);
			this.btnCotizar.TabIndex = 23;
			this.btnCotizar.Text = "Cotizar";
			this.btnCotizar.UseVisualStyleBackColor = true;
			this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(288, 474);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 29);
			this.label1.TabIndex = 24;
			this.label1.Text = "$";
			// 
			// lbResultado
			// 
			this.lbResultado.AutoSize = true;
			this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbResultado.Location = new System.Drawing.Point(320, 474);
			this.lbResultado.Name = "lbResultado";
			this.lbResultado.Size = new System.Drawing.Size(26, 29);
			this.lbResultado.TabIndex = 25;
			this.lbResultado.Text = "_";
			// 
			// rbStandard
			// 
			this.rbStandard.AutoSize = true;
			this.rbStandard.Location = new System.Drawing.Point(24, 44);
			this.rbStandard.Name = "rbStandard";
			this.rbStandard.Size = new System.Drawing.Size(87, 21);
			this.rbStandard.TabIndex = 26;
			this.rbStandard.TabStop = true;
			this.rbStandard.Text = "Standard";
			this.rbStandard.UseVisualStyleBackColor = true;
			// 
			// rbPremium
			// 
			this.rbPremium.AutoSize = true;
			this.rbPremium.Location = new System.Drawing.Point(156, 44);
			this.rbPremium.Name = "rbPremium";
			this.rbPremium.Size = new System.Drawing.Size(84, 21);
			this.rbPremium.TabIndex = 27;
			this.rbPremium.TabStop = true;
			this.rbPremium.Text = "Premium";
			this.rbPremium.UseVisualStyleBackColor = true;
			// 
			// gbCalidadPrenda
			// 
			this.gbCalidadPrenda.Controls.Add(this.rbStandard);
			this.gbCalidadPrenda.Controls.Add(this.rbPremium);
			this.gbCalidadPrenda.Location = new System.Drawing.Point(16, 336);
			this.gbCalidadPrenda.Name = "gbCalidadPrenda";
			this.gbCalidadPrenda.Size = new System.Drawing.Size(258, 119);
			this.gbCalidadPrenda.TabIndex = 28;
			this.gbCalidadPrenda.TabStop = false;
			this.gbCalidadPrenda.Text = "Calidad de Prenda";
			// 
			// gbPrenda
			// 
			this.gbPrenda.Controls.Add(this.chkChupin);
			this.gbPrenda.Controls.Add(this.chkCuelloMao);
			this.gbPrenda.Controls.Add(this.chkMangaCorta);
			this.gbPrenda.Controls.Add(this.rbCamisa);
			this.gbPrenda.Controls.Add(this.rbPantalon);
			this.gbPrenda.Location = new System.Drawing.Point(12, 84);
			this.gbPrenda.Name = "gbPrenda";
			this.gbPrenda.Size = new System.Drawing.Size(465, 189);
			this.gbPrenda.TabIndex = 29;
			this.gbPrenda.TabStop = false;
			this.gbPrenda.Text = "Prenda";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 531);
			this.Controls.Add(this.gbPrenda);
			this.Controls.Add(this.gbCalidadPrenda);
			this.Controls.Add(this.lbResultado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCotizar);
			this.Controls.Add(this.lbCantidad);
			this.Controls.Add(this.lbSignoPesos);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.lbPrecioUnitarioCantidad);
			this.Controls.Add(this.lbStock);
			this.Controls.Add(this.lbUnidadesStockDisponible);
			this.Controls.Add(this.bntHistorial);
			this.Controls.Add(this.lbNombreCodigoVendedor);
			this.Controls.Add(this.lbVendedor);
			this.Controls.Add(this.lbDireccion);
			this.Controls.Add(this.lbTienda);
			this.Name = "Form1";
			this.Text = "Cotizador Prenda";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbCalidadPrenda.ResumeLayout(false);
			this.gbCalidadPrenda.PerformLayout();
			this.gbPrenda.ResumeLayout(false);
			this.gbPrenda.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbTienda;
		private System.Windows.Forms.Label lbDireccion;
		private System.Windows.Forms.Label lbVendedor;
		private System.Windows.Forms.Label lbNombreCodigoVendedor;
		private System.Windows.Forms.Button bntHistorial;
		private System.Windows.Forms.CheckBox chkChupin;
		private System.Windows.Forms.CheckBox chkMangaCorta;
		private System.Windows.Forms.RadioButton rbCamisa;
		private System.Windows.Forms.RadioButton rbPantalon;
		private System.Windows.Forms.CheckBox chkCuelloMao;
		private System.Windows.Forms.Label lbUnidadesStockDisponible;
		private System.Windows.Forms.Label lbStock;
		private System.Windows.Forms.Label lbPrecioUnitarioCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lbSignoPesos;
		private System.Windows.Forms.Label lbCantidad;
		private System.Windows.Forms.Button btnCotizar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbResultado;
		private System.Windows.Forms.RadioButton rbStandard;
		private System.Windows.Forms.RadioButton rbPremium;
		private System.Windows.Forms.GroupBox gbCalidadPrenda;
		private System.Windows.Forms.GroupBox gbPrenda;
	}
}

