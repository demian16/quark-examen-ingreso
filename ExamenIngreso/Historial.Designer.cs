namespace ExamenIngreso
{
	partial class FormHistorial
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
			this.dgvHistorial = new System.Windows.Forms.DataGridView();
			this.btnCerrarHistorial = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHistorial
			// 
			this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorial.Location = new System.Drawing.Point(30, 12);
			this.dgvHistorial.Name = "dgvHistorial";
			this.dgvHistorial.RowHeadersWidth = 51;
			this.dgvHistorial.RowTemplate.Height = 24;
			this.dgvHistorial.Size = new System.Drawing.Size(1187, 527);
			this.dgvHistorial.TabIndex = 0;
			// 
			// btnCerrarHistorial
			// 
			this.btnCerrarHistorial.Location = new System.Drawing.Point(469, 567);
			this.btnCerrarHistorial.Name = "btnCerrarHistorial";
			this.btnCerrarHistorial.Size = new System.Drawing.Size(243, 61);
			this.btnCerrarHistorial.TabIndex = 1;
			this.btnCerrarHistorial.Text = "Cerrar";
			this.btnCerrarHistorial.UseVisualStyleBackColor = true;
			this.btnCerrarHistorial.Click += new System.EventHandler(this.btnCerrarHistorial_Click);
			// 
			// FormHistorial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1246, 640);
			this.Controls.Add(this.btnCerrarHistorial);
			this.Controls.Add(this.dgvHistorial);
			this.Name = "FormHistorial";
			this.Text = "Historial";
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvHistorial;
		private System.Windows.Forms.Button btnCerrarHistorial;
	}
}