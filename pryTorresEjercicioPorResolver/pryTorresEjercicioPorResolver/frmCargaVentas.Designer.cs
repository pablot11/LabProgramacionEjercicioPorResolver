namespace pryTorresEjercicioPorResolver
{
    partial class frmCargaVentas
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
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.mskFechaVenta = new System.Windows.Forms.MaskedTextBox();
            this.mskNumeroFactura = new System.Windows.Forms.MaskedTextBox();
            this.lstClienteId = new System.Windows.Forms.ComboBox();
            this.lblVendedorId = new System.Windows.Forms.Label();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lstVendedorId = new System.Windows.Forms.ComboBox();
            this.mskTipoFactura = new System.Windows.Forms.MaskedTextBox();
            this.mskMontoVenta = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(12, 85);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(86, 16);
            this.lblVendedor.TabIndex = 1;
            this.lblVendedor.Text = "Vendedor ID:";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(12, 113);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(103, 16);
            this.lblNumeroFactura.TabIndex = 2;
            this.lblNumeroFactura.Text = "Numero Factura";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(129, 113);
            this.txtNumeroFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroFactura.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 142);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(129, 143);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 22);
            this.txtFecha.TabIndex = 5;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 174);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 16);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(129, 174);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 7;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(155, 210);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // mskFechaVenta
            // 
            this.mskFechaVenta.Location = new System.Drawing.Point(129, 142);
            this.mskFechaVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskFechaVenta.Mask = "00/00/0000";
            this.mskFechaVenta.Name = "mskFechaVenta";
            this.mskFechaVenta.Size = new System.Drawing.Size(100, 22);
            this.mskFechaVenta.TabIndex = 9;
            // 
            // mskNumeroFactura
            // 
            this.mskNumeroFactura.Location = new System.Drawing.Point(129, 113);
            this.mskNumeroFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskNumeroFactura.Mask = "9999";
            this.mskNumeroFactura.Name = "mskNumeroFactura";
            this.mskNumeroFactura.Size = new System.Drawing.Size(100, 22);
            this.mskNumeroFactura.TabIndex = 10;
            // 
            // lstClienteId
            // 
            this.lstClienteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstClienteId.FormattingEnabled = true;
            this.lstClienteId.Location = new System.Drawing.Point(129, 55);
            this.lstClienteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstClienteId.Name = "lstClienteId";
            this.lstClienteId.Size = new System.Drawing.Size(100, 24);
            this.lstClienteId.TabIndex = 12;
            // 
            // lblVendedorId
            // 
            this.lblVendedorId.AutoSize = true;
            this.lblVendedorId.Location = new System.Drawing.Point(12, 25);
            this.lblVendedorId.Name = "lblVendedorId";
            this.lblVendedorId.Size = new System.Drawing.Size(52, 16);
            this.lblVendedorId.TabIndex = 14;
            this.lblVendedorId.Text = "Factura";
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Location = new System.Drawing.Point(12, 55);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(67, 16);
            this.lblClienteId.TabIndex = 15;
            this.lblClienteId.Text = "Cliente ID:";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(129, 25);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFactura.MaxLength = 1;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 22);
            this.txtFactura.TabIndex = 17;
            // 
            // lstVendedorId
            // 
            this.lstVendedorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedorId.FormattingEnabled = true;
            this.lstVendedorId.Location = new System.Drawing.Point(129, 83);
            this.lstVendedorId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVendedorId.Name = "lstVendedorId";
            this.lstVendedorId.Size = new System.Drawing.Size(100, 24);
            this.lstVendedorId.TabIndex = 18;
            // 
            // mskTipoFactura
            // 
            this.mskTipoFactura.Location = new System.Drawing.Point(129, 24);
            this.mskTipoFactura.Mask = "A";
            this.mskTipoFactura.Name = "mskTipoFactura";
            this.mskTipoFactura.Size = new System.Drawing.Size(100, 22);
            this.mskTipoFactura.TabIndex = 19;
            // 
            // mskMontoVenta
            // 
            this.mskMontoVenta.Location = new System.Drawing.Point(129, 174);
            this.mskMontoVenta.Mask = "99999999999";
            this.mskMontoVenta.Name = "mskMontoVenta";
            this.mskMontoVenta.Size = new System.Drawing.Size(100, 22);
            this.mskMontoVenta.TabIndex = 20;
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 258);
            this.Controls.Add(this.mskMontoVenta);
            this.Controls.Add(this.mskTipoFactura);
            this.Controls.Add(this.lstVendedorId);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.lblVendedorId);
            this.Controls.Add(this.lstClienteId);
            this.Controls.Add(this.mskNumeroFactura);
            this.Controls.Add(this.mskFechaVenta);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblVendedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCargaVentas";
            this.Text = "Carga Ventas";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.MaskedTextBox mskFechaVenta;
        private System.Windows.Forms.MaskedTextBox mskNumeroFactura;
        private System.Windows.Forms.ComboBox lstClienteId;
        private System.Windows.Forms.Label lblVendedorId;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.ComboBox lstVendedorId;
        private System.Windows.Forms.MaskedTextBox mskTipoFactura;
        private System.Windows.Forms.MaskedTextBox mskMontoVenta;
    }
}