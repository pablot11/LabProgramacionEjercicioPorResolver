namespace pryTorresEjercicioPorResolver
{
    partial class frmConsultarCliente
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
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaUno,
            this.columnaDos});
            this.dgvConsultaCliente.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.RowHeadersWidth = 51;
            this.dgvConsultaCliente.RowTemplate.Height = 24;
            this.dgvConsultaCliente.Size = new System.Drawing.Size(304, 150);
            this.dgvConsultaCliente.TabIndex = 0;
            this.dgvConsultaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCliente_CellContentClick);
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "ID";
            this.columnaUno.MinimumWidth = 6;
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            this.columnaUno.Width = 125;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Nombre";
            this.columnaDos.MinimumWidth = 6;
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            this.columnaDos.Width = 125;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 187);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Name = "frmConsultarCliente";
            this.Text = "Consultar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.Button btnConsultar;
    }
}