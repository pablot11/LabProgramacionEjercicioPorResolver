namespace pryTorresEjercicioPorResolver
{
    partial class frmConsulta
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
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.btnConsultarVenta = new System.Windows.Forms.Button();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSeis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaUno,
            this.columnaDos,
            this.columnaTres,
            this.columnaCuatro,
            this.columnaCinco,
            this.columnaSeis});
            this.dgvConsultaVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.RowHeadersWidth = 51;
            this.dgvConsultaVentas.RowTemplate.Height = 24;
            this.dgvConsultaVentas.Size = new System.Drawing.Size(787, 197);
            this.dgvConsultaVentas.TabIndex = 0;
            // 
            // btnConsultarVenta
            // 
            this.btnConsultarVenta.Location = new System.Drawing.Point(724, 215);
            this.btnConsultarVenta.Name = "btnConsultarVenta";
            this.btnConsultarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVenta.TabIndex = 1;
            this.btnConsultarVenta.Text = "Consultar";
            this.btnConsultarVenta.UseVisualStyleBackColor = true;
            this.btnConsultarVenta.Click += new System.EventHandler(this.btnConsultarVenta_Click);
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "Factura Tipo";
            this.columnaUno.MinimumWidth = 6;
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            this.columnaUno.Width = 125;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Factura Numero";
            this.columnaDos.MinimumWidth = 6;
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            this.columnaDos.Width = 125;
            // 
            // columnaTres
            // 
            this.columnaTres.HeaderText = "Fecha";
            this.columnaTres.MinimumWidth = 6;
            this.columnaTres.Name = "columnaTres";
            this.columnaTres.ReadOnly = true;
            this.columnaTres.Width = 125;
            // 
            // columnaCuatro
            // 
            this.columnaCuatro.HeaderText = "Cliente Id";
            this.columnaCuatro.MinimumWidth = 6;
            this.columnaCuatro.Name = "columnaCuatro";
            this.columnaCuatro.ReadOnly = true;
            this.columnaCuatro.Width = 125;
            // 
            // columnaCinco
            // 
            this.columnaCinco.HeaderText = "VendedorId";
            this.columnaCinco.MinimumWidth = 6;
            this.columnaCinco.Name = "columnaCinco";
            this.columnaCinco.ReadOnly = true;
            this.columnaCinco.Width = 125;
            // 
            // columnaSeis
            // 
            this.columnaSeis.HeaderText = "Monto";
            this.columnaSeis.MinimumWidth = 6;
            this.columnaSeis.Name = "columnaSeis";
            this.columnaSeis.ReadOnly = true;
            this.columnaSeis.Width = 125;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultarVenta);
            this.Controls.Add(this.dgvConsultaVentas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCuatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSeis;
        private System.Windows.Forms.Button btnConsultarVenta;
    }
}