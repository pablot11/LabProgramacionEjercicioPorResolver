namespace pryTorresEjercicioPorResolver
{
    partial class frmCargaVendedor
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
            this.lblVendedorNombre = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.mskIdVendedor = new System.Windows.Forms.MaskedTextBox();
            this.mskActivo = new System.Windows.Forms.MaskedTextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.mskComision = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblVendedorNombre
            // 
            this.lblVendedorNombre.AutoSize = true;
            this.lblVendedorNombre.Location = new System.Drawing.Point(9, 7);
            this.lblVendedorNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedorNombre.Name = "lblVendedorNombre";
            this.lblVendedorNombre.Size = new System.Drawing.Size(56, 13);
            this.lblVendedorNombre.TabIndex = 0;
            this.lblVendedorNombre.Text = "Vendedor:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(68, 7);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(76, 20);
            this.txtVendedor.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(87, 118);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(56, 19);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Location = new System.Drawing.Point(9, 37);
            this.lblIdVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(18, 13);
            this.lblIdVendedor.TabIndex = 3;
            this.lblIdVendedor.Text = "ID";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(9, 67);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(37, 13);
            this.lblActivo.TabIndex = 4;
            this.lblActivo.Text = "Activo";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(9, 93);
            this.lblComision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(52, 13);
            this.lblComision.TabIndex = 5;
            this.lblComision.Text = "Comision:";
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Location = new System.Drawing.Point(68, 37);
            this.txtIdVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(76, 20);
            this.txtIdVendedor.TabIndex = 6;
            // 
            // txtActivo
            // 
            this.txtActivo.Location = new System.Drawing.Point(68, 67);
            this.txtActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(76, 20);
            this.txtActivo.TabIndex = 7;
            // 
            // mskIdVendedor
            // 
            this.mskIdVendedor.Location = new System.Drawing.Point(68, 37);
            this.mskIdVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskIdVendedor.Mask = "9999";
            this.mskIdVendedor.Name = "mskIdVendedor";
            this.mskIdVendedor.Size = new System.Drawing.Size(76, 20);
            this.mskIdVendedor.TabIndex = 10;
            // 
            // mskActivo
            // 
            this.mskActivo.Location = new System.Drawing.Point(68, 67);
            this.mskActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskActivo.Mask = "9";
            this.mskActivo.Name = "mskActivo";
            this.mskActivo.Size = new System.Drawing.Size(76, 20);
            this.mskActivo.TabIndex = 11;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(68, 91);
            this.txtComision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(76, 20);
            this.txtComision.TabIndex = 12;
            // 
            // mskComision
            // 
            this.mskComision.Location = new System.Drawing.Point(68, 90);
            this.mskComision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskComision.Mask = "9";
            this.mskComision.Name = "mskComision";
            this.mskComision.Size = new System.Drawing.Size(76, 20);
            this.mskComision.TabIndex = 13;
            // 
            // frmCargaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 141);
            this.Controls.Add(this.mskComision);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.mskActivo);
            this.Controls.Add(this.mskIdVendedor);
            this.Controls.Add(this.txtActivo);
            this.Controls.Add(this.txtIdVendedor);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.lblIdVendedor);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblVendedorNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCargaVendedor";
            this.Text = "Carga Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendedorNombre;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblIdVendedor;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtIdVendedor;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.MaskedTextBox mskIdVendedor;
        private System.Windows.Forms.MaskedTextBox mskActivo;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.MaskedTextBox mskComision;
    }
}