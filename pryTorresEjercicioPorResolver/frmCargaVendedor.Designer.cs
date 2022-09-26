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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaVendedor));
            this.lblVendedorNombre = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
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
            this.lblVendedorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorNombre.Location = new System.Drawing.Point(12, 9);
            this.lblVendedorNombre.Name = "lblVendedorNombre";
            this.lblVendedorNombre.Size = new System.Drawing.Size(66, 18);
            this.lblVendedorNombre.TabIndex = 0;
            this.lblVendedorNombre.Text = "Nombre:";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVendedor.Location = new System.Drawing.Point(96, 9);
            this.txtNombreVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreVendedor.MaxLength = 30;
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(217, 24);
            this.txtNombreVendedor.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(238, 147);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 31);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVendedor.Location = new System.Drawing.Point(12, 44);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(22, 18);
            this.lblIdVendedor.TabIndex = 3;
            this.lblIdVendedor.Text = "ID";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(12, 79);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(48, 18);
            this.lblActivo.TabIndex = 4;
            this.lblActivo.Text = "Activo";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(12, 114);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(76, 18);
            this.lblComision.TabIndex = 5;
            this.lblComision.Text = "Comision:";
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVendedor.Location = new System.Drawing.Point(96, 44);
            this.txtIdVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(68, 24);
            this.txtIdVendedor.TabIndex = 6;
            // 
            // txtActivo
            // 
            this.txtActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivo.Location = new System.Drawing.Point(96, 80);
            this.txtActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(44, 24);
            this.txtActivo.TabIndex = 7;
            // 
            // mskIdVendedor
            // 
            this.mskIdVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskIdVendedor.Location = new System.Drawing.Point(96, 44);
            this.mskIdVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskIdVendedor.Mask = "9999";
            this.mskIdVendedor.Name = "mskIdVendedor";
            this.mskIdVendedor.Size = new System.Drawing.Size(68, 24);
            this.mskIdVendedor.TabIndex = 10;
            // 
            // mskActivo
            // 
            this.mskActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskActivo.Location = new System.Drawing.Point(96, 79);
            this.mskActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskActivo.Mask = "9";
            this.mskActivo.Name = "mskActivo";
            this.mskActivo.Size = new System.Drawing.Size(44, 24);
            this.mskActivo.TabIndex = 11;
            // 
            // txtComision
            // 
            this.txtComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComision.Location = new System.Drawing.Point(96, 114);
            this.txtComision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(44, 24);
            this.txtComision.TabIndex = 12;
            // 
            // mskComision
            // 
            this.mskComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskComision.Location = new System.Drawing.Point(96, 114);
            this.mskComision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskComision.Mask = "9";
            this.mskComision.Name = "mskComision";
            this.mskComision.Size = new System.Drawing.Size(44, 24);
            this.mskComision.TabIndex = 13;
            // 
            // frmCargaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 189);
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
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.lblVendedorNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCargaVendedor";
            this.Text = "Carga Vendedor";
            this.Load += new System.EventHandler(this.frmCargaVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendedorNombre;
        private System.Windows.Forms.TextBox txtNombreVendedor;
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